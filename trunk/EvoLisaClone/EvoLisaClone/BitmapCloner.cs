// <copyright file="BitmapCloner.cs" company="Jader DIas">
// Copyright (c) Jader Dias. All rights reserved.
// </copyright>
// <author>Jader Dias</author>
// <email>jaderd@gmail.com</email>
// <date>2009-06-21</date>

// This file is part of EvoLisaClone.
//
// EvoLisaClone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// EvoLisaClone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with EvoLisaClone.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public class BitmapCloner
    {
        void RecombineMutateAndAdd(Dictionary<long, VectorDrawing> population, int indexA, int indexB, Bitmap bitmap)
        {
            VectorDrawing child;
            long childDistance;
            do
            {
                child = VectorDrawingGenetics.Instance.Recombine(population.ElementAt(indexA).Value, population.ElementAt(indexB).Value);
                child = VectorDrawingGenetics.Instance.Mutate(child, bitmap.Width, bitmap.Height);
                childDistance = VectorDrawingGenetics.Instance.CalculateDistance(child, bitmap);
            } while (!DictionaryExtensions.TryAdd(population, childDistance, child));
        }

        public VectorDrawing Clone(Bitmap bitmap, long distance, int populationSize)
        {
            var population = new Dictionary<long, VectorDrawing>();
            while (population.Count < populationSize)
            {
                var newborn = VectorDrawingGenetics.Instance.Create(bitmap.Width, bitmap.Height, 1);
                var newbornDistance = VectorDrawingGenetics.Instance.CalculateDistance(newborn, bitmap);
                DictionaryExtensions.TryAdd(population, newbornDistance, newborn);
            }
            var minDistance = 0L;
            while (!population.Where(a => a.Key <= distance).Any())
            {
                for (var i = 1; i < populationSize; i++)
                {
                    this.RecombineMutateAndAdd(population, i - 1, i, bitmap);
                }
                this.RecombineMutateAndAdd(population, 0, populationSize - 1, bitmap);
                minDistance = population.Min(a => a.Key);
                while (population.Count() > populationSize)
                {
                    var toBeRemoved = population.Where(a => a.Key != minDistance);
                    population.Remove(toBeRemoved.First().Key);
                }
            }
            return population.OrderBy(a => a.Key).First().Value;
        }
    }
}
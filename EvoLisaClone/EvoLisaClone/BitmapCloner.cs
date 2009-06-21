using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public class BitmapCloner
    {
        void CrossOverMutateAndAdd(Dictionary<long, VectorDrawing> population, int indexA, int indexB, Bitmap bitmap)
        {
            VectorDrawing child;
            long childDistance;
            do
            {
                child = VectorDrawingGenetics.Instance.CrossOver(population.ElementAt(indexA).Value, population.ElementAt(indexB).Value);
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
                    this.CrossOverMutateAndAdd(population, i - 1, i, bitmap);
                }
                this.CrossOverMutateAndAdd(population, 0, populationSize - 1, bitmap);
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
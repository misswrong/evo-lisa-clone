using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EvoLisaClone
{
    public class BitmapCloner
    {
        public VectorDrawing Clone(Bitmap bitmap, long distance, int populationSize)
        {
            var population = new Dictionary<VectorDrawing, long>();
            while (population.Count < populationSize)
            {
                var newborn = VectorDrawingGenetics.Instance.Create(bitmap.Width, bitmap.Height, 1);
                var newbornDistance = VectorDrawingGenetics.Instance.CalculateDistance(newborn, bitmap);
                population.Add(newborn, newbornDistance);
            }
            var minDistance = 0L;
            while (!population.Where(a => a.Value <= distance).Any())
            {
                if (populationSize == 1)
                {
                    var child = VectorDrawingGenetics.Instance.Mutate(population.First().Key, bitmap.Height, bitmap.Width);
                    var childDistance = VectorDrawingGenetics.Instance.CalculateDistance(child, bitmap);
                    population.Add(child, childDistance);
                }
                else
                {
                    for (var i = 1; i < populationSize; i++)
                    {
                        VectorDrawing child = new VectorDrawing();
                        do
                        {
                            child = VectorDrawingGenetics.Instance.CrossOver(population.ElementAt(i - 1).Key, population.ElementAt(i).Key);
                            child = VectorDrawingGenetics.Instance.Mutate(child, bitmap.Width, bitmap.Height);
                        } while (population.Keys.Contains(child));
                        var childDistance = VectorDrawingGenetics.Instance.CalculateDistance(child, bitmap);
                        population.Add(child, childDistance);
                    }
                    {
                        VectorDrawing child = new VectorDrawing();
                        do
                        {
                            child = VectorDrawingGenetics.Instance.CrossOver(population.First().Key, population.Last().Key);
                            child = VectorDrawingGenetics.Instance.Mutate(child, bitmap.Width, bitmap.Height);
                        } while (population.Keys.Contains(child));
                        var childDistance = VectorDrawingGenetics.Instance.CalculateDistance(child, bitmap);
                        population.Add(child, childDistance);
                    }
                }
                minDistance = population.Min(a => a.Value);
                while (population.Count() > populationSize)
                {
                    var toBeRemoved = population.Where(a => a.Value != minDistance);
                    if (toBeRemoved.Any())
                    {
                        population.Remove(toBeRemoved.First().Key);
                    }
                    else
                    {
                        population.Remove(population.First().Key);
                    }
                }
            }
            return population.Where(a => a.Value == minDistance).First().Key;
        }
    }
}
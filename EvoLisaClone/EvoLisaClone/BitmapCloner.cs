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
                long childDistance;
                VectorDrawing child = new VectorDrawing();
                if (populationSize == 1)
                {
                    do
                    {
                        child = VectorDrawingGenetics.Instance.Mutate(population.First().Value, bitmap.Width, bitmap.Height);
                        childDistance = VectorDrawingGenetics.Instance.CalculateDistance(child, bitmap);
                    } while (population.Keys.Contains(childDistance));
                    population.Add(childDistance, child);
                }
                else
                {
                    for (var i = 1; i < populationSize; i++)
                    {
                        do
                        {
                            child = VectorDrawingGenetics.Instance.CrossOver(population.ElementAt(i - 1).Value, population.ElementAt(i).Value);
                            child = VectorDrawingGenetics.Instance.Mutate(child, bitmap.Width, bitmap.Height);
                            childDistance = VectorDrawingGenetics.Instance.CalculateDistance(child, bitmap);
                        } while (population.Keys.Contains(childDistance));
                        population.Add(childDistance, child);
                    }
                    do
                    {
                        child = VectorDrawingGenetics.Instance.CrossOver(population.First().Value, population.Last().Value);
                        child = VectorDrawingGenetics.Instance.Mutate(child, bitmap.Width, bitmap.Height);
                        childDistance = VectorDrawingGenetics.Instance.CalculateDistance(child, bitmap);
                    } while (population.Keys.Contains(childDistance));
                    population.Add(childDistance, child);
                }
                minDistance = population.Min(a => a.Key);
                while (population.Count() > populationSize)
                {
                    var toBeRemoved = population.Where(a => a.Key != minDistance);
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
            return population.OrderBy(a => a.Key).First().Value;
        }
    }
}
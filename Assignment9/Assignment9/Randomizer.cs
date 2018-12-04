using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment9
{
    public static class Randomizer
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> thisList)
        {
            List<T> list = thisList.ToList();
            Random randomIndexer = new Random();
            while (list.Any())
            {
                var size = list.Count();
                var index = randomIndexer.Next(size);
                T item = list.ElementAt(index);
                list.Remove(item);
                yield return item;
            }
        }
    }
}

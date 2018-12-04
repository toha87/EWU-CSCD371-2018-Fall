using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment9
{
    public static class PatentDataAnalyzer
    {
        public static List<string> InventorNames(string country)
        {
            if (country is null) throw new NullReferenceException();

            var inventorNamesList = PatentData.Inventors
                .Where(inventor => inventor.Country == country)
                .Select(inventor => inventor.Name)
                .ToList();

            return inventorNamesList;
        }

        public static List<string> InventoryLastNames()
        {
            var inventorLastNameList = PatentData.Inventors
                .OrderByDescending(inventor => inventor.Id)
                .Select(inventor => inventor.Name.Split().Last())
                .ToList();
            return inventorLastNameList;
        }

        public static string LocationsWithInventors()
        {
            return string.Join(", ",
                PatentData.Inventors
                    .Select(inventor => $"{inventor.State}-{inventor.Country}")
                    .Distinct()
            );
        }
    }
}

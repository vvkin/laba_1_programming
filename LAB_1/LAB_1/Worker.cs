﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LAB_1
{
    class Worker
    {
        private readonly string dirName;
        public Worker(string dirName) => this.dirName = dirName;

        private Dictionary<string, int> DoWork()
        {
            Parser parser = new Parser(dirName);
            (List<string> countriesList, List<List<int>> gradesList) = parser.GetInput();
            int[] gradesForPlace = new int[] { 12, 10, 8, 7, 6, 5, 4, 3, 2, 1 };
            Dictionary<string, int> results = new Dictionary<string, int>();
            int upBound = (10 < countriesList.Count + 1) ? 10 : countriesList.Count + 1;

            foreach (var countryName in countriesList)
            {
                results.Add(countryName, 0);
            }
            return results;
        }
    }
}
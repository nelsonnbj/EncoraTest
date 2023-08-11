using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationEncora
{
    public class SortingOperations
    {
        public string SortStringByCharFrequency(string str)
        {
            var charFrequency = str.GroupBy(c => c)                                   
                                   .OrderByDescending(group => group.Count())
                                   .ThenBy(x => x.Key)
                                   .Select(group => new string(group.Key, group.Count()));

            return string.Concat(charFrequency);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            var stringy = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 4)
                {
                    stringy.Add(strings[i]);
                }

            }
            return stringy.ToArray();
        }
    }
}

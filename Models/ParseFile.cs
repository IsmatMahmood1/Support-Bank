using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Support_Bank.Models
{
    public class ParseFile
    {
        public static List<Transaction> Parse(string route)
        {
            var path = route;
            var lines = File.ReadAllLines(path);

            return lines.Select(line => new Transaction(line.Split(","))).ToList();
        }
    }
}

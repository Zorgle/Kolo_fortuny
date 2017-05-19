using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WheelOfFortune
{
    class BankLoader
    {
        public void Load(WordBank bank, string filepath, string category)
        {
            if (!File.Exists(filepath)) { throw new Exception("File does not exist: " + filepath); }
            var lines = File.ReadAllLines(filepath);
            int lineno = 0;
            foreach (var rawline in lines)
            {
                ++lineno;
                string linecat = category;
                var line = rawline.Trim();
                if (line.Length == 0) { continue; } // skip blank lines
                if (line.StartsWith("#")) { continue; } // skip comments
                var data = ParseLine(line);
                if (data.Item2.Length > 0)
                {
                    if (data.Item1.Length == 0)
                    {
                        // : category
                        // setting new category for subsequent words
                        category = data.Item2;
                        continue;
                    }
                    linecat = data.Item2;
                }
                if (data.Item1.Length > 0)
                {
                    string answer = data.Item1;
                    bank.AddPuzzle(linecat, answer);
                }
            }
        }
        private Tuple<string, string> ParseLine(string line)
        {
            string word = "", category = "";
            int ix = line.IndexOf(":");
            if (ix > 0)
            {
                word = line.Substring(0, ix).Trim();
            }
            if (ix < line.Length)
            {
                category = line.Substring(ix + 1).Trim();
            }
            return new Tuple<string, string>(word, category);
        }
    }
}

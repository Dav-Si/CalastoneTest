using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calastone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (!args.Any())
                throw new ArgumentNullException("No pathname argument provided");

            string path = args[0];

            if (!File.Exists(path))
                throw new ArgumentException("No file exists at the provided pathname");

            string text = File.ReadAllText(path);

            char[] invalidChars = { ',', ',', '.', ':', ';', '?', '(', ')', '"', '`', '!' };

            List<string> words = Regex.Split(text, " ").ToList();
            words.RemoveAll(w => w == "");

            // to-do - identify where invalid word due to invalid character and updated that word in words list
            // ie: identifty "slowly," replace as "slowly" and updated in list "slowly," -> "slowly"
            //if (Array.IndexOf(invalidChars, word) is int index && index > -1)
            //    words.Add(word.Replace(word[index].ToString(), ""));


            List<string> filteredWords = words.Where(word => word.Length > 0)
                .Where(word => word.IsValid()).ToList();

            Console.WriteLine(string.Join("\r\n", filteredWords));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

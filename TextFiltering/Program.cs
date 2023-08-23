using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFiltering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFileName = "input.txt";
            string outputFileName = "output.txt";
            string keywordFileName = "keyword.txt";
            // Wczytaj frazę kluczową z pliku
            string keyword = File.ReadAllText(keywordFileName);

            FilterLines(inputFileName, outputFileName, keyword);
        }

        static void FilterLines(string inputFileName, string outputFileName, string keyword)
        {
            try
            {
                using (StreamReader reader = new StreamReader(inputFileName))
                using (StreamWriter writer = new StreamWriter(outputFileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(keyword))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
                Console.WriteLine("Zakończono filtrowanie.");
            }
            catch (IOException)
            {
                Console.WriteLine("Wystąpił błąd podczas operacji plikowych.");
            }
        }
    }
}

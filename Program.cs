using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize counters
            int numWords = 1;
            int i = 0;

            //read the file and store it in the variable 'fileData'
            string fileData = System.IO.File.ReadAllText("A12TextFile.txt");

            //loop through each word in the file
            while (i < fileData.Length)
            {
                //check if condition is true. If true, increment numWords
                if ((fileData[i] == '.' || fileData[i] == ' '
                    || fileData[i] == '!' || fileData[i] == ',')
                    && ((fileData[i - 1] == 't' || fileData[i - 1] == 'e')))
                {
                    numWords++;
                }
                i++;
            }
            //print how many times the condition above was evaluated true
            Console.Write("There are " + numWords + " words ending in t or e.");
        }
    }
}

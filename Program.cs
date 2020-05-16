using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   // Open the text file using a stream reader.

                List<string> words = new List<string>();

                using (StreamReader sr = new System.IO.StreamReader("TestFile.txt"))
                {

                    while(!sr.EndOfStream)
                    { 
                      words.Add(sr.ReadLine());
                    }
                    
                }

                words.Sort();
                foreach (var line in words)
                {
                    Console.WriteLine(line);
                }
             
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


        }
    }
}

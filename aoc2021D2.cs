using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace esercizi
{

    class Day3
    {
        

        static void Main()
        {
            // AOC DAY 2

            var lines = Acquire("sample.txt");
            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            foreach (string line in lines)
            {
                Console.WriteLine(line);

                switch (line.Split(' ')[0])
                {
                    case "forward":
                        horizontal += int.Parse(line.Split(' ')[1]);
                        depth+= int.Parse(line.Split(' ')[1])*aim;
                        break;
                    case "down":
                        //depth += int.Parse(line.Split(' ')[1]);
                        aim += int.Parse(line.Split(' ')[1]);
                        break;
                    case "up":
                        //depth -= int.Parse(line.Split(' ')[1]);
                        aim -= int.Parse(line.Split(' ')[1]);
                        break;

                }
            }
            Console.WriteLine(horizontal);
            Console.WriteLine(depth);
            Console.WriteLine(horizontal*depth);
            Console.ReadKey();



        }

        public static string[] Acquire (string path)
        {
            string[] fileLines = File.ReadAllLines(path);  
            return fileLines;
        }
    }
}




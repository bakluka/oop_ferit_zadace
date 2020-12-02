using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DZ2
{
    static class TvUtilities
    {
        public static Episode[] LoadEpisodesFromFile(string file)
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            Episode[] episodes = new Episode[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] episode = lines[i].Split(',');
                episodes[i] = new Episode(int.Parse(episode[0]), double.Parse(episode[1]), double.Parse(episode[2]), int.Parse(episode[3]), TimeSpan.FromMinutes(double.Parse(episode[4])), episode[5]);  //malo hacky pristup
            }
            return episodes;
        }

        public static double GenerateRandomScore()
        {
            Random random_number = new Random();
            int result = random_number.Next(10, 100);  
            return (Double)result / 10.00;
        }

    }
}

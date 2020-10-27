using System;
using ClassLibrary_DZ1;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Episode ep1, ep2;
            ep1 = new Episode();
            ep2 = new Episode(10, 64.39, 8.7);
            int viewers = 10;
            for (int i = 0; i < viewers; i++)
            {
                ep1.AddView(GenerateRandomScore());
                Console.WriteLine(ep1.GetMaxScore());
            }
            if (ep1.GetAverageScore() > ep2.GetAverageScore())
            {
                Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
            }
            else
            {
                Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
            }

        }
        public static double GenerateRandomScore()
        {
            Random random_number = new Random();
            int result = random_number.Next(10, 100);  //vraca slicne brojeve, seed se neznacajno mjenja kroz for
            return (Double)result / 10.00;
        }
    }
}

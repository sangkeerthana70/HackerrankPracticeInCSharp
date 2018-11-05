using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int steps = 8;
            string s = "DDUUUUDD";

            int result = countingValleys(steps, s);
        }

        static int countingValleys(int steps, string s)
        {
            int valleyCount = 0;
            int altitude = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == 'U')
                {
                    Console.WriteLine("Climb up hill");
                    altitude++;
                    
                }
                else
                {
                    Console.WriteLine("Climb downhill");
                    altitude--;
                    if(altitude == -1)
                    {
                        Console.WriteLine("Hit sea level");
                        valleyCount += 1;
                    }
                }
                Console.WriteLine("Altitude: " + altitude);
                
                Console.WriteLine();
            }

            Console.WriteLine("Valley Count: " + valleyCount);
            return valleyCount;
        }
    }
}

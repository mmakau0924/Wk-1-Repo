using System;

namespace Primer_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World!");
            }
            // Age Qn

            Console.WriteLine("Enter Your Age:");
            string Age = Console.ReadLine();
            int AgeNo = Convert.ToInt32(Age);

            if (AgeNo >= 18)
                {
                Console.WriteLine("Adult");
                
            }
            else
            {
                Console.WriteLine("Not Adult");
            }
            
        }
    }
}

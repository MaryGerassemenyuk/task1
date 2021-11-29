using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите m:");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] mass = new int[n];
            int a = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = a + 1;
                a = mass[i];

            }

            int[] b = new int[m];
            int[] c = new int[mass.Length];

            while (b[m - 1] != 1)
            {

                Array.Copy(mass, 0, b, 0, m);

                Array.Copy(mass, m - 1, c, 0, mass.Length - m + 1);

                Array.Copy(mass, 0, c, mass.Length - m + 1, m - 1);

                Console.Write(b[0]);

                Array.Copy(c, 0, mass, 0, n);

            }
        }
    }
}


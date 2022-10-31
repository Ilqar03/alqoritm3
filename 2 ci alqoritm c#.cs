using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
                int N=Convert.ToInt32(Console.ReadLine());
            if (N==1)
            {
                Console.WriteLine("1 ne musbet nede menfi ededdir");
            }
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    count += 1;
                }
            }
            if (count == 2)
                {
                    Console.WriteLine("eded sade ededdir");
                }
                else
                {
                    Console.WriteLine("eded murekkeb ededdir");
                }
            

        }
    }
}using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
                int N=Convert.ToInt32(Console.ReadLine());
            if (N==1)
            {
                Console.WriteLine("1 ne musbet nede menfi ededdir");
            }
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    count += 1;
                }
            }
            if (count == 2)
                {
                    Console.WriteLine("eded sade ededdir");
                }
                else
                {
                    Console.WriteLine("eded murekkeb ededdir");
                }
            

        }
    }
}
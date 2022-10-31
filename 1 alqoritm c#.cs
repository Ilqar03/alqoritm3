using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int N=Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=N; i++)
            {
                count *= i;
            }
            Console.WriteLine(N+"faktoriali"+count);
        }
    }
}
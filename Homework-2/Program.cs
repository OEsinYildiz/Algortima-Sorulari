using System;
using System.Linq;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif iki sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) ThrowException.Ex();
            int m = Convert.ToInt32(Console.ReadLine());
            if (n < 0) ThrowException.Ex();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Pozitif bir sayı giriniz");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("_______________");
            
            foreach (var item in arr)
            {
                if (item%m==0)
                {
                    item.Console(item);
                }
            }
           
            
            
        }
    }

    public static class Print
    {
        public static void Console(this int x, int item)
        {
            System.Console.WriteLine(item);
        }
    }
    
    static class ThrowException
    {
        internal static void Ex()
        {
            throw new Exception("Pozitif sayı girmelisiniz");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) ThrowException.Ex();
            Console.WriteLine($"{n} adet sayı giriniz");
            List<int> list = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();
            if(list.Any(x=>x<0)) ThrowException.Ex();
            foreach (var item in list)
            {
                if(item%2==0)
                    Console.WriteLine(item);
            }
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
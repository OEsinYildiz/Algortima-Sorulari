using System;
using System.Linq;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz");
            string message = Console.ReadLine();
            string[] arr = message?.Split(' ');
            Console.WriteLine("Toplam kelime sayısı: {0}",arr.Length);
            string newMessage = string.Join("", arr);
            Console.WriteLine("Toplam harf sayısı: {0}",newMessage.Length);
        }
    }
}
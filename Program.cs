using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _15._10_ConsoleApp_usses_tread
{
    class Program
    {

        static void Print()
        {
            var SecondTread = Thread.CurrentThread;
            SecondTread.Name = "SecondTread";
            Console.WriteLine($"Создан поток {SecondTread.Name} #ID = {SecondTread.GetHashCode()}");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"Поток {SecondTread.Name} #ID = {SecondTread.GetHashCode()} работает");
            }

            Console.WriteLine($"Поток {SecondTread.Name} #ID = {SecondTread.GetHashCode()} окончил работу");
        }

        static void Main(string[] args)
        {
            var MainTread = Thread.CurrentThread;
            MainTread.Name = "CurrentTread";
            Console.WriteLine($"Создан поток {MainTread.Name} #ID = {MainTread.GetHashCode()}");

            Thread SecondTread = new Thread(Print);

            SecondTread.Start();
            //SecondTread.Join();

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Поток {MainTread.Name} #ID = {MainTread.GetHashCode()} работает");
            }

            Console.WriteLine($"Поток {MainTread.Name} #ID = {MainTread.GetHashCode()} окончил работу");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfOptional = int.Parse(Console.ReadLine());
            Optional<int>[] optionals = new Optional<int>[amountOfOptional];
            for (int i = 0; i < optionals.Length; i++)
            {
                try
                {
                    int userData = int.Parse(Console.ReadLine());
                    optionals[i] = new Optional<int>(userData);
                }
                catch (Exception)
                {
                    optionals[i] = new Optional<int>();
                }
            }

            ExtendedOptional<int> extendedOptional = new ExtendedOptional<int>();
            extendedOptional.OnOptionalEmptied += OnOptionalEmptiedHandler;
            extendedOptional.OnOptionalFilled += OnOptionalFilledHandler;

            foreach (Optional<int> item in optionals)
                Console.WriteLine(item.ToString());

            extendedOptional.SetValue(42);
            extendedOptional.SetValue(null);

            Console.ReadLine();
        }

        public static void OnOptionalFilledHandler(int value) => Console.WriteLine(value);

        public static void OnOptionalEmptiedHandler() => Console.WriteLine("информацию об опустошении");
    }
}

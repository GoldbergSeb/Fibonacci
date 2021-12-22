using System;
using System.Threading;

namespace FibonacciNumbers {
    class Program {
        static void Main(string[] args) {
            string input = string.Empty;

            if(args.Length == 1)
            {
                input = args[0];
                int number = int.Parse(input);
                int result = Fib(number);
                Console.WriteLine($"\nDie {number}. Fibonacci-Nummer lautet: {result}");
            }
            else
            {
                Console.WriteLine("Die wievielte Fibonacci-Nummer soll berechnet werden?");
                input = Console.ReadLine();
                int number = int.Parse(input);
                int result = Fib(number);
                Console.WriteLine($"\nDie {number}. Fibonacci-Nummer lautet: {result}");
                Thread.Sleep(2000);
            }

        }

        static int Fib(int number)
        {
            if (number == 0) 
              return 0;        
            if (number == 1) 
              return 1; 
   
            return Fib(number - 1) + Fib(number - 2);
        }
    }
}

using System;
using System.Threading;

namespace FibonacciNumbers {
    class Program {
        static void Main(string[] args) {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Die wievielte Fibonacci-Zahl soll berechnet werden?");
                string input = Console.ReadLine();
                if(input != "e")
                {
                    int number = int.Parse(input);

                    int result = Fib(number);
                    Console.WriteLine($"\nDie {number}. Fibonacci-Nummer lautet: {result}");
                    Thread.Sleep(2000);
                }
                else
                {
                    break;
                }
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

//Console.WriteLine("Hello, World!");
using System;
namespace OperatorsExercise
{
class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine();
            Console.WriteLine("What is the radius of your circle?");
            Console.WriteLine();
            var radius = double.Parse(Console.ReadLine());
            var answer1 = Methods.AreaOfCircle(radius);
            Console.WriteLine(answer1);
        }
    }
}

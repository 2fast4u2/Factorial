using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(input));
            Console.ReadKey();
        }
        static int currentNum = 0;
        static int counter = 0;
        static int Factorial(int num)
        {
            int answer = num;
            if (num > 1)
            {
                answer = num * Factorial(num - 1);
            }
            return answer;
        }
    }
}

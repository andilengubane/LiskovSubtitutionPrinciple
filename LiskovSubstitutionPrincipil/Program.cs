using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrincipil
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {5,7,9,8,1,6,4 };

            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of the numbers: {sum.Calculate()}");

            Console.WriteLine();

            SumCalculator evenNumbersSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of the even numbers: {evenNumbersSum.Calculate()}");

            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}

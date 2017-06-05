using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int [7];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 56;
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers.Length );
        }
    }
}

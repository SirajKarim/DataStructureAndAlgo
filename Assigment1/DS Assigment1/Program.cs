using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Assigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            double n = double.Parse(Console.ReadLine());
            double val = 2 * n - 1;
            Console.WriteLine(val);
            double a = 1;
            double fomu = (n / 2) * (a + val);
            Console.WriteLine("Sum of the odd series is {0}", fomu);
            Console.WriteLine("Q No:    02");
            int[] arr = {50,40,30,20,10 };
            int count = arr.Length-1;
            Console.WriteLine("Unsorted Series");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0} ",arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Reverse Series");
            for (int i = 0; i < count; i++)
            {
                arr[i] = arr[i] + arr[count];
                arr[count] = arr[i] - arr[count];
                arr[i] = arr[i] - arr[count];
                count--;
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0} ",arr[i]);
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting obj1 = new Sorting();
            File obj = new File();
            File[] arr = new File[2];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new File();
                Console.WriteLine("enter name");
                arr[i].name = Console.ReadLine();
                Console.WriteLine("enter age");
                arr[i].age = float.Parse(Console.ReadLine());
            }


           
            Console.WriteLine("Select bubble sort or selectional sort");
            Console.WriteLine("Press b for bubble sort or s for selectional sort");
            string userPrompt = Console.ReadLine();
            if (userPrompt=="b")
            {
                Console.WriteLine("Press 1 to sort by size and 2 for sort by name");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput==1)
                {
                    obj1.bubbleSortSize(arr);
                }
                else if (userInput == 2)
                {
                    obj1.bubbleSortName(arr);
                }
            }
            else if (userPrompt == "s")
            {
                obj1.selectionSort(arr);

            }

        }
    }
}

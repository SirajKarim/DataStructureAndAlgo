using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_2
{
    class Sorting:File
    {
        
        float temp1 = 0;
        string temp;
        public  void selectionSort(File [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[min].age>arr[j].age)
                    {
                        min = j;
                    }
                }
                temp1 = arr[min].age;
                arr[min].age = arr[i].age;
                arr[i].age = temp1;

            }
            foreach (var item in arr)
            {
                Console.WriteLine(item.age);
            }
        }
        public  void bubbleSortName(File [] arr)
        {
            for (int i = arr.Length-1; i >0 ; i--)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].name.CompareTo(arr[i].name)>0)
                    {
                        temp = arr[i].name;
                        arr[i].name = arr[j].name;
                        arr[j].name = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item.name);
            }
        }
        public void bubbleSortSize(File [] arr)
        {
           // int l = arr.Length;
            for (int i = arr.Length - 1; i > 0; i--)
            {
                
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].age>arr[i].age)
                    {
                        temp1 = arr[i].age;
                        arr[i].age = arr[j].age;
                        arr[j].age = temp1;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item.age);
            }
        }
    }
}

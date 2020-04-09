using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamArray
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass mc = new myClass();
            mc.sumNums(1,2,3,4);
            mc.sumNums(10,20,30,40,50,60,70,80,90,100,110);
        }
    }
    class myClass
    {
        public void sumNums(params int[]nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("The sum the given number is {0}",sum);
        }
    }
}

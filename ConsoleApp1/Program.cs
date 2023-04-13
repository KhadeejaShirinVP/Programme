using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums ={1, 2, 3, 4, 6, 3, 4, 9};
            //string dublicate="";
            //int length = 0;
            //length = nums.Length - 1;
            //foreach(int  n in nums)
            //{
            //    dublicate += nums[length];
            //}
            //Console.WriteLine(dublicate);
            //dublicate.ToArray();
            //if (dublicate.ToString == nums.ToString) { }


            int[] nums = { 1, 2, 3, 4, 6, 3, 4, 9 };
            string dublicate = "";

            foreach (int n in nums)
            {
                dublicate += n;
            }
            Console.WriteLine(dublicate.ToArray());


        }
    }
}

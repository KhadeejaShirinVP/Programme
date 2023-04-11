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
            int[] nums ={1, 2, 3, 4, 6, 3, 4, 9};
            string dublicate = "";
        
            foreach(int  n in nums)
            {
                dublicate += n;
            }
            Console.WriteLine(dublicate.ToArray());
            


        }
    }
}

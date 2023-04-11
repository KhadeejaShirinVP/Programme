using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //largest number and second largest

            //int[] nums = { 1, 2, 68, 67, 21, 78, 90, 67, 54, 35, 23 };
            //Console.WriteLine("Array is: ");
            //foreach(int i in nums)
            //{
            //    Console.WriteLine(i+ " ");
            //}
            //Array.Sort(nums);
            //Console.WriteLine("\nLargest number is: "+ nums[nums.Length-1]);
            //Console.WriteLine("\nSecond Largest is: " + nums[nums.Length-2]);

            //......................................................................................................................//
            //smallest element in the array
            int[] nums = { 7, 2, 68, 67, 21, 78, 90, 67, 54, 35, 23 };
            int min = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine("Smallest element in the array is: "+min);
            
            //..............................................................................................................//

            ////Reverse string
            //string word = "", rev = "";
            //Console.WriteLine("enter a word: ");
            //word= Console.ReadLine();
            //int len = 0;
            //len= word.Length-1;
            //while(len>=0)
            //{
            //    rev += word[len];
            //    len--;
            //}
            //Console.WriteLine("\nReverse of wors is : " + rev);
            //Console.ReadKey();

            //.................................................................................//

            //pallindrom
            //string word = "", rev = "";
            //Console.WriteLine("enter a word: ");
            //word = Console.ReadLine();
            //int len = 0;
            //len = word.Length - 1;
            //while (len >= 0)
            //{
            //    rev += word[len];
            //    len--;
            //}
            ////Console.WriteLine("\nReverse of wors is : " + rev);
            //if(word==rev)
            //{
            //    Console.WriteLine("pallindrom");
            //}
            //else
            //{
            //    Console.WriteLine("not pallindrom");

            //}
            //Console.ReadKey();

            //............................................................................................//
            //prime number
            //int n;
            //int count = 0;
            //Console.WriteLine("enter a number: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i < n / 2; i++)
            //{
            //    if (n % 2 == 0)
            //    {
            //        count = 1;

            //    }
            //}
            //if (count == 0)
            //{
            //    Console.WriteLine("prime number");
            //}
            //if(n == 1)
            //{
            //    Console.WriteLine("1 is not prime nad nom prime");
            //}
            //else
            //    Console.WriteLine("non prime");
            //Console.ReadKey();

            //...................................................................//

            // even or odd
            //int n;
            //Console.WriteLine("enter a number: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("even number");

            //}
            //else
            //    Console.WriteLine("odd prime");
            //Console.ReadKey();

            ///...................................................................................................//

            //even numbers between x to y
            //int min = 16;
            //int max = 48;
            //for(int i=min; i<=max; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //........................................................................................................//
            ////odd numbers between x to y and how many numbers
            //int min = 16;
            //int max = 48;
            //int count = 0;
            //for (int i = min+1; i <= max-1; i += 2)
            //{
            //    Console.WriteLine(i);
            //    count++;
            //}
            //Console.WriteLine("Numbers of odd: " + count);

            //....................................................................//

            //Distance calulator
            //int distance, result;

            //Console.WriteLine("enter your KM distance");
            //distance=Convert.ToInt32(Console.ReadLine());
            //result = distance * 1000;
            //Console.WriteLine("distance in meter: " + result);
            //Console.ReadKey();


            //....................................................................................//

            //repeat character
            //string input = "aabbccddaagghhttrrew";
            //string output = "";

            //for(int i=0;i<input.Length;i++)
            //{
            //    if (!output.Contains(input[i]))
            //    {
            //        output+= input[i];
            //    }
            //}
            //Console.WriteLine(output);

            //........................................................................//

            //count of repeat charactor
            //string word = "khadeeja shirin";
            //char charToFind = 'k';
            //int count=word.Count(c=>c==charToFind);
            //Console.WriteLine(count);


            //....................................................................//

            //Anagram
            //string word1 = "silent", word2 = "listen";
            //if(word1.Length==word2.Length)
            //{
            //    char[] array1= word1.ToLower().ToCharArray();
            //    char[] array2= word2.ToLower().ToCharArray();
            //    Array.Sort(array1);
            //    Array.Sort(array2);
            //    if (array1.ToString() == array2.ToString())
            //    {
            //        Console.WriteLine("anagram");
            //    }

            //}
            //else
            //Console.WriteLine("non Anagram");


            ////............................................................................................................//
            ////duplicate array
            //int[] nums = { 1, 2, 3, 4, 6, 3, 4, 9 };
            //string dublicate = "";

            //foreach (int n in nums)
            //{
            //    dublicate += n;
            //}
            //Console.WriteLine(dublicate.ToArray());


            //.....................................................................................................//
            //vowels and consonants
            //string word = "";
            //int vowels=0;
            //int consonats = 0;
            //Console.WriteLine("enter a word");
            //word= Console.ReadLine();
            //for(int i = 0; i < word.Length; i++)
            //{
            //    char c = char.ToLower(word[i]); 
            //    if(c== 'a'|| c=='e'|| c=='i'|| c=='o'|| c=='u' )
            //    {
            //        vowels++;
            //    }
            //    else if(c>='a' && c<= 'z')
            //    {
            //        consonats++;
            //    }
            //}
            //Console.WriteLine("Number of vowels: " + vowels);
            //Console.WriteLine("Number of Consonants: " + consonats);

            //......................................................................................................//

            //factorial of integer
            //int number=0;
            //int factorial=1;
            //Console.WriteLine("enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //for(int i = number; i >= 1; i--)
            //{
            //    factorial*=i;
            //}
            //Console.WriteLine("The factorial of " + number + " is " + factorial);




        }

       
    }
}

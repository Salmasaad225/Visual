using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace lab9
{
    static class Extension
    {
        public static int Reversenum(this int num)
        {
            int temp;
            int rev = 0;
            while (num != 0)
            {
                temp = num % 10;
                rev = (rev * 10) + temp;
                num = num / 10;
            }
            return rev;
        }



        public static int Num_degit(this int num)
        {
            int i = 0;
            string str_num = num.ToString();
            foreach (char item in str_num)
            {
                i++;
            }
            return i;
        }

        public static string remove_Char(this string text)
        {
            return Regex.Replace(text, "[-,!,*,=,+,/,&]", "");


        }

        public static int num_max(this IEnumerable<int> listnums)
        {
            int max_num = 0;

            foreach (int item in listnums)
            {
                if (item > max_num)
                    max_num = item;
            }
            return max_num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1234;
            string text = "s!a+l&m*a";
            List<int> mylist = new List<int>() { 1, 2, 3, 4 };





            Console.WriteLine(number.Reversenum());

            Console.WriteLine(number.Num_degit());

            Console.WriteLine(text.remove_Char());

            Console.WriteLine(mylist.num_max());
        }
    }
}

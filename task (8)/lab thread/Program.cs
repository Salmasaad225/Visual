using System;
using System.Threading.Tasks;

namespace lab_thread
{
    class Program
    {
       public static int Sum_Odd()
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int Sum_Even()
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int Sum_all()
        {
            int sum = 0;

            for (int i = 0; i <1000; i++)
            {
                sum += i;
            }

            return sum;
        }

        public static int array_odd(int [] nums)
        {
            int sum_odd = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    sum_odd += nums[i];
                }
                
            }

            return sum_odd;
        }

        public static int array_even(int[] nums)
        {
            int sum_even = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    sum_even += nums[i];
                }

            }

            return sum_even;
        }

        public static int array_all(int[] nums)
        {
            int sum_all = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                    sum_all += nums[i];
                

            }

            return sum_all;
        }



        static async Task Main(string[] args)
        {
            //int result1 = await Task.Run(() => Sum_Odd());
            //Console.WriteLine(result1);

            //int result2 = await Task.Run(() => Sum_Even());
            //Console.WriteLine(result2);

            //int result3 = await Task.Run(() => Sum_all());
            //Console.WriteLine(result3);


            //Console.WriteLine(Sum_Odd());
            //Console.WriteLine(Sum_Even());
            //Console.WriteLine(Sum_all());

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int result4 = await Task.Run(() => array_odd(nums));
            Console.WriteLine(result4);

            int result5 = await Task.Run(() => array_even(nums));
            Console.WriteLine(result5);

            int result6 = await Task.Run(() => array_all(nums));
            Console.WriteLine(result6);



            //int sum_odd = array_odd(nums);
            //int sum_even = array_even(nums);
            //int sum_all = array_all(nums);

            //Console.WriteLine(sum_odd);
            //Console.WriteLine(sum_even);
            //Console.WriteLine(sum_all);








        }
    }
}

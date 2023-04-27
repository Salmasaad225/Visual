using System;
using System.Collections.Generic;

namespace lab1 
{
    public class Point : IComparable
    {
        public int x { get; set; }

        public int y { get; set; }




        public int CompareTo(object obj)
        {
            Point temp = obj as Point;         // casting  
            if (this.x == temp.x)
                return 0;
            else if (this.x > temp.x)
                return 1;
            else
                return -1;
            //return this.x.CompareTo(temp.x);
        }
        public override string ToString()
        {
            return x.ToString();
        }







        public interface IPayable
        {
            int salary { get; set; }

            void ShowPayment();
        }

        public class Employee : IPayable
        {

            public int salary { get; set; }

            public string name { get; set; }



            public Employee(int _salary, string _name)    // constructor with pramiters
            {
                salary = _salary;
                name = _name;
            }


            public void ShowPayment()
            {
                Console.WriteLine($"{name}'s Salary is {salary}");
            }
        }

        public class Trainee : IPayable
        {

            public int salary { get; set; }

            public string name2 { get; set; }


            public Trainee(int _salary, string _name)    // constructor with pramiters
            {
                salary = _salary;
                name2 = _name;
            }



            public void ShowPayment()
            {
                Console.WriteLine($"{name2} 's  Salary is {salary}");
            }

            public override string ToString()
            {
                return $"{name2} have  Salary {salary}";
            }
        }

        public class usingComparer : IComparer<Trainee>
        {
            public int Compare(Trainee x, Trainee y)
            {
                //Trainee temp = x as Trainee;
                //Trainee temp2 = y as Trainee;

                if (x.salary > y.salary)
                    return 1;
                else if (x.salary == y.salary)
                    return 0;
                else
                    return -1;
            }
        }





        class Program
        {





            static void Main(string[] args)
            {
                Point p1 = new Point();
                Point p2 = new Point();
                Point p3 = new Point();
                p1.x = 200;
                p2.x = 9;
                p3.x = 7;

                p1.y = 80;
                p2.y = 90;
                p3.y = 75;



                Point[] ppp = new[] { p3, p2, p1 };

                Array.Sort(ppp);

                for (int i = 0; i < ppp.Length; i++)
                {
                    Console.WriteLine(ppp[i]);
                }

                //////////////////////////////////////////////////////////////////////

                Employee emp = new Employee(700, "salma");
                emp.ShowPayment();

                Trainee tre = new Trainee(600, "ahmed");
                tre.ShowPayment();

               

                Console.WriteLine();


                Trainee tra1 = new Trainee(500, "salma");
                Trainee tra2 = new Trainee(700, "ahmed");
                Trainee tra3 = new Trainee(345, "noha");
                Trainee tra4 = new Trainee(9000, "Salwa");

                Trainee[] trainees = new[] { tra1, tra2, tra3, tra4 };

                Array.Sort(trainees, new usingComparer());


                for (int i = 0; i <trainees.Length; i++)
                {
                    Console.WriteLine(trainees[i]);
                }









            }
        }
    }
}


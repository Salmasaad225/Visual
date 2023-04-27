using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace lab_5_rrr
{
    public class Employee : IComparable<Employee>
    {
        public int id { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public int salary { get; set; }

        public int yearsofexpretions { get; set; }

        public int dep_id { get; set; }

        //public int CompareTo( Employee other)
        //{
        //    throw new NotImplementedException();
        //}



        public int CompareTo(Employee other)
        {
            return yearsofexpretions.CompareTo(other.yearsofexpretions);
        }
        public override string ToString()
        {
            return $"years are {yearsofexpretions}";

        }
        
    }

    class salaryComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.salary.CompareTo(y.salary);
        }

        //public override string ToString()
        //{
        //    return ToString();

        //}

    }
    public class Department
    {
        public string name { get; set; }

        public  int num_employees { get; set; }

        public Employee[] emp_array { get; set; }

        
        public List<Employee> emp_list { get; set; } = new List<Employee>();
        public Department()
        {
            emp_array = new Employee[4];

        }

        public Dictionary<int, Employee> Dic { set; get; } = new Dictionary<int, Employee>();

        public void EmployeeName(int id)
        {
            Console.WriteLine(Dic[id]);
        }











    }
            
            
    class Program
    {
        static void Main(string[] args)
        {
          

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();

            emp1.yearsofexpretions = 50;
            emp2.yearsofexpretions = 40;
            emp3.yearsofexpretions = 30;
            emp4.yearsofexpretions = 20;

            emp1.salary = 500;
            emp2.salary = 900;
            emp3.salary = 300;
            emp4.salary = 200;

            Department dep1 = new Department();
            dep1.emp_array[0] = emp1;
            dep1.emp_array[1] = emp2;
            dep1.emp_array[2] = emp3;
            dep1.emp_array[3] = emp4;

            Array.Sort(dep1.emp_array);
            for (int i = 0; i < dep1.emp_array.Length; i++)
            {
                Console.WriteLine(dep1.emp_array[i]);
            }

            Array.Sort(dep1.emp_array, new salaryComparer());
            for (int i = 0; i < dep1.emp_array.Length; i++)
            {
                Console.WriteLine(dep1.emp_array[i].salary);
            }

            ////////////////////////////////////////////////////////////////////
            ///

            dep1.emp_list.Add(emp1);
            dep1.emp_list.Add(emp2);
            dep1.emp_list.Add(emp3);
            dep1.emp_list.Add(emp4);



            dep1.emp_list.Sort(new salaryComparer());

            foreach (Employee item in dep1.emp_list)
            {
                Console.WriteLine(item);
            }

            dep1.emp_list.Sort();

            foreach (Employee emp in dep1.emp_list)
            {
                Console.WriteLine(emp.yearsofexpretions);
            }

            ///////////////////////////////////////////////////////
            emp3.name = "salma";



           
            dep1.Dic.Add(1, emp1);
            dep1.Dic.Add(2, emp2);
            dep1.Dic.Add(3, emp3);


            Console.WriteLine(dep1.Dic[3].name);



        }









    }
   
}

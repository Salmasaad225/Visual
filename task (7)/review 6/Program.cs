using System;
using System.Collections.Generic;

namespace review_6
{
    delegate void increaseEmp(Employee emp);

    class Employee
    {
        public event increaseEmp increase;
        public int ID { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        public int Salary { set; get; }
        public int YearofExperience { get; set; }

        public Department Dept { set; get; }

        public Employee(string name, int salary, int years)  /*constructor*/
        {
            Name = name;
            Salary = salary;
            YearofExperience = years;
        }

        public void ChangeDept(Department d) // function 
        {
            Dept = d;

            if (increase != null)
            {
                increase.Invoke(this);
            }
        }


    }

    class Department
    {
        public string Name { set; get; }



        public List<Employee> employeesList { get; set; } = new List<Employee>();




        public void decreaseEmp(Employee emp)    /* هيشاور*/
        {
            employeesList.Remove(emp);
        }

        public void increaseEmp(Employee emp)       /* هيشاور*/
        {
            employeesList.Add(emp);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee("Ahmed", 5000, 5);
            Employee emp2 = new Employee("Khaled", 9000, 10);
            Employee emp3 = new Employee("mohamed", 2000, 1);
            Employee emp4 = new Employee("Ali", 2000, 1);

            Department depp1 = new Department();
            Department depp2 = new Department();

            depp1.employeesList.Add(emp1);
            depp1.employeesList.Add(emp2);

            depp2.employeesList.Add(emp3);
            depp2.employeesList.Add(emp4);


            emp1.increase += depp1.decreaseEmp;
            emp1.increase += depp2.increaseEmp;

            emp1.ChangeDept(depp2);



            foreach (Employee employee in depp1.employeesList)
            {
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine();

            foreach (Employee employee in depp2.employeesList)
            {
                Console.WriteLine(employee.Name);
            }




        }
    }
}

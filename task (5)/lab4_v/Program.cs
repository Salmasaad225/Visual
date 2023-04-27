using System;
using System.Collections.Generic;
using static lab4_v.Animal;

namespace lab4_v
{


    public delegate void die_animal(Animal animal);
    public class Animal
    {
        public string Name { get; set; }

        public event die_animal die_animal;    /* REFRENCE OF DELEDATE*/

        public void die_an()
        {
            if (die_animal != null)
            {
                die_animal.Invoke(this);
            }
        }

        public override string ToString()
        {
            return $" ANIMAL IS {Name}";
        }



    }
    public class Zoo
    {
        public List<Animal> Animalslist { get; set; } = new List<Animal>();

        public void Add(Animal addAnimal)
        {
            Animalslist.Add(addAnimal);
        }

        public void dieing(Animal animal)   /* هيشاور عليها */
        {
            Animalslist.Remove(animal);
        }


        public void display_animals()
        {

            foreach (var item in Animalslist)
            {
                Console.WriteLine($" {item}");
            }
           
        }


        

    }



    public delegate void neew(float salary);     /* 2*/


    public delegate bool filter_employee(float salary);         /*1*/

    public class Employee                    /* puplisher*/
    {
        public string Name { get; set; }

        public float Salary { get; set; }

        public event neew neew;                               /* 2*/

        public void increase_salary(float increase)         /* 2*/
        {
            Salary += increase;

            neew.Invoke(increase);



        }

        public override string ToString()
        {
            return $"EMPLOYEES  {Salary}";
        }


    }

    public class Company    /* supscrips*/
    {
        public string Name { get; set; }
        public float Budget { get; set; }

        public List<Employee> FilterEmpLIST { set; get; } = new List<Employee>();       /* 1*/

        public List<Employee> employess { set; get; } = new List<Employee>();               /*2*/
        

        public List<Employee> filter_employees(List<Employee> empList, filter_employee filter_employee)      /*1*/
        {
            List<Employee> results = new List<Employee>();

            foreach (Employee item in empList)
            {
                if (filter_employee.Invoke(item.Salary))
                    results.Add(item);
            }




            return results;
        }


        public bool filterEmpSalary(float salary)                 /* هيشاور عليعا*/  /*   1*/
        {
            return salary > 4000;
        }

        public void newsalary(float n)        /* هيشاور عليها 2*/   /* 2*/
        {
            Console.WriteLine(Budget - n);
        }



    }

    class Program
        {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            Animal elephant = new Animal();
            Animal lion = new Animal();
            Animal sparow = new Animal();
            Animal tiger = new Animal();

            elephant.Name = "ELEPHANT";
            lion.Name = "LION";
            sparow.Name = "SPAROW";

            zoo.Add(elephant);
            zoo.Add(lion);
            zoo.Add(sparow);
            zoo.Add(tiger);

            elephant.die_animal += zoo.dieing;
            lion.die_animal += zoo.dieing;
            sparow.die_animal += zoo.dieing;
            tiger.die_animal += zoo.dieing;

            elephant.die_an();
            tiger.die_an();


            zoo.display_animals();



            Company com = new Company();
            com.Name = "company1";
            com.Budget = 5000;


            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            emp1.Salary = 5000;
            emp2.Salary = 3000;
            emp3.Salary = 4000;


            com.FilterEmpLIST.Add(emp1);
            com.FilterEmpLIST.Add(emp2);
            com.FilterEmpLIST.Add(emp3);


            List<Employee> empList = com.filter_employees(com.FilterEmpLIST, com.filterEmpSalary);  // هنبعت الليست والفانكشن


            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp);
            }
            /* 2*//* 2*//* 2*//* 2*//* 2*//* 2*//* 2*//* 2*/

            com.employess.Add(emp1);
            com.employess.Add(emp2);
            com.employess.Add(emp3);

            emp1.neew += com.newsalary;
            emp2.neew += com.newsalary;

            emp1.increase_salary(400); 
            emp2.increase_salary(600);

            foreach (Employee employee in com.employess)
            {
                Console.WriteLine(employee);
            }













        }    
       
    }
}       

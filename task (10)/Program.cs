using System;
using System.Collections.Generic;

namespace zoo2
{
    


    public class AnimalList : List<Animal>
    {
        public new void Add(Animal item)
        {
            if (item.Age <= 10)
                base.Add(item);
        }


    }

    class Zoo
    {
        public AnimalList Animals { get; set; } = new AnimalList();
        public IReadOnlyCollection<Animal> Birds
        {
            get
            {
                List<Animal> Bird = new List<Animal>();
                foreach (Animal item in Animals)
                {
                    if (item.ismammel == false)
                        Bird.Add(item);
                }
                return Bird;
                
            }
        }
        public IReadOnlyCollection<Animal> Mammmels
        {
            get
            {
                List<Animal> Mam = new List<Animal>();
                foreach (Animal item in Animals)
                {
                    if (item.ismammel == true)
                        Mam.Add(item);
                }
                return Mam;
            }
        }

        public void Add(Animal n_Animal)
        {
            Animals.Add(n_Animal);
        }
        

        public void display_animals()
        {
            foreach (var item in Animals)
            {
                Console.WriteLine($"animals is " + item);

            }

        }




        //public void display_mammels()
        //{
        //    foreach (var item in Mammal)
        //    {
        //        Console.WriteLine($"animals is " + item);

        //    }

        //}

        //public void display_birds()
        //{
        //    foreach (var item in bird)
        //    {
        //        Console.WriteLine($"animals is " + item);

        //    }

        //}

        //static List<Animal> Filter_animals(List<Animal> filter, checkanimal checkanimal)
        //{
        //    List<Animal> birds = new List<Animal>();
        //    List<Animal> mammels = new List<Animal>();

        //    foreach (var item in filter)
        //    {
        //        if (checkanimal(item))
        //        {
        //            birds.Add(item);
        //            return birds;

        //        }
        //        else
        //        {
        //            mammels.Add(item);
        //            return mammels;
        //        }

        //    }
        //    return mammels;




        //}


    }

    public class Animal
    {
        public string name { get; set; }
        public int Age { get; set; }
        public bool ismammel { get; set; }
        public override string ToString()
        {
            return $" {name}";
        }

        




    }

    public class Mammal : Animal
    {
        public Mammal()
        {
            ismammel=true;

        }

    }

    public class Bird : Animal
    {
        public Bird()
        {
            ismammel = false;

        }

    }


    public class Lion : Mammal
    {

    }

    public class Elephant : Mammal
    {

    }

    public class Penguin : Bird
    {

    }

    public class Sparrow : Bird
    {
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            


            Lion lion = new Lion();
            Sparrow sparrow = new Sparrow();
            Elephant elephant =new Elephant();

            lion.name = "lion";
            lion.Age = 20;

            sparrow.name = "sparrow";
            sparrow.Age = 4;

            elephant.name = "elephant";
            elephant.Age = 6;


            Zoo zoo = new Zoo();
            zoo.Add(lion);
            zoo.Add(sparrow);
            zoo.Add(elephant);

            zoo.display_animals();
            Console.WriteLine();

            foreach (var item in zoo.Animals)   
            {
                Console.WriteLine(item.name);
            }

            Console.WriteLine();

            foreach (var item in zoo.Birds)
            {
                Console.WriteLine(item.name);
            }

            Console.WriteLine();

            foreach (var item in zoo.Mammmels)
            {

                Console.WriteLine(item.name);
            }

        }
    }
}

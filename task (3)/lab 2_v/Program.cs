using lab_2_v;
using System;
using System.Collections.Generic;

namespace lab_2_v
{
    delegate bool checkanimal(AnimalList animals);

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
        public IReadOnlyCollection<Bird> birds { get { if ()} }
        public IReadOnlyCollection<Animal> Mammals
        //public AnimalList Mammal { get; set; } = new AnimalList();
        //public AnimalList bird { get; set; } = new AnimalList();

        public void Add(Animal n_Animal)
        {
            Animals.Add(n_Animal);
        }
        //public void Add_m(Animal n_mammel)
        //{
        //    Animals.Add(n_mammel);
        //}
        //public void Add_b(Animal n_bird)
        //{
        //    Animals.Add(n_bird);
        //}

        public void display_animals()
        {
            foreach (var item in Animals)
            {
                Console.WriteLine($"animals is "+item);

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

    }

    public class Animal
    {
        public string type { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"animal age is {Age}";
        }
    }

    public class Mammal : Animal
    {
        public Mammal ()
        {
            
        }

    }

    public class Bird : Animal
    {

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





    public class Phonebook
    {
        public Dictionary<int, string> _phonebook = new Dictionary<int, string>();


        public string this[int i]
        {

            set
            {
                _phonebook[i] = value;
            }
            get
            {
                return _phonebook[i];
            }
        }

        public int this[string name]
        {

            set
            {
                _phonebook[value] = name;


            }

            get
            {
                
                if (_phonebook.ContainsValue(name))
                {
                    
                    foreach (int item in _phonebook.Keys)
                    {
                        if (_phonebook[item] == name)
                        {
                            return item;
                            
                        }

                       
                        
                    }

                    return 0;

                }

                else
                {
                    return -1;
                }



            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            zoo.Add(new Lion() { Age = 20 });
            zoo.Add(new Elephant() { Age = 11 });
            zoo.Add(new Penguin() { Age = 3 });
            zoo.Add(new Sparrow() { Age = 7 });

            zoo.display_animals();

            //zoo.Add_m(new Elephant());


            //zoo.display_mammels();
            //zoo.display_birds();

            //////////////////////////////////////////////////////////
            ///





            Phonebook phonebook = new Phonebook();
            phonebook[123] = "Ali";
            phonebook["Hossam"] = 456;
            int phone = phonebook["Ali"];

            foreach (var item in phonebook._phonebook)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine(phone);










        }
    }
}

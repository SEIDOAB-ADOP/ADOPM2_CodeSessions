namespace _09_inheritance2;

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Animal();
        Console.WriteLine($"{a.Name} says {a.Noise()}. I am {a.Age} years old");

        Dog d = new Dog();
        Console.WriteLine($"{d.Name} says {d.Noise()}. I am {d.Age} years old");

        Animal d1 = d;
        Console.WriteLine($"{d1.Name} says {d1.Noise()}. I am {d1.Age} years old");

        Cat c = new Cat();
        Console.WriteLine($"{c.Name} says {c.Noise()}. I am {c.Age} years old");

        Animal c1 = c;
        Console.WriteLine($"{c1.Name} says {c1.Noise()}. I am {c1.Age} years old");


        var animals = new List<Animal>();

        animals.Add(a);
        animals.Add(d);
        animals.Add(d1);
        animals.Add(c);
        animals.Add(c1);
        Console.WriteLine("ANIMALS:");
        foreach (var item in animals)
        {
            Console.WriteLine($"{item.Name} says {item.Noise()}. I am {item.Age} years old");
            if (item is Dog dog)
            {
                Console.WriteLine(dog.Hate());
            }

        }

        /*
        Console.WriteLine("09_inheritance2");
        Console.WriteLine(new Animal().Noise());
        Console.WriteLine(new Dog().Noise());
        Console.WriteLine(new Cat().Noise());
        Console.WriteLine(new Labrador().Noise());

        
        Console.WriteLine("\nAnimals array");
        Animal[] animals = new Animal[4];
        animals[0] = new Animal();
        animals[1] = new Dog();
        animals[2] = new Cat();
        animals[3] = new Labrador();
        
        OtherTeamWritingNoise(animals);
        

        Console.ReadKey();
        */
    }

    /*
    private static void OtherTeamWritingNoise(Animal[] animals)
    {
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Noise());
            Console.WriteLine(animal.Name);

            //cast, as, is
            //csDog d = (csDog)animal;  //cast - crash if not working

            Dog d = animal as Dog;
            if (d != null)
            {
                Console.WriteLine(d.IHate());
            }

            if (animal is Labrador d1)
            {
                Console.WriteLine(d1.IAm());
                Console.WriteLine(d1.myAgeIs());
            }
        }
    }
    */
}


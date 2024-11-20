namespace _09_inheritance2;

class Program
{
    static void Main(string[] args)
    {
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
    }

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
}


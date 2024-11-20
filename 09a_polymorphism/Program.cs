namespace _09a_polymorphism;

public class Bird
{
    //public bool ICanFly { get; } = true;  //Not polymorphism
    public virtual bool ICanFly { get; } = true; //polymorphism
}

public class Duck : Bird { }
public class Ostrich : Bird
{
    //public new bool ICanFly { get; } = false; //Not polymorphism
    public override bool ICanFly { get; } = false; //polymorphism
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("09a_polymorphism");

        CanIFly(new Duck());
        CanIFly(new Ostrich());
    }

    static void CanIFly(Bird bird)
    {
        if (bird.ICanFly)
        {
            Console.WriteLine($"Hello, I am a {bird.GetType().Name}. Hurray! I can fly!");
        }
        else
        {
            Console.WriteLine($"Hello, I am a {bird.GetType().Name}. Sadly, I cannot fly!");
        }
    }
}


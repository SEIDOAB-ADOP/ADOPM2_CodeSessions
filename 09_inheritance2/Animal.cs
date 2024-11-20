using System;
namespace _09_inheritance2
{
	public class Animal
	{
		public virtual string Noise() => "Clonk";
        public virtual string Name { get; }
        public int Age = 0;

        public Animal()
        {
            Name = "Max the animal";
        }
	}
	public class Dog : Animal
	{
        public override string Noise() => "Voff";
        public override string Name { get; }
        public new int Age = 17;

        private string _hate = "Cats";
        public string IHate() => $"I hate {_hate}";
        public Dog():base()
        {
            Name = "Cooper the Dog";
        }
        public Dog(string hatedAnimal)
        {
            _hate = hatedAnimal;
        }

    }
    public class Cat : Animal
    {
        public override string Noise() => "Meow";
        public override string Name { get; }
        public Cat()
        {
            Name = "Scobby the Cat";
        }
    }
    public class Labrador : Dog
    {
        public override string Noise() => "Voff Voff Rauw!";
        public new int Age = 10;
        public override string Name { get; }
        public string IAm() => "I the best";
        public string myAgeIs()
        {
            return $"I am {this.Age}, my faher is {base.Age}";
        }
        public Labrador() : base("Squirrels")
        {
            Name = "Aladin the Labrador";
        }
    }
}


namespace _02_Methods_again;


class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public string AddLastName(string LastName)
    {
        Name = Name + " " + LastName;
        return Name;
    }
    public string AddLastName(string LastName, string MiddleName)
    {
        Name = Name + " " + MiddleName + " " + LastName;
        return Name;
    }

    public Student(string Name, int Grade = 5)
    {
        this.Name = Name;
        this.Grade = Grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("02_Methods_again");

        var s1 = new Student("Martin");
        Console.WriteLine(s1.Grade);

        var s2 = new Student("Martin", 1);
        Console.WriteLine(s2.Grade);

        Console.WriteLine(s2.AddLastName("Lenart"));
        Console.WriteLine(s2.Name);

        Console.WriteLine(s1.AddLastName("Lenart", "Sven"));

    }
}


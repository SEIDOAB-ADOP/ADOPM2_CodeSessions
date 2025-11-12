// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using _17_pattern_matching.Models;
using Seido.Utilities.SeedGenerator;

var rnd = new SeedGenerator();

IPearl p1 = new PearlAsClass().Seed(rnd);
IPearl p2 = new PearlAsStruct().Seed(rnd);
IPearl p3 = new PearlAsRecord().Seed(rnd);

//Pattern matching using if - is
if (p1 is PearlAsClass pac)
{
    pac.Price = 1000;
    System.Console.WriteLine("Implemented as a class");
}

//Pattern matching using switch
var message = p1 switch
{
    PearlAsClass pac1 => $"Implemented as a class, price: {pac1.Price}",
    PearlAsStruct => "Implemented as a struct",
    PearlAsRecord => "Implemented as a record",
    
    _ => "discarded"
};
System.Console.WriteLine(message);


//Pattern matching using a method with switch
System.Console.WriteLine(MethodPatternMatching(p1));
System.Console.WriteLine(MethodPatternMatching(p2));
System.Console.WriteLine(MethodPatternMatching(p3));

var pr = new PearlAsRecord(25, PearlColor.White, PearlShape.Round, PearlType.SaltWater);
System.Console.WriteLine(ComplexPatternMatching(pr));

var pr1 = pr with {Size = 5, Color = PearlColor.Black};
System.Console.WriteLine(ComplexPatternMatching(pr1));

var pc1 = new PearlAsClass(){ Color = PearlColor.White, Size = 7};
System.Console.WriteLine(ComplexPatternMatching(pc1));



//Pattern matching in a method with switch using expression bodied member syntax
static string MethodPatternMatching(IPearl pearl) => pearl switch
{
    PearlAsClass => "Implemented as a class",
    PearlAsStruct => "Implemented as a struct",
    PearlAsRecord => "Implemented as a record",
    
    _ => "discarded"
};


//Pattern matching in a method with switch using expression bodied member syntax
static string ComplexPatternMatching(IPearl pearl) => pearl switch
{
    //Order of most specific
    PearlAsRecord {Color: PearlColor.White } p when p.Size > 20 => "Large White Pearl, implemented as a Record ",

    PearlAsClass and IPearl {Color: PearlColor.White, Size: < 10}  => "Small White Pearl, implemented as a Class",

    IPearl p when p.Size < 10 && p.Color == PearlColor.Black => "Small Black Pearl, any implementation",

    PearlAsClass => "Implemented as a class",
    PearlAsStruct => "Implemented as a struct",
    PearlAsRecord => "Implemented as a record",
    
    _ => "discarded"
};
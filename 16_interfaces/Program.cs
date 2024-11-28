// See https://aka.ms/new-console-template for more information
using _16_interfaces.Models;

Console.WriteLine("Hello, Necklace!");


INecklace necklace = new Necklace();

IPearl p1 = new PearlAsClass();
p1.Color = PearlColor.Black;
p1.Shape = PearlShape.DropShaped;
p1.Type = PearlType.SaltWater;
p1.Size = 5;

IPearl p2 = new PearlAsStruct();
p2.Color = PearlColor.White;
p2.Shape = PearlShape.Round;
p2.Type = PearlType.FreshWater;
p2.Size = 25;

necklace.Name = "Sample Necklace";
necklace.ListOfPearls.Add(p1);
necklace.ListOfPearls.Add(p2);

var largestpearl = necklace.LargestPearl;
var smallestpearl = necklace.SmallestPearl;

Console.WriteLine(largestpearl);
Console.WriteLine(smallestpearl);

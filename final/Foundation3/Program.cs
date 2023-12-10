using System;

class Program
{
    static void Main(string[] args)
    {
        

        Address address1 = new Address("Honduras 205", "Palermo ", "Buenos Aires", "Argentina");
        Address address2 = new Address("Balcarce 323", "Santa Rosa", "La Pampa", "Argentina");
        Address address3 = new Address("9 de julio 2067", "San Salvador", "Jujuy", "Argentina");


        Lecture l1 = new Lecture("Lecture 1", "Lecture 1 Description", "1/1/2020", "1:00 PM", address1, "Speaker 1", 100);
        Reception r1 = new Reception("Reception 1", "Reception 1 Description", "05/07/2021", "1:00 PM", address2, "registration");
        OutdoorGathering o1 = new OutdoorGathering("Outdoor Gathering 1", "Outdoor Gathering 1 Description", "12/12/2022", "1:00 PM", address3, "rainy");

        Console.WriteLine(l1.generateStandardMessage());
        Console.WriteLine("\n");
        Console.WriteLine(l1.generateFullMessage());
        Console.WriteLine("\n");
        Console.WriteLine(l1.generateShortMessage());


        Console.WriteLine("\n");
        Console.WriteLine("===========================================================================================");

        Console.WriteLine(r1.generateStandardMessage());
        Console.WriteLine("\n");
        Console.WriteLine(r1.generateFullMessage());
        Console.WriteLine("\n");
        Console.WriteLine(r1.generateShortMessage());


        Console.WriteLine("\n");
        Console.WriteLine("===========================================================================================");


        Console.WriteLine(o1.generateStandardMessage());
        Console.WriteLine("\n");
        Console.WriteLine(o1.generateFullMessage());
        Console.WriteLine("\n");
        Console.WriteLine(o1.generateShortMessage());


    }
}
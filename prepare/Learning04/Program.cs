using System;
class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assing2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assing2.GetSummary());
        Console.WriteLine(assing2.GetHomeworkList());

        WritingAssignment assing3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assing3.GetSummary());
        Console.WriteLine(assing3.GetWritingInformation());
    }
}
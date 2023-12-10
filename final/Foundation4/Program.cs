using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[3];
        activities[0] = new Running("09 Dec 2023", 33, "Running", 5);
        activities[1] = new Swimming("07 Nov 2023", 45, "Swimming", 20);
        activities[2] = new StationaryBicycle("08 Jul 2023", 60, "StationaryBicycle", 30);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());   
        }

    }
}
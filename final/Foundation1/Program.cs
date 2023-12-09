using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("C# Tutorial", "Bob Tabor", 3600);
        v1.AddComment(new Comment("John Doe", "This is a great video!"));
        v1.AddComment(new Comment("Jane Doe", "I love this video!"));
        v1.AddComment(new Comment("Bob Smith", "Thanks for the video!"));

        Video v2 = new Video("Python Tutorial", "Bob Tabor", 3600);
        v2.AddComment(new Comment("Martin Taylor", "I love Python"));
        v2.AddComment(new Comment("Juan Ramirez", "You are a great teacher!"));
        v2.AddComment(new Comment("Joseph King", "Wow! This is great!"));


        Video v3 = new Video("Java Tutorial", "Bob Tabor", 3600);
        v3.AddComment(new Comment("Lucas Martinez", "It will be great to learn Java!"));
        v3.AddComment(new Comment("Jane Doe", "Programming is fun!"));
        v3.AddComment(new Comment("Bob Smith", "How can I call a API in Java?"));


        List<Video> videos = new List<Video>(){v1, v2, v3};

        foreach(Video video in videos){
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength());
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments: ");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Basics", "John Doe", 300);
        Video video2 = new Video("Learn Encapsulation", "Jane Smith", 450);
        Video video3 = new Video("Design Patterns Overview", "Sam Lee", 600);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great introduction!"));
        video1.AddComment(new Comment("Bob", "Very clear examples."));
        video1.AddComment(new Comment("Charlie", "I learned a lot from this video."));

        video2.AddComment(new Comment("David", "Loved the detailed explanations!"));
        video2.AddComment(new Comment("Eve", "This helped me understand abstraction."));

        video3.AddComment(new Comment("Frank", "Excellent overview."));
        video3.AddComment(new Comment("Grace", "Very informative."));
        video3.AddComment(new Comment("Hank", "Good pacing and examples."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
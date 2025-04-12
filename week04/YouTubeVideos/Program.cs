using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create and populate videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Train for a Marathon", "Coach Mike", 600);
        video1.AddComment(new Comment("Alice", "Very helpful tips!"));
        video1.AddComment(new Comment("Bob", "Loved the energy."));
        video1.AddComment(new Comment("Charlie", "Can you make one for beginners?"));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Coding Languages in 2025", "TechDaily", 480);
        video2.AddComment(new Comment("DevGuy", "Python for life!"));
        video2.AddComment(new Comment("CodeQueen", "Great breakdown."));
        video2.AddComment(new Comment("Student99", "JavaScript surprised me!"));
        videos.Add(video2);

        Video video3 = new Video("Make Money on YouTube", "GrowTube", 720);
        video3.AddComment(new Comment("Sarah", "Subscribed!"));
        video3.AddComment(new Comment("Moe", "This was super informative."));
        video3.AddComment(new Comment("Femi", "I'm starting my channel now!"));
        videos.Add(video3);

        // Display video info and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"\nTitle: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
            }
        }
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("How to Bake a Cake", "Baker123", 300);
        Video video2 = new Video("Top 10 Travel Destinations", "TravelGuru", 600);
        Video video3 = new Video("JavaScript Basics Tutorial", "CodeMaster", 900);
        Video video4 = new Video("Morning Yoga Routine", "FitLife", 450);

        // Add comments for video 1
        video1.AddComment(new Comment("Alice", "Great recipe! Tried it and loved it."));
        video1.AddComment(new Comment("Bob", "Thanks for the tips on frosting."));
        video1.AddComment(new Comment("Cathy", "Can you do a gluten-free version?"));

        // Add comments for video 2
        video2.AddComment(new Comment("David", "I want to visit all these places!"));
        video2.AddComment(new Comment("Eva", "Nice list, but I think Bali should be #1."));
        video2.AddComment(new Comment("Frank", "Good video, very informative."));
        video2.AddComment(new Comment("Grace", "Thanks for sharing your experience."));

        // Add comments for video 3
        video3.AddComment(new Comment("Hannah", "This helped me understand closures."));
        video3.AddComment(new Comment("Ian", "Please do a tutorial on async functions."));
        video3.AddComment(new Comment("Jane", "Clear and easy to follow."));
        
        // Add comments for video 4
        video4.AddComment(new Comment("Kyle", "Perfect way to start my day!"));
        video4.AddComment(new Comment("Laura", "Can you do a beginner’s meditation session?"));
        video4.AddComment(new Comment("Mark", "Loved the breathing exercises."));
        video4.AddComment(new Comment("Nina", "Thanks for the motivation!"));

        // Put videos in a list
        List<Video> videos = new List<Video>() { video1, video2, video3, video4 };

        // Display video info and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLengthInSeconds()}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine(); // blank line between videos
        }
    }
}

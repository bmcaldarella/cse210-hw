using System;
using System.Collections.Generic;

namespace YouTubeVideoManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video("Learning C# Basics", "John Doe", 600);
            Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 1200);
            Video video3 = new Video("C# Design Patterns", "Alice Johnson", 900);

            video1.AddComment(new Comment("User1", "Great video! Very informative."));
            video1.AddComment(new Comment("User2", "I learned a lot, thanks!"));
            video1.AddComment(new Comment("User3", "Could you explain more about classes?"));

            video2.AddComment(new Comment("User4", "Fantastic explanation of advanced concepts."));
            video2.AddComment(new Comment("User5", "I liked the examples given."));
            video2.AddComment(new Comment("User6", "This video was too long."));

            video3.AddComment(new Comment("User7", "Design patterns are crucial for clean code."));
            video3.AddComment(new Comment("User8", "Great examples of patterns in use."));
            video3.AddComment(new Comment("User9", "Very helpful for my project."));

            List<Video> videos = new List<Video> { video1, video2, video3 };

            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Duration: {video.Duration} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
                }

                Console.WriteLine();
            }
        }
    }
}

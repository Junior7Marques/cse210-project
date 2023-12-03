using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // videos and comments
        List<Video> videos = new List<Video>
        {
            new Video
            {
                Title = "Introduction to C#",
                Author = "CodingExpert",
                LengthInSeconds = 300
            },
            new Video
            {
                Title = "Data Structures Explained",
                Author = "TechGuru",
                LengthInSeconds = 450
            },
            new Video
            {
                Title = "Machine Learning Basics",
                Author = "AIEnthusiast",
                LengthInSeconds = 600
            }
        };

        //comments to the videos
        videos[0].AddComment("User1", "Great video!");
        videos[0].AddComment("User2", "Thanks for explaining");

        videos[1].AddComment("User3", "Very informative");
        videos[1].AddComment("User4", "Helped me a lot");

        videos[2].AddComment("User5", "Awesome content!");
        videos[2].AddComment("User6", "Looking forward to more");

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
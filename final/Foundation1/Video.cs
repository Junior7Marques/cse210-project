using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; } = new List<Comment>();

    //add a comment to the video
    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment
        {
            CommenterName = commenterName,
            Text = commentText
        };

        Comments.Add(comment);
    }

    //get the number of comments on the video
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    //display information about the video and its comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        
        if (GetNumberOfComments() > 0)
        {
            Console.WriteLine("Comments:");
            foreach (var comment in Comments)
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }
        }

        Console.WriteLine();
    }
}

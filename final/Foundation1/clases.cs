using System;
using System.Collections.Generic;

namespace YouTubeVideoManager
{
    public class Comment
    {
        public string CommenterName { get; private set; }
        public string CommentText { get; private set; }

        public Comment(string commenterName, string commentText)
        {
            CommenterName = commenterName;
            CommentText = commentText;
        }
    }

    public class Video
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Duration { get; private set; } // Duración en segundos

        // Lista privada para almacenar los comentarios
        private List<Comment> Comments { get; set; }

        public Video(string title, string author, int duration)
        {
            Title = title;
            Author = author;
            Duration = duration;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return Comments.Count;
        }

        public List<Comment> GetComments()
        {
            return new List<Comment>(Comments);
        }
    }
}

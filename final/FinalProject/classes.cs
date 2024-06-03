using System;
using System.Collections.Generic;

namespace YouTubeVideoManager
{
    // Clase para representar un comentario
    public class Comment
    {
        public string CommenterName { get; set; }
        public string CommentText { get; set; }

        public Comment(string commenterName, string commentText)
        {
            CommenterName = commenterName;
            CommentText = commentText;
        }
    }

    // Clase para representar un video de YouTube
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Duration { get; set; } // Duración en segundos
        private List<Comment> Comments { get; set; }

        public Video(string title, string author, int duration)
        {
            Title = title;
            Author = author;
            Duration = duration;
            Comments = new List<Comment>();
        }

        // Método para agregar un comentario al video
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        // Método para obtener la cantidad de comentarios
        public int GetCommentCount()
        {
            return Comments.Count;
        }

        // Método para obtener la lista de comentarios
        public List<Comment> GetComments()
        {
            return Comments;
        }
    }
}

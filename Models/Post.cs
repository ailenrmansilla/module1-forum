// This file holds properties of a Post object.
using System;
using System.Collections.Generic;

namespace forum.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public string Author { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<string> Replies { get; set; } = new List<string>();
    }
}
// This file holds the forum entries' data and related methods
using System;
using System.Collections.Generic;
using System.Linq;
using forum.Models;

namespace forum.Data
{
    public static class ForumData
    {
        private static List<Post> _posts = new List<Post>
        {
            new Post { Id=001, Title="Welcome to the forum!", Content="This is the first post you'll find here. It is pretty cool, isn't it?", Author="Admin" },
            new Post { Id=002, Title="C#", Content="Did you know this whole webapp is coded in asp.net using C#? That's such a fun Module #1 project. Let me know what you think in the comments!", Author="user0001" },
            new Post { Id=003, Title="Module #1", Content="This is Ailen's Module #1 project. Try it out and let me know what you think.", Author="user0002" }
        };

        private static int _nextId = 004;

        public static IEnumerable<Post> GetAll() => _posts.OrderByDescending(p => p.CreatedAt);

        public static Post? GetById(int id) => _posts.FirstOrDefault(p => p.Id == id);

        public static void AddPost(string title, string content, string author)
        {
            _posts.Add(new Post
            {
                Id = _nextId++,
                Title = title,
                Content = content,
                Author = string.IsNullOrWhiteSpace(author) ? "anonymousUser" : author,
                CreatedAt = DateTime.UtcNow
            });
        }

        public static void AddReply(int id, string reply)
        {
            var post = GetById(id);
            if (post != null)
                post.Replies.Add(reply);
        }
    }
}

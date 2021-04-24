using Composition2.Entities;
using System;
using System.Collections.Generic;

namespace Composition2
{
    class Program
    {
        static void Main(string[] args)
        {
            var posts = CreatePosts();
            foreach(Post p in posts) 
            {
                Console.WriteLine(p.ToString());
            }
        }

        public static List<Post> CreatePosts()
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awsome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2021 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wounderful country!",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night.");
            Comment c4 = new Comment("May the Force be with you.");
            Post p2 = new Post(
                DateTime.Parse("22/03/2020 23:23:15"),
                "Good night guys.",
                "See you tomorrow",
                5
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            List<Post> posts = new List<Post>();
            posts.Add(p1);
            posts.Add(p2);

            return posts;
        }
    }
}

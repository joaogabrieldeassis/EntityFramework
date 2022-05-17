using System;
using Blog.DataContext;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userCotext = new BlogDataContext();
            // userCotext.Users.Add(new User
            // {
            //     Name = "João Arquiteto",
            //     Email = "joao24@13.com",
            //     PassWordHash = "jao29R@",
            //     Bio = "Casaou e mudou com a mary mary",
            //     Image = "https:joao.com",
            //     Slug = "Oi"
            // });
            // userCotext.SaveChanges();
            var user = userCotext.Users.FirstOrDefault();
            var post = new Post
            {
                Author = user,
                Body = "Meu EFCore",
                Category = new Category
                {
                    Name = "FullStack",
                    Slug = "Pleno"
                },
                CreateDate = System.DateTime.Now,
                Slug = "Meu artigo",
                Summary = "Me contratem",
                Title = "Artigo João",
            };
            userCotext.Posts.Add(post);
            userCotext.SaveChanges();
        }
    }
}
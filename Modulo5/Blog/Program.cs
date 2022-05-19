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
            var user = new User
            {
                Name = "Mariana",
                Email = "Mariana@134",
                PassWordHash = "1234a",
                Bio = "Linda",
                Image = "https:mary.com",
                Slug = "Médica",
                GitHub = "MaryMary"
            };
            var conection = new BlogDataContext();
            conection.Users.Add(user);
            conection.SaveChanges();
        }
    }
}
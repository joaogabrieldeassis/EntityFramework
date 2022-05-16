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
            using var dbset = new BlogDataContext();

            // var user = new User
            // {
            //     Name = "João Arquiteto",
            //     Slug = "João e Mary",
            //     Email = "JaoAssis@gmail.com",
            //     Bio = "João Casando e mudando",
            //     Image = "https//joao.com",
            //     PassWordHash = "12345"
            // };
            // var category = new Category
            // {
            //     Name = "BackAnd",
            //     Slug = "Developer"
            // };
            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<b>Bom dia vida</b>",
            //     Slug = "Comecar a me arrumar",
            //     Summary = "Tomar café",
            //     Title = "Começar no balta",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            // };

            // dbset.Posts.Add(post);
            // dbset.SaveChanges();

            //ineer join com listagem
            // var post = dbset
            // .Posts
            // .AsNoTracking()
            // .Include(x => x.Author)
            // .Include(x => x.Category)
            // .OrderByDescending(x => x.LastUpdateDate)
            // .ToList();
            // foreach (var item in post)
            //     Console.WriteLine($"{item.Title} escrito por {item.Author?.Name} da Categoria {item.Category?.Name}");

            //Update sem o AsNoTracking() por que eu quero de fato jogar no banco
            // var update = dbset
            // .Posts
            // .Include(x => x.Author)
            // .Include(x => x.Category)
            // .OrderByDescending(x => x.LastUpdateDate)
            // .FirstOrDefault();//Esta pegando o primeiro item da lista
            // update.Author.Name = "João Arquiteto Pleno";//Alterou o meu autor
            // dbset.Posts.Update(update);
            // dbset.SaveChanges();

        }
    }
}
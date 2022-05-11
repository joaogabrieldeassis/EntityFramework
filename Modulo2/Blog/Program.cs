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
            using (var dbset = new BlogDataContext())
            {
                // // Create 
                // var tag = new Tag { Name = "João Arquiteto", Slug = "Junior" };
                // dbset.Tags.Add(tag);
                // dbset.SaveChanges();

                //Update
                // var tag = dbset.Tags.FirstOrDefault(x => x.Id == 1);
                // tag.Name = "Segundo nome do Entity";
                // tag.Slug = "Entity";
                // dbset.Update(tag);
                // dbset.SaveChanges();

                //Delete
                // var tag = dbset.Tags.FirstOrDefault(x => x.Id == 1);
                // dbset.Remove(tag);
                // dbset.SaveChanges();

                // !! Sempre fazer o ToList no final da minha Query
                // var list = dbset.Tags.Where(x => x.Name.Contains("Entity")).ToList();
                // foreach (var item in list)
                // {
                //     Console.WriteLine(item.Name);
                // }

                // var tag = dbset.Tags.FirstOrDefault(x => x.Id == 1);
                // tag.Name = "Ponto Entity";
                // tag.Slug = "Entity";
                // dbset.Update(tag);
                // dbset.SaveChanges();

                //FirstOrderDefault
                var tag = dbset.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 3);
                Console.WriteLine(tag.Name);
            }


            Console.WriteLine("Hello World!");
        }
    }
}
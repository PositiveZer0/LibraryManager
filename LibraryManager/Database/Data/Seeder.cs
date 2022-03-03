namespace LibraryManager.Database.Data
{
    using LibraryManager.Database.Models;
    using LibraryManager.Services.Login.ValidationCreateAccount;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                CreatedOn = DateTime.Now,
                Title = "Harry Potter and the Chamber of Secrets",
                AuthorName = "J. K. Rowling",
                Quantity = 10,
                Genre = "Fantasy Fiction",
                Description = "The second instalment of boy wizard Harry Potter's adventures at Hogwarts School of Witchcraft and Wizardry, based on the novel by JK Rowling. A mysterious elf tells Harry to expect trouble during his second year at Hogwarts, but nothing can prepare him for trees that fight back, flying cars, spiders that talk and deadly warnings written in blood on the walls of the school.",
                BookImage = null,
            }, new Book
            {
                Id = 2,
                CreatedOn = DateTime.Now,
                Title = "Atomic Habits",
                AuthorName = "James Clear",
                Quantity = 5,
                Genre = "Self improvement",
                Description = "An atomic habit is a regular practice or routine that is not only small and easy to do but is also the source of incredible power; a component of the system of compound growth. Bad habits repeat themselves again and again not because you don't want to change, but because you have the wrong system for change.",
                BookImage = null,
            }, new Book
            {
                Id = 3,
                CreatedOn = DateTime.Now,
                Title = "The Godfather",
                AuthorName = "Mario Puzo",
                Quantity = 5,
                Genre = "Thriller",
                Description = "The Godfather is a crime novel written by Mario Puzo, originally published in 1969 by G. P. Putnam's Sons. It details the story of a fictitious Sicilian Mafia family based in New York City and headed by Don Vito Corleone, who became synonymous with the Italian Mafia.",
                BookImage = null,
            }, new Book
            {
                Id = 4,
                CreatedOn = DateTime.Now,
                Title = "Rich Dad Poor Dad",
                AuthorName = "Robert Kiyosaki",
                Quantity = 100,
                Genre = "Personal finance",
                Description = "Rich Dad Poor Dad is about Robert Kiyosaki (author) and his two dads—his real father (poor dad) and the father of his best friend (rich dad)—and the ways in which both men shaped his thoughts about money and investing. The book explodes the myth that you do not need to earn a high income to become rich.",
                BookImage = null,
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = Guid.NewGuid().ToString(),
                CreatedOn = DateTime.Now,
                Name = "Admin",
                Surname = "Admin",
                Email = "admin@admin.com",
                Password = SecurePasswordHasher.Hash("admin"),
                Role = "Admin",
                UserImageId = null,
            }, new User
            {
                Id = Guid.NewGuid().ToString(),
                CreatedOn = DateTime.Now,
                Name = "Student",
                Surname = "Student",
                Email = "student@student.com",
                Password = SecurePasswordHasher.Hash("student"),
                Role = "Student",
                UserImageId = null,
            });
        }
    }
}

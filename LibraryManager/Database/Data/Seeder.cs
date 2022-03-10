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
        public static byte[] StringToByteArrayFastest(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return arr;
        }

        public static int GetHexVal(char hex)
        {
            int val = (int)hex;
            //For uppercase A-F letters:
            //return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            //return val - (val < 58 ? 48 : 87);
            //Or the two combined, but a bit slower:
            return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookImage>().HasData(new BookImage
            {
                Id = 1,
                Image = StringToByteArrayFastest(BookImagesData.HarryPotter),
            }, new BookImage
            {
                Id = 2,
                Image = StringToByteArrayFastest(BookImagesData.AtomicHabits),
            }, new BookImage
            {
                Id = 3,
                Image = StringToByteArrayFastest(BookImagesData.Godfather),
            }, new BookImage
            {
                Id = 4,
                Image = StringToByteArrayFastest(BookImagesData.RichDadPoorDad),
            }, new BookImage
            {
                Id = 5,
                Image = StringToByteArrayFastest(BookImagesData.FiveAmClub),
            }, new BookImage
            {
                Id = 6,
                Image = StringToByteArrayFastest(BookImagesData.TheIntelligentInvestor),
            }, new BookImage
            {
                Id = 7,
                Image = StringToByteArrayFastest(BookImagesData.IntroductionToProgramming),
            }, new BookImage
            {
                Id = 8,
                Image = StringToByteArrayFastest(BookImagesData.IfYourNotFirstYourLast),
            }, new BookImage
            {
                Id = 9,
                Image = StringToByteArrayFastest(BookImagesData.HellWeek),
            }, new BookImage
            {
                Id = 10,
                Image = StringToByteArrayFastest(BookImagesData.TheWarrenBuffetWay),
            }, new BookImage
            {
                Id = 11,
                Image = StringToByteArrayFastest(BookImagesData.PodIgoto),
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                CreatedOn = DateTime.Now,
                Title = "Harry Potter and the Chamber of Secrets",
                AuthorName = "J. K. Rowling",
                Quantity = 10,
                Genre = "Fantasy Fiction",
                Description = "The second instalment of boy wizard Harry Potter's adventures at Hogwarts School of Witchcraft and Wizardry, based on the novel by JK Rowling. A mysterious elf tells Harry to expect trouble during his second year at Hogwarts, but nothing can prepare him for trees that fight back, flying cars, spiders that talk and deadly warnings written in blood on the walls of the school.",
                BookImageId = 1,
            }, new Book
            {
                Id = 2,
                CreatedOn = DateTime.Now,
                Title = "Atomic Habits",
                AuthorName = "James Clear",
                Quantity = 5,
                Genre = "Self improvement",
                Description = "An atomic habit is a regular practice or routine that is not only small and easy to do but is also the source of incredible power; a component of the system of compound growth. Bad habits repeat themselves again and again not because you don't want to change, but because you have the wrong system for change.",
                BookImageId = 2,
            }, new Book
            {
                Id = 3,
                CreatedOn = DateTime.Now,
                Title = "The Godfather",
                AuthorName = "Mario Puzo",
                Quantity = 5,
                Genre = "Thriller",
                Description = "The Godfather is a crime novel written by Mario Puzo, originally published in 1969 by G. P. Putnam's Sons. It details the story of a fictitious Sicilian Mafia family based in New York City and headed by Don Vito Corleone, who became synonymous with the Italian Mafia.",
                BookImageId = 3,
            }, new Book
            {
                Id = 4,
                CreatedOn = DateTime.Now,
                Title = "Rich Dad Poor Dad",
                AuthorName = "Robert Kiyosaki",
                Quantity = 100,
                Genre = "Personal finance",
                Description = "Rich Dad Poor Dad is about Robert Kiyosaki (author) and his two dads—his real father (poor dad) and the father of his best friend (rich dad)—and the ways in which both men shaped his thoughts about money and investing. The book explodes the myth that you do not need to earn a high income to become rich.",
                BookImageId = 4,
            }, new Book
            {
                Id = 5,
                CreatedOn = DateTime.Now,
                Title = "Five Am Club",
                AuthorName = "Robin Sharma",
                Quantity = 12,
                Genre = "Self-help book",
                Description = "The 5 AM Club (2018) shows how embracing a revolutionary morning routine can deliver epic results. Through the enchanting story of an entrepreneur, an artist, and their eccentric billionaire mentor, it explains how you can use the first hour of your day to drive personal growth and get the most out of life.",
                BookImageId = 5,
            }, new Book
            {
                Id = 6,
                CreatedOn = DateTime.Now,
                Title = "The Intelligent Investor",
                AuthorName = "Benjamin Graham",
                Quantity = 122,
                Genre = "Personal finance",
                Description = "The Intelligent Investor is a book that aims to help people invest in the stock market while minimizing their economic risks. It focuses on longer-term and more risk-averse approaches. Graham focuses on investments (based on research) rather than speculations (based on predictions). The Intelligent Investor provides guidance on how to get involved in value investing and how you can prevent Mr. Market from dictating your financial decisions.",
                BookImageId = 6,
            }, new Book
            {
                Id = 7,
                CreatedOn = DateTime.Now,
                Title = "Introduction To Programming",
                AuthorName = "Svetlin Nakov",
                Quantity = 420,
                Genre = "Programming",
                Description = "The book Introduction to Programming with C# is fundamental computer programming book that focuses on the concepts of the computer programming, data structures and algorithms. It is the recommended start for junior developers and is entirely free.",
                BookImageId = 7,
            }, new Book
            {
                Id = 8,
                CreatedOn = DateTime.Now,
                Title = "If your not first you're last",
                AuthorName = "Grant Cardone",
                Quantity = 40,
                Genre = "Personal finance",
                Description = "In If You're Not First, You're Last, international sales expert Grant Cardone explains how to sell your products and services - despite the economy - and provides you with ways to capitalize regardless of your product, service, or idea.",
                BookImageId = 8,
            }, new Book
            {
                Id = 9,
                CreatedOn = DateTime.Now,
                Title = "Hell Week",
                AuthorName = "Erik Larssen",
                Quantity = 410,
                Genre = "Self-help book",
                Description = "From world-renowned mental trainer Erik Bertrand Larssen, whose clients include Olympic athletes and Fortune 500 CEOs, Hell Week is a military-inspired yet accessible guide to making the critical changes necessary for long-term professional and personal success and overall lifestyle improvements.",
                BookImageId = 9,
            }, new Book
            {
                Id = 10,
                CreatedOn = DateTime.Now,
                Title = "The Warren Buffett Way",
                AuthorName = "Robert Hagstrom",
                Quantity = 10,
                Genre = "Personal finance",
                Description = "The Warren Buffett Way is a book about investing, written for the investment world. It explores in great detail the nine tenants that Buffett has used in his investment history and explores the nuances of all of the major purchases he's made over the past fifty-something years.",
                BookImageId = 10,
            }, new Book
            {
                Id = 11,
                CreatedOn = DateTime.Now,
                Title = "Pod Igoto",
                AuthorName = "Ivan Vazov",
                Quantity = 1000,
                Genre = "Historical novel",
                Description = "Follows the Bulgarian people's struggle for national independence in the period from 1875 to the Liberation from Otoman bondage. The tranquility in a Bulgarian village under the Ottoman yoke is ostensible.In fact, the people prepare themselves strenuously for an uprising. The educated part of the population desperately wants changes.The enthusiasm is enormous, but the rebellion is beyond their powers.The Turk break down the resistance and shed a lot of blood.The sanguinary uprising is the reason for the Russian-Turkish war, in which the Bulgarian volunteers take part as well.",
                BookImageId = 11,
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

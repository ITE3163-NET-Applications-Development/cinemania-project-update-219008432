using System;
using CineMania.Models;
using Microsoft.EntityFrameworkCore;

namespace CineMania.Data
{
    public class CinemaniaContext : DbContext
    {
        public CinemaniaContext(DbContextOptions<CinemaniaContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Message> Feedback { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             var movies = new Movie[]
            {
                new Movie
                {
                    Id = 1,
                    Title = "Black Widow",
                    Description = "A film about Natasha Romanoff in her quests " +
                                  "between the films Civil War and Infinity War.",
                    ImageName = "black_widow.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2021-07-09")
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Tomorrow War",
                    Description = "A family man is drafted to fight in a future war where " +
                                  "the fate of humanity relies on his ability to confront the past.",
                    ImageName = "the_tomorrow_war.jpg",
                    Genre = "Sci-Fi",
                    ReleaseDate = DateTime.Parse("2021-07-02")
                },
                new Movie
                {
                    Id = 3,
                    Title = "Pitch Perfect",
                    Description = "Beca, a freshman at Barden University, is cajoled into joining The Bellas, " +
                                  "her school's all-girls singing group. Injecting some much needed energy into " +
                                  "their repertoire, The Bellas take on their male rivals in a campus competition",
                    ImageName = "black_widow.jpg",
                    Genre = "Comedy",
                    ReleaseDate = DateTime.Parse("2013-09-24")
                },
                new Movie
                {
                    Id = 4,
                    Title = "The Hills Have Eyes",
                    Description = "A family falls victim to a group of mutated cannibals " +
                                  "in a desert far away from civilization.",
                    ImageName = "hills_have_eyes.jpg",
                    Genre = "Horror",
                    ReleaseDate = DateTime.Parse("2006-11-11")
                },
                new Movie
                {
                    Id = 5,
                    Title = "Up",
                    Description = "78-year-old Carl Fredricksen travels to Paradise Falls in his house " +
                                  "equipped with balloons, inadvertently taking a young stowaway",
                    ImageName = "up.jpg",
                    Genre = "Animation",
                    ReleaseDate = DateTime.Parse("2009-03-01")
                },
                new Movie
                {
                    Id = 6,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of " +
                                  "diner bandits intertwine in four tales of violence and redemption.",
                    ImageName = "pulp_fiction.jpg",
                    Genre = "Crime",
                    ReleaseDate = DateTime.Parse("1994-12-05")
                },
                new Movie
                {
                    Id = 7,
                    Title = "Rocky",
                    Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion " +
                                  "in a bout in which he strives to go the distance for his self-respect.",
                    ImageName = "rocky.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1976-11-29")
                },
                new Movie
                                {
               Id = 8,
               Title = "blood_And_Water",
                Description = "After crossing paths at a party, a Cape Town teen" +
               " sets out to prove whether a private-school swimming star" +
               " is her sister who was abducted at birth.",
                  ImageName = "blood_And_Water.jpg",
                   Genre = "Romantic",
                  ReleaseDate = DateTime.Parse("2000-05-20")
                 },
                new Movie
                {
                    Id = 9,
                    Title = "Focus",
                    Description = "Focus is a 2015 American crime comedy-drama film written and directed"+
                     "by Glenn Ficarra and John Requa, starring Will Smith and Margot Robbie."+
                    "The plot follows a career con artist who takes an aspiring femme fatale under his wing",
                    ImageName = "Focus.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2015-02-20")
                },
                new Movie
                {
                    Id = 10,
                    Title = "Love_Alarm",
                    Description = "In a world where an app alerts people if someone in the vicinity likes them," +
                                  " Kim Jojo experiences young love while coping with personal adversities.",
                    ImageName = "Love_Alarm.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("2019-08-22")
                },
                new Movie
                {
                    Id = 11,
                    Title = "Ginny_Georgia",
                    Description = "Premise. Ginny & Georgia follows Ginny Miller," +
                                  " a 15-year-old who is more mature than her 30-year-old mother"+
                                  " Georgia, in a New England town where Georgia "+
                                  "decides to settle down with her daughter Ginny and son Austin "+
                                  "to give them a better life than she had.",
                    ImageName = "Ginny_Georgia.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("2021-02-24")
                },
                new Movie
                {
                    Id = 12,
                    Title = "Lupin",
                    Description = "Inspired by the adventures of Arsène Lupin, gentleman thief Assane Diop " +
                                  "sets out to avenge his father for an injustice inflicted by a wealthy family." +
                                  "Emmy winner Louis Leterrier directs this series starring Omar Sy (The Intouchables)",
                    ImageName = "Lupin.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2019-10-18")
                },
                new Movie
                {
                    Id = 13,
                    Title = "Little",
                    Description = "Little is a 2019 American fantasy comedy film directed and co-written by Tina Gordon." +
                                  " It stars Regina Hall, Issa Rae and Marsai Martin, and follows an overbearing boss who" +
                                  " is transformed into the child version of herself",
                    ImageName = "Little.jpg",
                    Genre = "Comedy",
                    ReleaseDate = DateTime.Parse("2019-04-8")
                },
                new Movie
                {
                    Id = 14,
                    Title = "The_Princess_Switch",
                    Description = "The Princess Switch is a 2018 American Christmas romantic comedy film directed by Mike Rohl" +
                                  " from a screenplay by Robin Bernheim and Megan Metzger. ... The film's concept of two people" +
                                  " running into one another who look identical and switch places comes from" +
                                  " Mark Twain's 1881 novel The Prince and the Pauper",
                    ImageName = "The_Princess_Switch.jpg",
                    Genre = "Romantic",
                    ReleaseDate = DateTime.Parse("2018-11-16")
                },
                new Movie
                {
                    Id = 15,
                    Title = "Crazy_Rich_Asian",
                    Description = "It follows a Chinese-American professor who travels to meet her boyfriend's family" +
                                  " and is surprised to discover they are among the richest in Singapore." +
                                  " The film was announced in August 2013 after the rights to the book were purchased",
                    ImageName = "Crazy_Rich_Asian.jpg",
                    Genre = "Romantic",
                    ReleaseDate = DateTime.Parse("2018-08-15")
                },
                new Movie
                {
                    Id = 16,
                    Title = "Never_Have_I_ever",
                    Description = "After a traumatic year, an Indian-American teen just wants to spruce up " +
                                  "her social status — but friends, family and feelings won't make it easy on her",
                    ImageName = "Never_Have_I_Ever.jpg",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("2020-04-27")
                },
                    new Movie
                    {
                    Id = 17,
                    Title = "Fatherhood",
                    Description = "The Netflix film – based on the real-life story of Matthew Logelin – gives Hart" +
                                  " a chance to show off his serious side once again after The Upside. Fatherhood follows" +
                                  " Matthew Logelin whose wife passes away shortly after the birth of their daughter",
                    ImageName = "Fatherhood.jpg",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2021-01-8")
               
                },
            };
          
            modelBuilder.Entity<Movie>().HasData(movies);
            base.OnModelCreating(modelBuilder);
        }
    }
}
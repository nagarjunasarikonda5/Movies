// See https://aka.ms/new-console-template for more information
using Movies;
using System;

Movie Movie1 = new Movie();
Movie1.MovieTitle = "Titanic";
Movie1.Director = "James Cameron";
Movie1.Actors = new List<string>{ "Leonardo DiCaprio", "Kate Winslet" };
Movie1.Reviews = new List<Review>{
    new Review()
    {
       ReviewText = "Great movie!",
        ReviewerName= "Irvine Rolf",
        Rating = 4.5
    },
    new Review()
    {
       ReviewText = "Highly recommended!",
        ReviewerName= "Ashkii Karlheinz",
        Rating = 4.5
    },
    new Review()
    {
       ReviewText = "A classic that never gets old.",
        ReviewerName= "Nele Athol",
        Rating = 4.0
    },
};
Movie Movie2 = new Movie();
Movie2.MovieTitle = "The Godfather";
Movie2.Director = "Francis Ford Coppola";
Movie2.Actors = new List<string> { "Marlon Brando", "Al Pacino", "James Caan" };
Movie2.Reviews = new List<Review>{
    new Review()
    {
        ReviewText = "Great movie!",
        ReviewerName= "Cipactli Anselma",
        Rating = 4.2
    },
    new Review()
    {
       ReviewText = "Highly recommended!",
        ReviewerName= "Ashkii Karlheinz",
        Rating = 4.5
    },
    new Review()
    {
        ReviewText = "A classic that never gets old.",
        ReviewerName= "Nele Athol",
        Rating = 4.0
    },
};
Console.WriteLine( Movie1.ToString());
Console.WriteLine(Movie2.ToString());
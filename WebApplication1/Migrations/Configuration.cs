namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.MovieDBContext>
    {
        
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WebApplication1.Models.MovieDBContext";
            
        }

        protected override void Seed(Models.MovieDBContext context)
        {
            context.movies.AddOrUpdate(i => i.Title,
        new Models.Movie
        {
            Title = "When Harry Met Sally",
            ReleaseDate = DateTime.Parse("1989-1-11"),
            Genre = "Romantic Comedy",
            Price = 7.99M,
            Rating = "PG"
        },

         new Models.Movie
         {
             Title = "Ghostbusters ",
             ReleaseDate = DateTime.Parse("1984-3-13"),
             Genre = "Comedy",
             Price = 8.99M,
             Rating = "PG"
         },

         new Models.Movie
         {
             Title = "Ghostbusters 2",
             ReleaseDate = DateTime.Parse("1986-2-23"),
             Genre = "Comedy",
             Price = 9.99M,
             Rating = "PG"
         },

       new Models.Movie
       {
           Title = "Rio Bravo",
           ReleaseDate = DateTime.Parse("1959-4-15"),
           Genre = "Western",
           Price = 3.99M,
           Rating = "PG"
       }
   );
        }
    }
}

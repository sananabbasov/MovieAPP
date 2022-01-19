using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MovieContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MovieDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }


        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<ContentLanguage> ContentLanguages { get; set; }
        public DbSet<ContentCategory> ContentCategories { get; set; }
        public DbSet<CategoryLanguage> CategoryLanguages { get; set; }
        public DbSet<Url> Urls { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmToComment> FilmToComments { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }

}

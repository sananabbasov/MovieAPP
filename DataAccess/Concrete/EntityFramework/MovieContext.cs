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
            //optionsBuilder.UseSqlServer(@"Data Source = SQL5109.site4now.net; Initial Catalog = db_a4f2ac_moviedb; User Id = db_a4f2ac_moviedb_admin; Password = Compar2022");
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

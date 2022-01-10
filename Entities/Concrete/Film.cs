using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Film : IEntity
    {
        public int Id { get; set; }
        public int ContentId { get; set; }
        public int UrlId { get; set; }
        public decimal Imdb { get; set; }
        public bool IsSubscribe { get; set; }
        public virtual Content Content { get; set; }
        public virtual Url Url { get; set; }
        //public virtual ICollection<Buying> Buyings { get; set; }
        public virtual ICollection<FilmToComment> FilmToComments { get; set; }
        //public virtual ICollection<PayFullFilm> PayFullFilms { get; set; }
    }
}

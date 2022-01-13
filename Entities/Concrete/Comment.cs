using Core.Entities.Concrete;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public bool Spolier { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual User User { get; set; }
        //public virtual ICollection<CinemaLabToComment> CinemaLabToComments { get; set; }
        public virtual ICollection<FilmToComment> FilmToComments { get; set; }
        //public virtual ICollection<SeriesToComment> SeriesToComments { get; set; }
    }
}

using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Content : IEntity
    {
        public int Id { get; set; }
        public string MainPicture { get; set; }
        public string Age { get; set; }
        public DateTime ContentDate { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsFree { get; set; }
        public int Hit { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ContentTypeId { get; set; }
        public virtual ContentType ContentType { get; set; }
        //public virtual ICollection<CinemaLab> CinemaLabs { get; set; }
        public virtual ICollection<ContentLanguage> ContentLanguages { get; set; }
        //public virtual ICollection<ContentActor> ContentActors { get; set; }
        public virtual ICollection<ContentCategory> ContentCategories { get; set; }
        //public virtual ICollection<ContentDirector> ContentDirectors { get; set; }
        //public virtual ICollection<FavoryContent> FavoryContents { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        //public virtual ICollection<LikedContent> LikedContents { get; set; }
        //public virtual ICollection<TrailerContent> TrailerContents { get; set; }
    }
}

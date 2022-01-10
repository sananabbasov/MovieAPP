using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Url
    {
        public int Id { get; set; }
        public string UrlName { get; set; }

        //public virtual ICollection<Audio> Audios { get; set; }
        public virtual ICollection<CinemaLab> CinemaLabs { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        //public virtual ICollection<History> Histories { get; set; }
        //public virtual ICollection<Series> Series { get; set; }
        //public virtual ICollection<Subtitle> Subtitles { get; set; }
    }
}

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CreateFilimDto
    {
        public int ContentId { get; set; }
        public int UrlId { get; set; }
        public decimal Imdb { get; set; }
        public bool IsSubscribe { get; set; }
        //public virtual Content Content { get; set; }
        //public virtual Url Url { get; set; }
    }
}

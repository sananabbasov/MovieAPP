using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MovieDetailDto
    {
        public int Id { get; set; }
        public string ContentType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public string MovieUrl { get; set; }
        public decimal IMDB { get; set; }
        public string Age { get; set; }
        public List<string> Categories { get; set; }
        public List<CommentList> Comments { get; set; }
    }


    public class CommentList
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public bool IsSpoiller { get; set; }
    }
}

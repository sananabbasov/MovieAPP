using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class HomeContentsDto
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
        public List<ContentCommentList> Comments { get; set; }
    }

    public class ContentCommentList
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public bool IsSpoiller { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AddCommentToFilmDto
    {
        public int UserId { get; set; }
        public int FilmId { get; set; }
        public string Text { get; set; }
        public bool IsSpolier { get; set; }
    }
}

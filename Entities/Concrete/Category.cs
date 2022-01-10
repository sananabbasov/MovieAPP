using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CategorySeo { get; set; }

        public virtual ICollection<CategoryLanguage> CategoryLanguages { get; set; }
        public virtual ICollection<ContentCategory> ContentToCategories { get; set; }
    }
}

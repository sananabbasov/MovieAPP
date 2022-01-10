﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CategoryLanguage : IEntity
    {
        public int Id { get; set; }
        public string LangCode { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}

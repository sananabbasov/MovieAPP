using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContentCategoryService
    {
        List<ContentCategory> GetAll();

        List<ContentListDto> GetContentList(string lang);
    }
}

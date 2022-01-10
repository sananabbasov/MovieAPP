using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContentCategoryManager : IContentCategoryService
    {
        IContentCategoryDal _contentCategoryDal;

        
        public ContentCategoryManager(IContentCategoryDal contentCategoryDal)
        {
            _contentCategoryDal = contentCategoryDal;
        }



        public List<ContentCategory> GetAll()
        {
            return _contentCategoryDal.GetAll();
        }

        public List<ContentListDto> GetContentList(string lang)
        {
            return _contentCategoryDal.GetContentList(lang);
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;
        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public List<Content> GetAll()
        {

            var result = _contentDal.GetAll();

            

            return result;
        }

        public List<Content> GetAllByCategoryById(int categoryId)
        {
            return _contentDal.GetAll(post => post.ContentCategories.All(tag => tag.CategoryId == categoryId));
        }

        public List<ContentListDto> GetContentDetails()
        {

            
            throw new NotImplementedException();
        }
    }
}

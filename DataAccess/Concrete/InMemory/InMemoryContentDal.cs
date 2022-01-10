using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryContentDal : IContentDal
    {
        List<Content> _contents;

        //public InMemoryContentDal()
        //{
        //    _contents = new List<Content> { 
        //        new Content { Id = 1, IMDB = 5.6M, PublishDate = DateTime.Now },
        //        new Content { Id = 2, IMDB = 5.6M, PublishDate = DateTime.Now },
        //        new Content { Id = 3, IMDB = 5.6M, PublishDate = DateTime.Now },
        //        new Content { Id = 4, IMDB = 5.6M, PublishDate = DateTime.Now },
        //        new Content { Id = 5, IMDB = 5.6M, PublishDate = DateTime.Now },
        //    };
        //}

        public void Add(Content content)
        {
            _contents.Add(content);
        }

        public void Delete(Content content)
        {
            Content deletedContent = _contents.SingleOrDefault(c=>c.Id == content.Id);
        }

        public Content Get(Expression<Func<Content, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public List<Content> GetAll(Expression<Func<Content, bool>> filter = null)
        {
            return _contents;
        }

        public List<Content> GetAllByCategory(int categoryId)
        {
            return _contents.Where(post => post.ContentCategories.All(tag=>tag.CategoryId == categoryId)).ToList();
        }

        public void Update(Content content)
        {
            //Content updatedContent = _contents.SingleOrDefault(c=>c.Id == content.Id);
            //updatedContent.IMDB = content.IMDB;
            throw new NotImplementedException();
        }
    }
}

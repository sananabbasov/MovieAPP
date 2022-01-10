using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContentCategoryDal : EfEntityRepositoryBase<ContentCategory, MovieContext>, IContentCategoryDal
    {
        public List<ContentListDto> GetContentList(string lang)
        {
          
            using (MovieContext context = new ())
            {


                List<ContentListDto> result = new();


                var categories = context.Categories.Include(x=>x.CategoryLanguages).ToList();
                var content = context.Contents.Include(x=>x.ContentCategories).ThenInclude(x=>x.Category).Include(x=>x.ContentType).Include(x=>x.ContentLanguages).ToList();


                foreach (var item in content)
                {
                    List<string> cates = new();

                    var contentName = item.ContentLanguages.FirstOrDefault(x=>x.LangCode == lang).Name;
                    var contentType = item.ContentType.Name;
                    var contentDescription = item.ContentLanguages.FirstOrDefault(x=>x.LangCode == lang).Description;
                    var image = item.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Content.MainPicture;
                    var age = item.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Content.Age;
                    foreach (var cat in item.ContentCategories)
                    {
                        var cate = cat.Category.CategoryLanguages.FirstOrDefault(c=>c.LangCode == lang).CategoryName;
                        cates.Add(cate);
                    }
                    result.Add(new ContentListDto
                    {
                        Id  = item.Id,
                        Name = contentName,
                        Categories = cates,
                        Age = age,
                        PhotoUrl = image,
                        ContentType = contentType,
                        Description = contentDescription
                    });

                }




                return result.ToList();
            }
        }
    }
}

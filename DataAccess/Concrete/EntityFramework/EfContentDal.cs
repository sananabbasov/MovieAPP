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
    public class EfContentDal : EfEntityRepositoryBase<Content, MovieContext>, IContentDal
    {
        public List<MovieDetailDto> GetContentDetail(int id, string lang)
        {
            using (MovieContext context = new())
            {
                List<MovieDetailDto> result = new();
                var categories = context.Categories.Include(x => x.CategoryLanguages).ToList();
                var content = context.Contents.Include(x => x.ContentCategories).ThenInclude(x => x.Category).Include(x => x.ContentType).Include(x => x.ContentLanguages).ToList();

                var catToContent = context.ContentCategories.ToList();

                var films = context.Films.Include(x => x.FilmToComments).ThenInclude(x => x.Comment).Include(x => x.Url).FirstOrDefault(x => x.ContentId == id);

                //var commentToFilm = context.FilmToComments.Where(x => x.FilmId == films.Id).Select(x => new { x.Comment.Text, x.Comment.User.Name }).ToList();
                /*var commentToFilm = context.FilmToComments.Include(x => x.Comment).ThenInclude(x => x.User).Where(x => x.FilmId == films.Id).ToList(); */// new Comment
                //var commentToFilm = context.FilmToComments.Where(x=>x.FilmId == films.Id).Select(x=> new Tuple<string,string>(x.Comment.Text, x.Comment.User.Name)).ToList();


                try
                {
                    var commentToFilm = context.FilmToComments.Include(x => x.Comment).ThenInclude(x => x.User).Where(x => x.FilmId == films.Id).ToList(); 
                }
                catch (Exception)
                {
                    var commentToFilm = "asda";

                }


                List<string> cates = new();
                List<KeyValuePair<string, string>> contentComments = new();

                List<CommentList> comments = new();


                try
                {
                    var commentToFilm = context.FilmToComments.Include(x => x.Comment).ThenInclude(x => x.User).Where(x => x.FilmId == films.Id).ToList();
                    foreach (var item in commentToFilm)
                    {


                        comments.Add(new CommentList
                        {

                            Name = item.Comment.User.FirstName,
                            Text = item.Comment.Text,
                            IsSpoiller = item.Comment.Spolier

                        });
                    }
                    if (films.FilmToComments.Count() != 0)
                    {
                        foreach (var item in films.FilmToComments)
                        {
                            if (item != null)
                            {
                                contentComments.Add(new KeyValuePair<string, string>("MehemmedEli", item.Comment.Text));

                            }
                        }
                    }

                }
                catch (Exception)
                {
                    var commentToFilm = "asda";

                }
                









                foreach (var item in catToContent.Where(x => x.ContentId == id))
                {
                    cates.Add(item.Category.CategoryLanguages.FirstOrDefault(x => x.LangCode == lang).CategoryName);
                }




                var contentName = context.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Name;
                var contentType = context.Contents.FirstOrDefault(x => x.Id == id).ContentType.Name;
                var contentDescription = context.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Description;
                var image = context.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Content.MainPicture;
                var age = context.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Content.Age;



                result.Add(new MovieDetailDto
                {
                    Name = contentName,
                    Categories = cates,
                    Age = age,
                    PhotoUrl = image,
                    //MovieUrl = films.Url.UrlName,
                    ContentType = contentType,
                    Description = contentDescription,
                    Comments = comments
                });



                return result.ToList();
            }
        }

        public List<ContentListDto> GetContentList(string lang)
        {
            using (MovieContext context = new())
            {


                List<ContentListDto> result = new();


                var categories = context.Categories.Include(x => x.CategoryLanguages).ToList();
                var content = context.Contents.Where(x => x.IsFree == true).Include(x => x.ContentCategories).ThenInclude(x => x.Category).Include(x => x.ContentType).Include(x => x.ContentLanguages).ToList();


                foreach (var item in content)
                {
                    List<string> cates = new();

                    var contentName = item.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Name;
                    var contentType = item.ContentType.Name;
                    var contentDescription = item.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Description;
                    var image = item.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Content.MainPicture;
                    var age = item.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Content.Age;
                    foreach (var cat in item.ContentCategories)
                    {
                        var cate = cat.Category.CategoryLanguages.FirstOrDefault(c => c.LangCode == lang).CategoryName;
                        cates.Add(cate);
                    }
                    result.Add(new ContentListDto
                    {
                        Id = item.Id,
                        Name = contentName,
                        IsSlider = item.IsSlider,
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

        public List<HomeContentsDto> GetMovieDetail(string lang)
        {
            using (MovieContext context = new())
            {
                List<HomeContentsDto> result = new();
                var categories = context.Categories.Include(x => x.CategoryLanguages).ToList();
                var content = context.Contents.Where(x => x.IsFree == false).Include(x => x.ContentCategories).ThenInclude(x => x.Category).Include(x => x.ContentType).Include(x => x.ContentLanguages).ToList();

                var catToContent = context.ContentCategories.ToList();

                var films = context.Films.Include(x => x.FilmToComments).ThenInclude(x => x.Comment).Include(x => x.Url).FirstOrDefault(x => x.ContentId == 5);

                //var commentToFilm = context.FilmToComments.Where(x => x.FilmId == films.Id).Select(x => new { x.Comment.Text, x.Comment.User.Name }).ToList();
                var commentToFilm = context.FilmToComments.Include(x => x.Comment).ThenInclude(x => x.User).Where(x => x.FilmId == films.Id).ToList();
                //var commentToFilm = context.FilmToComments.Where(x=>x.FilmId == films.Id).Select(x=> new Tuple<string,string>(x.Comment.Text, x.Comment.User.Name)).ToList();

                List<string> cates = new();
                List<KeyValuePair<string, string>> contentComments = new();

                List<ContentCommentList> comments = new();
                foreach (var item in commentToFilm)
                {


                    comments.Add(new ContentCommentList
                    {

                        Name = item.Comment.User.FirstName,
                        Text = item.Comment.Text,
                        IsSpoiller = item.Comment.Spolier

                    });
                }
                //if (films.FilmToComments.Count() != 0)
                //{
                //    foreach (var item in films.FilmToComments)
                //    {
                //        if (item != null)
                //        {
                //            contentComments.Add(new KeyValuePair<string, string>("MehemmedEli", item.Comment.Text));

                //         }
                //    }
                //}


                foreach (var item in catToContent.Where(x => x.ContentId == 5))
                {
                    cates.Add(item.Category.CategoryLanguages.FirstOrDefault(x => x.LangCode == lang).CategoryName);
                }




                var contentName = context.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Name;
                var contentType = context.Contents.Where(x => x.IsFree == true).FirstOrDefault(x => x.Id == 5).ContentType.Name;
                var contentDescription = context.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Description;
                var image = context.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Content.MainPicture;
                var age = context.ContentLanguages.FirstOrDefault(x => x.LangCode == lang).Content.Age;



                result.Add(new HomeContentsDto
                {
                    Name = contentName,
                    Categories = cates,
                    Age = age,
                    PhotoUrl = image,
                    MovieUrl = films.Url.UrlName,
                    ContentType = contentType,
                    Description = contentDescription,
                    Comments = comments
                });



                return result.ToList();
            }
        }
    }
}

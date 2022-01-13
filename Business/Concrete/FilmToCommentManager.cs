using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
    public class FilmToCommentManager : IFilmToCommentService
    {
        IFilmToCommentDal _filmToCommentDal;
        public FilmToCommentManager(IFilmToCommentDal filmToCommentDal)
        {
            _filmToCommentDal = filmToCommentDal;
        }

       

        public IResult Add(FilmToComment filmToComment)
        {
            _filmToCommentDal.Add(filmToComment);

            return new SuccessResult(Messages.CommentAdded);
        }
    }
}

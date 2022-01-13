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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        IFilmToCommentService _commentService;
        public CommentManager(ICommentDal commentDal, IFilmToCommentService commentService)
        {
            _commentDal = commentDal;
            _commentService = commentService;
        }

        public IResult Add(AddCommentToFilmDto addCommentToFilmDto)
        {
            var comment = new Comment {
                UserId = addCommentToFilmDto.UserId,
                Text = addCommentToFilmDto.Text,
                Spolier = addCommentToFilmDto.IsSpolier
            };
            _commentDal.Add(comment);

            var filmComment = new FilmToComment { 
                CommentId = comment.Id,
                FilmId = addCommentToFilmDto.FilmId
            };

            _commentService.Add(filmComment);

            return new SuccessResult(Messages.CommentAdded);
        }
    }
}

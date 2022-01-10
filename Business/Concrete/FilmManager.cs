using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
    public class FilmManager : IFilmService
    {
        IFilmDal _filmDal;

        public FilmManager(IFilmDal filmDal)
        {
            _filmDal = filmDal;
        }
        public IResult Add(Film film)
        {
            throw new NotImplementedException();
        }

        //[SecuredOperation("film.add,admin")]
        public IResult Add(CreateFilimDto createFilimDto)
        {

                //public int ContentId { get; set; }
                //public int UrlId { get; set; }
                //public decimal Imdb { get; set; }
                //public bool IsSubscribe { get; set; }

            var film = new Film
            {
                ContentId = createFilimDto.ContentId,
                UrlId = createFilimDto.UrlId,
                Imdb = createFilimDto.Imdb,
                IsSubscribe = createFilimDto.IsSubscribe,
                
            };

            _filmDal.Add(film);

            return new SuccessResult(Messages.FilmAdded);
        }


        //[SecuredOperation("admin,subscriber")]
        public List<MovieDetailDto> GetMovieDetails(int id, string langs)
        {
            return _filmDal.GetMovieDetail(id, langs);
        }


        
    }
}

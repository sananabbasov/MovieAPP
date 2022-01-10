using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        IFilmService _filmService;

        public FilmsController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [HttpGet("{lang}/getfilmbyid/{id}")]
        public IActionResult GetFilmById(int id,string lang)
        {
            
            var result = _filmService.GetMovieDetails(id,lang);

            return Ok(result);

        }


        [HttpPost("add")]
        public IActionResult Add(CreateFilimDto createFilimDto)
        {


            _filmService.Add(createFilimDto);

                return Ok();
            

        }


    }
}

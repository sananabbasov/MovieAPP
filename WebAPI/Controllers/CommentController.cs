using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }


        [HttpPost("add")]
        public IActionResult Add(AddCommentToFilmDto addCommentToFilmDto)
        {


            _commentService.Add(addCommentToFilmDto);

            return Ok();


        }
    }
}

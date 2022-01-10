using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        IContentService _contentService;
        IContentCategoryService _service;

        public MoviesController(IContentCategoryService service)
        {
            _service = service;
        }

        [HttpGet("{lang}/getall")]
        public IActionResult GetAll(string lang)
        {
            var result = _service.GetContentList(lang);
            
                return Ok(result);
          
        }
        
    }
}

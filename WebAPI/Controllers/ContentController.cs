using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        IContentService _contentService;
        IContentCategoryService _service;

        public ContentController(IContentCategoryService service, IContentService contentService)
        {
            _service = service;
            _contentService = contentService;
        }

        [HttpGet("{lang}/getallfreecontent")]
        public IActionResult GetAllFreeContent(string lang)
        {

            var result = _contentService.GetFreeFilms(lang);

            return Ok(result);

        }

        [HttpGet("{lang}/getallcontent")]
        public IActionResult GetAllContent(string lang)
        {

            var result = _service.GetContentList(lang);
            return Ok(result);

        }

        [HttpGet("{lang}/getcontentbyid/{id}")]
        public IActionResult GetContentById(int id, string lang)
        {

            var result = _contentService.GetContentDetails(id, lang);

            return Ok(result);

        }
        [HttpGet("{lang}/getsubscribercontentbyid/{id}")]
        public IActionResult GetSubscriberContentById(int id, string lang)
        {

            var result = _contentService.GetContentDetails(id, lang);

            return Ok(result);

        }
    }
}

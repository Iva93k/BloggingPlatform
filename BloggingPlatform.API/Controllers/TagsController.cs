using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloggingPlatform.API.Interfaces;
using BloggingPlatform.API.Models.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly ITagService _tagService;
        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        //GET api/tags
        [HttpGet]
        public ActionResult<TagDTO> GetAllTags()
        {
            try
            {
                var tags = _tagService.GetAllTags();
                if (tags == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(tags);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

using AutoMapper;
using ClassLibrary;
using ClassLibrary.DTO;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService authorService;
        private readonly IMapper mapper;

        public AuthorsController(IAuthorService authorService, IMapper mapper)
        {
            this.authorService = authorService;
            this.mapper = mapper;
        }
        //[HttpGet]
        //public async Task<ActionResult> Create([FromBody] AuthorDtoCreate req)
        //{

        //    return Ok();
        //}
        [HttpPost]
        public async Task<ActionResult> CreateAuthor([FromBody] AuthorDtoCreate req)
        {
            var data = mapper.Map<Author>(req);
            var author = await authorService.CreateAuthor(data);
            return Ok(author);
        }
    }
}

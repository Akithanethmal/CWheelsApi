using CWheelsApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CWheelsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private CWheelsDbContext _cWheelsDbContext;

        public CategoriesController(CWheelsDbContext cWheelsDbContext)
        {
            _cWheelsDbContext = cWheelsDbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
           var categories =  _cWheelsDbContext.Categories;
            return Ok(categories);
        }
    }
}

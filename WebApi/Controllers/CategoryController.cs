using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repository.IRepository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_unitOfWork.Category.GetAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            _unitOfWork.Category.Add(category);
            _unitOfWork.Save();
            return Ok();
        }
    }
}

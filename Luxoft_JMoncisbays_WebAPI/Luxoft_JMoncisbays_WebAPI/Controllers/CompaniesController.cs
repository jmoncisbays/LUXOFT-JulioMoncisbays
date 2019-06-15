using Microsoft.AspNetCore.Mvc;
using Luxoft_JMoncisbays_WebAPI.Repositories;

namespace Luxoft_JMoncisbays_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private ICompanyRepository _repository;

        public CompaniesController(ICompanyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public JsonResult Get() => new JsonResult(_repository.Get());
    }
}

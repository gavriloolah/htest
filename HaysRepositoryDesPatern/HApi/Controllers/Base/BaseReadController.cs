using HData.Interface;
using HServices.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseReadController<TEntity, TDto> : ControllerBase where TEntity:IEntity where TDto: IDto
    {
        IServiceRead<TEntity, TDto> Function;

        public BaseReadController(IServiceRead<TEntity, TDto> serviceClass)
        {
            Function=serviceClass;
        }

        // GET: api/<BaseReadController>
        [HttpGet]
        public IEnumerable<TDto> Get()
        {
            return Function.GetAll();
        }

        // GET api/<BaseReadController>/5
        [HttpGet("{id}")]
        public TDto Get(int id)
        {
            return Function.GetByID(id);
        }

        
    }
}

using HData.Interface;
using HServices.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCUDController<TEntity, TDto> : ControllerBase where TEntity : IEntity where TDto : IDto
    {
        IServiceCUD<TEntity, TDto> Function;

        public BaseCUDController(IServiceCUD<TEntity, TDto> serviceClass)
        {
            Function = serviceClass;
        }

        // POST api/<BaseCUDController>
        [HttpPost]
        public void Post([FromBody] TDto value)
        {
            Function.Insert(value);
            Function.Save();
        }

        // PUT api/<BaseCUDController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TDto value)
        {
            Function.Update(value);
            Function.Save();
        }

        // DELETE api/<BaseCUDController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Function.Delete(id);
            Function.Save();
        }
    }
}

using HData.DTO;
using HData.Model;
using Microsoft.AspNetCore.Mvc;
using HServices.Base;
using HRepository.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CBSteernigReadController : BaseReadController<CBSteering, CBSteeringDto>
    {
        IReadRepository<CBSteering> _readRepository;
        public CBSteernigReadController([FromServices]IReadRepository<CBSteering> readRepository) : base(new CBSteeringReadService(readRepository))
        {
            _readRepository = readRepository;
        }
    }
}

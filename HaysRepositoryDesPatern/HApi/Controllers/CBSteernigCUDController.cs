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
    public class CBSteernigCUDController : BaseCUDController<CBSteering, CBSteeringDto>
    {
        ICUDRepository<CBSteering> _cudRepository;
        public CBSteernigCUDController(ICUDRepository<CBSteering> cudRepository) : base(new CBSteeringCUDService(cudRepository))
        {
            _cudRepository= cudRepository;
        }
    }
}

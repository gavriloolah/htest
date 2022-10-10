using HServices.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HData.DTO;
using HData.Model;
using HRepository.Interface;

namespace HServices.Base
{
    public class CBSteeringCUDService : ServiceGenericCUD<CBSteering, CBSteeringDto>
    {
        public CBSteeringCUDService(ICUDRepository<CBSteering> cudRepository) : base(cudRepository)
        {
        }

        public override CBSteering GetFromDto(CBSteeringDto myDto)
        {
            return _mapper.Map<CBSteering>(myDto);
        }

        public override CBSteeringDto GetFromEntity(CBSteering myEntity)
        {
            return _mapper.Map<CBSteeringDto>(myEntity);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HData.DTO;
using HData.Model;
using HRepository.Interface;
using HServices.Generic;

namespace HServices.Base
{
    public class CBSteeringReadService : ServiceGenericRead<CBSteering, CBSteeringDto>
    {
        public CBSteeringReadService(IReadRepository<CBSteering> readRepository) : base(readRepository)
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

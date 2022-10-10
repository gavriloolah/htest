using AutoMapper;
using HData.DTO;
using HData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HServices.Base
{
    internal class MappingProfile: Profile
    {

        public MappingProfile()
        {
            CreateMap<CBSteering, CBSteeringDto>();
            CreateMap<CBSteeringDto, CBSteering>();

            

            // more mapping as simnple or as complexe


        }
    }
}

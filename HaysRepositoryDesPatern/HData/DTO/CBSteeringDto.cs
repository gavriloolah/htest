using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HData.DTO
{
    public class CBSteeringDto: DtoMain
    {
        public Guid HaysCompanyID { get; set; }
        public Guid CompanyID { get; set; }
        public int ContractType { get; set; }
        public int DistributionChannel { get; set; }
        public bool MPSFlag { get; set; }
    }
}

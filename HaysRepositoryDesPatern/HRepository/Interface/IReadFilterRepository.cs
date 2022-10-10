using HData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRepository.Interface
{
    public interface IReadFilterRepository<TFilterEntity>: IReadRepository<TFilterEntity> where TFilterEntity: IFilterEntity
    {
        IEnumerable<TFilterEntity> GetFromFilter(IFilterData myFilterData);
    }
}

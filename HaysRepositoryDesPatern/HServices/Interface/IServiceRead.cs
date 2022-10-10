using HData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HServices.Interface
{
    public interface IServiceRead<TEntity, TDto> where TDto : IDto where  TEntity : IEntity
    {
        IEnumerable<TDto> GetAll();
        TDto GetByID(object ID);
    }
}

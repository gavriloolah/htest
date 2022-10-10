using HData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HServices.Interface
{
    public interface IServiceCUD<TEntity, TDto> where TDto : IDto where  TEntity : IEntity
    {
        void Insert(TDto myEntity);
        void Update(TDto myEntity);
        void Delete(object ID);
        void Save();
    }
}

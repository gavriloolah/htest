using HData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRepository.Interface
{

    public interface ICUDRepository<TEntity> where TEntity : IEntity
    {
        void Insert(TEntity myEntity);
        void Update(TEntity myEntity);
        void Delete(object ID);
        void Save();
    }
}

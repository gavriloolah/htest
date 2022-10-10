using HData.Interface;
using HData.Model;
using HRepository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRepository.Generic
{
    public class ReadRepositoryGeneric<TEintity> : IReadRepository<TEintity> where TEintity : EntityMain
    {
        DataModel DBContext;

        public ReadRepositoryGeneric(DataModel myDataModel)
        {
            DBContext = myDataModel;
        }
        public IEnumerable<TEintity> GetAll()
        {
            return DBContext.Set<TEintity>().AsNoTracking();
        }

        public TEintity GetByID(object ID)
        {
            var myEntity=  DBContext.Set<TEintity>().Find(ID);
            if (myEntity != null)
            {
                DBContext.Entry(myEntity).State = EntityState.Detached;
                return myEntity;
            }
            else 
            {
                return default(TEintity);
            }
            

        }
    }
}

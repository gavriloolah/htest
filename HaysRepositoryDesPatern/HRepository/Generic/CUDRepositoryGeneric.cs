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
  
    public class CUDRepositoryGeneric<TEintity> : ICUDRepository<TEintity> where TEintity : EntityMain
    {
        DataModel DBContext;

        public CUDRepositoryGeneric(DataModel myDataModel)
        {
            DBContext = myDataModel;
        }
        public void Insert(TEintity myEntity)
        {
            try
            {
                DBContext.Set<TEintity>().Add(myEntity);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void Update(TEintity myEntity)
        {
            try
            {
                DBContext.Set<TEintity>().Update(myEntity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Delete (object ID)
        {
            try
            {
                var myEnt= DBContext.Set<TEintity>().Find(ID);
                if (myEnt != null)
                {
                    DBContext.Remove(myEnt);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Save()
        {
            try
            {
                DBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        
    }

}

using AutoMapper;
using HData.DTO;
using HData.Interface;
using HData.Model;
using HRepository.Generic;
using HRepository.Interface;
using HServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HServices.Generic
{
    public abstract class ServiceGenericCUD<TEntity, TDto>: IServiceCUD<TEntity, TDto> where TDto : IDto where TEntity : IEntity
    {
        ICUDRepository<TEntity> _cudRepository;
        public IMapper _mapper;

        public ServiceGenericCUD(ICUDRepository<TEntity> cudRepository)
        {
            _cudRepository = cudRepository;
        }


        public void Insert(TDto myDto)
        {
            
            try
            {
                _cudRepository.Insert(GetFromDto(myDto));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(TDto myDto)
        {
            try
            {
                _cudRepository.Update(GetFromDto(myDto));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(object ID)
        {
            try
            {
                _cudRepository.Delete(ID);
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
                _cudRepository.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        public abstract TDto GetFromEntity(TEntity myEntity);


        public abstract TEntity GetFromDto(TDto myDto);
    }
}

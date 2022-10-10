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
    public abstract class ServiceGenericRead<TEntity, TDto>: IServiceRead<TEntity, TDto> where TDto : DtoMain where TEntity : EntityMain
    {
        IReadRepository<TEntity> _readRepository;
        public IMapper _mapper;

        public ServiceGenericRead(IReadRepository<TEntity> readRepository)
        {
            _readRepository = readRepository;
        }

        public IEnumerable<TDto> GetAll()
        {
            try
            {
                return _readRepository.GetAll().Select(ad=>GetFromEntity(ad));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TDto GetByID(object ID)
        {
            try
            {
                return GetFromEntity(_readRepository.GetByID(ID));
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

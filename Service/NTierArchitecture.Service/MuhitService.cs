using AutoMapper;
using NTierArchitecture.Data;
using NTierArchitecture.Service.Common.DTOs;
using NTierArchitecture.Service.IServices;

namespace NTierArchitecture.Service
{
    public class MuhitService : IMuhitService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MuhitService(
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Add(MuhitDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid ID)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(MuhitDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(MuhitDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Upsert(MuhitDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<MuhitDTO> GetById(Guid ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MuhitDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Any()
        {
            throw new NotImplementedException();
        }
    }
}

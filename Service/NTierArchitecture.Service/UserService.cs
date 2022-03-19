using AutoMapper;
using NTierArchitecture.Data;
using NTierArchitecture.Data.Model;
using NTierArchitecture.Service.Common.DTOs;
using NTierArchitecture.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Add(UserDTO entityDTO)
        {
            try
            {
                Guid guid = Guid.NewGuid();
                var user = _mapper.Map<User>(entityDTO);
                user.ID = guid; //Test için created vs aynı atadık
                user.Active = true;
                user.CreatedBy = guid;
                var _dt = DateTime.Now;
                user.CreatedOn = _dt;
                var res = await _unitOfWork.UserRepository.Add(user);

                _unitOfWork.Commit(); //Etmezsen eklemez

                return res;
            }
            catch
            {

                throw;
            }
        }

        public async Task<bool> Delete(Guid ID)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(UserDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(UserDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Upsert(UserDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO> GetById(Guid ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            try
            {
                return _mapper.Map<IEnumerable<UserDTO>>(await _unitOfWork.UserRepository.GetAll());
            }
            catch
            {

                throw;
            }
        }

        public async Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Any()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetFirstNameAndLastName(Guid ID)
        {
            throw new NotImplementedException();
        }
    }
}

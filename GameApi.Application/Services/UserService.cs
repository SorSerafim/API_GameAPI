using AutoMapper;
using FluentResults;
using GameApi.Domain.Interfaces.RepositoryInterfaces;
using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        private IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void AdicionaUser(CreateUserDto createDto)
        {
            _repository.Adiciona(_mapper.Map<User>(createDto));
        }

        public Result AtualizaUser(int id, CreateUserDto createDto)
        {
            User user = _repository.Retorna(id);
            if (user != null)
            {
                user.Id = id;
                user.Username = createDto.Username;
                user.Password = createDto.Password;
                user.Role = createDto.Role;
                _repository.Atualiza(user);
                return Result.Ok();
            }
            return Result.Fail("User não encontrado!");
        }

        public Result DeletaUser(int id)
        {
            User user = _repository.Retorna(id);
            if(user != null)
            {
                _repository.Deleta(user);
                return Result.Ok();
            }
            return Result.Fail("User não encontrado!");
        }

        public List<ReadUserDto> RetornaTodosOsUsers()
        {
            return _mapper.Map<List<ReadUserDto>>(_repository.RetornaTodos());
        }

        public ReadUserDto RetornaUserPorId(int id)
        {
            User user = _repository.Retorna(id);
            if(user != null) return _mapper.Map<ReadUserDto>(user);
            return null;
        }

        public User Get(string username, string password)
        {
            return _repository.RetornaTodos()
                .FirstOrDefault(x => x.Username.ToLower() == 
                username.ToLower() && x.Password == 
                password.ToLower());
        }
    }
}
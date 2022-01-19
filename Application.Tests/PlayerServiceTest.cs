using AutoMapper;
using GameApi.Application.Services;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using Moq;
using Xunit;

namespace Application.Tests
{
    public class PlayerServiceTest
    {
        private readonly PlayerService _sut;
        private readonly Mock<IPlayerRepository> _playerRepository;
        private readonly Mock<IMapper> _mapper;

        public PlayerServiceTest()
        {
            _playerRepository = new Mock<IPlayerRepository>();
            _mapper = new Mock<IMapper>();
            _sut = new PlayerService(_playerRepository.Object, _mapper.Object);
        }

        [Fact]
        public void AtualizaPlayer_DeveAtualizarOPlayerCorrespondentePeloId()
        {
            //Arrange

            CreatePlayerDto createDto = new CreatePlayerDto();
            createDto.Nome = "ricardo";
            createDto.Level = 1;
            createDto.Vida = 1;

            Player player = new Player();
            player.Id = 1;
            player.Nome = "teste";
            player.Vida = 2;
            player.Level = 2;

            _playerRepository.Setup(x => x.Retorna(1)).Returns(player);

            //Act

            _sut.AtualizaPlayer(1, createDto);


            //Assert

            _playerRepository.Verify(x => x.Atualiza(player), Times.Once);

        }
    }
}

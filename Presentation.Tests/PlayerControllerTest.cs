using GameApi.Controllers;
using GameApi.Domain.Interfaces.ServiceInterfaces;
using GameApi.Shared.Dtos.Read;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Presentation.Tests
{
    public class PlayerControllerTest
    {
        private readonly PlayerController _sut;
        private readonly Mock<IPlayerService> _playerService;

        public PlayerControllerTest()
        {
            _playerService = new Mock<IPlayerService>();
            _sut = new PlayerController(_playerService.Object);
        }

        [Fact]
        public void RetornaTodos_DeveRetornarListeDeReadPlayerDto()
        {
            //Arrange
            List<ReadPlayerDto> listDto = new List<ReadPlayerDto>();

            ReadPlayerDto readDto = new ReadPlayerDto();

            readDto.Id = 1;
            readDto.Nome = "test";
            readDto.Level = 1;
            readDto.Vida = 1;

            listDto.Add(readDto);

            _playerService.Setup(x => x.RetornaTodosOsPlayers()).Returns(listDto);

            //Act
            var resultado = _sut.RetornaTodos() as OkObjectResult;

            //Assert
            Assert.IsType<List<ReadPlayerDto>>(resultado.Value);

            _playerService.Verify(x => x.RetornaTodosOsPlayers(), Times.Once);
        }

        [Fact]
        public void RetornaPorId_DeveRetornarUmPlayerPorId()
        {
            //Arrange
            ReadPlayerDto readDto = new ReadPlayerDto();

            readDto.Id = 1;
            readDto.Nome = "test";
            readDto.Level = 1;
            readDto.Vida = 1;

            _playerService.Setup(x => x.RetornaPlayerPorId(It.IsAny<int>())).Returns(readDto);

            //Act
            var resultado = _sut.RetornaPorId(1) as OkObjectResult;
            var player = resultado.Value as ReadPlayerDto;

            //Assert
            Assert.IsType<ReadPlayerDto>(player);

            Assert.Equal(readDto.Nome, player.Nome);
        }

        [Fact]
        public void RetornaPorId_CasoDeRetornoNulo()
        {
            //Arrange
            _playerService.Setup(x => x.RetornaPlayerPorId(It.IsAny<int>())).Returns<object>(null);

            //Act
            var resultado = _sut.RetornaPorId(1) as OkObjectResult;

            //Assert
            Assert.Null(resultado);

            _playerService.Verify(x => x.RetornaPlayerPorId(It.IsAny<int>()), Times.Once);
        }
    }
}

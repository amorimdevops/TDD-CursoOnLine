using CurcoOnLine.Domain;
using CurcoOnLine.Domain.Business;
using CurcoOnLine.Domain.Dtos;
using CurcoOnLine.Domain.Entities;
using CurcoOnLine.Domain.Interfaces;
using Moq;

namespace CursoOnLine.Test.Business.Cursos
{
    public class CursoBusinessTest
    {
        [Fact]
        public void DeveIncluirCurso()
        {
            // Arrange
            var cursoDto = new CursoDto
            {
                Descricao = "Informatica Basica",
                CargaHoraria = 90,
                PublicAlvo = PublicoAlvo.Estudantes,
                Valor = 155
            };

            var cursoRepositoryMock = new Mock<ICursoRepository>();

            var business = new CursoBusiness(cursoRepositoryMock.Object);


            // Action
            business.Insert(cursoDto);

            // Assert
            //cursoRepositoryMock.Verify(x => x.Insert(It.IsAny<Curso>()));
            //cursoRepositoryMock.Verify(x => x.Insert(It.Is<Curso>(x => x.Descricao == cursoDto.Descricao &&
            //    x.CargaHoraria == cursoDto.CargaHoraria)));
            cursoRepositoryMock.Verify(x => x.Insert(It.IsAny<Curso>()), Times.AtLeast(1));
        }
    }
}

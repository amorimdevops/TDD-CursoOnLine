using CurcoOnLine.Domain;
using CurcoOnLine.Domain.Entities;
using ExpectedObjects;

namespace CursoOnLine.Test.Domain
{

    /*​
    ---- Criterio de aceite

    Opções de público alvo: Estudantes, Universitário, Empregado, Empregador​

    Todos os campos do cursos são obrigatório.​
    */

    public class CursoTest
    {
        [Fact]
        public void DeveCriarCurso()
        {
            // Arrange
            var cursoEsperado = new
            {
                Descricao = "Curso A",
                CargaHorario = 80,
                PublicoAlvo = PublicoAlvo.Estudantes,
                Valor = 150
            };

            // Action
            var curso = new Curso(cursoEsperado.Descricao, cursoEsperado.CargaHorario, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);

            // Assert
            cursoEsperado.ToExpectedObject().ShouldMatch(cursoEsperado);            
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveDescricaoSerInvalida(string descricaoInvalida)
        {
            // Arrange
            var cursoEsperado = new
            {
                Descricao = "Curso A",
                CargaHorario = 80,
                PublicoAlvo = PublicoAlvo.Estudantes,
                Valor = 150
            };

            string messageEsperada = "Descrição invalida.";

            // Action


            // Assert
            var message = Assert.Throws<ArgumentException>(() => 
                new Curso(descricaoInvalida, cursoEsperado.CargaHorario, cursoEsperado.PublicoAlvo, cursoEsperado.Valor))
                .Message;
            Assert.Equal(messageEsperada, message);

        }


        [Theory]
        [InlineData(0)]
        [InlineData(-100)]
        public void NaoDeveValorSerMenorQueHum(int valorInvalido)
        {
            // Arrange
            var cursoEsperado = new
            {
                Descricao = "Curso A",
                CargaHorario = 80,
                PublicoAlvo = PublicoAlvo.Estudantes,
                Valor = 150
            };

            // Action


            // Assert
            Assert.Throws<ArgumentException>(() => new Curso(cursoEsperado.Descricao, cursoEsperado.CargaHorario, cursoEsperado.PublicoAlvo, valorInvalido));

        }
    }
}

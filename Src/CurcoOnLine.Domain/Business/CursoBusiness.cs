using CurcoOnLine.Domain.Dtos;
using CurcoOnLine.Domain.Entities;
using CurcoOnLine.Domain.Interfaces;

namespace CurcoOnLine.Domain.Business
{
    public class CursoBusiness
    {
        private ICursoRepository _cursoRepository;

        public CursoBusiness(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public void Insert(CursoDto cursoDto)
        {
            var curso = new Curso(cursoDto.Descricao, cursoDto.CargaHoraria, cursoDto.PublicAlvo, cursoDto.Valor);

            _cursoRepository.Insert(curso);
        }
    }
}

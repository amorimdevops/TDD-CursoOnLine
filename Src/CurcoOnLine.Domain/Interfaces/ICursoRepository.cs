using CurcoOnLine.Domain.Entities;

namespace CurcoOnLine.Domain.Interfaces
{
    public interface ICursoRepository
    {
        void Insert(Curso curso);
        void Update(Curso curso);
    }
}

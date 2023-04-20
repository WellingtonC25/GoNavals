namespace GoNavals.Core.Interfaces
{ 
    public interface ICursoService
    {
        Task<IEnumerable<Domain.Curso>?> GetAllCursos();
        Task<Domain.Curso?> GetSingleCurso(int id);
        Task<Domain.Curso?> AddCurso( Domain.Curso curso);
        Task<Domain.Curso?> UpdateCurso(int id, Domain.Curso curso);
        Task<Domain.Curso?> DeleteCurso(int id);
    }
}

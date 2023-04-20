using GoNavals.Core;
using GoNavals.Core.Interfaces;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.BusinessLogic.Services.Curso
{
    public class CursoService : ICursoService
    {
        private readonly DataContext _dataContext;

        public CursoService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Domain.Curso?> AddCurso(Domain.Curso curso)
        {
            var cursoResult = await _dataContext.Curso.AddAsync(curso);

            if (cursoResult is null)
                return null;

            _dataContext.SaveChanges();

            return cursoResult.Entity;
        }

        public async Task<Domain.Curso?> DeleteCurso(int id)
        {
            var curso = await _dataContext.Curso.FindAsync(id);

            if (curso is null) 
                return null;

            _dataContext.Curso.Remove(curso);
            await _dataContext.SaveChangesAsync();

            return curso;
        }

        public async Task<IEnumerable<Domain.Curso>?> GetAllCursos()
        {
            return await _dataContext.Curso.ToListAsync();
        }

        public async Task<Domain.Curso?> GetSingleCurso(int id)
        {
            var curso = await _dataContext.Curso.FindAsync(id);

            if (curso is null)
                return null;

            return curso;
        }

        public async Task<Domain.Curso?> UpdateCurso(int id, Domain.Curso curso)
        {
            var cursoResult = await _dataContext.Curso.FindAsync(id);

            if (cursoResult is null)
                return null;

            cursoResult.Descripcion = curso.Descripcion;
            cursoResult.Origen = curso.Origen;
            cursoResult.TipoCurso = curso.TipoCurso;

            await _dataContext.SaveChangesAsync();

            return cursoResult;

        }
    }
}

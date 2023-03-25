using System.Collections;

namespace GoNavals.API.Services.Comandancia
{
    public interface IComandanciaService
    {

        Task<IEnumerable<Domain.Comandancia>?> GetAllComandancias();
        Task<Domain.Comandancia?> GetSingleComandancia( int id);
        Task<IEnumerable<Domain.Comandancia>?> AddComandancia(Domain.Comandancia comandancia);
        Task<IEnumerable<Domain.Comandancia>?> UpdateComandancia(int id, Domain.Comandancia comandancia);
        Task<IEnumerable<Domain.Comandancia>?> DeleteComandancia(int id);
    }
}

namespace GoNavals.API.Services.ComandanteComandancia
{
    public interface IComandanteComandanciaService
    {
        Task<IEnumerable<Domain.ComandanteComandancia>?> GetAllComandanteComandancias();
        Task<Domain.ComandanteComandancia?> GetSingleComandanteComandancia(int id);
        Task<Domain.ComandanteComandancia?> AddComandanteComandancia(Domain.ComandanteComandancia comandanteComandancia);
        Task<Domain.ComandanteComandancia?> UpdateComandanteComandancia(int id, Domain.ComandanteComandancia comandanteComandancia);
        Task<Domain.ComandanteComandancia?> DeleteComandanteComandancia(int id);
    }
}

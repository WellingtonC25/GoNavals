namespace GoNavals.Core.Interfaces
{
    public interface IComandanteService
    {
        Task<Domain.Comandante?> DeleteComandante(int id);
        Task<Domain.Comandante?> AddComandante(Domain.Comandante comandante);
        Task<IEnumerable<Domain.Comandante>?> GetAllComandantes();
        Task<Domain.Comandante?> GetSingleComandante(int id);
        Task<Domain.Comandante?> UpdateComandante(int id, Domain.Comandante comandante);
    }
}

namespace GoNavals.Core.Interfaces
{
    public interface IConstructoraService
    {
        Task<List<Domain.Constructora>> GetAllConstructoras();
        Task<Domain.Constructora?> GetSingleConstructora(int id);
        Task<Domain.Constructora?> AddConstructora(Domain.Constructora constructora);
        Task<Domain.Constructora?> UpdateConstructora(int id, Domain.Constructora constructora);
        Task<Domain.Constructora?> DeleteConstructora(int id);
    }
}

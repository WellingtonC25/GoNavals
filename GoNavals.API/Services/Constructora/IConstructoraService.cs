namespace GoNavals.API.Services.Constructora
{
    public interface IConstructoraService
    {
        Task<IEnumerable<Domain.Constructora>> GetAllConstructoras();
        Task<Domain.Constructora?> GetSingleConstructora(int id);
        Task<Domain.Constructora?> AddConstructora(Domain.Constructora constructora);
        Task<Domain.Constructora?> UpdateConstructora(int id, Domain.Constructora constructora);
        Task<Domain.Constructora?> DeleteConstructora(int id);
    }
}

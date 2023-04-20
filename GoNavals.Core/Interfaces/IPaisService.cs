namespace GoNavals.Core.Interfaces
{
    public interface IPaisService
    {   
        Task<IEnumerable<Domain.Pais>?> GetAllPaises();
        Task<Domain.Pais?> GetSinglePais(int id);
        Task<Domain.Pais?> AddPais(Domain.Pais pais);
        Task<Domain.Pais?> UpdatePais(int id, Domain.Pais pais);
        Task<Domain.Pais?> DeletePais(int id);
    }
}

namespace GoNavals.Core.Interfaces
{
    public interface IPuertoService
    {
        Task<IEnumerable<Domain.Puerto>?> GetAllPuertos();
        Task<Domain.Puerto?> GetSinglePuerto(int id);
        Task<Domain.Puerto?> AddPuerto(Domain.Puerto puerto);
        Task<Domain.Puerto?> UpdatePuerto(int id, Domain.Puerto puerto);
        Task<Domain.Puerto?> DeletePuerto(int id);
    }
}

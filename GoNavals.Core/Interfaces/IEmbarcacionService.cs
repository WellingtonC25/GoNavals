namespace GoNavals.Core.Interfaces
{
    public interface IEmbarcacionService
    {
        Task<IEnumerable<Domain.Embarcacion>?> GetAllEmbarcaciones();
        Task<Domain.Embarcacion?> GetSingleEmbarcacion(int id);
        Task<Domain.Embarcacion?> AddEmbarcacion(Domain.Embarcacion embarcacion);
        Task<Domain.Embarcacion?> UpdateEmbarcacion(int id, Domain.Embarcacion embarcacion);
        Task<Domain.Embarcacion?> DeleteEmbarcacion(int id);
    }
}

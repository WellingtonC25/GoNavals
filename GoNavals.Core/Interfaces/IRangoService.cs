namespace GoNavals.Core.Interfaces
{
    public interface IRangoService
    {
        Task<IEnumerable<Domain.Rango>?> GetAllRangos();
        Task<Domain.Rango?> GetSingleRango(int id);
        Task<Domain.Rango?> AddRango(Domain.Rango rango);
        Task<Domain.Rango?> UpdateRango(int id, Domain.Rango rango);
        Task<Domain.Rango?> DeleteRango(int id);
    }
}

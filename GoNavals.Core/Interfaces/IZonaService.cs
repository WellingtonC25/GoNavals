namespace GoNavals.Core.Interfaces
{
    public interface IZonaService
    {
        Task<IEnumerable<Domain.Zona>?> GetAllZonas();
        Task<Domain.Zona?> GetSingleZona(int id);
        Task<Domain.Zona?> AddZona(Domain.Zona zona);
        Task<Domain.Zona?> UpdateZona(int id, Domain.Zona zona);
        Task<Domain.Zona?> DeleteZona(int id);
    }
}

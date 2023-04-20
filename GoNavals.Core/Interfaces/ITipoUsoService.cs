namespace GoNavals.Core.Interfaces
{
    public interface ITipoUsoService
    {
        Task<IEnumerable<Domain.TipoUso>?> GetAllTipoUsos();
        Task<Domain.TipoUso?> GetSingleTipoUso(int id);
        Task<Domain.TipoUso?> AddTipoUso(Domain.TipoUso tipoUso);
        Task<Domain.TipoUso?> UpdateTipoUso(int id, Domain.TipoUso tipoUso);
        Task<Domain.TipoUso?> DeleteTipoUso(int id);
    }
}

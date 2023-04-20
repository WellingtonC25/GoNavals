namespace GoNavals.Core.Interfaces
{
    public interface IPropietarioService
    {
        Task<IEnumerable<Domain.Propietario>?> GetAllPropietarios();
        Task<Domain.Propietario?> GetSinglePropietario(int id);
        Task<Domain.Propietario?> AddPropietario(Domain.Propietario propietario);
        Task<Domain.Propietario?> UpdatePropietario(int id, Domain.Propietario propietario);
        Task<Domain.Propietario?> DeletePropietario(int id);
    }
}

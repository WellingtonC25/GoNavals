namespace GoNavals.Core.Interfaces
{
    public interface IOcupacionService
    {
        Task<IEnumerable<Domain.Ocupacion>?> GetAllOcupaciones();
        Task<Domain.Ocupacion?> GetSingleOcupacion(int id);
        Task<Domain.Ocupacion?> AddOcupacion(Domain.Ocupacion ocupacion);
        Task<Domain.Ocupacion?> UpdateOcupacion(int id, Domain.Ocupacion ocupacion);
        Task<Domain.Ocupacion?> DeleteOcupacion(int id);
    }
}

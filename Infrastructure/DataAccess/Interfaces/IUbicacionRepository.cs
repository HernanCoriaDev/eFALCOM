using Domain.Entities;

namespace TrabajoIntegradorSofftek.DataAccess.Repositories.Interfaces
{
	public interface IUbicacionRepository
	{
        public Task<List<UbicacionEntity>> GetAll();
        public Task<UbicacionEntity> GetById(int id);
        public Task<bool> Update(UbicacionEntity Entity);
        public Task<bool> Delete(int id);
    }
}

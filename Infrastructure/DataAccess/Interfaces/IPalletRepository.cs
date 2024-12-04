using Domain.Entities;

namespace TrabajoIntegradorSofftek.DataAccess.Repositories.Interfaces
{
	public interface IPalletRepository
	{
        public Task<List<PalletEntity>> GetAll();
        public Task<PalletEntity> GetById(int id);
        public Task<bool> Update(PalletEntity Entity);
        public Task<bool> Delete(int id);
    }
}

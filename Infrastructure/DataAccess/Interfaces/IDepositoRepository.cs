using Domain.Entities;

namespace TrabajoIntegradorSofftek.DataAccess.Repositories.Interfaces
{
	public interface IDepositoRepository
	{
        public Task<List<DepositoEntity>> GetAll();
        public Task<DepositoEntity> GetById(int id);
        public Task<bool> Update(DepositoEntity Entity);
        public Task<bool> Delete(int id);
    }
}

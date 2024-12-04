using Domain.Entities;

namespace TrabajoIntegradorSofftek.DataAccess.Repositories.Interfaces
{
	public interface IStockMovimientoRepository
	{
        public Task<List<StockMovimientoEntity>> GetAll();
        public Task<StockMovimientoEntity> GetById(int id);
        public Task<bool> Update(StockMovimientoEntity Entity);
        public Task<bool> Delete(int id);
    }
}

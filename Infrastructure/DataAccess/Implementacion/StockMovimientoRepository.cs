using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorSofftek.DataAccess.Repositories.Interfaces;

namespace Infrastructure.DataAccess.Implementacion
{
    public class StockMovimientoRepository : IStockMovimientoRepository
    {
        public StockMovimientoRepository(AppDbContext context) { }
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StockMovimientoEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<StockMovimientoEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(StockMovimientoEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}

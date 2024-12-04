using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorSofftek.DataAccess.Repositories.Interfaces;

namespace Infrastructure.DataAccess.Implementacion
{
    public class DepositoRepository : IDepositoRepository
    {
        public DepositoRepository(AppDbContext context) { }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DepositoEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DepositoEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DepositoEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}

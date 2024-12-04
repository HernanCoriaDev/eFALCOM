using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorSofftek.DataAccess.Repositories.Interfaces;

namespace Infrastructure.DataAccess.Implementacion
{
    public class UbicacionRepository : IUbicacionRepository
    {

        public UbicacionRepository(AppDbContext context) { }
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UbicacionEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UbicacionEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(UbicacionEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}

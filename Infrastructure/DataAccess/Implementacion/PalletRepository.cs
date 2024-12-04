using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorSofftek.DataAccess.Repositories.Interfaces;

namespace Infrastructure.DataAccess.Implementacion
{
    public class PalletRepository : IPalletRepository
    {
        private readonly AppDbContext _context;
        public PalletRepository(AppDbContext context) 
        {
            _context = context;
        
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PalletEntity>> GetAll()
        {
            return await _context.Pallet.ToListAsync();
        }

        public async Task<PalletEntity> GetById(int id)
        {
            return await _context.Pallet.FirstOrDefaultAsync();
        }

        public Task<bool> Update(PalletEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}

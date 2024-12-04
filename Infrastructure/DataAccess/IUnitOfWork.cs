using Infrastructure.DataAccess.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public interface IUnitOfWork
    {
        public StockMovimientoRepository StockMovimientoRepository { get; }
        public PalletRepository PalletRepository { get; }
        public UbicacionRepository UbicacionRepository { get; }
        public DepositoRepository DepositoRepository { get; }
        Task<int> Complete();
    }
}

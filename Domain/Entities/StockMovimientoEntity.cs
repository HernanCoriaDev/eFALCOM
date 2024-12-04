using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StockMovimientoEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CodigoProducto { get; set; }
        public Guid PalletId { get; set; }
        public DateTime FechaMovimiento { get; set; } = DateTime.Now;
        public string TipoMovimiento { get; set; }
        public int UbicacionId { get; set; }
        public UbicacionEntity Ubicacion { get; set; }
    }
}

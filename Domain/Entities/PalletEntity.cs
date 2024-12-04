using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PalletEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CodigoProducto { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public int UbicacionId { get; set; }
        public UbicacionEntity Ubicacion { get; set; }
    }
}

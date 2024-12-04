using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UbicacionEntity
    {
        public int Id { get; set; }
        public string Fila { get; set; }
        public string Columna { get; set; }
        public bool Ocupada { get; set; } = false;
    }
}

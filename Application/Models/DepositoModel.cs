using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DepositoModel
    {
        public int DepositoId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int UbicacionId { get; set; }
    }


}

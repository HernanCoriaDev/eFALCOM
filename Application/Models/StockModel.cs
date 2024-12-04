using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class StockModel
    {
        public int StockId { get; set; }
        public int PalletId { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int UbicacionId { get; set; }
    }


}

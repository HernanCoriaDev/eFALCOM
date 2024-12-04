namespace API.DTOs
{
    public class StockDTO
    {
        public int StockId { get; set; }
        public int PalletId { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string PalletName { get; set; } 
        public string UbicacionName { get; set; }
    }

}



namespace Domain.Entities
{
    public class DepositoEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CapacidadTotal { get; set; }
        public int CapacidadOcupada { get; set; }
        public List<UbicacionEntity> Ubicaciones { get; set; } = new List<UbicacionEntity>();
    }
}

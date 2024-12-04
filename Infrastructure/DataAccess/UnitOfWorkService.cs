using Infrastructure.DataAccess.Implementacion;

namespace Infrastructure.DataAccess
{
    public class UnitOfWorkService : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public StockMovimientoRepository StockMovimientoRepository { get; set; }
        public PalletRepository PalletRepository { get; set; }
        public UbicacionRepository UbicacionRepository { get; set; }
        public DepositoRepository DepositoRepository { get; set; }

        public UnitOfWorkService(AppDbContext context)
        {
            _context = context;

            StockMovimientoRepository = new StockMovimientoRepository(_context);
            PalletRepository = new PalletRepository(_context);
            UbicacionRepository = new UbicacionRepository(_context);
            DepositoRepository = new DepositoRepository(_context);
        }

        public Task<int> Complete()
        {
            return _context.SaveChangesAsync();
        }
    }
}

using Market.DataService.SQL;
using Market.Interfaces.DataService;
using Market.Models;
using System.Threading.Tasks;
using System.Linq;

namespace Market.DataService {
  public class WholesalerService : IWholesalerService {
    private MarketDbContext _context;
    public WholesalerService(MarketDbContext context){
      _context = context;
    }
    public async void AddWholesaler(Wholesaler wholesaler) {
      await _context.Wholesalers.AddAsync(wholesaler);
      await _context.SaveChangesAsync();
    }

    public async Task<Wholesaler> GetWholesalerById(int id) {
      var wholesaler = await _context.Wholesalers.FindAsync(id);
      return wholesaler;
    }

    public IQueryable<Wholesaler> GetWholesalers() {
      return _context.Wholesalers;
    }
    
  }
}
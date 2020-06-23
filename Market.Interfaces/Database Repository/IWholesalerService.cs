using Market.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Interfaces.DataService {
  public interface IWholesalerService {
    Task<Wholesaler> GetWholesalerById(int id);
    IQueryable<Wholesaler> GetWholesalers();
    // Task AddWholesaler(Wholesaler wholesaler);
    // Wholesaler GetWholesalerByEmail(string email);
    // Wholesaler UpdateWholesaler(int id, Retailer newRetailer);
    // void DeleteWholesaler(int id);
  }
}
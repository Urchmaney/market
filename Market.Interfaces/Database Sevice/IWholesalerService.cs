using Market.Models;
using System.Linq;

namespace Market.Interfaces.DataService {
  interface IWholesalerService {
    Wholesaler GetWholesalerById(int id);
    IQueryable<Wholesaler> GetWholesalers();
    void AddWholesalers(Wholesaler wholesaler);
    Wholesaler GetWholesalerByEmail(string email);
  }
}
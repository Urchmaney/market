using Market.Models;
using System.Linq;

namespace Market.Interfaces.DataService {
  public interface IRetailerService {
    Retailer GetRetailerById(int Id);
    Retailer GetRetailerByEmail(string email);
    IQueryable<Retailer> GetRetailers();
    void AddRetailer(Retailer retailer);
    void DeleteRetailer(int retailerId);
    Retailer UpdateRetailer(int retailerId, Retailer newRetailer);
  }
}
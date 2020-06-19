using System;
using Microsoft.EntityFrameworkCore;
using Market.Models;

namespace Market.DataService.SQL{
  public class MarketDbContext : DbContext {
    public MarketDbContext(DbContextOptions<MarketDbContext> options)
    : base(options) {
    }
    private DbSet<Wholesaler> Wholesalers { get; set; }
    private DbSet<Retailer> Retailers { get; set; }

    public async void CreateWholesaler(Wholesaler wholesaler) {
      await Wholesalers.AddAsync(wholesaler);
      await SaveChangesAsync();
    }

    public async void CreateRetailer(Retailer retailer) {
      await Retailers.AddAsync(retailer);
      await SaveChangesAsync();
    }
  }
}
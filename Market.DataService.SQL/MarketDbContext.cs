using System;
using Microsoft.EntityFrameworkCore;
using Market.Models;

namespace Market.DataService.SQL{
  internal class MarketDbContext : DbContext {
    public MarketDbContext(DbContextOptions<MarketDbContext> options)
    : base(options) {
    }
    public DbSet<Wholesaler> Wholesalers { get; set; }
    public DbSet<Retailer> Retailers { get; set; }
  }
}
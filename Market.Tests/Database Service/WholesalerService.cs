using System;
using Microsoft.EntityFrameworkCore;
using Market.Interfaces.DataService;
using Market.DataService.SQL;
using Market.Models;
using Xunit;

namespace Market.Tests.DatabaseService
{
  public class WholesalerService
  {
    private readonly IWholesalerService _wholesalerService;
    public WholesalerService(){
      var option = new DbContextOptionBuilder<MarketDbContext>().UseInMemoryDatabase(databaseName: "Market").options;
      var marketContext = new MarketDbContext(option);
      _wholesalerService = new WholesalerService(marketContext);
    }

    [Fact]
    public async void Add_Wholesaler_IncrementDatabaseTable()
    {
      //Given
      var initialWholesalerLength =_wholesalerService.GetWholesalers().Length;
      var wholesaler = new Wholesaler() {
        CompanyName = "Memory",
        PhoneNumber = "08164292882",
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
        IsDeleted = false,
      };
      //When
      await _wholesalerService.AddWholesaler(wholesaler);
      //Then
      Assert.Equal(_wholesalerService.GetWholesalers().Length, initialWholesalerLength + 1);
    }
    
  }
}

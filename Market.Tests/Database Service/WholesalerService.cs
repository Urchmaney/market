using System;
using Microsoft.EntityFrameworkCore;
using Market.Interfaces.DataService;
using Market.DataService;
using Market.Models;
using Xunit;

namespace Market.Tests.DatabaseService
{
  public class WholesalerServiceTest
  {
    private readonly IWholesalerService _wholesalerService;
    public WholesalerServiceTest(){
      var option = new DbContextOptionsBuilder<MarketDbContext>().UseInMemoryDatabase(databaseName: "Market").Options;
      var marketContext = new MarketDbContext(option);
      _wholesalerService = new WholesalerService(marketContext);
    }

    [Fact]
    public async void Add_Wholesaler_IncrementDatabaseTable()
    {
      //Given
      var initialWholesalerLength =await _wholesalerService.GetWholesalers().CountAsync();
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
      Assert.Equal(await _wholesalerService.GetWholesalers().CountAsync(), initialWholesalerLength + 1);
    }
    
  }
}

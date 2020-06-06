using System;

namespace Market.DistributorProduct {
  public class DistributorProduct {
    public int Id { get; set; }
    public int DistributorId { get; set; }
    public int ProductId { get; set; }
    public double UnitPrice { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
  }
}
using System;

namespace Market.Invoice {
  public class Invoice {
    public int Id { get; set; }
    public string TransactionId { get; set; }
    public int ClientId { get; set; }
    public int DistributorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
  }
}
using System;

namespace Market.Invoice {
  public class Invoice {
    public int Id { get; set; }
    public string TransactionId { get; set; }
    public int RetailerId { get; set; }
    public int WholesalerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
  }
}
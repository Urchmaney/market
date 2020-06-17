using System;

namespace Market.Models {
  public class InvoiceProduct {
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int InvoiceId { get; set; }
    public string TransactionId { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
  }
}
using System;

namespace Market.Product{
  public class Product {
    public int Id { get; set; }
    public string MedicalName { get; set; }
    public string CompanyName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
  }
}
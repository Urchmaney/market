using System;
using System.ComponentModel.DataAnnotations;

namespace Market.Models {
  public class Wholesaler{
    public int Id { get; set; }
    [Required]
    public string CompanyName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
  }
}
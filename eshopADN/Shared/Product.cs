using System.ComponentModel.DataAnnotations.Schema;

namespace eshopADN.Shared;

public class Product
{
    public int Id { get; set; }
    public string Titolo { get; set; } = string.Empty;
    public string Descrizione { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
    public Category? Category { get; set; }
    public int CategoryId { get; set; }
    public List<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
}
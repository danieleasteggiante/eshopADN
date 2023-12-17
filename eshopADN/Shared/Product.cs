using System.ComponentModel.DataAnnotations.Schema;

namespace eshopADN.Shared;

public class Product
{
    public int Id { get; set; }
    public string Titolo { get; set; } = string.Empty;
    public string Descrizione { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    [Column (TypeName = "decimal(18,2)")]
    public decimal Prezzo { get; set; }
    public bool IsAvailable { get; set; }
    public Category? Category { get; set; }
    public int CategoryId { get; set; }
}
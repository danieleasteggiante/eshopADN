namespace eshopADN.Shared;

public class Product
{
    public int Id { get; set; }
    public string Titolo { get; set; } = string.Empty;
    public string Descrizione { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public decimal Prezzo { get; set; }
}
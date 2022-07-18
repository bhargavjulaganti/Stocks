namespace Stocks.Api;

public class Stocks
{
    public string? StockName { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime SoldDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
}

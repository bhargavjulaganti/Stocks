using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Api.Models.Entity;

[Table("StockPositions")]
public class StockPositions
{
    [Key]
    [Column("StockName")]
    public string StockName { get; set; }
}
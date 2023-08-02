using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stocks.Api.Models.Entity;

[Table("DividendRecords")]
public class DividendRecords
{
    [Key]
    [Column("DividendId")]
    public int DividendId { get; set; }
    
    [Column("StockName")]
    public string StockName { get; set; }

    [Column("DividendReceivedPerStock")]
    public decimal DividendReceivedPerStock { get; set; }

    [Column("NoOfShares")]
    public decimal NoOfShares { get; set; }

    [Column("TotalAmount")]
    public decimal TotalAmount { get; set; }

    [Column("ReceivedDate")]
    public DateTime ReceivedDate { get; set; }

    [Column("MemberId")]
    public string MemberId { get; set; }
    
}
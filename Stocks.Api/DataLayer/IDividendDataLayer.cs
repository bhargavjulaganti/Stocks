using Stocks.Api.Models.Entity;

namespace Stocks.Api.DataLayer;

public interface IDividendDataLayer
{
    IAsyncEnumerable<Models.Entity.DividendRecords> RetrieveDividends(string stockName);
    IQueryable<DividendRecords> RetrieveAllDividendRecords();
}
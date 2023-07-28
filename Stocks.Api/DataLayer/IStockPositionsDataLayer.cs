namespace Stocks.Api.DataLayer;

public interface IStockPositionsDataLayer
{
    Task CreateStockPosition(string stockName);
}
using DefaultNamespace;

namespace Stocks.Api.DataLayer;

public class StockPositionsDataLayer : IStockPositionsDataLayer
{
    private readonly StocksDbContext _context;

    public StockPositionsDataLayer(StocksDbContext stocksDbContext)
    {
        _context = stocksDbContext;
    }
    
    public async Task CreateStockPosition(string stockName)
    {
        try
        {
            var StockName = new Models.Entity.StockPositions
            {
                StockName = stockName
            };

            _context.StockPositions.Add(StockName);

            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
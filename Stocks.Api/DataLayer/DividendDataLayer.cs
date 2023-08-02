using DefaultNamespace;
using Microsoft.EntityFrameworkCore;
using Stocks.Api.Models.Entity;

namespace Stocks.Api.DataLayer;

public class DividendDataLayer : IDividendDataLayer
{
    private readonly StocksDbContext _context;

    public DividendDataLayer(StocksDbContext stocksDbContext)
    {
        _context = stocksDbContext;
    }
    
    public IAsyncEnumerable<Models.Entity.DividendRecords> RetrieveDividends(string stockName)
    {
        try
        {
            var data =  _context.DividendRecords.Where(x => x.StockName == stockName).AsAsyncEnumerable();
            
            return data;

            // var myData = data.GetAsyncEnumerator().Current.TotalAmount;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        //return null;
    }
    
    public IQueryable<DividendRecords> RetrieveAllDividendRecords()
    {
        try
        {
            // LINQ query to select all records from the table
            /*var data = from record in _context.DividendRecords
                select record;*/

            var data = _context.DividendRecords.AsNoTracking().Where(x => x.DividendId < 12);
            
            // Process retrieved data
            foreach (var record in data)
            {
                Console.WriteLine($"Id: {record.DividendId}, Name: {record.StockName}");
                // Output other properties as needed
            }
            
            return data;

            // var myData = data.GetAsyncEnumerator().Current.TotalAmount;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        //return null;
    }
}
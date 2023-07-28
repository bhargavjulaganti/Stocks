using Microsoft.EntityFrameworkCore.Storage;

namespace Stocks.Api.DataLayer.Context;

public interface IStocksDbContext
{
    Task<IDbContextTransaction> BeginTransactionAsync();
}
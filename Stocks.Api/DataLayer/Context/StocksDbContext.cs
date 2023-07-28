using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Stocks.Api.DataLayer.Context;
using Stocks.Api.Models.Entity;

namespace DefaultNamespace;

public class StocksDbContext : DbContext, IStocksDbContext
{
    public StocksDbContext([NotNull] DbContextOptions options) : base(options)
    {}

    public Task<IDbContextTransaction> BeginTransactionAsync()
    {
        return Database.BeginTransactionAsync();
    }

    public DbSet<StockPositions> StockPositions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StockPositions>()
            .HasKey(stockPositions => new { stockPositions.StockName });
    }
}
using Microsoft.EntityFrameworkCore;

class TestDB : DbContext
{
    public TestDB(DbContextOptions<TestDB> options)
        : base(options) { }

    public DbSet<Beholdning> Beholdning => Set<Beholdning>();
    public DbSet<ProductData> ProductData => Set<ProductData>();
}
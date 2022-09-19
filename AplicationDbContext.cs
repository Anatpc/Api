using Microsoft.EntityFrameworkCore;

public class AplicationDbContext : DbContext{
    public DbSet<Product> Products {get; set;}

    public AplicationDbContext(DbContextOptions<AplicationDbContext> opitions) : base(opitions){

    }

    protected override void OnModelCreating(ModelBuilder builder){
        builder.Entity<Product>()
            .Property(p => p.Description).HasMaxLength(500).IsRequired(false);
        builder.Entity<Product>()
            .Property(p => p.Name).HasMaxLength(120).IsRequired();
        builder.Entity<Product>()
            .Property(p => p.Code).HasMaxLength(20).IsRequired();
    }

}
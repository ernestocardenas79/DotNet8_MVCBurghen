using Microsoft.EntityFrameworkCore;
using dn8mvc.web.Models;

namespace dn8mvc.web.Data;
public class ApplicationContext: DbContext{

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema("blk");
        modelBuilder.Entity<Category>().HasData(
            new Category{Id=1, Name="Acton", DisplayOrder="1"},
            new Category{Id=2, Name="Scify", DisplayOrder="2"},
            new Category{Id=3, Name="History", DisplayOrder="3"}
            );
    }

    
    public DbSet<Category> Categories { get; set; }
}
using Microsoft.EntityFrameworkCore;

namespace FreeCourse.Services.Order.Infrastructure
{
    public class OrderDbContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "ordering";

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }

        public DbSet<Domain.Order> Orders { get; set; }
        public DbSet<Domain.OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Domain.Order>().ToTable("Orders", DEFAULT_SCHEMA);
            modelBuilder.Entity<Domain.OrderItem>().ToTable("OrderItems", DEFAULT_SCHEMA);

            modelBuilder.Entity<Domain.OrderItem>().Property(x => x.Price).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Domain.Order>().OwnsOne(o => o.Address).WithOwner();

            base.OnModelCreating(modelBuilder);
        }
    }
}

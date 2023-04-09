namespace happykids.Helpers;

using Microsoft.EntityFrameworkCore;
using happykids.Entities;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(e=> new {e.custID});
            modelBuilder.Entity<Basket>().HasKey(e=> new {e.custID , e.productDetailID});
            modelBuilder.Entity<StroedProduct>().HasNoKey();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to mysql with connection string from app settings
        var connectionString = Configuration.GetConnectionString("WebApiDatabase");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    public DbSet<Category> Category { get; set; }
    public DbSet<Color> Color { get; set; }
    public DbSet<Size> Size { get; set; }

    public DbSet<Product> Product { get; set; }
    public DbSet<ProductColor> ProductColor { get; set; }
    public DbSet<ProductDetail> ProductDetail { get; set; }
    public DbSet<StroedProduct> GetProductAll { get; set; }

    public DbSet<Basket> Basket { get; set; }

    
    public DbSet<Customer> Customer { get; set; }


        public virtual List<StroedProduct> SpGetProductAll()
        {
            var result = Set<StroedProduct>().FromSqlRaw("Call GetProductAll()").ToList();
            return result;
        }
}

   /* public partial class YourStoredProcedureDbContext : YourDbContext
    {
        public YourStoredProcedureDbContext(DbContextOptions<YourStoredProcedureDbContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SalesOrderResult>().HasNoKey();
            modelBuilder.Entity<SalesReceiptResult>().HasNoKey();
        }

        public virtual DbSet<SalesOrderResult> SalesOrderResult { get; set; } = null!;
        public virtual DbSet<SalesReceiptResult> SalesReceiptResult { get; set; } = null!;

        public virtual List<SalesOrderResult> SpSalesOrderV3(string find, int top)
        {
            object[] parameters = {
                    new MySqlParameter("find",  find),
                    new MySqlParameter("top",  top),
                };

            var result = Set<SalesOrderResult>().FromSqlRaw("Call sp_sales_order_v3(@find,@top)", parameters).ToList();
            return result;
        }

        public virtual async Task<List<SalesReceiptResult>> SpSalesReceiptV1Async(string drNosRegEx)
        {
            object[] parameters = {
                    new MySqlParameter("drNosRegEx",  drNosRegEx)
                };

            var result = await Set<SalesReceiptResult>().FromSqlRaw("Call sp_sales_receipt_v1(@drNosRegEx)", parameters).ToListAsync();
            return result;
        }
    */
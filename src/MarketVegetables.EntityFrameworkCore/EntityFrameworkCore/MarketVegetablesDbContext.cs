using MarketVegetables.Categories;
using MarketVegetables.OrderDetails;
using MarketVegetables.Orders;
using MarketVegetables.Products;
using MarketVegetables.Units;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace MarketVegetables.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class MarketVegetablesDbContext :
    AbpDbContext<MarketVegetablesDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }


    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public MarketVegetablesDbContext(DbContextOptions<MarketVegetablesDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.Entity<Category>(b =>
        {
            b.ToTable(MarketVegetablesConsts.DbTablePrefix + "Categories", MarketVegetablesConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.CategoryName).IsRequired().HasMaxLength(200);
        });

        builder.Entity<Unit>(b =>
        {
            b.ToTable(MarketVegetablesConsts.DbTablePrefix + "Units", MarketVegetablesConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.UnitName).IsRequired().HasMaxLength(50);
        });

        builder.Entity<Product>(b =>
        {
            b.ToTable(MarketVegetablesConsts.DbTablePrefix + "Products", MarketVegetablesConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.CategoryId).IsRequired();
            b.Property(x => x.UnitId).IsRequired();
            b.Property(x => x.ProductName).IsRequired().HasMaxLength(200);
            b.Property(x => x.ProductAmount).IsRequired();
            b.Property(x => x.ProductPrice).IsRequired();
        });
        builder.Entity<Order>(b =>
        {
            b.ToTable(MarketVegetablesConsts.DbTablePrefix + "Orders", MarketVegetablesConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.UserId).IsRequired();
            b.Property(x => x.Created).IsRequired();
            b.Property(x => x.TotalBill).IsRequired();
            b.Property(x => x.OrderDeliverDate).IsRequired();
        });

        builder.Entity<OrderDetail>(b =>
        {
            b.ToTable(MarketVegetablesConsts.DbTablePrefix + "OrderDetails", MarketVegetablesConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.ProductId).IsRequired();
            b.Property(x => x.OrderId).IsRequired();
            b.Property(x => x.ProductName).IsRequired().HasMaxLength(200);
            b.Property(x => x.ProductPrice).IsRequired();
            b.Property(x => x.Amount).IsRequired();
        });
    }
}

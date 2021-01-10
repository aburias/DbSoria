using DbSoria.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DbSoria.Data.DbContexts
{
    public class DbSoriaContext : DbContext
    {
        public DbSoriaContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSoriaContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=DbSoriaData;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<AccessPermision> AccessPermisions { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountAddress> AccountAddresses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<File> Files { get; set; }
        public LoginDetail LoginDetail { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderAddOn> OrderAddOns { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public OrderPaymentDetail OrderPaymentDetail { get; set; }
        public OrderShippingStatus OrderShippingStatus { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAddOn> ProductAddOns { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductSection> ProductSections { get; set; }
        public DbSet<ProductSectionType> ProductSectionTypes { get; set; }
        public DbSet<ProductVariation> ProductVariations { get; set; }
        public DbSet<ProductVariationGroup> ProductVariationGroups { get; set; }
        public DbSet<ProductVariationPrice> ProductVariationPrices { get; set; }
        public DbSet<ProductVariationPriceVariationId> ProductVariationPriceVariationIds { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreInvite> StoreInvites { get; set; }
        public DbSet<StoreMarketing> StoreMarketings { get; set; }
        public DbSet<StoreStaff> StoreStaves { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplateType> TemplateTypes { get; set; }
        public DbSet<UpdateHistory> UpdateHistories { get; set; }

    }
}
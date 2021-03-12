using CloudBar.Domain.General;
using CloudBar.Domain.Purchase;
using CloudBar.Domain.Sale;
using CloudBar.Domain.Security;
using CloudBar.Domain.Warehouse;
using Microsoft.EntityFrameworkCore;
using System;

namespace CloudBar.DataAccess
{
    public class CloudBarDBContext : DbContext
    {
        public CloudBarDBContext(DbContextOptions<CloudBarDBContext> options) : base(options)
        {
        }

        #region Security
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion

        #region General
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Person> People { get; set; }
        #endregion

        #region Purchase
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierItem> SupplierItems { get; set; }
        #endregion

        #region Sale
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceLine> InvoiceLines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        #endregion

        #region Warehouse
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        #endregion
    }
}

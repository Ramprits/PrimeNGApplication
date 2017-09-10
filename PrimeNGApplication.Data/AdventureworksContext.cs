using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PrimeNGApplication.Data
{
    public partial class AdventureworksContext : DbContext
    {
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<AwbuildVersion> AwbuildVersion { get; set; }
        public virtual DbSet<BillOfMaterials> BillOfMaterials { get; set; }
        public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
        public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<CountryRegion> CountryRegion { get; set; }
        public virtual DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<Culture> Culture { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<DemoSalesOrderDetailSeed> DemoSalesOrderDetailSeed { get; set; }
        public virtual DbSet<DemoSalesOrderHeaderSeed> DemoSalesOrderHeaderSeed { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<EmailAddress> EmailAddress { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public virtual DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
        public virtual DbSet<EmployeeTemporal> EmployeeTemporal { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Illustration> Illustration { get; set; }
        public virtual DbSet<JobCandidate> JobCandidate { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<OrderTracking> OrderTracking { get; set; }
        public virtual DbSet<Password> Password { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual DbSet<PersonJson> PersonJson { get; set; }
        public virtual DbSet<PersonPhone> PersonPhone { get; set; }
        public virtual DbSet<PersonTemporal> PersonTemporal { get; set; }
        public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }
        public virtual DbSet<ProductDescription> ProductDescription { get; set; }
        public virtual DbSet<ProductInmem> ProductInmem { get; set; }
        public virtual DbSet<ProductInventory> ProductInventory { get; set; }
        public virtual DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }
        public virtual DbSet<ProductModel> ProductModel { get; set; }
        public virtual DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }
        public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
        public virtual DbSet<ProductOndisk> ProductOndisk { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
        public virtual DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }
        public virtual DbSet<ProductSubcategory> ProductSubcategory { get; set; }
        public virtual DbSet<ProductVendor> ProductVendor { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public virtual DbSet<SalesOrderDetailInmem> SalesOrderDetailInmem { get; set; }
        public virtual DbSet<SalesOrderDetailOndisk> SalesOrderDetailOndisk { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual DbSet<SalesOrderHeaderInmem> SalesOrderHeaderInmem { get; set; }
        public virtual DbSet<SalesOrderHeaderOndisk> SalesOrderHeaderOndisk { get; set; }
        public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
        public virtual DbSet<SalesOrderJson> SalesOrderJson { get; set; }
        public virtual DbSet<SalesPerson> SalesPerson { get; set; }
        public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        public virtual DbSet<SalesReason> SalesReason { get; set; }
        public virtual DbSet<SalesTaxRate> SalesTaxRate { get; set; }
        public virtual DbSet<SalesTerritory> SalesTerritory { get; set; }
        public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public virtual DbSet<ScrapReason> ScrapReason { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<ShipMethod> ShipMethod { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<SpecialOffer> SpecialOffer { get; set; }
        public virtual DbSet<SpecialOfferInmem> SpecialOfferInmem { get; set; }
        public virtual DbSet<SpecialOfferOndisk> SpecialOfferOndisk { get; set; }
        public virtual DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
        public virtual DbSet<SpecialOfferProductInmem> SpecialOfferProductInmem { get; set; }
        public virtual DbSet<SpecialOfferProductOndisk> SpecialOfferProductOndisk { get; set; }
        public virtual DbSet<StateProvince> StateProvince { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<TrackingEvent> TrackingEvent { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }
        public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }
        public virtual DbSet<UnitMeasure> UnitMeasure { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }
        public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=AdventureWorks;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Address_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.StateProvinceId)
                    .HasName("IX_Address_StateProvinceID");

                entity.HasIndex(e => new { e.AddressLine1, e.AddressLine2, e.City, e.StateProvinceId, e.PostalCode })
                    .HasName("IX_Address_AddressLine1_AddressLine2_City_StateProvinceID_PostalCode")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_AddressType_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_AddressType_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<AwbuildVersion>(entity =>
            {
                entity.HasKey(e => e.SystemInformationId)
                    .HasName("PK_AWBuildVersion_SystemInformationID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<BillOfMaterials>(entity =>
            {
                entity.HasIndex(e => e.UnitMeasureCode)
                    .HasName("IX_BillOfMaterials_UnitMeasureCode");

                entity.HasIndex(e => new { e.ProductAssemblyId, e.ComponentId, e.StartDate })
                    .HasName("AK_BillOfMaterials_ProductAssemblyID_ComponentID_StartDate")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.PerAssemblyQty).HasDefaultValueSql("1.00");

                entity.Property(e => e.StartDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<BusinessEntity>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_BusinessEntity_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<BusinessEntityAddress>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.AddressId, e.AddressTypeId })
                    .HasName("PK_BusinessEntityAddress_BusinessEntityID_AddressID_AddressTypeID");

                entity.HasIndex(e => e.AddressId)
                    .HasName("IX_BusinessEntityAddress_AddressID");

                entity.HasIndex(e => e.AddressTypeId)
                    .HasName("IX_BusinessEntityAddress_AddressTypeID");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_BusinessEntityAddress_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<BusinessEntityContact>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.PersonId, e.ContactTypeId })
                    .HasName("PK_BusinessEntityContact_BusinessEntityID_PersonID_ContactTypeID");

                entity.HasIndex(e => e.ContactTypeId)
                    .HasName("IX_BusinessEntityContact_ContactTypeID");

                entity.HasIndex(e => e.PersonId)
                    .HasName("IX_BusinessEntityContact_PersonID");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_BusinessEntityContact_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ContactType_Name")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<CountryRegion>(entity =>
            {
                entity.HasKey(e => e.CountryRegionCode)
                    .HasName("PK_CountryRegion_CountryRegionCode");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_CountryRegion_Name")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<CountryRegionCurrency>(entity =>
            {
                entity.HasKey(e => new { e.CountryRegionCode, e.CurrencyCode })
                    .HasName("PK_CountryRegionCurrency_CountryRegionCode_CurrencyCode");

                entity.HasIndex(e => e.CurrencyCode)
                    .HasName("IX_CountryRegionCurrency_CurrencyCode");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.HasIndex(e => e.CardNumber)
                    .HasName("AK_CreditCard_CardNumber")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Culture>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Culture_Name")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode)
                    .HasName("PK_Currency_CurrencyCode");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_Currency_Name")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<CurrencyRate>(entity =>
            {
                entity.HasIndex(e => new { e.CurrencyRateDate, e.FromCurrencyCode, e.ToCurrencyCode })
                    .HasName("AK_CurrencyRate_CurrencyRateDate_FromCurrencyCode_ToCurrencyCode")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.AccountNumber)
                    .HasName("AK_Customer_AccountNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Customer_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.TerritoryId)
                    .HasName("IX_Customer_TerritoryID");

                entity.Property(e => e.AccountNumber)
                    .HasComputedColumnSql("isnull('AW'+[dbo].[ufnLeadingZeros]([CustomerID]),'')")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<DemoSalesOrderDetailSeed>(entity =>
            {
                entity.HasKey(e => e.LocalId)
                    .HasName("PK__DemoSale__499359DA37DC4424");

                entity.HasIndex(e => e.OrderId)
                    .HasName("IX_OrderID");
            });

            modelBuilder.Entity<DemoSalesOrderHeaderSeed>(entity =>
            {
                entity.HasKey(e => e.LocalId)
                    .HasName("PK__DemoSale__499359DA31897820");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Department_Name")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<EmailAddress>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.EmailAddressId })
                    .HasName("PK_EmailAddress_BusinessEntityID_EmailAddressID");

                entity.HasIndex(e => e.EmailAddress1)
                    .HasName("IX_EmailAddress_EmailAddress");

                entity.Property(e => e.EmailAddressId).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Employee_BusinessEntityID");

                entity.HasIndex(e => e.LoginId)
                    .HasName("AK_Employee_LoginID")
                    .IsUnique();

                entity.HasIndex(e => e.NationalIdnumber)
                    .HasName("AK_Employee_NationalIDNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Employee_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId).ValueGeneratedNever();

                entity.Property(e => e.CurrentFlag).HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.OrganizationLevel)
                    .HasComputedColumnSql("[OrganizationNode].[GetLevel]()")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");

                entity.Property(e => e.SalariedFlag).HasDefaultValueSql("1");

                entity.Property(e => e.SickLeaveHours).HasDefaultValueSql("0");

                entity.Property(e => e.VacationHours).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EmployeeDepartmentHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.StartDate, e.DepartmentId, e.ShiftId })
                    .HasName("PK_EmployeeDepartmentHistory_BusinessEntityID_StartDate_DepartmentID");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_EmployeeDepartmentHistory_DepartmentID");

                entity.HasIndex(e => e.ShiftId)
                    .HasName("IX_EmployeeDepartmentHistory_ShiftID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<EmployeePayHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.RateChangeDate })
                    .HasName("PK_EmployeePayHistory_BusinessEntityID_RateChangeDate");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<EmployeeTemporal>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Employee_History_BusinessEntityID");

                entity.Property(e => e.BusinessEntityId).ValueGeneratedNever();

                entity.Property(e => e.OrganizationLevel)
                    .HasComputedColumnSql("[OrganizationNode].[GetLevel]()")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.Property(e => e.ErrorTime).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Illustration>(entity =>
            {
                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<JobCandidate>(entity =>
            {
                entity.HasIndex(e => e.BusinessEntityId)
                    .HasName("IX_JobCandidate_BusinessEntityID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Location_Name")
                    .IsUnique();

                entity.Property(e => e.Availability).HasDefaultValueSql("0.00");

                entity.Property(e => e.CostRate).HasDefaultValueSql("0.00");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<OrderTracking>(entity =>
            {
                entity.HasIndex(e => e.CarrierTrackingNumber)
                    .HasName("IX_OrderTracking_CarrierTrackingNumber");

                entity.HasIndex(e => e.SalesOrderId)
                    .HasName("IX_OrderTracking_SalesOrderID");
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Password_BusinessEntityID");

                entity.Property(e => e.BusinessEntityId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Person_BusinessEntityID");

                entity.HasIndex(e => e.AdditionalContactInfo)
                    .HasName("PXML_Person_AddContact");

                entity.HasIndex(e => e.Demographics)
                    .HasName("XMLVALUE_Person_Demographics");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Person_rowguid")
                    .IsUnique();

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.MiddleName })
                    .HasName("IX_Person_LastName_FirstName_MiddleName");

                entity.Property(e => e.BusinessEntityId).ValueGeneratedNever();

                entity.Property(e => e.EmailPromotion).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.NameStyle).HasDefaultValueSql("0");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<PersonCreditCard>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.CreditCardId })
                    .HasName("PK_PersonCreditCard_BusinessEntityID_CreditCardID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<PersonJson>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("PK_Person_json_PersonID");

                entity.Property(e => e.EmailPromotion).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.NameStyle).HasDefaultValueSql("0");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<PersonPhone>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.PhoneNumber, e.PhoneNumberTypeId })
                    .HasName("PK_PersonPhone_BusinessEntityID_PhoneNumber_PhoneNumberTypeID");

                entity.HasIndex(e => e.PhoneNumber)
                    .HasName("IX_PersonPhone_PhoneNumber");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<PersonTemporal>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Person_Temporal_BusinessEntityID");

                entity.Property(e => e.BusinessEntityId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PhoneNumberType>(entity =>
            {
                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Product_Name")
                    .IsUnique();

                entity.HasIndex(e => e.ProductNumber)
                    .HasName("AK_Product_ProductNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Product_rowguid")
                    .IsUnique();

                entity.Property(e => e.FinishedGoodsFlag).HasDefaultValueSql("1");

                entity.Property(e => e.MakeFlag).HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductCategory_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductCategory_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<ProductCostHistory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StartDate })
                    .HasName("PK_ProductCostHistory_ProductID_StartDate");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<ProductDescription>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductDescription_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<ProductInmem>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("IMPK_Product_ProductID");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name");

                entity.HasIndex(e => e.ProductNumber)
                    .HasName("IX_ProductNumber");

                entity.Property(e => e.FinishedGoodsFlag).HasDefaultValueSql("1");

                entity.Property(e => e.MakeFlag).HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("sysdatetime()");
            });

            modelBuilder.Entity<ProductInventory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.LocationId })
                    .HasName("PK_ProductInventory_ProductID_LocationID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Quantity).HasDefaultValueSql("0");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<ProductListPriceHistory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StartDate })
                    .HasName("PK_ProductListPriceHistory_ProductID_StartDate");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.HasIndex(e => e.CatalogDescription)
                    .HasName("PXML_ProductModel_CatalogDescription");

                entity.HasIndex(e => e.Instructions)
                    .HasName("PXML_ProductModel_Instructions");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductModel_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductModel_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<ProductModelIllustration>(entity =>
            {
                entity.HasKey(e => new { e.ProductModelId, e.IllustrationId })
                    .HasName("PK_ProductModelIllustration_ProductModelID_IllustrationID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<ProductModelProductDescriptionCulture>(entity =>
            {
                entity.HasKey(e => new { e.ProductModelId, e.ProductDescriptionId, e.CultureId })
                    .HasName("PK_ProductModelProductDescriptionCulture_ProductModelID_ProductDescriptionID_CultureID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<ProductOndisk>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("ODPK_Product_ProductID");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name");

                entity.HasIndex(e => e.ProductNumber)
                    .HasName("IX_ProductNumber");

                entity.Property(e => e.FinishedGoodsFlag).HasDefaultValueSql("1");

                entity.Property(e => e.MakeFlag).HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("sysdatetime()");
            });

            modelBuilder.Entity<ProductPhoto>(entity =>
            {
                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<ProductProductPhoto>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductPhotoId })
                    .HasName("PK_ProductProductPhoto_ProductID_ProductPhotoID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Primary).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.HasIndex(e => new { e.Comments, e.ProductId, e.ReviewerName })
                    .HasName("IX_ProductReview_ProductID_Name");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.ReviewDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<ProductSubcategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductSubcategory_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductSubcategory_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<ProductVendor>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.BusinessEntityId })
                    .HasName("PK_ProductVendor_ProductID_BusinessEntityID");

                entity.HasIndex(e => e.BusinessEntityId)
                    .HasName("IX_ProductVendor_BusinessEntityID");

                entity.HasIndex(e => e.UnitMeasureCode)
                    .HasName("IX_ProductVendor_UnitMeasureCode");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<PurchaseOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.PurchaseOrderId, e.PurchaseOrderDetailId })
                    .HasName("PK_PurchaseOrderDetail_PurchaseOrderID_PurchaseOrderDetailID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_PurchaseOrderDetail_ProductID");

                entity.Property(e => e.PurchaseOrderDetailId).ValueGeneratedOnAdd();

                entity.Property(e => e.LineTotal)
                    .HasComputedColumnSql("isnull([OrderQty]*[UnitPrice],(0.00))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.StockedQty)
                    .HasComputedColumnSql("isnull([ReceivedQty]-[RejectedQty],(0.00))")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<PurchaseOrderHeader>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderId)
                    .HasName("PK_PurchaseOrderHeader_PurchaseOrderID");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_PurchaseOrderHeader_EmployeeID");

                entity.HasIndex(e => e.VendorId)
                    .HasName("IX_PurchaseOrderHeader_VendorID");

                entity.Property(e => e.Freight).HasDefaultValueSql("0.00");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.OrderDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.RevisionNumber).HasDefaultValueSql("0");

                entity.Property(e => e.Status).HasDefaultValueSql("1");

                entity.Property(e => e.SubTotal).HasDefaultValueSql("0.00");

                entity.Property(e => e.TaxAmt).HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalDue)
                    .HasComputedColumnSql("isnull(([SubTotal]+[TaxAmt])+[Freight],(0))")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<SalesOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderId, e.SalesOrderDetailId })
                    .HasName("PK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_SalesOrderDetail_ProductID");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesOrderDetail_rowguid")
                    .IsUnique();

                entity.Property(e => e.SalesOrderDetailId).ValueGeneratedOnAdd();

                entity.Property(e => e.LineTotal)
                    .HasComputedColumnSql("isnull(([UnitPrice]*((1.0)-[UnitPriceDiscount]))*[OrderQty],(0.0))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");

                entity.Property(e => e.UnitPriceDiscount).HasDefaultValueSql("0.0");
            });

            modelBuilder.Entity<SalesOrderDetailInmem>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderId, e.SalesOrderDetailId })
                    .HasName("imPK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductID");

                entity.HasIndex(e => e.SalesOrderId)
                    .HasName("IX_SalesOrderID");

                entity.Property(e => e.SalesOrderDetailId).ValueGeneratedOnAdd();

                entity.Property(e => e.UnitPriceDiscount).HasDefaultValueSql("0.0");
            });

            modelBuilder.Entity<SalesOrderDetailOndisk>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderId, e.SalesOrderDetailId })
                    .HasName("ODPK_SalesOrderDetail_SalesOrderID_SalesOrderDetailID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductID");

                entity.Property(e => e.SalesOrderDetailId).ValueGeneratedOnAdd();

                entity.Property(e => e.UnitPriceDiscount).HasDefaultValueSql("0.0");
            });

            modelBuilder.Entity<SalesOrderHeader>(entity =>
            {
                entity.HasKey(e => e.SalesOrderId)
                    .HasName("PK_SalesOrderHeader_SalesOrderID");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_SalesOrderHeader_CustomerID");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesOrderHeader_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.SalesOrderNumber)
                    .HasName("AK_SalesOrderHeader_SalesOrderNumber")
                    .IsUnique();

                entity.HasIndex(e => e.SalesPersonId)
                    .HasName("IX_SalesOrderHeader_SalesPersonID");

                entity.Property(e => e.Freight).HasDefaultValueSql("0.00");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.OnlineOrderFlag).HasDefaultValueSql("1");

                entity.Property(e => e.OrderDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.RevisionNumber).HasDefaultValueSql("0");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");

                entity.Property(e => e.SalesOrderNumber)
                    .HasComputedColumnSql("isnull(N'SO'+CONVERT([nvarchar](23),[SalesOrderID]),N'*** ERROR ***')")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Status).HasDefaultValueSql("1");

                entity.Property(e => e.SubTotal).HasDefaultValueSql("0.00");

                entity.Property(e => e.TaxAmt).HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalDue)
                    .HasComputedColumnSql("isnull(([SubTotal]+[TaxAmt])+[Freight],(0))")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<SalesOrderHeaderInmem>(entity =>
            {
                entity.HasKey(e => e.SalesOrderId)
                    .HasName("PK__SalesOrd__B14003C3270C320B");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerID");

                entity.HasIndex(e => e.SalesPersonId)
                    .HasName("IX_SalesPersonID");

                entity.Property(e => e.Freight).HasDefaultValueSql("0.00");

                entity.Property(e => e.OnlineOrderFlag).HasDefaultValueSql("1");

                entity.Property(e => e.RevisionNumber).HasDefaultValueSql("0");

                entity.Property(e => e.SalesPersonId).HasDefaultValueSql("-1");

                entity.Property(e => e.Status).HasDefaultValueSql("1");

                entity.Property(e => e.SubTotal).HasDefaultValueSql("0.00");

                entity.Property(e => e.TaxAmt).HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<SalesOrderHeaderOndisk>(entity =>
            {
                entity.HasKey(e => e.SalesOrderId)
                    .HasName("PK__SalesOrd__B14003C2B181FB70");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerID");

                entity.HasIndex(e => e.SalesPersonId)
                    .HasName("IX_SalesPersonID");

                entity.Property(e => e.Freight).HasDefaultValueSql("0.00");

                entity.Property(e => e.OnlineOrderFlag).HasDefaultValueSql("1");

                entity.Property(e => e.RevisionNumber).HasDefaultValueSql("0");

                entity.Property(e => e.SalesPersonId).HasDefaultValueSql("-1");

                entity.Property(e => e.Status).HasDefaultValueSql("1");

                entity.Property(e => e.SubTotal).HasDefaultValueSql("0.00");

                entity.Property(e => e.TaxAmt).HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<SalesOrderHeaderSalesReason>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderId, e.SalesReasonId })
                    .HasName("PK_SalesOrderHeaderSalesReason_SalesOrderID_SalesReasonID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<SalesOrderJson>(entity =>
            {
                entity.HasKey(e => e.SalesOrderId)
                    .HasName("PK_SalesOrder__json_SalesOrderID");

                entity.Property(e => e.SalesOrderId).ValueGeneratedNever();

                entity.Property(e => e.Freight).HasDefaultValueSql("0.00");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.OnlineOrderFlag).HasDefaultValueSql("1");

                entity.Property(e => e.OrderDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.RevisionNumber).HasDefaultValueSql("0");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");

                entity.Property(e => e.SalesOrderNumber)
                    .HasComputedColumnSql("isnull(N'SO'+CONVERT([nvarchar](23),[SalesOrderID]),N'*** ERROR ***')")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Status).HasDefaultValueSql("1");

                entity.Property(e => e.SubTotal).HasDefaultValueSql("0.00");

                entity.Property(e => e.TaxAmt).HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalDue)
                    .HasComputedColumnSql("isnull(([SubTotal]+[TaxAmt])+[Freight],(0))")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<SalesPerson>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_SalesPerson_BusinessEntityID");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesPerson_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId).ValueGeneratedNever();

                entity.Property(e => e.Bonus).HasDefaultValueSql("0.00");

                entity.Property(e => e.CommissionPct).HasDefaultValueSql("0.00");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");

                entity.Property(e => e.SalesLastYear).HasDefaultValueSql("0.00");

                entity.Property(e => e.SalesYtd).HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<SalesPersonQuotaHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.QuotaDate })
                    .HasName("PK_SalesPersonQuotaHistory_BusinessEntityID_QuotaDate");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesPersonQuotaHistory_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<SalesReason>(entity =>
            {
                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<SalesTaxRate>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesTaxRate_rowguid")
                    .IsUnique();

                entity.HasIndex(e => new { e.StateProvinceId, e.TaxType })
                    .HasName("AK_SalesTaxRate_StateProvinceID_TaxType")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");

                entity.Property(e => e.TaxRate).HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<SalesTerritory>(entity =>
            {
                entity.HasKey(e => e.TerritoryId)
                    .HasName("PK_SalesTerritory_TerritoryID");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_SalesTerritory_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesTerritory_rowguid")
                    .IsUnique();

                entity.Property(e => e.CostLastYear).HasDefaultValueSql("0.00");

                entity.Property(e => e.CostYtd).HasDefaultValueSql("0.00");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");

                entity.Property(e => e.SalesLastYear).HasDefaultValueSql("0.00");

                entity.Property(e => e.SalesYtd).HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<SalesTerritoryHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.StartDate, e.TerritoryId })
                    .HasName("PK_SalesTerritoryHistory_BusinessEntityID_StartDate_TerritoryID");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesTerritoryHistory_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<ScrapReason>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ScrapReason_Name")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Shift_Name")
                    .IsUnique();

                entity.HasIndex(e => new { e.StartTime, e.EndTime })
                    .HasName("AK_Shift_StartTime_EndTime")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<ShipMethod>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ShipMethod_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ShipMethod_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");

                entity.Property(e => e.ShipBase).HasDefaultValueSql("0.00");

                entity.Property(e => e.ShipRate).HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.HasIndex(e => new { e.ShoppingCartId, e.ProductId })
                    .HasName("IX_ShoppingCartItem_ShoppingCartID_ProductID");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("getdate()");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Quantity).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<SpecialOffer>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SpecialOffer_rowguid")
                    .IsUnique();

                entity.Property(e => e.DiscountPct).HasDefaultValueSql("0.00");

                entity.Property(e => e.MinQty).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<SpecialOfferInmem>(entity =>
            {
                entity.HasKey(e => e.SpecialOfferId)
                    .HasName("IMPK_SpecialOffer_SpecialOfferID");

                entity.Property(e => e.DiscountPct).HasDefaultValueSql("0.00");

                entity.Property(e => e.MinQty).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("sysdatetime()");
            });

            modelBuilder.Entity<SpecialOfferOndisk>(entity =>
            {
                entity.HasKey(e => e.SpecialOfferId)
                    .HasName("ODPK_SpecialOffer_SpecialOfferID");

                entity.Property(e => e.DiscountPct).HasDefaultValueSql("0.00");

                entity.Property(e => e.MinQty).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("sysdatetime()");
            });

            modelBuilder.Entity<SpecialOfferProduct>(entity =>
            {
                entity.HasKey(e => new { e.SpecialOfferId, e.ProductId })
                    .HasName("PK_SpecialOfferProduct_SpecialOfferID_ProductID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_SpecialOfferProduct_ProductID");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SpecialOfferProduct_rowguid")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<SpecialOfferProductInmem>(entity =>
            {
                entity.HasKey(e => new { e.SpecialOfferId, e.ProductId })
                    .HasName("IMPK_SpecialOfferProduct_SpecialOfferID_ProductID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("ix_ProductID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("sysdatetime()");
            });

            modelBuilder.Entity<SpecialOfferProductOndisk>(entity =>
            {
                entity.HasKey(e => new { e.SpecialOfferId, e.ProductId })
                    .HasName("ODPK_SpecialOfferProduct_SpecialOfferID_ProductID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("ix_ProductID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("sysdatetime()");
            });

            modelBuilder.Entity<StateProvince>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_StateProvince_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_StateProvince_rowguid")
                    .IsUnique();

                entity.HasIndex(e => new { e.StateProvinceCode, e.CountryRegionCode })
                    .HasName("AK_StateProvince_StateProvinceCode_CountryRegionCode")
                    .IsUnique();

                entity.Property(e => e.IsOnlyStateProvinceFlag).HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Store_BusinessEntityID");

                entity.HasIndex(e => e.Demographics)
                    .HasName("PXML_Store_Demographics");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Store_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.SalesPersonId)
                    .HasName("IX_Store_SalesPersonID");

                entity.Property(e => e.BusinessEntityId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<TransactionHistory>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_TransactionHistory_TransactionID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_TransactionHistory_ProductID");

                entity.HasIndex(e => new { e.ReferenceOrderId, e.ReferenceOrderLineId })
                    .HasName("IX_TransactionHistory_ReferenceOrderID_ReferenceOrderLineID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.ReferenceOrderLineId).HasDefaultValueSql("0");

                entity.Property(e => e.TransactionDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<TransactionHistoryArchive>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK_TransactionHistoryArchive_TransactionID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_TransactionHistoryArchive_ProductID");

                entity.HasIndex(e => new { e.ReferenceOrderId, e.ReferenceOrderLineId })
                    .HasName("IX_TransactionHistoryArchive_ReferenceOrderID_ReferenceOrderLineID");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.ReferenceOrderLineId).HasDefaultValueSql("0");

                entity.Property(e => e.TransactionDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<UnitMeasure>(entity =>
            {
                entity.HasKey(e => e.UnitMeasureCode)
                    .HasName("PK_UnitMeasure_UnitMeasureCode");

                entity.HasIndex(e => e.Name)
                    .HasName("AK_UnitMeasure_Name")
                    .IsUnique();

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId)
                    .HasName("PK_Vendor_BusinessEntityID");

                entity.HasIndex(e => e.AccountNumber)
                    .HasName("AK_Vendor_AccountNumber")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId).ValueGeneratedNever();

                entity.Property(e => e.ActiveFlag).HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.PreferredVendorStatus).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_WorkOrder_ProductID");

                entity.HasIndex(e => e.ScrapReasonId)
                    .HasName("IX_WorkOrder_ScrapReasonID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");

                entity.Property(e => e.StockedQty)
                    .HasComputedColumnSql("isnull([OrderQty]-[ScrappedQty],(0))")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<WorkOrderRouting>(entity =>
            {
                entity.HasKey(e => new { e.WorkOrderId, e.ProductId, e.OperationSequence })
                    .HasName("PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_WorkOrderRouting_ProductID");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("getdate()");
            });
        }
    }
}
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LeMai.Efs;

public partial class LeMaiDbContext : DbContext
{
    public LeMaiDbContext(DbContextOptions<LeMaiDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ExpCustomer> ExpCustomers { get; set; }

    public virtual DbSet<ExpPost> ExpPosts { get; set; }

    public virtual DbSet<GexpAccept> GexpAccepts { get; set; }

    public virtual DbSet<GexpBillStatus> GexpBillStatuses { get; set; }

    public virtual DbSet<GexpDistrict> GexpDistricts { get; set; }

    public virtual DbSet<GexpOrder> GexpOrders { get; set; }

    public virtual DbSet<GexpOrderStatus> GexpOrderStatuses { get; set; }

    public virtual DbSet<GexpProvince> GexpProvinces { get; set; }

    public virtual DbSet<GexpReceiveTask> GexpReceiveTasks { get; set; }

    public virtual DbSet<GexpReceiveTaskStatus> GexpReceiveTaskStatuses { get; set; }

    public virtual DbSet<GexpScan> GexpScans { get; set; }

    public virtual DbSet<GexpShipper> GexpShippers { get; set; }

    public virtual DbSet<GexpWard> GexpWards { get; set; }

    public virtual DbSet<ViewGexpBill> ViewGexpBills { get; set; }

    public virtual DbSet<ViewGexpBillDelivery> ViewGexpBillDeliveries { get; set; }

    public virtual DbSet<ViewGexpFeeDetail> ViewGexpFeeDetails { get; set; }

    public virtual DbSet<ViewGexpFeeDetailsPro> ViewGexpFeeDetailsPros { get; set; }

    public virtual DbSet<ViewGexpOrder> ViewGexpOrders { get; set; }

    public virtual DbSet<ViewGexpProblem> ViewGexpProblems { get; set; }

    public virtual DbSet<ViewGexpReceiveTask> ViewGexpReceiveTasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExpCustomer>(entity =>
        {
            entity.ToTable("ExpCustomer");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerCodePass).HasMaxLength(50);
            entity.Property(e => e.CustomerName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CustomerPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.DiaChi).HasMaxLength(250);
            entity.Property(e => e.DonVi).HasMaxLength(150);
            entity.Property(e => e.FkGiaCuoc)
                .HasMaxLength(50)
                .HasColumnName("FK_GiaCuoc");
            entity.Property(e => e.FkGroup)
                .HasMaxLength(50)
                .HasColumnName("FK_Group");
            entity.Property(e => e.FkPost)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Post");
            entity.Property(e => e.GoogleMap).HasMaxLength(4000);
            entity.Property(e => e.MaSoThue).HasMaxLength(50);
            entity.Property(e => e.NgayHopDong).HasColumnType("datetime");
            entity.Property(e => e.SecrectId).HasMaxLength(50);
            entity.Property(e => e.ShopIdpickup)
                .HasMaxLength(250)
                .HasColumnName("ShopIDPickup");
            entity.Property(e => e.SoHopDong).HasMaxLength(50);
            entity.Property(e => e.TenHopDong).HasMaxLength(50);
            entity.Property(e => e.TenSanPham).HasMaxLength(150);
            entity.Property(e => e.Token).HasMaxLength(150);
            entity.Property(e => e.UnsigName).HasMaxLength(250);
            entity.Property(e => e.WardId).HasMaxLength(50);
        });

        modelBuilder.Entity<ExpPost>(entity =>
        {
            entity.ToTable("ExpPost");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Cmnd)
                .HasMaxLength(50)
                .HasColumnName("CMND");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Codfee).HasColumnName("CODFee");
            entity.Property(e => e.CreateBy)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.DieuPhoi).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FkDvhc).HasColumnName("FK_DVHC");
            entity.Property(e => e.GoogleMap).HasMaxLength(500);
            entity.Property(e => e.Idlogin)
                .HasMaxLength(50)
                .HasColumnName("IDLogin");
            entity.Property(e => e.MaBuuCuc).HasMaxLength(50);
            entity.Property(e => e.NganHang).HasMaxLength(50);
            entity.Property(e => e.NgayCap).HasColumnType("datetime");
            entity.Property(e => e.ParrentPost).HasMaxLength(50);
            entity.Property(e => e.Pass).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.QuanLy).HasMaxLength(50);
            entity.Property(e => e.SdtcaNhan)
                .HasMaxLength(50)
                .HasColumnName("SDTCaNhan");
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.SoTaiKhoan).HasMaxLength(50);
            entity.Property(e => e.TenDaiLy)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ThuongTru).HasMaxLength(50);
            entity.Property(e => e.WebsiteCheckBill).HasMaxLength(250);
            entity.Property(e => e.ZoneCode)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<GexpAccept>(entity =>
        {
            entity.ToTable("GExpAccept");

            entity.HasIndex(e => e.AcceptPhone, "GExpAccept_AcceptPhone_IDX");

            entity.HasIndex(e => e.AcceptPhone, "NonClusteredIndex-20230519-213059");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AcceptAddress)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.AcceptAddressFull)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.AcceptMan)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptWard)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<GexpBillStatus>(entity =>
        {
            entity.ToTable("GExpBillStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.SelectNv).HasColumnName("SelectNV");
            entity.Property(e => e.StatusBackgroundColor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusTextColor)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<GexpDistrict>(entity =>
        {
            entity.HasKey(e => e.DistrictId);

            entity.ToTable("GExpDistrict");

            entity.Property(e => e.DistrictId)
                .ValueGeneratedNever()
                .HasColumnName("DistrictID");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.DistrictName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
        });

        modelBuilder.Entity<GexpOrder>(entity =>
        {
            entity.ToTable("GExpOrder");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.AcceptAddress)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AcceptName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Cod)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("COD");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DistrictWard).HasMaxLength(50);
            entity.Property(e => e.FkCustomerId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_CustomerId");
            entity.Property(e => e.FkShipperNot)
                .HasMaxLength(10)
                .HasColumnName("FK_ShipperNot");
            entity.Property(e => e.GoodsName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(150);
            entity.Property(e => e.OrderCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PickupDate).HasColumnType("datetime");
            entity.Property(e => e.PickupUser).HasMaxLength(50);
            entity.Property(e => e.TransferCode).HasMaxLength(50);
        });

        modelBuilder.Entity<GexpOrderStatus>(entity =>
        {
            entity.ToTable("GExpOrderStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.StatusBackgroundColor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusTextColor)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<GexpProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceId);

            entity.ToTable("GExpProvince");

            entity.Property(e => e.ProvinceId)
                .ValueGeneratedNever()
                .HasColumnName("ProvinceID");
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ProvinceName)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.Short).HasMaxLength(10);
            entity.Property(e => e.ZoneCode)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<GexpReceiveTask>(entity =>
        {
            entity.ToTable("GExpReceiveTask");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FkAccount)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Account");
            entity.Property(e => e.FkCustomerId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_CustomerId");
            entity.Property(e => e.FkPickupShipper)
                .HasMaxLength(50)
                .HasColumnName("FK_PickupShipper");
            entity.Property(e => e.FkPost)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Post");
            entity.Property(e => e.FkShipperId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_ShipperId");
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.PickupDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<GexpReceiveTaskStatus>(entity =>
        {
            entity.ToTable("GExpReceiveTaskStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.StatusReceiveName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<GexpScan>(entity =>
        {
            entity.ToTable("GExpScan");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.BillCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.KeyDate)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.NameCreate).HasMaxLength(50);
            entity.Property(e => e.Note)
                .IsRequired()
                .HasMaxLength(2000);
            entity.Property(e => e.Post)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.TypeScan)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.UserCreate)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<GexpShipper>(entity =>
        {
            entity.ToTable("GExpShipper");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.FkPost)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Post");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ShipperName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ShipperPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<GexpWard>(entity =>
        {
            entity.HasKey(e => e.WardId);

            entity.ToTable("GExpWard");

            entity.Property(e => e.WardId).HasMaxLength(50);
            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.DisplayValue).HasMaxLength(250);
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.SearchKey).HasMaxLength(150);
            entity.Property(e => e.WardName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<ViewGexpBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_GExpBill");

            entity.Property(e => e.AcceptDistrict)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AcceptMan)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptManAddress)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.AcceptManPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptManUs)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptProvince)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AcceptWard)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AcceptWardCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AddressPickup).HasMaxLength(150);
            entity.Property(e => e.BillCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.BillWeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Bt3cod)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("BT3COD");
            entity.Property(e => e.Bt3code)
                .HasMaxLength(50)
                .HasColumnName("BT3Code");
            entity.Property(e => e.Bt3codeSub)
                .HasMaxLength(50)
                .HasColumnName("BT3CodeSub");
            entity.Property(e => e.Bt3freight)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("BT3Freight");
            entity.Property(e => e.Bt3lastMess)
                .HasMaxLength(250)
                .HasColumnName("BT3LastMess");
            entity.Property(e => e.Bt3payType)
                .HasMaxLength(50)
                .HasColumnName("BT3PayType");
            entity.Property(e => e.Bt3status)
                .HasMaxLength(250)
                .HasColumnName("BT3Status");
            entity.Property(e => e.Bt3type)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("BT3Type");
            entity.Property(e => e.Cod)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("COD");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DistricPickup).HasMaxLength(50);
            entity.Property(e => e.FeeWeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FkCustomer)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Customer");
            entity.Property(e => e.FkPaymentType)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_PaymentType");
            entity.Property(e => e.FkProviderAccount)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_ProviderAccount");
            entity.Property(e => e.FkShipType)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_ShipType");
            entity.Property(e => e.Freight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FullAddress)
                .IsRequired()
                .HasMaxLength(1253);
            entity.Property(e => e.GoodsCode).HasMaxLength(150);
            entity.Property(e => e.GoodsName)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.GroupProvider)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateUser)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(250);
            entity.Property(e => e.PayCustomerDate).HasColumnType("datetime");
            entity.Property(e => e.PayType)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PaymentTypeName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PrintData).HasMaxLength(250);
            entity.Property(e => e.PrintLable).HasMaxLength(50);
            entity.Property(e => e.ProviderName)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.ProviderTypeCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ProvincePickup).HasMaxLength(50);
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.RegisterSiteCode)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.RegisterUser)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.SendMan)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.SendManAddress)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.SendManPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.SendManUs)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ShipNoteType)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ShipperPhoneNumber).HasMaxLength(50);
            entity.Property(e => e.ShopIdPickup).HasMaxLength(50);
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
            entity.Property(e => e.StatusBackgroundColor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusTextColor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
            entity.Property(e => e.WardPickup).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewGexpBillDelivery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_GExpBillDelivery");

            entity.Property(e => e.AcceptDistrict)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AcceptMan)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptManAddress)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.AcceptManPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptManUs)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptProvince)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AcceptWard)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AcceptWardCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.BillCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.BillWeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Bt3cod)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("BT3COD");
            entity.Property(e => e.Bt3code)
                .HasMaxLength(50)
                .HasColumnName("BT3Code");
            entity.Property(e => e.Bt3codeSub)
                .HasMaxLength(50)
                .HasColumnName("BT3CodeSub");
            entity.Property(e => e.Bt3freight)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("BT3Freight");
            entity.Property(e => e.Bt3lastMess)
                .HasMaxLength(250)
                .HasColumnName("BT3LastMess");
            entity.Property(e => e.Bt3payType)
                .HasMaxLength(50)
                .HasColumnName("BT3PayType");
            entity.Property(e => e.Bt3status)
                .HasMaxLength(250)
                .HasColumnName("BT3Status");
            entity.Property(e => e.Bt3type)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("BT3Type");
            entity.Property(e => e.Cod)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("COD");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.FeeWeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FkCustomer)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Customer");
            entity.Property(e => e.FkPaymentType)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_PaymentType");
            entity.Property(e => e.FkProviderAccount)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_ProviderAccount");
            entity.Property(e => e.FkShipType)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_ShipType");
            entity.Property(e => e.FkShipperId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_ShipperId");
            entity.Property(e => e.Freight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FullAddress)
                .IsRequired()
                .HasMaxLength(1253);
            entity.Property(e => e.GoodsCode).HasMaxLength(150);
            entity.Property(e => e.GoodsName)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.GroupProvider)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateUser)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(250);
            entity.Property(e => e.PayCustomerDate).HasColumnType("datetime");
            entity.Property(e => e.PayType)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PaymentTypeName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PrintLable).HasMaxLength(50);
            entity.Property(e => e.ProviderName)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.ProviderTypeCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.RegisterSiteCode)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.RegisterUser)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.SendMan)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.SendManAddress)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.SendManPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.SendManUs)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ShipNoteType)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ShipperPhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
            entity.Property(e => e.StatusBackgroundColor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusTextColor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewGexpFeeDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_GExpFeeDetails");

            entity.Property(e => e.FeeName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.FkGexpFee)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_GExpFee");
            entity.Property(e => e.FkPost)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Post");
            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.MinFeeMb).HasColumnName("MinFeeMB");
            entity.Property(e => e.MinFeeMn).HasColumnName("MinFeeMN");
            entity.Property(e => e.MinFeeMt).HasColumnName("MinFeeMT");
            entity.Property(e => e.MinWeightMb).HasColumnName("MinWeightMB");
            entity.Property(e => e.MinWeightMn).HasColumnName("MinWeightMN");
            entity.Property(e => e.MinWeightMt).HasColumnName("MinWeightMT");
            entity.Property(e => e.NextFeeMb).HasColumnName("NextFeeMB");
            entity.Property(e => e.NextFeeMn).HasColumnName("NextFeeMN");
            entity.Property(e => e.NextFeeMt).HasColumnName("NextFeeMT");
            entity.Property(e => e.StepWeightMb).HasColumnName("StepWeightMB");
            entity.Property(e => e.StepWeightMn).HasColumnName("StepWeightMN");
            entity.Property(e => e.StepWeightMt).HasColumnName("StepWeightMT");
        });

        modelBuilder.Entity<ViewGexpFeeDetailsPro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_GExpFeeDetailsPro");

            entity.Property(e => e.District)
                .IsRequired()
                .HasMaxLength(200);
            entity.Property(e => e.FeeName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.FkGexpFee)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_GExpFee");
            entity.Property(e => e.FkPost)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Post");
            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<ViewGexpOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_GExpOrder");

            entity.Property(e => e.AcceptAddress)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.AcceptName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Cod)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("COD");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CustomerPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.DistrictWard).HasMaxLength(50);
            entity.Property(e => e.FkCustomerId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_CustomerId");
            entity.Property(e => e.FkPost)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Post");
            entity.Property(e => e.GoodsName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(150);
            entity.Property(e => e.OrderCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PickupDate).HasColumnType("datetime");
            entity.Property(e => e.PickupUser).HasMaxLength(50);
            entity.Property(e => e.StatusBackgroundColor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusTextColor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.TransferCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewGexpProblem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_GExpProblem");

            entity.Property(e => e.AcceptMan)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptManPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.AcceptProvince)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.BillCode)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.BillWeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FeeWeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FkCustomer)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Customer");
            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.GoodsName)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Note)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.RegisterSiteCode)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.StatusBackgroundColor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusTextColor)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<ViewGexpReceiveTask>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_GExpReceiveTask");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.CustomerPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.DiaChi).HasMaxLength(250);
            entity.Property(e => e.FkAccount)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Account");
            entity.Property(e => e.FkCustomerId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_CustomerId");
            entity.Property(e => e.FkPickupShipper)
                .HasMaxLength(50)
                .HasColumnName("FK_PickupShipper");
            entity.Property(e => e.FkPost)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_Post");
            entity.Property(e => e.FkShipperId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("FK_ShipperId");
            entity.Property(e => e.GoogleMap).HasMaxLength(4000);
            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Note)
                .IsRequired()
                .HasMaxLength(500);
            entity.Property(e => e.Nvgiao)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("NVGiao");
            entity.Property(e => e.PickupDate).HasColumnType("datetime");
            entity.Property(e => e.ShipperName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ShipperPhone)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.StatusReceiveName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.TenDaiLy)
                .IsRequired()
                .HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

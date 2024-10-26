using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Noyan.Repository2.Models;

public partial class NoyanDbContext : DbContext
{
    public NoyanDbContext()
    {
    }

    public NoyanDbContext(DbContextOptions<NoyanDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sefactor> Sefactors { get; set; }

    public virtual DbSet<Vwsehesab> Vwsehesabs { get; set; }

    public virtual DbSet<Vwsewsgetinvoice> Vwsewsgetinvoices { get; set; }

    public virtual DbSet<Vwsewsgetproforma> Vwsewsgetproformas { get; set; }

    public virtual DbSet<Vwsewsgetreturninvoice> Vwsewsgetreturninvoices { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-IL7J9SU;Initial Catalog=ACCOUNT98;Integrated Security=True;Connect Timeout=3000;; Command Timeout=3000;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.Entity<Sefactor>(entity =>
        {
            entity.HasKey(e => e.IdFactor);

            entity.ToTable("sefactor");

            entity.HasIndex(e => e.Date, "IX_sefactor_date");

            entity.HasIndex(e => e.FactorNo, "IX_sefactor_factor_no");

            entity.HasIndex(e => e.HsbCtm, "IX_sefactor_hsb_ctm");

            entity.HasIndex(e => e.HsbdtlCtm, "IX_sefactor_hsbdtl_ctm");

            entity.HasIndex(e => e.IdBar, "IX_sefactor_id_bar");

            entity.HasIndex(e => e.IdBranch, "IX_sefactor_id_branch");

            entity.HasIndex(e => e.IdBrngrp, "IX_sefactor_id_brngrp");

            entity.HasIndex(e => e.IdForm, "IX_sefactor_id_form");

            entity.HasIndex(e => e.IdKoshtar, "IX_sefactor_id_koshtar");

            entity.HasIndex(e => e.IdOk, "IX_sefactor_id_ok");

            entity.HasIndex(e => e.IdPeriod, "IX_sefactor_id_period");

            entity.HasIndex(e => new { e.IdPeriod, e.IdForm, e.FactorNo, e.IdBranch }, "IX_sefactor_id_period_id_branch_id_form_factor_no").IsUnique();

            entity.HasIndex(e => new { e.IdBranch, e.IdBrngrp, e.IdPeriod, e.FactorNo, e.Date, e.IdFshtyp, e.HsbCtm, e.HsbdtlCtm }, "NonClusteredIndex-20180710-103952");

            entity.Property(e => e.IdFactor)
                .ValueGeneratedNever()
                .HasColumnName("id_factor");
            entity.Property(e => e.Adrstahvil)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("adrstahvil");
            entity.Property(e => e.BtnAnamfi).HasColumnName("btn_anamfi");
            entity.Property(e => e.BtnMerge1).HasColumnName("btn_merge1");
            entity.Property(e => e.BtnMerge2).HasColumnName("btn_merge2");
            entity.Property(e => e.BtnMerge3).HasColumnName("btn_merge3");
            entity.Property(e => e.BtnMerge4).HasColumnName("btn_merge4");
            entity.Property(e => e.Comment)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.CommentTo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment_to");
            entity.Property(e => e.Daryaft)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("daryaft");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("date");
            entity.Property(e => e.Dateetebar)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("dateetebar");
            entity.Property(e => e.Datetahvil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("datetahvil");
            entity.Property(e => e.FactNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fact_no");
            entity.Property(e => e.FactorNo).HasColumnName("factor_no");
            entity.Property(e => e.HsbBzr).HasColumnName("hsb_bzr");
            entity.Property(e => e.HsbCtm).HasColumnName("hsb_ctm");
            entity.Property(e => e.HsbTo).HasColumnName("hsb_to");
            entity.Property(e => e.HsbctmDes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("hsbctm_des");
            entity.Property(e => e.HsbdtlAnb).HasColumnName("hsbdtl_anb");
            entity.Property(e => e.HsbdtlBzr).HasColumnName("hsbdtl_bzr");
            entity.Property(e => e.HsbdtlCtm).HasColumnName("hsbdtl_ctm");
            entity.Property(e => e.HsbdtlTo).HasColumnName("hsbdtl_to");
            entity.Property(e => e.IdBar).HasColumnName("id_bar");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdFshtyp).HasColumnName("id_fshtyp");
            entity.Property(e => e.IdKoshtar).HasColumnName("id_koshtar");
            entity.Property(e => e.IdOk)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_ok");
            entity.Property(e => e.IdPeriod).HasColumnName("id_period");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.IndtUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_user");
            entity.Property(e => e.Posinfo)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("posinfo");
            entity.Property(e => e.Sabt).HasColumnName("sabt");
            entity.Property(e => e.Sendsms).HasColumnName("sendsms");
            entity.Property(e => e.Sharhsanad)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sharhsanad");
            entity.Property(e => e.Tasvieh).HasColumnName("tasvieh");
            entity.Property(e => e.Tavasot)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tavasot");
            entity.Property(e => e.TaxAfzpay)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tax_afzpay");
            entity.Property(e => e.TaxBillno)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("tax_billno");
            entity.Property(e => e.TaxErrno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tax_errno");
            entity.Property(e => e.TaxError)
                .IsUnicode(false)
                .HasColumnName("tax_error");
            entity.Property(e => e.TaxFcttas)
                .HasDefaultValue((byte)1)
                .HasColumnName("tax_fcttas");
            entity.Property(e => e.TaxFcttyp)
                .HasDefaultValue((byte)1)
                .HasColumnName("tax_fcttyp");
            entity.Property(e => e.TaxId)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("tax_id");
            entity.Property(e => e.TaxNaghd)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tax_naghd");
            entity.Property(e => e.TaxNasiye)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tax_nasiye");
            entity.Property(e => e.TaxRefno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tax_refno");
            entity.Property(e => e.TaxSentat)
                .HasColumnType("datetime")
                .HasColumnName("tax_sentat");
            entity.Property(e => e.TaxStatus).HasColumnName("tax_status");
            entity.Property(e => e.TaxUid).HasColumnName("tax_uid");
            entity.Property(e => e.Timetahvil)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("timetahvil");
        });

        modelBuilder.Entity<Vwsehesab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vwsehesab");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Aqsat).HasColumnName("aqsat");
            entity.Property(e => e.Birthdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("birthdate");
            entity.Property(e => e.Birthshahr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("birthshahr");
            entity.Property(e => e.Code)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("code");
            entity.Property(e => e.CodeComp)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("code_comp");
            entity.Property(e => e.CodeHsb)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("code_hsb");
            entity.Property(e => e.Codekala)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codekala");
            entity.Property(e => e.Codelength).HasColumnName("codelength");
            entity.Property(e => e.Codepost)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codepost");
            entity.Property(e => e.Comment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.Credit)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("credit");
            entity.Property(e => e.Credittype).HasColumnName("credittype");
            entity.Property(e => e.Darsad3).HasColumnName("darsad3");
            entity.Property(e => e.Eghtesadno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("eghtesadno");
            entity.Property(e => e.Enteghal).HasColumnName("enteghal");
            entity.Property(e => e.Father)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("father");
            entity.Property(e => e.FiForosh)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi_forosh");
            entity.Property(e => e.FiForosh1)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi_forosh1");
            entity.Property(e => e.FiForosh2)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi_forosh2");
            entity.Property(e => e.FiForosh3)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi_forosh3");
            entity.Property(e => e.FiKharid)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi_kharid");
            entity.Property(e => e.Fname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fname");
            entity.Property(e => e.Forceaqsat).HasColumnName("forceaqsat");
            entity.Property(e => e.Hesabno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hesabno");
            entity.Property(e => e.Hesabowner)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hesabowner");
            entity.Property(e => e.IdActive).HasColumnName("id_active");
            entity.Property(e => e.IdBank).HasColumnName("id_bank");
            entity.Property(e => e.IdBnkhtyp).HasColumnName("id_bnkhtyp");
            entity.Property(e => e.IdCtmtit).HasColumnName("id_ctmtit");
            entity.Property(e => e.IdCtmtyp).HasColumnName("id_ctmtyp");
            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.IdHsbdtl).HasColumnName("id_hsbdtl");
            entity.Property(e => e.IdHsbgrp).HasColumnName("id_hsbgrp");
            entity.Property(e => e.IdKalagrp).HasColumnName("id_kalagrp");
            entity.Property(e => e.IdSex).HasColumnName("id_sex");
            entity.Property(e => e.IdUnit).HasColumnName("id_unit");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");
            entity.Property(e => e.IdsHsb)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ids_hsb");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.Iskaladate).HasColumnName("iskaladate");
            entity.Property(e => e.Iskalasril).HasColumnName("iskalasril");
            entity.Property(e => e.KalHsb).HasColumnName("kal_hsb");
            entity.Property(e => e.KalHsbdtl).HasColumnName("kal_hsbdtl");
            entity.Property(e => e.KalHsbtyp).HasColumnName("kal_hsbtyp");
            entity.Property(e => e.KeyStr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("key_str");
            entity.Property(e => e.LevelHsb).HasColumnName("level_hsb");
            entity.Property(e => e.Lname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("lname");
            entity.Property(e => e.Machinetyp).HasColumnName("machinetyp");
            entity.Property(e => e.Mahal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mahal");
            entity.Property(e => e.Melino)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("melino");
            entity.Property(e => e.Mobile)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.NaAfter)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_after");
            entity.Property(e => e.NaBefore)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_before");
            entity.Property(e => e.NaCtmtit)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("na_ctmtit");
            entity.Property(e => e.NaHsbgrp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_hsbgrp");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NameComp)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("name_comp");
            entity.Property(e => e.NameHsb)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name_hsb");
            entity.Property(e => e.NameKol)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name_kol");
            entity.Property(e => e.Noanbar).HasColumnName("noanbar");
            entity.Property(e => e.ParHsbdtl).HasColumnName("par_hsbdtl");
            entity.Property(e => e.ParentHsb).HasColumnName("parent_hsb");
            entity.Property(e => e.ParentStr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("parent_str");
            entity.Property(e => e.PriceType).HasColumnName("price_type");
            entity.Property(e => e.Sefaresh)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("sefaresh");
            entity.Property(e => e.Shanasno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("shanasno");
            entity.Property(e => e.Shenase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("shenase");
            entity.Property(e => e.Shobecode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shobecode");
            entity.Property(e => e.Shobeh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("shobeh");
            entity.Property(e => e.Sodoor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("sodoor");
            entity.Property(e => e.Sodoordate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sodoordate");
            entity.Property(e => e.StrCode1)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("str_code1");
            entity.Property(e => e.StrCode2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("str_code2");
            entity.Property(e => e.StrKey)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("str_key");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Typemandeh).HasColumnName("typemandeh");
            entity.Property(e => e.Undercount).HasColumnName("undercount");
            entity.Property(e => e.Vazn)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("vazn");
            entity.Property(e => e.Vin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vin");
        });

        modelBuilder.Entity<Vwsewsgetinvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWsewsgetinvoice");

            entity.Property(e => e.Amount).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.AmountAfterDis).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.Count).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.CustomerCode).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Discount).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.Price).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.ProductCode).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.ProductId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Tax).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(15, 0)");
        });

        modelBuilder.Entity<Vwsewsgetproforma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWsewsgetproforma");

            entity.Property(e => e.Amount).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.AmountAfterDis).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.Count).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.CustomerCode).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Discount).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.Price).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.ProductCode).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.ProductId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Tax).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(15, 0)");
        });

        modelBuilder.Entity<Vwsewsgetreturninvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWsewsgetreturninvoice");

            entity.Property(e => e.Amount).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.AmountAfterDis).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.Count).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.CustomerCode).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Discount).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.Price).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.ProductCode).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.ProductId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Tax).HasColumnType("numeric(15, 0)");
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(15, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

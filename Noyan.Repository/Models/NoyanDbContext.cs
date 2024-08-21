using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Noyan.Repository.Models;

public partial class NoyanDbContext : DbContext
{
    public NoyanDbContext()
    {
    }

    public NoyanDbContext(DbContextOptions<NoyanDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Active> Actives { get; set; }

    public virtual DbSet<Advancefind> Advancefinds { get; set; }

    public virtual DbSet<Advancefindcolumn> Advancefindcolumns { get; set; }

    public virtual DbSet<Advanceresultfind> Advanceresultfinds { get; set; }

    public virtual DbSet<Advanceresultfindcolumn> Advanceresultfindcolumns { get; set; }

    public virtual DbSet<Advanceresultfindused> Advanceresultfinduseds { get; set; }

    public virtual DbSet<Baskol> Baskols { get; set; }

    public virtual DbSet<Camera> Cameras { get; set; }

    public virtual DbSet<Caption> Captions { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Clientsgroup> Clientsgroups { get; set; }

    public virtual DbSet<Clientsgroupdetail> Clientsgroupdetails { get; set; }

    public virtual DbSet<Educationlevel> Educationlevels { get; set; }

    public virtual DbSet<Find> Finds { get; set; }

    public virtual DbSet<Keyboardlayout> Keyboardlayouts { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<Madrak> Madraks { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Mobileregister> Mobileregisters { get; set; }

    public virtual DbSet<Nation> Nations { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<Ostan> Ostans { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Persondetail> Persondetails { get; set; }

    public virtual DbSet<Persondetailtype> Persondetailtypes { get; set; }

    public virtual DbSet<Persongroup> Persongroups { get; set; }

    public virtual DbSet<Persongroupdetail> Persongroupdetails { get; set; }

    public virtual DbSet<Personrelation> Personrelations { get; set; }

    public virtual DbSet<Persontype> Persontypes { get; set; }

    public virtual DbSet<Program> Programs { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Reportquery> Reportqueries { get; set; }

    public virtual DbSet<Reportsgroup> Reportsgroups { get; set; }

    public virtual DbSet<Reportsitem> Reportsitems { get; set; }

    public virtual DbSet<Reportsitemsdetail> Reportsitemsdetails { get; set; }

    public virtual DbSet<Reporttablesinfo> Reporttablesinfos { get; set; }

    public virtual DbSet<Reportuser> Reportusers { get; set; }

    public virtual DbSet<Seanboth> Seanboths { get; set; }

    public virtual DbSet<Seanbothdetail> Seanbothdetails { get; set; }

    public virtual DbSet<Seaqsat> Seaqsats { get; set; }

    public virtual DbSet<Seaqsatdetail> Seaqsatdetails { get; set; }

    public virtual DbSet<Sebank> Sebanks { get; set; }

    public virtual DbSet<Sebankhesabtype> Sebankhesabtypes { get; set; }

    public virtual DbSet<Sebarnameh> Sebarnamehs { get; set; }

    public virtual DbSet<SebarnamehMarkaz> SebarnamehMarkazs { get; set; }

    public virtual DbSet<Sebeton> Sebetons { get; set; }

    public virtual DbSet<Sebranch> Sebranches { get; set; }

    public virtual DbSet<Sebranchgroup> Sebranchgroups { get; set; }

    public virtual DbSet<Sebranchpermission> Sebranchpermissions { get; set; }

    public virtual DbSet<Sebranchuser> Sebranchusers { get; set; }

    public virtual DbSet<Secaption> Secaptions { get; set; }

    public virtual DbSet<Secheque> Secheques { get; set; }

    public virtual DbSet<Sechequeform> Sechequeforms { get; set; }

    public virtual DbSet<Sechequeformitem> Sechequeformitems { get; set; }

    public virtual DbSet<Sechequeitemstype> Sechequeitemstypes { get; set; }

    public virtual DbSet<Sechequepaper> Sechequepapers { get; set; }

    public virtual DbSet<Sechequestate> Sechequestates { get; set; }

    public virtual DbSet<Secollection> Secollections { get; set; }

    public virtual DbSet<Secollectiondetail> Secollectiondetails { get; set; }

    public virtual DbSet<Secustomertitle> Secustomertitles { get; set; }

    public virtual DbSet<Sedatainput> Sedatainputs { get; set; }

    public virtual DbSet<Sedatainputdetail> Sedatainputdetails { get; set; }

    public virtual DbSet<Sedataoutput> Sedataoutputs { get; set; }

    public virtual DbSet<Sedataoutputdetail> Sedataoutputdetails { get; set; }

    public virtual DbSet<Sefactor> Sefactors { get; set; }

    public virtual DbSet<Sefactorbarnameh> Sefactorbarnamehs { get; set; }

    public virtual DbSet<Sefactorbazaryab> Sefactorbazaryabs { get; set; }

    public virtual DbSet<Sefactorbeton> Sefactorbetons { get; set; }

    public virtual DbSet<Sefactordetail> Sefactordetails { get; set; }

    public virtual DbSet<Sefactordetailpallet> Sefactordetailpallets { get; set; }

    public virtual DbSet<Sefactorrel> Sefactorrels { get; set; }

    public virtual DbSet<Sefactorsanadrel> Sefactorsanadrels { get; set; }

    public virtual DbSet<Sefactorscale> Sefactorscales { get; set; }

    public virtual DbSet<Seform> Seforms { get; set; }

    public virtual DbSet<Seformsgroup> Seformsgroups { get; set; }

    public virtual DbSet<Seformshesab> Seformshesabs { get; set; }

    public virtual DbSet<Seformsrelation> Seformsrelations { get; set; }

    public virtual DbSet<Seformtype> Seformtypes { get; set; }

    public virtual DbSet<Seformtypepermission> Seformtypepermissions { get; set; }

    public virtual DbSet<Seformuser> Seformusers { get; set; }

    public virtual DbSet<Seforooshtype> Seforooshtypes { get; set; }

    public virtual DbSet<Sehesab> Sehesabs { get; set; }

    public virtual DbSet<Sehesabfield> Sehesabfields { get; set; }

    public virtual DbSet<Sehesabgroup> Sehesabgroups { get; set; }

    public virtual DbSet<Sehesabgroupdetail> Sehesabgroupdetails { get; set; }

    public virtual DbSet<Sehesabgroupfield> Sehesabgroupfields { get; set; }

    public virtual DbSet<Sehesabgrouptype> Sehesabgrouptypes { get; set; }

    public virtual DbSet<Sehesabgrouptypeconvert> Sehesabgrouptypeconverts { get; set; }

    public virtual DbSet<Sehesabgrouptypepermission> Sehesabgrouptypepermissions { get; set; }

    public virtual DbSet<Sehesabgroupuser> Sehesabgroupusers { get; set; }

    public virtual DbSet<Sehesablevel> Sehesablevels { get; set; }

    public virtual DbSet<Sehesablevelname> Sehesablevelnames { get; set; }

    public virtual DbSet<Sehesabmarkaz> Sehesabmarkazs { get; set; }

    public virtual DbSet<Sehesabparameter> Sehesabparameters { get; set; }

    public virtual DbSet<Sehesabparametersdetail> Sehesabparametersdetails { get; set; }

    public virtual DbSet<Sehesabparametersfield> Sehesabparametersfields { get; set; }

    public virtual DbSet<Sehesabparametersfielditem> Sehesabparametersfielditems { get; set; }

    public virtual DbSet<Sehesabparameterstype> Sehesabparameterstypes { get; set; }

    public virtual DbSet<Sehesabpermission> Sehesabpermissions { get; set; }

    public virtual DbSet<Sehesabtype> Sehesabtypes { get; set; }

    public virtual DbSet<Sehesabuser> Sehesabusers { get; set; }

    public virtual DbSet<Sehvlrsd> Sehvlrsds { get; set; }

    public virtual DbSet<Sehvlrsddetail> Sehvlrsddetails { get; set; }

    public virtual DbSet<Sehvlrsddetailpallet> Sehvlrsddetailpallets { get; set; }

    public virtual DbSet<Seiotype> Seiotypes { get; set; }

    public virtual DbSet<Sekalaformul> Sekalaformuls { get; set; }

    public virtual DbSet<Sekalagroup> Sekalagroups { get; set; }

    public virtual DbSet<Sekalaunit> Sekalaunits { get; set; }

    public virtual DbSet<Sekoshtar> Sekoshtars { get; set; }

    public virtual DbSet<Selabbetonazmooneh> Selabbetonazmoonehs { get; set; }

    public virtual DbSet<Selabbetonnemooneh> Selabbetonnemoonehs { get; set; }

    public virtual DbSet<Selabbetonnemoonehprint> Selabbetonnemoonehprints { get; set; }

    public virtual DbSet<Selabbetontemplate> Selabbetontemplates { get; set; }

    public virtual DbSet<Semarkaz> Semarkazs { get; set; }

    public virtual DbSet<Semarkazdetail> Semarkazdetails { get; set; }

    public virtual DbSet<Semarkazfield> Semarkazfields { get; set; }

    public virtual DbSet<Semarkazfielditem> Semarkazfielditems { get; set; }

    public virtual DbSet<Semarkaztype> Semarkaztypes { get; set; }

    public virtual DbSet<Seok> Seoks { get; set; }

    public virtual DbSet<Seperiod> Seperiods { get; set; }

    public virtual DbSet<Seperiodbranch> Seperiodbranches { get; set; }

    public virtual DbSet<Seperiodpermission> Seperiodpermissions { get; set; }

    public virtual DbSet<Seperioduser> Seperiodusers { get; set; }

    public virtual DbSet<Sepermission> Sepermissions { get; set; }

    public virtual DbSet<Serasidprintform> Serasidprintforms { get; set; }

    public virtual DbSet<Sesanad> Sesanads { get; set; }

    public virtual DbSet<Sesanadlog> Sesanadlogs { get; set; }

    public virtual DbSet<Sesanadrow> Sesanadrows { get; set; }

    public virtual DbSet<Sesanadvajh> Sesanadvajhs { get; set; }

    public virtual DbSet<Sesanadvajhtype> Sesanadvajhtypes { get; set; }

    public virtual DbSet<Sescale> Sescales { get; set; }

    public virtual DbSet<Sescalemodel> Sescalemodels { get; set; }

    public virtual DbSet<Setahlil> Setahlils { get; set; }

    public virtual DbSet<Setahlildetail> Setahlildetails { get; set; }

    public virtual DbSet<Seunit> Seunits { get; set; }

    public virtual DbSet<Seunitconvert> Seunitconverts { get; set; }

    public virtual DbSet<Sex> Sexes { get; set; }

    public virtual DbSet<Sm> Sms { get; set; }

    public virtual DbSet<Smsmodule> Smsmodules { get; set; }

    public virtual DbSet<Smsmoduleno> Smsmodulenos { get; set; }

    public virtual DbSet<Smsmoduletype> Smsmoduletypes { get; set; }

    public virtual DbSet<Sqlprocess> Sqlprocesses { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<Tanzimclient> Tanzimclients { get; set; }

    public virtual DbSet<Tanzimclient1> Tanzimclients1 { get; set; }

    public virtual DbSet<Tanzimtotal> Tanzimtotals { get; set; }

    public virtual DbSet<Tanzimuser> Tanzimusers { get; set; }

    public virtual DbSet<Tanzimuser1> Tanzimusers1 { get; set; }

    public virtual DbSet<Tatilat> Tatilats { get; set; }

    public virtual DbSet<Undo> Undos { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Usersgrp> Usersgrps { get; set; }

    public virtual DbSet<Userwork> Userworks { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<Vwclientsconfig> Vwclientsconfigs { get; set; }

    public virtual DbSet<Vwsebeton> Vwsebetons { get; set; }

    public virtual DbSet<Vwsebetonctmlastdate> Vwsebetonctmlastdates { get; set; }

    public virtual DbSet<Vwsefactorsanadrel> Vwsefactorsanadrels { get; set; }

    public virtual DbSet<Vwsehesab> Vwsehesabs { get; set; }

    public virtual DbSet<Vwsehesabmarkaz> Vwsehesabmarkazs { get; set; }

    public virtual DbSet<Vwsehesabmarkazdetail> Vwsehesabmarkazdetails { get; set; }

    public virtual DbSet<Vwsehesabparameter> Vwsehesabparameters { get; set; }

    public virtual DbSet<Vwsewsgetcustomer> Vwsewsgetcustomers { get; set; }

    public virtual DbSet<Vwsewsgetinvoice> Vwsewsgetinvoices { get; set; }

    public virtual DbSet<Vwsewsgetproforma> Vwsewsgetproformas { get; set; }

    public virtual DbSet<Vwsewsgetreturninvoice> Vwsewsgetreturninvoices { get; set; }

    public virtual DbSet<Vwtotalconfig> Vwtotalconfigs { get; set; }

    public virtual DbSet<Vwusersconfig> Vwusersconfigs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-IL7J9SU;Initial Catalog=ACCOUNT98;Integrated Security=True;Connect Timeout=3000;; Command Timeout=3000;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.Entity<Active>(entity =>
        {
            entity.HasKey(e => e.IdActive).HasName("PK_seactiveitem");

            entity.ToTable("active");

            entity.Property(e => e.IdActive).HasColumnName("id_active");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Advancefind>(entity =>
        {
            entity.HasKey(e => e.IdFnd);

            entity.ToTable("advancefind");

            entity.Property(e => e.IdFnd).HasColumnName("id_fnd");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Advancefindcolumn>(entity =>
        {
            entity.HasKey(e => e.IdFndcol);

            entity.ToTable("advancefindcolumns");

            entity.HasIndex(e => e.IdFnd, "IX_advancefindcolumns_id_fnd");

            entity.Property(e => e.IdFndcol)
                .ValueGeneratedNever()
                .HasColumnName("id_fndcol");
            entity.Property(e => e.Field)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("field");
            entity.Property(e => e.Fieldid)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fieldid");
            entity.Property(e => e.IdFnd).HasColumnName("id_fnd");
            entity.Property(e => e.Searchable)
                .HasDefaultValue(true)
                .HasColumnName("searchable");
            entity.Property(e => e.Tartib).HasColumnName("tartib");
            entity.Property(e => e.Tblonlylst).HasColumnName("tblonlylst");
            entity.Property(e => e.Tblsource)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tblsource");
            entity.Property(e => e.Tblsource1)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tblsource1");
            entity.Property(e => e.Tblsrcid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tblsrcid");
            entity.Property(e => e.Tblsrctype).HasColumnName("tblsrctype");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("type");
            entity.Property(e => e.Width)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("width");
            entity.Property(e => e.Width1)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("width_");

            entity.HasOne(d => d.IdFndNavigation).WithMany(p => p.Advancefindcolumns)
                .HasForeignKey(d => d.IdFnd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_advancefindcolumns_advancefind");
        });

        modelBuilder.Entity<Advanceresultfind>(entity =>
        {
            entity.HasKey(e => e.IdFndres);

            entity.ToTable("advanceresultfind");

            entity.HasIndex(e => e.IdFnd, "IX_advanceresultfind_id_fnd");

            entity.Property(e => e.IdFndres)
                .ValueGeneratedNever()
                .HasColumnName("id_fndres");
            entity.Property(e => e.Execommand)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("execommand");
            entity.Property(e => e.Fields)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fields");
            entity.Property(e => e.Fixedcols).HasColumnName("fixedcols");
            entity.Property(e => e.IdFnd).HasColumnName("id_fnd");
            entity.Property(e => e.Idfields)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("idfields");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Order)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("order");
            entity.Property(e => e.Returnval)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("returnval");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Where)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("where");

            entity.HasOne(d => d.IdFndNavigation).WithMany(p => p.Advanceresultfinds)
                .HasForeignKey(d => d.IdFnd)
                .HasConstraintName("FK_advanceresultfind_advancefind");
        });

        modelBuilder.Entity<Advanceresultfindcolumn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("advanceresultfindcolumns");

            entity.HasIndex(e => new { e.IdFndres, e.IdFndcol }, "IX_advanceresultfindcolumns_id_fndres_id_fndcol").IsClustered();

            entity.Property(e => e.IdFndcol).HasColumnName("id_fndcol");
            entity.Property(e => e.IdFndres).HasColumnName("id_fndres");
            entity.Property(e => e.Tartib).HasColumnName("tartib");

            entity.HasOne(d => d.IdFndcolNavigation).WithMany()
                .HasForeignKey(d => d.IdFndcol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table1_advancefindcolumns");

            entity.HasOne(d => d.IdFndresNavigation).WithMany()
                .HasForeignKey(d => d.IdFndres)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table1_advanceresultfind");
        });

        modelBuilder.Entity<Advanceresultfindused>(entity =>
        {
            entity.HasKey(e => e.IdFndsav);

            entity.ToTable("advanceresultfindused");

            entity.HasIndex(e => new { e.IdUser, e.IdFndres }, "IX_advanceresultfindused_id_user_id_fndres");

            entity.Property(e => e.IdFndsav)
                .ValueGeneratedNever()
                .HasColumnName("id_fndsav");
            entity.Property(e => e.Condition)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("condition");
            entity.Property(e => e.Descrip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("descrip");
            entity.Property(e => e.IdFndres).HasColumnName("id_fndres");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");
            entity.Property(e => e.Type)
                .HasDefaultValue((byte)1)
                .HasColumnName("type");

            entity.HasOne(d => d.IdFndresNavigation).WithMany(p => p.Advanceresultfinduseds)
                .HasForeignKey(d => d.IdFndres)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_advanceresultfindused_advanceresultfind");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Advanceresultfinduseds)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_advanceresultfindused_users");
        });

        modelBuilder.Entity<Baskol>(entity =>
        {
            entity.HasKey(e => e.IdBaskol);

            entity.ToTable("baskol");

            entity.Property(e => e.IdBaskol)
                .ValueGeneratedNever()
                .HasColumnName("id_baskol");
            entity.Property(e => e.Formul)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("formul");
            entity.Property(e => e.Ifstable)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ifstable");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.NegChr).HasColumnName("neg_chr");
            entity.Property(e => e.Reverse).HasColumnName("reverse");
            entity.Property(e => e.SepChr).HasColumnName("sep_chr");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Camera>(entity =>
        {
            entity.HasKey(e => e.IdCam);

            entity.ToTable("cameras");

            entity.Property(e => e.IdCam).HasColumnName("id_cam");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ipaddress");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("password");
            entity.Property(e => e.Tartib).HasColumnName("tartib");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Caption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("caption");

            entity.Property(e => e.Caption1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("caption");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdClt);

            entity.ToTable("clients", tb =>
                {
                    tb.HasTrigger("clients_delete_after");
                    tb.HasTrigger("clients_insert_after");
                    tb.HasTrigger("clients_update_after");
                });

            entity.Property(e => e.IdClt)
                .ValueGeneratedNever()
                .HasColumnName("id_clt");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Clientsgroup>(entity =>
        {
            entity.HasKey(e => e.IdCltgrp);

            entity.ToTable("clientsgroup", tb =>
                {
                    tb.HasTrigger("clientsgroup_delete_after");
                    tb.HasTrigger("clientsgroup_insert_after");
                    tb.HasTrigger("clientsgroup_update_after");
                });

            entity.Property(e => e.IdCltgrp)
                .ValueGeneratedNever()
                .HasColumnName("id_cltgrp");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Clientsgroupdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("clientsgroupdetail", tb =>
                {
                    tb.HasTrigger("clientsgroupdetail_delete_after");
                    tb.HasTrigger("clientsgroupdetail_insert_after");
                    tb.HasTrigger("clientsgroupdetail_update_after");
                });

            entity.HasIndex(e => new { e.IdCltgrp, e.IdClt }, "IX_clientsgroupdetail_id_cltgrp_id_clt").IsClustered();

            entity.Property(e => e.IdClt).HasColumnName("id_clt");
            entity.Property(e => e.IdCltgrp).HasColumnName("id_cltgrp");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdCltNavigation).WithMany()
                .HasForeignKey(d => d.IdClt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_clientsgroupdetail_clients");

            entity.HasOne(d => d.IdCltgrpNavigation).WithMany()
                .HasForeignKey(d => d.IdCltgrp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_clientsgroupdetail_clientsgroup");
        });

        modelBuilder.Entity<Educationlevel>(entity =>
        {
            entity.HasKey(e => e.IdEdulvl).HasName("PK_spEducationLevel");

            entity.ToTable("educationlevel");

            entity.Property(e => e.IdEdulvl).HasColumnName("id_edulvl");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("code");
            entity.Property(e => e.Termnology)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("termnology");
            entity.Property(e => e.Value)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Find>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("find");

            entity.HasIndex(e => e.IdUser, "ClusteredIndex-20180710-115410").IsClustered();

            entity.Property(e => e.Finditem)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("finditem");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");
            entity.Property(e => e.Radif)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("radif");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_find_users");
        });

        modelBuilder.Entity<Keyboardlayout>(entity =>
        {
            entity.ToTable("keyboardlayout", tb =>
                {
                    tb.HasTrigger("keyboardlayout_delete_after");
                    tb.HasTrigger("keyboardlayout_insert_after");
                    tb.HasTrigger("keyboardlayout_update_after");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Level>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("level", tb => tb.HasTrigger("level_update_updated_at"));

            entity.HasIndex(e => new { e.IdUser, e.Id, e.Sys }, "ClusteredIndex-20180710-115719").IsClustered();

            entity.HasIndex(e => e.IdUser, "IX_level");

            entity.HasIndex(e => e.UpdatedAt, "level_updated_at");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");
            entity.Property(e => e.Sys).HasColumnName("sys");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_level1_users");
        });

        modelBuilder.Entity<Madrak>(entity =>
        {
            entity.HasKey(e => e.IdMadrak);

            entity.ToTable("madrak");

            entity.Property(e => e.IdMadrak).HasColumnName("id_madrak");
            entity.Property(e => e.IdEdulvl).HasColumnName("id_edulvl");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdEdulvlNavigation).WithMany(p => p.Madraks)
                .HasForeignKey(d => d.IdEdulvl)
                .HasConstraintName("FK_madrak_educationlevel");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.IdMsg);

            entity.ToTable("message");

            entity.HasIndex(e => e.MsgCode, "UK_message_Code").IsUnique();

            entity.Property(e => e.IdMsg)
                .ValueGeneratedNever()
                .HasColumnName("id_msg");
            entity.Property(e => e.AlignHelp).HasColumnName("align_help");
            entity.Property(e => e.Alignment).HasColumnName("alignment");
            entity.Property(e => e.CharSeper)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("char_seper");
            entity.Property(e => e.Defaultkey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("defaultkey");
            entity.Property(e => e.IconHelp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("icon_help");
            entity.Property(e => e.Ignorekeys)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ignorekeys");
            entity.Property(e => e.Isquestion).HasColumnName("isquestion");
            entity.Property(e => e.LeftHelp).HasColumnName("left_help");
            entity.Property(e => e.MsgCode).HasColumnName("msg_code");
            entity.Property(e => e.MsgIcon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("msg_icon");
            entity.Property(e => e.MsgKeys)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("msg_keys");
            entity.Property(e => e.MsgLeft).HasColumnName("msg_left");
            entity.Property(e => e.MsgText)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("msg_text");
            entity.Property(e => e.MsgTitle)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("msg_title");
            entity.Property(e => e.MsgTop).HasColumnName("msg_top");
            entity.Property(e => e.TextHelp)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("text_help");
            entity.Property(e => e.Timedelay).HasColumnName("timedelay");
            entity.Property(e => e.Timeout).HasColumnName("timeout");
            entity.Property(e => e.TitleHelp)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("title_help");
            entity.Property(e => e.TopHelp).HasColumnName("top_help");
        });

        modelBuilder.Entity<Mobileregister>(entity =>
        {
            entity.HasKey(e => e.IdPhone);

            entity.ToTable("mobileregister");

            entity.Property(e => e.IdPhone)
                .ValueGeneratedNever()
                .HasColumnName("id_phone");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Imei)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("imei");
            entity.Property(e => e.Kry)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("kry");
            entity.Property(e => e.Phoneno)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("phoneno");
            entity.Property(e => e.Simserial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("simserial");
        });

        modelBuilder.Entity<Nation>(entity =>
        {
            entity.HasKey(e => e.IdNation);

            entity.ToTable("nation", tb => tb.HasTrigger("nation_update_updated_at"));

            entity.HasIndex(e => e.UpdatedAt, "IX_nation_updated_at");

            entity.Property(e => e.IdNation).HasColumnName("id_nation");
            entity.Property(e => e.IdNatIso).HasColumnName("id_nat_iso");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib).HasColumnName("tartib");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.IdNatIsoNavigation).WithMany(p => p.Nations)
                .HasForeignKey(d => d.IdNatIso)
                .HasConstraintName("FK_nation_nationality");
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.HasKey(e => e.IdNatIso).HasName("PK_spISO_3166_1");

            entity.ToTable("nationality");

            entity.Property(e => e.IdNatIso)
                .ValueGeneratedNever()
                .HasColumnName("id_nat_iso");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("code");
            entity.Property(e => e.Termnology)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("termnology");
            entity.Property(e => e.Value)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Ostan>(entity =>
        {
            entity.HasKey(e => e.IdOstan);

            entity.ToTable("ostan");

            entity.Property(e => e.IdOstan).HasColumnName("id_ostan");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Tartib).HasColumnName("tartib");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.IdPrs);

            entity.ToTable("person");

            entity.HasIndex(e => new { e.IdActive, e.Name, e.IdPrstyp, e.IdPrsgrp, e.IdOstan, e.IdSex, e.Malicode, e.Ctmtype }, "IX_person_id_active_name_id_prstyp_id_prsgrp_id_ostan_id_sex_malicode_ctmtype");

            entity.Property(e => e.IdPrs)
                .ValueGeneratedNever()
                .HasColumnName("id_prs");
            entity.Property(e => e.Alias)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("alias");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CtmNo).HasColumnName("ctm_no");
            entity.Property(e => e.Ctmtype).HasColumnName("ctmtype");
            entity.Property(e => e.Descrip)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("descrip");
            entity.Property(e => e.Groups)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("groups");
            entity.Property(e => e.Hamahangi).HasColumnName("hamahangi");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdOstan).HasColumnName("id_ostan");
            entity.Property(e => e.IdPrsgrp).HasColumnName("id_prsgrp");
            entity.Property(e => e.IdPrstyp).HasColumnName("id_prstyp");
            entity.Property(e => e.IdSex).HasColumnName("id_sex");
            entity.Property(e => e.Malicode).HasColumnName("malicode");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.NameRel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name_rel");
            entity.Property(e => e.RegDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("reg_date");
            entity.Property(e => e.RegTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("reg_time");
            entity.Property(e => e.RegUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("reg_user");
            entity.Property(e => e.Softinfo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("softinfo");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.People)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_person_active");

            entity.HasOne(d => d.IdOstanNavigation).WithMany(p => p.People)
                .HasForeignKey(d => d.IdOstan)
                .HasConstraintName("FK_person_ostan");

            entity.HasOne(d => d.IdPrsgrpNavigation).WithMany(p => p.People)
                .HasForeignKey(d => d.IdPrsgrp)
                .HasConstraintName("FK_person_persongroup");

            entity.HasOne(d => d.IdPrstypNavigation).WithMany(p => p.People)
                .HasForeignKey(d => d.IdPrstyp)
                .HasConstraintName("FK_person_persontype");

            entity.HasOne(d => d.IdSexNavigation).WithMany(p => p.People)
                .HasForeignKey(d => d.IdSex)
                .HasConstraintName("FK_person_sex");

            entity.HasOne(d => d.RegUserNavigation).WithMany(p => p.People)
                .HasForeignKey(d => d.RegUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_person_users");
        });

        modelBuilder.Entity<Persondetail>(entity =>
        {
            entity.HasKey(e => e.IdPrsdtl);

            entity.ToTable("persondetail");

            entity.HasIndex(e => new { e.IdPrs, e.IdPdtltyp }, "IX_persondetail_id_prs_id_pdtltyp");

            entity.Property(e => e.IdPrsdtl)
                .ValueGeneratedNever()
                .HasColumnName("id_prsdtl");
            entity.Property(e => e.Comment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.IdPdtltyp).HasColumnName("id_pdtltyp");
            entity.Property(e => e.IdPrs).HasColumnName("id_prs");
            entity.Property(e => e.RegDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("reg_date");
            entity.Property(e => e.RegTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("reg_time");
            entity.Property(e => e.RegUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("reg_user");
            entity.Property(e => e.Tartib)
                .HasDefaultValue(1)
                .HasColumnName("tartib");
            entity.Property(e => e.Value)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("value");

            entity.HasOne(d => d.IdPdtltypNavigation).WithMany(p => p.Persondetails)
                .HasForeignKey(d => d.IdPdtltyp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_persondetail_persondetailtype");

            entity.HasOne(d => d.IdPrsNavigation).WithMany(p => p.Persondetails)
                .HasForeignKey(d => d.IdPrs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_persondetail_person");

            entity.HasOne(d => d.RegUserNavigation).WithMany(p => p.Persondetails)
                .HasForeignKey(d => d.RegUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_persondetail_users");
        });

        modelBuilder.Entity<Persondetailtype>(entity =>
        {
            entity.HasKey(e => e.IdPdtltyp);

            entity.ToTable("persondetailtype");

            entity.Property(e => e.IdPdtltyp).HasColumnName("id_pdtltyp");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Inputmask)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("inputmask");
            entity.Property(e => e.Lang)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("lang");
            entity.Property(e => e.Length)
                .HasDefaultValue((short)1)
                .HasColumnName("length");
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasColumnName("type");
        });

        modelBuilder.Entity<Persongroup>(entity =>
        {
            entity.HasKey(e => e.IdPrsgrp);

            entity.ToTable("persongroup");

            entity.Property(e => e.IdPrsgrp)
                .ValueGeneratedNever()
                .HasColumnName("id_prsgrp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Persongroupdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdPrs, e.IdPrsgrp });

            entity.ToTable("persongroupdetail");

            entity.Property(e => e.IdPrs).HasColumnName("id_prs");
            entity.Property(e => e.IdPrsgrp).HasColumnName("id_prsgrp");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdPrsNavigation).WithMany(p => p.Persongroupdetails)
                .HasForeignKey(d => d.IdPrs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_persongroupdetail_person");

            entity.HasOne(d => d.IdPrsgrpNavigation).WithMany(p => p.Persongroupdetails)
                .HasForeignKey(d => d.IdPrsgrp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_persongroupdetail_persongroup");
        });

        modelBuilder.Entity<Personrelation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("personrelation");

            entity.HasIndex(e => new { e.IdPrs1, e.IdPrs2 }, "IX_personrelation_id_prs1_id_prs2").IsClustered();

            entity.Property(e => e.Comment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.IdPrs1).HasColumnName("id_prs1");
            entity.Property(e => e.IdPrs2).HasColumnName("id_prs2");
            entity.Property(e => e.RegDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("reg_date");
            entity.Property(e => e.RegTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("reg_time");
            entity.Property(e => e.RegUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("reg_user");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdPrs1Navigation).WithMany()
                .HasForeignKey(d => d.IdPrs1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personrelation_person");

            entity.HasOne(d => d.IdPrs2Navigation).WithMany()
                .HasForeignKey(d => d.IdPrs2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personrelation_person1");

            entity.HasOne(d => d.RegUserNavigation).WithMany()
                .HasForeignKey(d => d.RegUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personrelation_users");
        });

        modelBuilder.Entity<Persontype>(entity =>
        {
            entity.HasKey(e => e.IdPrstyp).HasName("PK_secustomertype");

            entity.ToTable("persontype");

            entity.Property(e => e.IdPrstyp).HasColumnName("id_prstyp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Program>(entity =>
        {
            entity.ToTable("program");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Notactive).HasColumnName("notactive");
            entity.Property(e => e.Sys10Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys10_key");
            entity.Property(e => e.Sys11Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys11_key");
            entity.Property(e => e.Sys12Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys12_key");
            entity.Property(e => e.Sys13Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys13_key");
            entity.Property(e => e.Sys14Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys14_key");
            entity.Property(e => e.Sys15Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys15_key");
            entity.Property(e => e.Sys16Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys16_key");
            entity.Property(e => e.Sys17Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys17_key");
            entity.Property(e => e.Sys18Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys18_key");
            entity.Property(e => e.Sys19Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys19_key");
            entity.Property(e => e.Sys1Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys1_key");
            entity.Property(e => e.Sys2Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys2_key");
            entity.Property(e => e.Sys3Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys3_key");
            entity.Property(e => e.Sys4Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys4_key");
            entity.Property(e => e.Sys5Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys5_key");
            entity.Property(e => e.Sys6Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys6_key");
            entity.Property(e => e.Sys7Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys7_key");
            entity.Property(e => e.Sys8Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys8_key");
            entity.Property(e => e.Sys9Key)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys9_key");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.IdRpt);

            entity.ToTable("reports", tb => tb.HasTrigger("reports_update_updated_at"));

            entity.HasIndex(e => new { e.Active, e.IdRptgrp }, "IX_reports_active_id_rptgrp");

            entity.HasIndex(e => e.UpdatedAt, "IX_reports_updated_at");

            entity.Property(e => e.IdRpt)
                .ValueGeneratedNever()
                .HasColumnName("id_rpt");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Compile)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("compile");
            entity.Property(e => e.CreateDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("create_da");
            entity.Property(e => e.Detail)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("detail");
            entity.Property(e => e.FrtFile)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frt_file");
            entity.Property(e => e.FrxFile)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frx_file");
            entity.Property(e => e.IdRptgrp).HasColumnName("id_rptgrp");
            entity.Property(e => e.LastuseDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("lastuse_da");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NoshowEmp)
                .HasDefaultValue(true)
                .HasColumnName("noshow_emp");
            entity.Property(e => e.NoshowPar)
                .HasDefaultValue(true)
                .HasColumnName("noshow_par");
            entity.Property(e => e.Other)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("other");
            entity.Property(e => e.Printtype)
                .HasDefaultValue((byte)1)
                .HasColumnName("printtype");
            entity.Property(e => e.Query)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("query");
            entity.Property(e => e.Runfirst).HasColumnName("runfirst");
            entity.Property(e => e.Shortcut)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shortcut");
            entity.Property(e => e.Smsdesc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("smsdesc");
            entity.Property(e => e.Smsto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("smsto");
            entity.Property(e => e.Sys)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.Version)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("version");

            entity.HasOne(d => d.IdRptgrpNavigation).WithMany(p => p.Reports)
                .HasForeignKey(d => d.IdRptgrp)
                .HasConstraintName("FK_reports_reportsgroup");
        });

        modelBuilder.Entity<Reportquery>(entity =>
        {
            entity.ToTable("reportquery");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompQuery)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comp_query");
        });

        modelBuilder.Entity<Reportsgroup>(entity =>
        {
            entity.HasKey(e => e.IdRptgrp);

            entity.ToTable("reportsgroup", tb => tb.HasTrigger("reportsgroup_update_updated_at"));

            entity.HasIndex(e => e.UpdatedAt, "reportsgroup_updated_at");

            entity.Property(e => e.IdRptgrp)
                .ValueGeneratedNever()
                .HasColumnName("id_rptgrp");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Sys)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sys");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Reportsitem>(entity =>
        {
            entity.HasKey(e => e.IdRptitm);

            entity.ToTable("reportsitems");

            entity.Property(e => e.IdRptitm)
                .ValueGeneratedNever()
                .HasColumnName("id_rptitm");
            entity.Property(e => e.Default)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("default");
            entity.Property(e => e.Descrip)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("descrip");
            entity.Property(e => e.Force).HasColumnName("force");
            entity.Property(e => e.Fullaccess)
                .HasDefaultValue(true)
                .HasColumnName("fullaccess");
            entity.Property(e => e.Help)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("help");
            entity.Property(e => e.Inputtype)
                .HasDefaultValue((byte)1)
                .HasColumnName("inputtype");
            entity.Property(e => e.Kind).HasColumnName("kind");
            entity.Property(e => e.Length)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("length");
            entity.Property(e => e.Maxcount)
                .HasDefaultValue((byte)1)
                .HasColumnName("maxcount");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Repeat)
                .HasDefaultValue(true)
                .HasColumnName("repeat");
            entity.Property(e => e.Right2left)
                .HasDefaultValue(true)
                .HasColumnName("right2left");
            entity.Property(e => e.Tartib).HasColumnName("tartib");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("type");
        });

        modelBuilder.Entity<Reportsitemsdetail>(entity =>
        {
            entity.ToTable("reportsitemsdetail");

            entity.HasIndex(e => e.IdRptitm, "IX_reportsitemsdetail_id_rptitm");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Descrip)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("descrip");
            entity.Property(e => e.IdRptitm).HasColumnName("id_rptitm");
            entity.Property(e => e.Tartib).HasColumnName("tartib");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("value");

            entity.HasOne(d => d.IdRptitmNavigation).WithMany(p => p.Reportsitemsdetails)
                .HasForeignKey(d => d.IdRptitm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_reportsitemsdetail_reportsitems");
        });

        modelBuilder.Entity<Reporttablesinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("reporttablesinfo");

            entity.HasIndex(e => new { e.Tablename, e.Columnname }, "IX_reporttablesinfo_tablename_columnname").IsClustered();

            entity.HasIndex(e => new { e.Tablename, e.Columnname }, "UQ_reporttablesinfo_tablename_columnname").IsUnique();

            entity.Property(e => e.Columnname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("columnname");
            entity.Property(e => e.Descrip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("descrip");
            entity.Property(e => e.Tablename)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("tablename");
        });

        modelBuilder.Entity<Reportuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("reportusers", tb => tb.HasTrigger("reportusers_update_updated_at"));

            entity.HasIndex(e => new { e.IdRpt, e.IdRptgrp, e.IdUser, e.Use, e.Print, e.Sms }, "ClusteredIndex-20180710-120200").IsClustered();

            entity.HasIndex(e => e.UpdatedAt, "reportusers_updated_at");

            entity.Property(e => e.IdRpt).HasColumnName("id_rpt");
            entity.Property(e => e.IdRptgrp).HasColumnName("id_rptgrp");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");
            entity.Property(e => e.Print).HasColumnName("print");
            entity.Property(e => e.Sms).HasColumnName("sms");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.Use).HasColumnName("use");

            entity.HasOne(d => d.IdRptNavigation).WithMany()
                .HasForeignKey(d => d.IdRpt)
                .HasConstraintName("FK_reportusers_reports");

            entity.HasOne(d => d.IdRptgrpNavigation).WithMany()
                .HasForeignKey(d => d.IdRptgrp)
                .HasConstraintName("FK_reportusers_reportsgroup");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_reportusers_users");
        });

        modelBuilder.Entity<Seanboth>(entity =>
        {
            entity.HasKey(e => e.IdAnboth);

            entity.ToTable("seanboth");

            entity.HasIndex(e => e.AnbothNo, "IX_seanboth_anboth_no");

            entity.HasIndex(e => e.Date, "IX_seanboth_date");

            entity.HasIndex(e => e.DateroozS, "IX_seanboth_daterooz_s");

            entity.HasIndex(e => e.HsbCtm, "IX_seanboth_hsb_ctm");

            entity.HasIndex(e => e.HsbdtlCtm, "IX_seanboth_hsbdtl_ctm");

            entity.HasIndex(e => e.HsbdtlTrf, "IX_seanboth_hsbdtl_trf");

            entity.HasIndex(e => e.IdBar, "IX_seanboth_id_bar");

            entity.HasIndex(e => e.IdBranch, "IX_seanboth_id_branch");

            entity.HasIndex(e => e.IdBrngrp, "IX_seanboth_id_brngrp");

            entity.HasIndex(e => e.IdFactor, "IX_seanboth_id_factor");

            entity.HasIndex(e => e.IdForm, "IX_seanboth_id_form");

            entity.HasIndex(e => e.IdKoshtar, "IX_seanboth_id_koshtar");

            entity.HasIndex(e => e.IdOk, "IX_seanboth_id_ok");

            entity.HasIndex(e => new { e.IdPeriod, e.IdForm, e.AnbothNo, e.IdBranch }, "UQ_seanboth_id_period_id_form_anboth_no_id_branch").IsUnique();

            entity.Property(e => e.IdAnboth)
                .ValueGeneratedNever()
                .HasColumnName("id_anboth");
            entity.Property(e => e.AnbothNo).HasColumnName("anboth_no");
            entity.Property(e => e.AutoEf).HasColumnName("auto_ef");
            entity.Property(e => e.BarNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("bar_no");
            entity.Property(e => e.Comment)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.CountM)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("count_m");
            entity.Property(e => e.Dahandeh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("dahandeh");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("date");
            entity.Property(e => e.DateroozS)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("daterooz_s");
            entity.Property(e => e.FactNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fact_no");
            entity.Property(e => e.Girandeh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("girandeh");
            entity.Property(e => e.HsbCtm).HasColumnName("hsb_ctm");
            entity.Property(e => e.HsbctmDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("hsbctm_des");
            entity.Property(e => e.HsbdtlCtm).HasColumnName("hsbdtl_ctm");
            entity.Property(e => e.HsbdtlDrv).HasColumnName("hsbdtl_drv");
            entity.Property(e => e.HsbdtlTrf).HasColumnName("hsbdtl_trf");
            entity.Property(e => e.IdAoRel).HasColumnName("id_ao_rel");
            entity.Property(e => e.IdBar).HasColumnName("id_bar");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
            entity.Property(e => e.IdFactor).HasColumnName("id_factor");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdHrRel).HasColumnName("id_hr_rel");
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
            entity.Property(e => e.MachineNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("machine_no");
            entity.Property(e => e.RoozRadif).HasColumnName("rooz_radif");
            entity.Property(e => e.Sabt).HasColumnName("sabt");
            entity.Property(e => e.Sharh)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sharh");
            entity.Property(e => e.Sharhsanad)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sharhsanad");
            entity.Property(e => e.Todate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("todate");
            entity.Property(e => e.Tshbymegh).HasColumnName("tshbymegh");
            entity.Property(e => e.Vazn3)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn3");
            entity.Property(e => e.Vazn34)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn34");
            entity.Property(e => e.Vazn3Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn3_date");
            entity.Property(e => e.Vazn3Row).HasColumnName("vazn3_row");
            entity.Property(e => e.Vazn3Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn3_time");
            entity.Property(e => e.Vazn4)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn4");
            entity.Property(e => e.Vazn4Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn4_date");
            entity.Property(e => e.Vazn4Row).HasColumnName("vazn4_row");
            entity.Property(e => e.Vazn4Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn4_time");

            entity.HasOne(d => d.HsbCtmNavigation).WithMany(p => p.Seanboths)
                .HasForeignKey(d => d.HsbCtm)
                .HasConstraintName("FK_seanboth_sehesab");

            entity.HasOne(d => d.HsbdtlCtmNavigation).WithMany(p => p.SeanbothHsbdtlCtmNavigations)
                .HasForeignKey(d => d.HsbdtlCtm)
                .HasConstraintName("FK_seanboth_sehesabgroupdetail2");

            entity.HasOne(d => d.HsbdtlDrvNavigation).WithMany(p => p.SeanbothHsbdtlDrvNavigations)
                .HasForeignKey(d => d.HsbdtlDrv)
                .HasConstraintName("FK_seanboth_sehesabgroupdetail1");

            entity.HasOne(d => d.HsbdtlTrfNavigation).WithMany(p => p.SeanbothHsbdtlTrfNavigations)
                .HasForeignKey(d => d.HsbdtlTrf)
                .HasConstraintName("FK_seanboth_sehesabgroupdetail");

            entity.HasOne(d => d.IdAoRelNavigation).WithMany(p => p.InverseIdAoRelNavigation)
                .HasForeignKey(d => d.IdAoRel)
                .HasConstraintName("FK_seanboth_seanboth");

            entity.HasOne(d => d.IdBarNavigation).WithMany(p => p.Seanboths)
                .HasForeignKey(d => d.IdBar)
                .HasConstraintName("FK_seanboth_sebarnameh");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Seanboths)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK_seanboth_sebranch");

            entity.HasOne(d => d.IdBrngrpNavigation).WithMany(p => p.Seanboths)
                .HasForeignKey(d => d.IdBrngrp)
                .HasConstraintName("FK_seanboth_sebranchgroup");

            entity.HasOne(d => d.IdFactorNavigation).WithMany(p => p.Seanboths)
                .HasForeignKey(d => d.IdFactor)
                .HasConstraintName("FK_seanboth_sefactor");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Seanboths)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seanboth_seforms");

            entity.HasOne(d => d.IdHrRelNavigation).WithMany(p => p.Seanboths)
                .HasForeignKey(d => d.IdHrRel)
                .HasConstraintName("FK_seanboth_sehvlrsd");

            entity.HasOne(d => d.IdKoshtarNavigation).WithMany(p => p.Seanboths)
                .HasForeignKey(d => d.IdKoshtar)
                .HasConstraintName("FK_seanboth_sekoshtar");

            entity.HasOne(d => d.IdOkNavigation).WithMany(p => p.Seanboths)
                .HasForeignKey(d => d.IdOk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seanboth_seok");

            entity.HasOne(d => d.IdPeriodNavigation).WithMany(p => p.Seanboths)
                .HasForeignKey(d => d.IdPeriod)
                .HasConstraintName("FK_seanboth_seperiod");
        });

        modelBuilder.Entity<Seanbothdetail>(entity =>
        {
            entity.HasKey(e => e.IdAoDtl);

            entity.ToTable("seanbothdetail");

            entity.HasIndex(e => e.DateKal, "IX_seanbothdetail_date_kal");

            entity.HasIndex(e => e.HsbKal, "IX_seanbothdetail_hsb_kal");

            entity.HasIndex(e => e.HsbdtlKal, "IX_seanbothdetail_hsbdtl_kal");

            entity.HasIndex(e => e.IdAnb, "IX_seanbothdetail_id_anb");

            entity.HasIndex(e => e.IdAnboth, "IX_seanbothdetail_id_anboth");

            entity.HasIndex(e => e.IdIoTyp, "IX_seanbothdetail_id_io_typ");

            entity.HasIndex(e => e.RadifS, "IX_seanbothdetail_radif_s");

            entity.HasIndex(e => e.SerialKal, "IX_seanbothdetail_serial_kal");

            entity.Property(e => e.IdAoDtl)
                .ValueGeneratedNever()
                .HasColumnName("id_ao_dtl");
            entity.Property(e => e.Afzoodeh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("afzoodeh");
            entity.Property(e => e.AfzoodehD)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("afzoodeh_d");
            entity.Property(e => e.AnbShfDtl).HasColumnName("anb_shf_dtl");
            entity.Property(e => e.Autoadd).HasColumnName("autoadd");
            entity.Property(e => e.Autobar).HasColumnName("autobar");
            entity.Property(e => e.Autotoulid).HasColumnName("autotoulid");
            entity.Property(e => e.Cancelfct).HasColumnName("cancelfct");
            entity.Property(e => e.CommPrint)
                .HasDefaultValue((byte)1)
                .HasColumnName("comm_print");
            entity.Property(e => e.CommRadif)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comm_radif");
            entity.Property(e => e.Count)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("count");
            entity.Property(e => e.CountM)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("count_m");
            entity.Property(e => e.CountPlt)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("count_plt");
            entity.Property(e => e.CountR)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("count_r");
            entity.Property(e => e.CountTot)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("count_tot");
            entity.Property(e => e.DarsadMab)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("darsad_mab");
            entity.Property(e => e.DateKal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("date_kal");
            entity.Property(e => e.Detailtype).HasColumnName("detailtype");
            entity.Property(e => e.Fi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi");
            entity.Property(e => e.FiR)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi_r");
            entity.Property(e => e.HsbKal).HasColumnName("hsb_kal");
            entity.Property(e => e.HsbdtlKal).HasColumnName("hsbdtl_kal");
            entity.Property(e => e.HsbdtlPlt).HasColumnName("hsbdtl_plt");
            entity.Property(e => e.IdAnb).HasColumnName("id_anb");
            entity.Property(e => e.IdAnboth).HasColumnName("id_anboth");
            entity.Property(e => e.IdIoTyp).HasColumnName("id_io_typ");
            entity.Property(e => e.IdUnitR).HasColumnName("id_unit_r");
            entity.Property(e => e.MabFormul)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mab_formul");
            entity.Property(e => e.MergeRow).HasColumnName("merge_row");
            entity.Property(e => e.MergeSnd).HasColumnName("merge_snd");
            entity.Property(e => e.MergedPrn).HasColumnName("merged_prn");
            entity.Property(e => e.Noprint).HasColumnName("noprint");
            entity.Property(e => e.Noprintunt).HasColumnName("noprintunt");
            entity.Property(e => e.Radif).HasColumnName("radif");
            entity.Property(e => e.RadifS)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("radif_s");
            entity.Property(e => e.Roundtype).HasColumnName("roundtype");
            entity.Property(e => e.Roundtype1).HasColumnName("roundtype1");
            entity.Property(e => e.Roweffect).HasColumnName("roweffect");
            entity.Property(e => e.Serial)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("serial");
            entity.Property(e => e.SerialKal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("serial_kal");
            entity.Property(e => e.Takhfif)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("takhfif");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("total");
            entity.Property(e => e.Total1)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("total1");
            entity.Property(e => e.Total2)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("total2");
            entity.Property(e => e.Vazn1)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn1");
            entity.Property(e => e.Vazn1Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn1_date");
            entity.Property(e => e.Vazn1Row).HasColumnName("vazn1_row");
            entity.Property(e => e.Vazn1Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn1_time");
            entity.Property(e => e.Vazn2)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn2");
            entity.Property(e => e.Vazn2Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn2_date");
            entity.Property(e => e.Vazn2Row).HasColumnName("vazn2_row");
            entity.Property(e => e.Vazn2Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn2_time");

            entity.HasOne(d => d.HsbKalNavigation).WithMany(p => p.Seanbothdetails)
                .HasForeignKey(d => d.HsbKal)
                .HasConstraintName("FK_seanbothdetail_sehesab");

            entity.HasOne(d => d.HsbdtlKalNavigation).WithMany(p => p.SeanbothdetailHsbdtlKalNavigations)
                .HasForeignKey(d => d.HsbdtlKal)
                .HasConstraintName("FK_seanbothdetail2_sehesabgroupdetail1");

            entity.HasOne(d => d.HsbdtlPltNavigation).WithMany(p => p.SeanbothdetailHsbdtlPltNavigations)
                .HasForeignKey(d => d.HsbdtlPlt)
                .HasConstraintName("FK_seanbothdetail1_sehesabgroupdetail2");

            entity.HasOne(d => d.IdAnbNavigation).WithMany(p => p.SeanbothdetailIdAnbNavigations)
                .HasForeignKey(d => d.IdAnb)
                .HasConstraintName("FK_seanbothdetail1_sehesabgroupdetail");

            entity.HasOne(d => d.IdAnbothNavigation).WithMany(p => p.Seanbothdetails)
                .HasForeignKey(d => d.IdAnboth)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seanbothdetail1_seanboth");

            entity.HasOne(d => d.IdIoTypNavigation).WithMany(p => p.Seanbothdetails)
                .HasForeignKey(d => d.IdIoTyp)
                .HasConstraintName("FK_seanbothdetail_seiotype");

            entity.HasOne(d => d.Sekalaunit).WithMany(p => p.Seanbothdetails)
                .HasForeignKey(d => new { d.HsbdtlKal, d.IdUnitR })
                .HasConstraintName("FK_seanbothdetail_sekalaunit");
        });

        modelBuilder.Entity<Seaqsat>(entity =>
        {
            entity.HasKey(e => e.IdQst).HasName("PK_seaghsat");

            entity.ToTable("seaqsat");

            entity.Property(e => e.IdQst)
                .ValueGeneratedNever()
                .HasColumnName("id_qst");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("date");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.IdHsbdtl).HasColumnName("id_hsbdtl");
            entity.Property(e => e.IdMkzd1).HasColumnName("id_mkzd1");
            entity.Property(e => e.IdMkzd10).HasColumnName("id_mkzd10");
            entity.Property(e => e.IdMkzd11).HasColumnName("id_mkzd11");
            entity.Property(e => e.IdMkzd12).HasColumnName("id_mkzd12");
            entity.Property(e => e.IdMkzd13).HasColumnName("id_mkzd13");
            entity.Property(e => e.IdMkzd14).HasColumnName("id_mkzd14");
            entity.Property(e => e.IdMkzd15).HasColumnName("id_mkzd15");
            entity.Property(e => e.IdMkzd16).HasColumnName("id_mkzd16");
            entity.Property(e => e.IdMkzd17).HasColumnName("id_mkzd17");
            entity.Property(e => e.IdMkzd18).HasColumnName("id_mkzd18");
            entity.Property(e => e.IdMkzd19).HasColumnName("id_mkzd19");
            entity.Property(e => e.IdMkzd2).HasColumnName("id_mkzd2");
            entity.Property(e => e.IdMkzd20).HasColumnName("id_mkzd20");
            entity.Property(e => e.IdMkzd3).HasColumnName("id_mkzd3");
            entity.Property(e => e.IdMkzd4).HasColumnName("id_mkzd4");
            entity.Property(e => e.IdMkzd5).HasColumnName("id_mkzd5");
            entity.Property(e => e.IdMkzd6).HasColumnName("id_mkzd6");
            entity.Property(e => e.IdMkzd7).HasColumnName("id_mkzd7");
            entity.Property(e => e.IdMkzd8).HasColumnName("id_mkzd8");
            entity.Property(e => e.IdMkzd9).HasColumnName("id_mkzd9");
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
                .IsFixedLength()
                .HasColumnName("indt_user");
            entity.Property(e => e.QstNo).HasColumnName("qst_no");
            entity.Property(e => e.Sharh)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sharh");
            entity.Property(e => e.VaMkz501)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz501");
            entity.Property(e => e.VaMkz502)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz502");
            entity.Property(e => e.VaMkz503)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz503");
            entity.Property(e => e.VaMkz504)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz504");
            entity.Property(e => e.VaMkz505)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz505");
            entity.Property(e => e.VaMkz506)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz506");
            entity.Property(e => e.VaMkz507)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz507");
            entity.Property(e => e.VaMkz508)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz508");
            entity.Property(e => e.VaMkz509)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz509");
            entity.Property(e => e.VaMkz510)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz510");
            entity.Property(e => e.VaMkz511)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz511");
            entity.Property(e => e.VaMkz512)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz512");
            entity.Property(e => e.VaMkz513)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz513");
            entity.Property(e => e.VaMkz514)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz514");
            entity.Property(e => e.VaMkz515)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz515");
            entity.Property(e => e.VaMkz516)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz516");
            entity.Property(e => e.VaMkz517)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz517");
            entity.Property(e => e.VaMkz518)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz518");
            entity.Property(e => e.VaMkz519)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz519");
            entity.Property(e => e.VaMkz520)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz520");
            entity.Property(e => e.VaMkz521)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz521");
            entity.Property(e => e.VaMkz522)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz522");
            entity.Property(e => e.VaMkz523)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz523");
            entity.Property(e => e.VaMkz524)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz524");
            entity.Property(e => e.VaMkz525)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz525");
            entity.Property(e => e.VaMkz526)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz526");
            entity.Property(e => e.VaMkz527)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz527");
            entity.Property(e => e.VaMkz528)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz528");
            entity.Property(e => e.VaMkz529)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz529");
            entity.Property(e => e.VaMkz530)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz530");
            entity.Property(e => e.VaMkz531)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz531");
            entity.Property(e => e.VaMkz532)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz532");
            entity.Property(e => e.VaMkz533)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz533");
            entity.Property(e => e.VaMkz534)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz534");
            entity.Property(e => e.VaMkz535)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz535");
            entity.Property(e => e.VaMkz536)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz536");
            entity.Property(e => e.VaMkz537)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz537");
            entity.Property(e => e.VaMkz538)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz538");
            entity.Property(e => e.VaMkz539)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz539");
            entity.Property(e => e.VaMkz540)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz540");
            entity.Property(e => e.VaMkz541)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz541");
            entity.Property(e => e.VaMkz542)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz542");
            entity.Property(e => e.VaMkz543)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz543");
            entity.Property(e => e.VaMkz544)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz544");
            entity.Property(e => e.VaMkz545)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz545");
            entity.Property(e => e.VaMkz546)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz546");
            entity.Property(e => e.VaMkz547)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz547");
            entity.Property(e => e.VaMkz548)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz548");
            entity.Property(e => e.VaMkz549)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz549");
            entity.Property(e => e.VaMkz550)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz550");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Seaqsats)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seaghsat_seforms");

            entity.HasOne(d => d.IdHsbNavigation).WithMany(p => p.Seaqsats)
                .HasForeignKey(d => d.IdHsb)
                .HasConstraintName("FK_seaghsat_sehesab");

            entity.HasOne(d => d.IdHsbdtlNavigation).WithMany(p => p.Seaqsats)
                .HasForeignKey(d => d.IdHsbdtl)
                .HasConstraintName("FK_seaghsat_sehesabgroupdetail");

            entity.HasOne(d => d.IdMkzd1Navigation).WithMany(p => p.SeaqsatIdMkzd1Navigations)
                .HasForeignKey(d => d.IdMkzd1)
                .HasConstraintName("FK_seaghsat_semarkazdetail01");

            entity.HasOne(d => d.IdMkzd10Navigation).WithMany(p => p.SeaqsatIdMkzd10Navigations)
                .HasForeignKey(d => d.IdMkzd10)
                .HasConstraintName("FK_seaghsat_semarkazdetail10");

            entity.HasOne(d => d.IdMkzd11Navigation).WithMany(p => p.SeaqsatIdMkzd11Navigations)
                .HasForeignKey(d => d.IdMkzd11)
                .HasConstraintName("FK_seaghsat_semarkazdetail11");

            entity.HasOne(d => d.IdMkzd12Navigation).WithMany(p => p.SeaqsatIdMkzd12Navigations)
                .HasForeignKey(d => d.IdMkzd12)
                .HasConstraintName("FK_seaghsat_semarkazdetail12");

            entity.HasOne(d => d.IdMkzd13Navigation).WithMany(p => p.SeaqsatIdMkzd13Navigations)
                .HasForeignKey(d => d.IdMkzd13)
                .HasConstraintName("FK_seaghsat_semarkazdetail13");

            entity.HasOne(d => d.IdMkzd14Navigation).WithMany(p => p.SeaqsatIdMkzd14Navigations)
                .HasForeignKey(d => d.IdMkzd14)
                .HasConstraintName("FK_seaghsat_semarkazdetail14");

            entity.HasOne(d => d.IdMkzd15Navigation).WithMany(p => p.SeaqsatIdMkzd15Navigations)
                .HasForeignKey(d => d.IdMkzd15)
                .HasConstraintName("FK_seaghsat_semarkazdetail15");

            entity.HasOne(d => d.IdMkzd16Navigation).WithMany(p => p.SeaqsatIdMkzd16Navigations)
                .HasForeignKey(d => d.IdMkzd16)
                .HasConstraintName("FK_seaghsat_semarkazdetail16");

            entity.HasOne(d => d.IdMkzd17Navigation).WithMany(p => p.SeaqsatIdMkzd17Navigations)
                .HasForeignKey(d => d.IdMkzd17)
                .HasConstraintName("FK_seaghsat_semarkazdetail17");

            entity.HasOne(d => d.IdMkzd18Navigation).WithMany(p => p.SeaqsatIdMkzd18Navigations)
                .HasForeignKey(d => d.IdMkzd18)
                .HasConstraintName("FK_seaghsat_semarkazdetail18");

            entity.HasOne(d => d.IdMkzd19Navigation).WithMany(p => p.SeaqsatIdMkzd19Navigations)
                .HasForeignKey(d => d.IdMkzd19)
                .HasConstraintName("FK_seaghsat_semarkazdetail19");

            entity.HasOne(d => d.IdMkzd2Navigation).WithMany(p => p.SeaqsatIdMkzd2Navigations)
                .HasForeignKey(d => d.IdMkzd2)
                .HasConstraintName("FK_seaghsat_semarkazdetail02");

            entity.HasOne(d => d.IdMkzd20Navigation).WithMany(p => p.SeaqsatIdMkzd20Navigations)
                .HasForeignKey(d => d.IdMkzd20)
                .HasConstraintName("FK_seaghsat_semarkazdetail20");

            entity.HasOne(d => d.IdMkzd3Navigation).WithMany(p => p.SeaqsatIdMkzd3Navigations)
                .HasForeignKey(d => d.IdMkzd3)
                .HasConstraintName("FK_seaghsat_semarkazdetail03");

            entity.HasOne(d => d.IdMkzd4Navigation).WithMany(p => p.SeaqsatIdMkzd4Navigations)
                .HasForeignKey(d => d.IdMkzd4)
                .HasConstraintName("FK_seaghsat_semarkazdetail04");

            entity.HasOne(d => d.IdMkzd5Navigation).WithMany(p => p.SeaqsatIdMkzd5Navigations)
                .HasForeignKey(d => d.IdMkzd5)
                .HasConstraintName("FK_seaghsat_semarkazdetail05");

            entity.HasOne(d => d.IdMkzd6Navigation).WithMany(p => p.SeaqsatIdMkzd6Navigations)
                .HasForeignKey(d => d.IdMkzd6)
                .HasConstraintName("FK_seaghsat_semarkazdetail06");

            entity.HasOne(d => d.IdMkzd7Navigation).WithMany(p => p.SeaqsatIdMkzd7Navigations)
                .HasForeignKey(d => d.IdMkzd7)
                .HasConstraintName("FK_seaghsat_semarkazdetail07");

            entity.HasOne(d => d.IdMkzd8Navigation).WithMany(p => p.SeaqsatIdMkzd8Navigations)
                .HasForeignKey(d => d.IdMkzd8)
                .HasConstraintName("FK_seaghsat_semarkazdetail08");

            entity.HasOne(d => d.IdMkzd9Navigation).WithMany(p => p.SeaqsatIdMkzd9Navigations)
                .HasForeignKey(d => d.IdMkzd9)
                .HasConstraintName("FK_seaghsat_semarkazdetail09");

            entity.HasOne(d => d.IndtUserNavigation).WithMany(p => p.Seaqsats)
                .HasForeignKey(d => d.IndtUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seaqsat_users");
        });

        modelBuilder.Entity<Seaqsatdetail>(entity =>
        {
            entity.HasKey(e => e.IdQstdtl);

            entity.ToTable("seaqsatdetail");

            entity.Property(e => e.IdQstdtl)
                .ValueGeneratedNever()
                .HasColumnName("id_qstdtl");
            entity.Property(e => e.CommRadif)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comm_radif");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("date");
            entity.Property(e => e.IdQst)
                .HasDefaultValueSql("('')")
                .HasColumnName("id_qst");
            entity.Property(e => e.Mablagh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mablagh");
            entity.Property(e => e.Radif).HasColumnName("radif");

            entity.HasOne(d => d.IdQstNavigation).WithMany(p => p.Seaqsatdetails)
                .HasForeignKey(d => d.IdQst)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Sebank>(entity =>
        {
            entity.HasKey(e => e.IdBank);

            entity.ToTable("sebank");

            entity.Property(e => e.IdBank).HasColumnName("id_bank");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue(1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sebankhesabtype>(entity =>
        {
            entity.HasKey(e => e.IdBnkhtyp).HasName("PK_seBankHesabType");

            entity.ToTable("sebankhesabtype");

            entity.Property(e => e.IdBnkhtyp).HasColumnName("id_bnkhtyp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sebarnameh>(entity =>
        {
            entity.HasKey(e => e.IdBar).HasName("PK_seforoosh");

            entity.ToTable("sebarnameh");

            entity.HasIndex(e => new { e.IdPeriod, e.IdBranch, e.IdForm, e.BarNo }, "IX_U_sebarnameh_id_period_id_branch_id_form_bar_no").IsUnique();

            entity.HasIndex(e => e.BarNo, "IX_sebarnameh_bar_no");

            entity.HasIndex(e => e.CtmHsb, "IX_sebarnameh_ctm_hsb");

            entity.HasIndex(e => e.CtmHsbd, "IX_sebarnameh_ctm_hsbd");

            entity.HasIndex(e => e.Date, "IX_sebarnameh_date");

            entity.HasIndex(e => e.IdAnb, "IX_sebarnameh_id_anb");

            entity.HasIndex(e => e.IdBranch, "IX_sebarnameh_id_branch");

            entity.HasIndex(e => e.IdBrngrp, "IX_sebarnameh_id_brngrp");

            entity.HasIndex(e => e.IdForm, "IX_sebarnameh_id_form");

            entity.HasIndex(e => e.IdOk, "IX_sebarnameh_id_ok");

            entity.HasIndex(e => e.KalHsb, "IX_sebarnameh_kal_hsb");

            entity.HasIndex(e => e.KalHsbd, "IX_sebarnameh_kal_hsbd");

            entity.HasIndex(e => e.MashinNo, "IX_sebarnameh_mashin_no");

            entity.Property(e => e.IdBar)
                .ValueGeneratedNever()
                .HasColumnName("id_bar");
            entity.Property(e => e.BarNo).HasColumnName("bar_no");
            entity.Property(e => e.BasAfz)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("bas_afz");
            entity.Property(e => e.BasAfzD)
                .HasColumnType("decimal(5, 1)")
                .HasColumnName("bas_afz_d");
            entity.Property(e => e.BasFi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("bas_fi");
            entity.Property(e => e.BasHsb).HasColumnName("bas_hsb");
            entity.Property(e => e.BasHsbd).HasColumnName("bas_hsbd");
            entity.Property(e => e.BasMb)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("bas_mb");
            entity.Property(e => e.BasMb1)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("bas_mb1");
            entity.Property(e => e.BasTkh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("bas_tkh");
            entity.Property(e => e.BasTkhFi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("bas_tkh_fi");
            entity.Property(e => e.Cancel).HasColumnName("cancel");
            entity.Property(e => e.Comment)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.CtmDesc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ctm_desc");
            entity.Property(e => e.CtmHsb).HasColumnName("ctm_hsb");
            entity.Property(e => e.CtmHsbd).HasColumnName("ctm_hsbd");
            entity.Property(e => e.DarHsb).HasColumnName("dar_hsb");
            entity.Property(e => e.DarHsbd).HasColumnName("dar_hsbd");
            entity.Property(e => e.DarMb)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("dar_mb");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("date");
            entity.Property(e => e.DrvAfz)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("drv_afz");
            entity.Property(e => e.DrvAfzD)
                .HasColumnType("decimal(5, 1)")
                .HasColumnName("drv_afz_d");
            entity.Property(e => e.DrvDesc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("drv_desc");
            entity.Property(e => e.DrvFi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("drv_fi");
            entity.Property(e => e.DrvHsb).HasColumnName("drv_hsb");
            entity.Property(e => e.DrvHsbd).HasColumnName("drv_hsbd");
            entity.Property(e => e.DrvMb)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("drv_mb");
            entity.Property(e => e.DrvMb1)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("drv_mb1");
            entity.Property(e => e.DrvTkh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("drv_tkh");
            entity.Property(e => e.DrvTkhFi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("drv_tkh_fi");
            entity.Property(e => e.DrvType)
                .HasDefaultValue((byte)1)
                .HasColumnName("drv_type");
            entity.Property(e => e.FactNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fact_no");
            entity.Property(e => e.Fazakhali)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fazakhali");
            entity.Property(e => e.IdAnb).HasColumnName("id_anb");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdMshtyp).HasColumnName("id_mshtyp");
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
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("indt_user");
            entity.Property(e => e.KalAfz)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kal_afz");
            entity.Property(e => e.KalAfzD)
                .HasColumnType("decimal(5, 1)")
                .HasColumnName("kal_afz_d");
            entity.Property(e => e.KalFi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("kal_fi");
            entity.Property(e => e.KalHsb).HasColumnName("kal_hsb");
            entity.Property(e => e.KalHsbd).HasColumnName("kal_hsbd");
            entity.Property(e => e.KalMb)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kal_mb");
            entity.Property(e => e.KalMb1)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kal_mb1");
            entity.Property(e => e.KalTkh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kal_tkh");
            entity.Property(e => e.KalTkhFi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("kal_tkh_fi");
            entity.Property(e => e.KhrFi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("khr_fi");
            entity.Property(e => e.KhrHsb).HasColumnName("khr_hsb");
            entity.Property(e => e.KhrHsbd).HasColumnName("khr_hsbd");
            entity.Property(e => e.KhrMb1)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("khr_mb1");
            entity.Property(e => e.KhrMegh)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("khr_megh");
            entity.Property(e => e.KryAfz)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kry_afz");
            entity.Property(e => e.KryAfzD)
                .HasColumnType("decimal(5, 1)")
                .HasColumnName("kry_afz_d");
            entity.Property(e => e.KryFi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("kry_fi");
            entity.Property(e => e.KryHsb).HasColumnName("kry_hsb");
            entity.Property(e => e.KryHsbd).HasColumnName("kry_hsbd");
            entity.Property(e => e.KryMb)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kry_mb");
            entity.Property(e => e.KryMb1)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kry_mb1");
            entity.Property(e => e.KryTkh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kry_tkh");
            entity.Property(e => e.KryTkhFi)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("kry_tkh_fi");
            entity.Property(e => e.Maghsad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("maghsad");
            entity.Property(e => e.MashinNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("mashin_no");
            entity.Property(e => e.MashinNoa).HasColumnName("mashin_noa");
            entity.Property(e => e.Meghdar)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("meghdar");
            entity.Property(e => e.MeghdarM)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("meghdar_m");
            entity.Property(e => e.MergeKb).HasColumnName("merge_kb");
            entity.Property(e => e.Mosalah).HasColumnName("mosalah");
            entity.Property(e => e.Narmi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("narmi");
            entity.Property(e => e.NewEdit)
                .HasDefaultValue(true)
                .HasColumnName("new_edit");
            entity.Property(e => e.PardHsb).HasColumnName("pard_hsb");
            entity.Property(e => e.PardHsbd).HasColumnName("pard_hsbd");
            entity.Property(e => e.PardMb)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("pard_mb");
            entity.Property(e => e.RndHsb).HasColumnName("rnd_hsb");
            entity.Property(e => e.RndHsbd).HasColumnName("rnd_hsbd");
            entity.Property(e => e.RndMb)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("rnd_mb");
            entity.Property(e => e.Rotoobat)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("rotoobat");
            entity.Property(e => e.Sangdane)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sangdane");
            entity.Property(e => e.Sayesh).HasColumnName("sayesh");
            entity.Property(e => e.Shekastegi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shekastegi");
            entity.Property(e => e.Time)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("time");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("total");
            entity.Property(e => e.TrfHsbd).HasColumnName("trf_hsbd");
            entity.Property(e => e.Usefornext)
                .HasDefaultValue(true)
                .HasColumnName("usefornext");
            entity.Property(e => e.Vazn1)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn1");
            entity.Property(e => e.Vazn2)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn2");
            entity.Property(e => e.Yakhbandan).HasColumnName("yakhbandan");

            entity.HasOne(d => d.BasHsbNavigation).WithMany(p => p.SebarnamehBasHsbNavigations)
                .HasForeignKey(d => d.BasHsb)
                .HasConstraintName("FK_sebarnameh_sehesab");

            entity.HasOne(d => d.BasHsbdNavigation).WithMany(p => p.SebarnamehBasHsbdNavigations)
                .HasForeignKey(d => d.BasHsbd)
                .HasConstraintName("FK_sebarnameh_sehesabgroupdetail2");

            entity.HasOne(d => d.CtmHsbNavigation).WithMany(p => p.SebarnamehCtmHsbNavigations)
                .HasForeignKey(d => d.CtmHsb)
                .HasConstraintName("FK_seforoosh_sehesab");

            entity.HasOne(d => d.CtmHsbdNavigation).WithMany(p => p.SebarnamehCtmHsbdNavigations)
                .HasForeignKey(d => d.CtmHsbd)
                .HasConstraintName("FK_seforoosh_sehesabgroupdetail");

            entity.HasOne(d => d.DarHsbNavigation).WithMany(p => p.SebarnamehDarHsbNavigations)
                .HasForeignKey(d => d.DarHsb)
                .HasConstraintName("FK_sebarnameh_sehesab2");

            entity.HasOne(d => d.DarHsbdNavigation).WithMany(p => p.SebarnamehDarHsbdNavigations)
                .HasForeignKey(d => d.DarHsbd)
                .HasConstraintName("FK_sebarnameh_sehesabgroupdetail4");

            entity.HasOne(d => d.DrvHsbNavigation).WithMany(p => p.SebarnamehDrvHsbNavigations)
                .HasForeignKey(d => d.DrvHsb)
                .HasConstraintName("FK_seforoosh_sehesab2");

            entity.HasOne(d => d.DrvHsbdNavigation).WithMany(p => p.SebarnamehDrvHsbdNavigations)
                .HasForeignKey(d => d.DrvHsbd)
                .HasConstraintName("FK_seforoosh_sehesabgroupdetail2");

            entity.HasOne(d => d.IdAnbNavigation).WithMany(p => p.SebarnamehIdAnbNavigations)
                .HasForeignKey(d => d.IdAnb)
                .HasConstraintName("FK_sebarnameh_sehesabgroupdetail1");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Sebarnamehs)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK_sebarnameh_sebranch");

            entity.HasOne(d => d.IdBrngrpNavigation).WithMany(p => p.Sebarnamehs)
                .HasForeignKey(d => d.IdBrngrp)
                .HasConstraintName("FK_sebarnameh_sebranchgroup");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Sebarnamehs)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sebarnameh_seforms");

            entity.HasOne(d => d.IdMshtypNavigation).WithMany(p => p.SebarnamehIdMshtypNavigations)
                .HasForeignKey(d => d.IdMshtyp)
                .HasConstraintName("FK_sebarnameh_sehesabgroupdetail");

            entity.HasOne(d => d.IdOkNavigation).WithMany(p => p.Sebarnamehs)
                .HasForeignKey(d => d.IdOk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sebarnameh_seok");

            entity.HasOne(d => d.IdPeriodNavigation).WithMany(p => p.Sebarnamehs)
                .HasForeignKey(d => d.IdPeriod)
                .HasConstraintName("FK_sebarnameh_seperiod");

            entity.HasOne(d => d.IndtUserNavigation).WithMany(p => p.Sebarnamehs)
                .HasForeignKey(d => d.IndtUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sebarnameh_users");

            entity.HasOne(d => d.KalHsbNavigation).WithMany(p => p.SebarnamehKalHsbNavigations)
                .HasForeignKey(d => d.KalHsb)
                .HasConstraintName("FK_seforoosh_sehesab1");

            entity.HasOne(d => d.KalHsbdNavigation).WithMany(p => p.SebarnamehKalHsbdNavigations)
                .HasForeignKey(d => d.KalHsbd)
                .HasConstraintName("FK_seforoosh_sehesabgroupdetail1");

            entity.HasOne(d => d.KryHsbNavigation).WithMany(p => p.SebarnamehKryHsbNavigations)
                .HasForeignKey(d => d.KryHsb)
                .HasConstraintName("FK_sebarnameh_sehesab1");

            entity.HasOne(d => d.KryHsbdNavigation).WithMany(p => p.SebarnamehKryHsbdNavigations)
                .HasForeignKey(d => d.KryHsbd)
                .HasConstraintName("FK_sebarnameh_sehesabgroupdetail3");

            entity.HasOne(d => d.PardHsbNavigation).WithMany(p => p.SebarnamehPardHsbNavigations)
                .HasForeignKey(d => d.PardHsb)
                .HasConstraintName("FK_sebarnameh_sehesab4");

            entity.HasOne(d => d.PardHsbdNavigation).WithMany(p => p.SebarnamehPardHsbdNavigations)
                .HasForeignKey(d => d.PardHsbd)
                .HasConstraintName("FK_sebarnameh_sehesabgroupdetail7");

            entity.HasOne(d => d.RndHsbNavigation).WithMany(p => p.SebarnamehRndHsbNavigations)
                .HasForeignKey(d => d.RndHsb)
                .HasConstraintName("FK_sebarnameh_sehesab3");

            entity.HasOne(d => d.RndHsbdNavigation).WithMany(p => p.SebarnamehRndHsbdNavigations)
                .HasForeignKey(d => d.RndHsbd)
                .HasConstraintName("FK_sebarnameh_sehesabgroupdetail5");

            entity.HasOne(d => d.TrfHsbdNavigation).WithMany(p => p.SebarnamehTrfHsbdNavigations)
                .HasForeignKey(d => d.TrfHsbd)
                .HasConstraintName("FK_sebarnameh_sehesabgroupdetail6");
        });

        modelBuilder.Entity<SebarnamehMarkaz>(entity =>
        {
            entity.HasKey(e => new { e.IdBar, e.Itemno }).HasName("PK_seforoosh_markaz");

            entity.ToTable("sebarnameh_markaz");

            entity.Property(e => e.IdBar).HasColumnName("id_bar");
            entity.Property(e => e.Itemno).HasColumnName("itemno");
            entity.Property(e => e.IdMkzd1).HasColumnName("id_mkzd1");
            entity.Property(e => e.IdMkzd10).HasColumnName("id_mkzd10");
            entity.Property(e => e.IdMkzd11).HasColumnName("id_mkzd11");
            entity.Property(e => e.IdMkzd12).HasColumnName("id_mkzd12");
            entity.Property(e => e.IdMkzd13).HasColumnName("id_mkzd13");
            entity.Property(e => e.IdMkzd14).HasColumnName("id_mkzd14");
            entity.Property(e => e.IdMkzd15).HasColumnName("id_mkzd15");
            entity.Property(e => e.IdMkzd16).HasColumnName("id_mkzd16");
            entity.Property(e => e.IdMkzd17).HasColumnName("id_mkzd17");
            entity.Property(e => e.IdMkzd18).HasColumnName("id_mkzd18");
            entity.Property(e => e.IdMkzd19).HasColumnName("id_mkzd19");
            entity.Property(e => e.IdMkzd2).HasColumnName("id_mkzd2");
            entity.Property(e => e.IdMkzd20).HasColumnName("id_mkzd20");
            entity.Property(e => e.IdMkzd3).HasColumnName("id_mkzd3");
            entity.Property(e => e.IdMkzd4).HasColumnName("id_mkzd4");
            entity.Property(e => e.IdMkzd5).HasColumnName("id_mkzd5");
            entity.Property(e => e.IdMkzd6).HasColumnName("id_mkzd6");
            entity.Property(e => e.IdMkzd7).HasColumnName("id_mkzd7");
            entity.Property(e => e.IdMkzd8).HasColumnName("id_mkzd8");
            entity.Property(e => e.IdMkzd9).HasColumnName("id_mkzd9");

            entity.HasOne(d => d.IdBarNavigation).WithMany(p => p.SebarnamehMarkazs)
                .HasForeignKey(d => d.IdBar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seforoosh_markaz_seforoosh");

            entity.HasOne(d => d.IdMkzd1Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd1Navigations)
                .HasForeignKey(d => d.IdMkzd1)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail");

            entity.HasOne(d => d.IdMkzd10Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd10Navigations)
                .HasForeignKey(d => d.IdMkzd10)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail9");

            entity.HasOne(d => d.IdMkzd11Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd11Navigations)
                .HasForeignKey(d => d.IdMkzd11)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail10");

            entity.HasOne(d => d.IdMkzd12Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd12Navigations)
                .HasForeignKey(d => d.IdMkzd12)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail11");

            entity.HasOne(d => d.IdMkzd13Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd13Navigations)
                .HasForeignKey(d => d.IdMkzd13)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail12");

            entity.HasOne(d => d.IdMkzd14Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd14Navigations)
                .HasForeignKey(d => d.IdMkzd14)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail13");

            entity.HasOne(d => d.IdMkzd15Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd15Navigations)
                .HasForeignKey(d => d.IdMkzd15)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail14");

            entity.HasOne(d => d.IdMkzd16Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd16Navigations)
                .HasForeignKey(d => d.IdMkzd16)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail15");

            entity.HasOne(d => d.IdMkzd17Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd17Navigations)
                .HasForeignKey(d => d.IdMkzd17)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail16");

            entity.HasOne(d => d.IdMkzd18Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd18Navigations)
                .HasForeignKey(d => d.IdMkzd18)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail17");

            entity.HasOne(d => d.IdMkzd19Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd19Navigations)
                .HasForeignKey(d => d.IdMkzd19)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail18");

            entity.HasOne(d => d.IdMkzd2Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd2Navigations)
                .HasForeignKey(d => d.IdMkzd2)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail1");

            entity.HasOne(d => d.IdMkzd20Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd20Navigations)
                .HasForeignKey(d => d.IdMkzd20)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail19");

            entity.HasOne(d => d.IdMkzd3Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd3Navigations)
                .HasForeignKey(d => d.IdMkzd3)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail2");

            entity.HasOne(d => d.IdMkzd4Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd4Navigations)
                .HasForeignKey(d => d.IdMkzd4)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail3");

            entity.HasOne(d => d.IdMkzd5Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd5Navigations)
                .HasForeignKey(d => d.IdMkzd5)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail4");

            entity.HasOne(d => d.IdMkzd6Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd6Navigations)
                .HasForeignKey(d => d.IdMkzd6)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail5");

            entity.HasOne(d => d.IdMkzd7Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd7Navigations)
                .HasForeignKey(d => d.IdMkzd7)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail6");

            entity.HasOne(d => d.IdMkzd8Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd8Navigations)
                .HasForeignKey(d => d.IdMkzd8)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail7");

            entity.HasOne(d => d.IdMkzd9Navigation).WithMany(p => p.SebarnamehMarkazIdMkzd9Navigations)
                .HasForeignKey(d => d.IdMkzd9)
                .HasConstraintName("FK_seforoosh_markaz_semarkazdetail8");
        });

        modelBuilder.Entity<Sebeton>(entity =>
        {
            entity.HasKey(e => e.IdBeton);

            entity.ToTable("sebeton", tb => tb.HasTrigger("sebeton_update_updated_at"));

            entity.HasIndex(e => e.BetonNo, "IX_sebeton_beton_no");

            entity.HasIndex(e => e.BtnHsb, "IX_sebeton_btn_hsb");

            entity.HasIndex(e => e.BtnHsbd, "IX_sebeton_btn_hsbd");

            entity.HasIndex(e => e.CtmHsbd, "IX_sebeton_ctm_hsbd");

            entity.HasIndex(e => e.Date, "IX_sebeton_date");

            entity.HasIndex(e => e.DrvName, "IX_sebeton_drv_name");

            entity.HasIndex(e => e.IdBranch, "IX_sebeton_id_branch");

            entity.HasIndex(e => e.IdBrngrp, "IX_sebeton_id_brngrp");

            entity.HasIndex(e => e.IdForm, "IX_sebeton_id_form");

            entity.HasIndex(e => e.IdPeriod, "IX_sebeton_id_period");

            entity.HasIndex(e => new { e.IdPeriod, e.IdForm, e.BetonNo, e.IdBranch }, "IX_sebeton_id_period_id_branch_id_form_beton_no").IsUnique();

            entity.HasIndex(e => e.IdSms, "IX_sebeton_id_sms");

            entity.HasIndex(e => e.KrnHsb, "IX_sebeton_krn_hsb");

            entity.HasIndex(e => e.KrnHsbd, "IX_sebeton_krn_hsbd");

            entity.HasIndex(e => e.Maghsad, "IX_sebeton_maghsad");

            entity.HasIndex(e => e.MasehAnb, "IX_sebeton_maseh_anb");

            entity.HasIndex(e => e.MasehM, "IX_sebeton_maseh_m");

            entity.HasIndex(e => e.MixHsb, "IX_sebeton_mix_hsb");

            entity.HasIndex(e => e.MixHsbd, "IX_sebeton_mix_hsbd");

            entity.HasIndex(e => e.MntHsbd, "IX_sebeton_mnt_hsbd");

            entity.HasIndex(e => e.ShenAnb, "IX_sebeton_shen_anb");

            entity.HasIndex(e => e.ShenM, "IX_sebeton_shen_m");

            entity.HasIndex(e => e.SimanAnb, "IX_sebeton_siman_anb");

            entity.HasIndex(e => e.SimanM, "IX_sebeton_siman_m");

            entity.HasIndex(e => e.TkhHsb, "IX_sebeton_tkh_hsb");

            entity.HasIndex(e => e.TkhHsbd, "IX_sebeton_tkh_hsbd");

            entity.HasIndex(e => e.TknHsb, "IX_sebeton_tkn_hsb");

            entity.HasIndex(e => e.TknHsbd, "IX_sebeton_tkn_hsbd");

            entity.HasIndex(e => e.TktHsbd, "IX_sebeton_tkt_hsbd");

            entity.HasIndex(e => e.CtmHsb, "N");

            entity.Property(e => e.IdBeton)
                .ValueGeneratedNever()
                .HasColumnName("id_beton");
            entity.Property(e => e.Afz1Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("afz1_code");
            entity.Property(e => e.Afz1Karkh)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("afz1_karkh");
            entity.Property(e => e.Afz1Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("afz1_name");
            entity.Property(e => e.Afz1Vazn)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("afz1_vazn");
            entity.Property(e => e.Afz2Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("afz2_code");
            entity.Property(e => e.Afz2Karkh)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("afz2_karkh");
            entity.Property(e => e.Afz2Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("afz2_name");
            entity.Property(e => e.Afz2Vazn)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("afz2_vazn");
            entity.Property(e => e.Baraneid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("baraneid");
            entity.Property(e => e.BchHsbd).HasColumnName("bch_hsbd");
            entity.Property(e => e.BetonNo).HasColumnName("beton_no");
            entity.Property(e => e.BtnAyar).HasColumnName("btn_ayar");
            entity.Property(e => e.BtnFi)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("btn_fi");
            entity.Property(e => e.BtnHsb).HasColumnName("btn_hsb");
            entity.Property(e => e.BtnHsbd).HasColumnName("btn_hsbd");
            entity.Property(e => e.BtnKharid).HasColumnName("btn_kharid");
            entity.Property(e => e.BtnMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("btn_meter");
            entity.Property(e => e.BtnSefar)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("btn_sefar");
            entity.Property(e => e.Btntype).HasColumnName("btntype");
            entity.Property(e => e.BzrHsb).HasColumnName("bzr_hsb");
            entity.Property(e => e.BzrHsbd).HasColumnName("bzr_hsbd");
            entity.Property(e => e.BzrMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("bzr_mab");
            entity.Property(e => e.Cancel).HasColumnName("cancel");
            entity.Property(e => e.Colorid)
                .HasColumnType("numeric(8, 3)")
                .HasColumnName("colorid");
            entity.Property(e => e.Comment)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.CtmHsb).HasColumnName("ctm_hsb");
            entity.Property(e => e.CtmHsbd).HasColumnName("ctm_hsbd");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("date");
            entity.Property(e => e.Datetahvil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("datetahvil");
            entity.Property(e => e.Davaran)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("davaran");
            entity.Property(e => e.DrvHsbd).HasColumnName("drv_hsbd");
            entity.Property(e => e.DrvName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("drv_name");
            entity.Property(e => e.Eskelet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("eskelet");
            entity.Property(e => e.Eslamp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("eslamp");
            entity.Property(e => e.Esltype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("esltype");
            entity.Property(e => e.Eslvalue)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("eslvalue");
            entity.Property(e => e.FullMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("full_meter");
            entity.Property(e => e.Havabeton)
                .HasColumnType("numeric(8, 3)")
                .HasColumnName("havabeton");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdOk)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_ok");
            entity.Property(e => e.IdPeriod).HasColumnName("id_period");
            entity.Property(e => e.IdSms).HasColumnName("id_sms");
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
            entity.Property(e => e.KharidNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("kharid_no");
            entity.Property(e => e.Kharidtype)
                .HasDefaultValue((byte)1)
                .HasColumnName("kharidtype");
            entity.Property(e => e.KhrComp).HasColumnName("khr_comp");
            entity.Property(e => e.KhrFi).HasColumnName("khr_fi");
            entity.Property(e => e.KhrHsb).HasColumnName("khr_hsb");
            entity.Property(e => e.KhrHsbd).HasColumnName("khr_hsbd");
            entity.Property(e => e.KhrMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("khr_meter");
            entity.Property(e => e.KraDesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("kra_desc");
            entity.Property(e => e.KraMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kra_mab");
            entity.Property(e => e.KrnHsb).HasColumnName("krn_hsb");
            entity.Property(e => e.KrnHsbd).HasColumnName("krn_hsbd");
            entity.Property(e => e.KrnMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("krn_mab");
            entity.Property(e => e.KrnctmMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("krnctm_mab");
            entity.Property(e => e.KrndarMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("krndar_mab");
            entity.Property(e => e.KrnzarMab).HasColumnName("krnzar_mab");
            entity.Property(e => e.KrtFi).HasColumnName("krt_fi");
            entity.Property(e => e.KrtMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("krt_mab");
            entity.Property(e => e.KrtMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("krt_meter");
            entity.Property(e => e.KrtMode)
                .HasDefaultValue(true)
                .HasColumnName("krt_mode");
            entity.Property(e => e.KryFi).HasColumnName("kry_fi");
            entity.Property(e => e.KryMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kry_mab");
            entity.Property(e => e.KryMabtot)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kry_mabtot");
            entity.Property(e => e.Looleh)
                .HasColumnType("numeric(10, 1)")
                .HasColumnName("looleh");
            entity.Property(e => e.Maghsad)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("maghsad");
            entity.Property(e => e.Manualend).HasColumnName("manualend");
            entity.Property(e => e.MasehAnb).HasColumnName("maseh_anb");
            entity.Property(e => e.MasehM)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("maseh_m");
            entity.Property(e => e.MasehS)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("maseh_s");
            entity.Property(e => e.MasehV)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("maseh_v");
            entity.Property(e => e.MashinNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mashin_no");
            entity.Property(e => e.MashinNoa).HasColumnName("mashin_noa");
            entity.Property(e => e.MasoolK)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("masool_k");
            entity.Property(e => e.MazMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("maz_meter");
            entity.Property(e => e.MixHsb).HasColumnName("mix_hsb");
            entity.Property(e => e.MixHsbd).HasColumnName("mix_hsbd");
            entity.Property(e => e.MixbesFi).HasColumnName("mixbes_fi");
            entity.Property(e => e.MixbesFul)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("mixbes_ful");
            entity.Property(e => e.MixbesKra)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mixbes_kra");
            entity.Property(e => e.MixbesKrt)
                .HasDefaultValue(true)
                .HasColumnName("mixbes_krt");
            entity.Property(e => e.MixbesKtf).HasColumnName("mixbes_ktf");
            entity.Property(e => e.MixbesKtm)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mixbes_ktm");
            entity.Property(e => e.MixbesKtt)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("mixbes_ktt");
            entity.Property(e => e.MixbesMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mixbes_mab");
            entity.Property(e => e.MixbesMbt)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mixbes_mbt");
            entity.Property(e => e.MixbesTyp)
                .HasDefaultValue((byte)1)
                .HasColumnName("mixbes_typ");
            entity.Property(e => e.MizanHava)
                .HasColumnType("numeric(8, 3)")
                .HasColumnName("mizan_hava");
            entity.Property(e => e.MntHsbd).HasColumnName("mnt_hsbd");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mobileno");
            entity.Property(e => e.MogHsbd).HasColumnName("mog_hsbd");
            entity.Property(e => e.Mogheiat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mogheiat");
            entity.Property(e => e.MsfHsbd).HasColumnName("msf_hsbd");
            entity.Property(e => e.Naghes).HasColumnName("naghes");
            entity.Property(e => e.NewEdit)
                .HasDefaultValue(true)
                .HasColumnName("new_edit");
            entity.Property(e => e.ObchHsbd).HasColumnName("obch_hsbd");
            entity.Property(e => e.OpmpHsbd).HasColumnName("opmp_hsbd");
            entity.Property(e => e.OrdMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("ord_meter");
            entity.Property(e => e.PmpbesFi).HasColumnName("pmpbes_fi");
            entity.Property(e => e.PmpbesMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("pmpbes_mab");
            entity.Property(e => e.PmpbesMin)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("pmpbes_min");
            entity.Property(e => e.PmpbesTka)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("pmpbes_tka");
            entity.Property(e => e.PmpbesTkf).HasColumnName("pmpbes_tkf");
            entity.Property(e => e.PmpbesTkm)
                .HasDefaultValue(true)
                .HasColumnName("pmpbes_tkm");
            entity.Property(e => e.PmpbesTyp)
                .HasDefaultValue((byte)1)
                .HasColumnName("pmpbes_typ");
            entity.Property(e => e.Ques01).HasColumnName("ques01");
            entity.Property(e => e.Ques02).HasColumnName("ques02");
            entity.Property(e => e.Ques03).HasColumnName("ques03");
            entity.Property(e => e.Ques04).HasColumnName("ques04");
            entity.Property(e => e.Ques05).HasColumnName("ques05");
            entity.Property(e => e.Ques06).HasColumnName("ques06");
            entity.Property(e => e.SayeAt)
                .HasColumnType("datetime")
                .HasColumnName("saye_at");
            entity.Property(e => e.Sayeid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sayeid");
            entity.Property(e => e.Sendsms).HasColumnName("sendsms");
            entity.Property(e => e.Shen2Anb).HasColumnName("shen2_anb");
            entity.Property(e => e.Shen2M)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shen2_m");
            entity.Property(e => e.Shen2S)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shen2_s");
            entity.Property(e => e.Shen2V)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("shen2_v");
            entity.Property(e => e.ShenAnb).HasColumnName("shen_anb");
            entity.Property(e => e.ShenM)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shen_m");
            entity.Property(e => e.ShenS)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shen_s");
            entity.Property(e => e.ShenV)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("shen_v");
            entity.Property(e => e.ShiftNo)
                .HasDefaultValue((byte)1)
                .HasColumnName("shift_no");
            entity.Property(e => e.SimanAnb).HasColumnName("siman_anb");
            entity.Property(e => e.SimanM)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("siman_m");
            entity.Property(e => e.SimanV)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("siman_v");
            entity.Property(e => e.SmnHsbd).HasColumnName("smn_hsbd");
            entity.Property(e => e.TabeghehM)
                .HasColumnType("numeric(10, 1)")
                .HasColumnName("tabegheh_m");
            entity.Property(e => e.TahvilG)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tahvil_g");
            entity.Property(e => e.TempBeton)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("temp_beton");
            entity.Property(e => e.TempMohit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("temp_mohit");
            entity.Property(e => e.TempWater)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("temp_water");
            entity.Property(e => e.Time)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("time");
            entity.Property(e => e.TkaDesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tka_desc");
            entity.Property(e => e.TkaMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tka_mab");
            entity.Property(e => e.TkhDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tkh_desc");
            entity.Property(e => e.TkhFi).HasColumnName("tkh_fi");
            entity.Property(e => e.TkhHsb).HasColumnName("tkh_hsb");
            entity.Property(e => e.TkhHsbd).HasColumnName("tkh_hsbd");
            entity.Property(e => e.TkhMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tkh_mab");
            entity.Property(e => e.TkhMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("tkh_meter");
            entity.Property(e => e.TkhMin)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("tkh_min");
            entity.Property(e => e.TkmCalc)
                .HasDefaultValue(true)
                .HasColumnName("tkm_calc");
            entity.Property(e => e.TkmFi).HasColumnName("tkm_fi");
            entity.Property(e => e.TknHsb).HasColumnName("tkn_hsb");
            entity.Property(e => e.TknHsbd).HasColumnName("tkn_hsbd");
            entity.Property(e => e.TknMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tkn_mab");
            entity.Property(e => e.TknctmMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tknctm_mab");
            entity.Property(e => e.TkndarMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tkndar_mab");
            entity.Property(e => e.TktHsbd).HasColumnName("tkt_hsbd");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.Vazn)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn");
            entity.Property(e => e.Vazn1)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn1");
            entity.Property(e => e.Vazn1Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn1_date");
            entity.Property(e => e.Vazn1Row).HasColumnName("vazn1_row");
            entity.Property(e => e.Vazn1Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn1_time");
            entity.Property(e => e.Vazn2)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn2");
            entity.Property(e => e.Vazn2Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn2_date");
            entity.Property(e => e.Vazn2Row).HasColumnName("vazn2_row");
            entity.Property(e => e.Vazn2Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn2_time");
            entity.Property(e => e.VaznMakh)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("vazn_makh");
            entity.Property(e => e.VaznpkPrn).HasColumnName("vaznpk_prn");
            entity.Property(e => e.WaterV)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("water_v");
            entity.Property(e => e.Weighid)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.BchHsbdNavigation).WithMany(p => p.SebetonBchHsbdNavigations)
                .HasForeignKey(d => d.BchHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail4");

            entity.HasOne(d => d.BtnHsbNavigation).WithMany(p => p.SebetonBtnHsbNavigations)
                .HasForeignKey(d => d.BtnHsb)
                .HasConstraintName("FK_sebeton_sehesab4");

            entity.HasOne(d => d.BtnHsbdNavigation).WithMany(p => p.SebetonBtnHsbdNavigations)
                .HasForeignKey(d => d.BtnHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail7");

            entity.HasOne(d => d.BzrHsbNavigation).WithMany(p => p.SebetonBzrHsbNavigations)
                .HasForeignKey(d => d.BzrHsb)
                .HasConstraintName("FK_sebeton_sehesab");

            entity.HasOne(d => d.BzrHsbdNavigation).WithMany(p => p.SebetonBzrHsbdNavigations)
                .HasForeignKey(d => d.BzrHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail1");

            entity.HasOne(d => d.CtmHsbNavigation).WithMany(p => p.SebetonCtmHsbNavigations)
                .HasForeignKey(d => d.CtmHsb)
                .HasConstraintName("FK_sebeton_sehesab3");

            entity.HasOne(d => d.CtmHsbdNavigation).WithMany(p => p.SebetonCtmHsbdNavigations)
                .HasForeignKey(d => d.CtmHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail6");

            entity.HasOne(d => d.DrvHsbdNavigation).WithMany(p => p.SebetonDrvHsbdNavigations)
                .HasForeignKey(d => d.DrvHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail17");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Sebetons)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK_sebeton_sebranch");

            entity.HasOne(d => d.IdBrngrpNavigation).WithMany(p => p.Sebetons)
                .HasForeignKey(d => d.IdBrngrp)
                .HasConstraintName("FK_sebeton_sebranchgroup");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Sebetons)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sebeton_seforms");

            entity.HasOne(d => d.IdOkNavigation).WithMany(p => p.Sebetons)
                .HasForeignKey(d => d.IdOk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sebeton_seok");

            entity.HasOne(d => d.IdPeriodNavigation).WithMany(p => p.Sebetons)
                .HasForeignKey(d => d.IdPeriod)
                .HasConstraintName("FK_sebeton_seperiod");

            entity.HasOne(d => d.IdSmsNavigation).WithMany(p => p.Sebetons)
                .HasForeignKey(d => d.IdSms)
                .HasConstraintName("FK_sebeton_sms");

            entity.HasOne(d => d.KhrHsbNavigation).WithMany(p => p.SebetonKhrHsbNavigations)
                .HasForeignKey(d => d.KhrHsb)
                .HasConstraintName("FK_sebeton_sehesab2");

            entity.HasOne(d => d.KhrHsbdNavigation).WithMany(p => p.SebetonKhrHsbdNavigations)
                .HasForeignKey(d => d.KhrHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail2");

            entity.HasOne(d => d.KrnHsbNavigation).WithMany(p => p.SebetonKrnHsbNavigations)
                .HasForeignKey(d => d.KrnHsb)
                .HasConstraintName("FK_sebeton_sehesab9");

            entity.HasOne(d => d.KrnHsbdNavigation).WithMany(p => p.SebetonKrnHsbdNavigations)
                .HasForeignKey(d => d.KrnHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail14");

            entity.HasOne(d => d.MasehAnbNavigation).WithMany(p => p.SebetonMasehAnbNavigations)
                .HasForeignKey(d => d.MasehAnb)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail15");

            entity.HasOne(d => d.MixHsbNavigation).WithMany(p => p.SebetonMixHsbNavigations)
                .HasForeignKey(d => d.MixHsb)
                .HasConstraintName("FK_sebeton_sehesab8");

            entity.HasOne(d => d.MixHsbdNavigation).WithMany(p => p.SebetonMixHsbdNavigations)
                .HasForeignKey(d => d.MixHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail12");

            entity.HasOne(d => d.MntHsbdNavigation).WithMany(p => p.SebetonMntHsbdNavigations)
                .HasForeignKey(d => d.MntHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail3");

            entity.HasOne(d => d.MogHsbdNavigation).WithMany(p => p.SebetonMogHsbdNavigations)
                .HasForeignKey(d => d.MogHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail9");

            entity.HasOne(d => d.MsfHsbdNavigation).WithMany(p => p.SebetonMsfHsbdNavigations)
                .HasForeignKey(d => d.MsfHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail");

            entity.HasOne(d => d.Shen2AnbNavigation).WithMany(p => p.SebetonShen2AnbNavigations)
                .HasForeignKey(d => d.Shen2Anb)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail16");

            entity.HasOne(d => d.ShenAnbNavigation).WithMany(p => p.SebetonShenAnbNavigations)
                .HasForeignKey(d => d.ShenAnb)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail11");

            entity.HasOne(d => d.SimanAnbNavigation).WithMany(p => p.SebetonSimanAnbNavigations)
                .HasForeignKey(d => d.SimanAnb)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail5");

            entity.HasOne(d => d.SmnHsbdNavigation).WithMany(p => p.SebetonSmnHsbdNavigations)
                .HasForeignKey(d => d.SmnHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail8");

            entity.HasOne(d => d.TkhHsbNavigation).WithMany(p => p.SebetonTkhHsbNavigations)
                .HasForeignKey(d => d.TkhHsb)
                .HasConstraintName("FK_sebeton_sehesab6");

            entity.HasOne(d => d.TkhHsbdNavigation).WithMany(p => p.SebetonTkhHsbdNavigations)
                .HasForeignKey(d => d.TkhHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail10");

            entity.HasOne(d => d.TknHsbNavigation).WithMany(p => p.SebetonTknHsbNavigations)
                .HasForeignKey(d => d.TknHsb)
                .HasConstraintName("FK_sebeton_sehesab7");

            entity.HasOne(d => d.TknHsbdNavigation).WithMany(p => p.SebetonTknHsbdNavigations)
                .HasForeignKey(d => d.TknHsbd)
                .HasConstraintName("FK_sebeton_sehesabgroupdetail13");
        });

        modelBuilder.Entity<Sebranch>(entity =>
        {
            entity.HasKey(e => e.IdBranch);

            entity.ToTable("sebranch");

            entity.HasIndex(e => new { e.IdBrngrp, e.IdBrnrel, e.IdActive }, "IX_sebranch_id_brngrp_id_brnrel_id_active");

            entity.Property(e => e.IdBranch)
                .ValueGeneratedNever()
                .HasColumnName("id_branch");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
            entity.Property(e => e.IdBrnrel).HasColumnName("id_brnrel");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("''")
                .HasColumnName("name");
            entity.Property(e => e.TaxSend).HasColumnName("tax_send");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Sebranches)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sebranch_active");

            entity.HasOne(d => d.IdBrngrpNavigation).WithMany(p => p.Sebranches)
                .HasForeignKey(d => d.IdBrngrp)
                .HasConstraintName("FK_sebranch_sebranchgroup");

            entity.HasOne(d => d.IdBrnrelNavigation).WithMany(p => p.InverseIdBrnrelNavigation)
                .HasForeignKey(d => d.IdBrnrel)
                .HasConstraintName("FK_sebranch_sebranch");
        });

        modelBuilder.Entity<Sebranchgroup>(entity =>
        {
            entity.HasKey(e => e.IdBrngrp);

            entity.ToTable("sebranchgroup");

            entity.Property(e => e.IdBrngrp)
                .ValueGeneratedNever()
                .HasColumnName("id_brngrp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sebranchpermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sebranchpermission");

            entity.HasIndex(e => new { e.IdPermis, e.Active }, "IX_sebranchpermission_id_permis_active").IsClustered();

            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.IdPermis).HasColumnName("id_permis");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdPermisNavigation).WithMany()
                .HasForeignKey(d => d.IdPermis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sebranchpermission_sepermission");
        });

        modelBuilder.Entity<Sebranchuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sebranchusers");

            entity.HasIndex(e => new { e.IdBranch, e.IdUser, e.IdPermis }, "IX_sebranchusers_id_branch_id_user_id_permis").IsClustered();

            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdPermis).HasColumnName("id_permis");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");

            entity.HasOne(d => d.IdBranchNavigation).WithMany()
                .HasForeignKey(d => d.IdBranch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sebranchusers_sebranch");

            entity.HasOne(d => d.IdPermisNavigation).WithMany()
                .HasForeignKey(d => d.IdPermis)
                .HasConstraintName("FK_sebranchusers_sepermission");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sebranchusers_users");
        });

        modelBuilder.Entity<Secaption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("secaption");

            entity.Property(e => e.Caption)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("caption");
        });

        modelBuilder.Entity<Secheque>(entity =>
        {
            entity.HasKey(e => e.IdChq).HasName("PK_secheque_1");

            entity.ToTable("secheque");

            entity.HasIndex(e => e.Date, "IX_secheque_date");

            entity.HasIndex(e => e.IdChqpap, "IX_secheque_id_chqpap");

            entity.Property(e => e.IdChq)
                .ValueGeneratedNever()
                .HasColumnName("id_chq");
            entity.Property(e => e.DaftarNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("daftar_no");
            entity.Property(e => e.Darvajh)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("darvajh");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("date");
            entity.Property(e => e.IdChqpap).HasColumnName("id_chqpap");
            entity.Property(e => e.Mablagh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("mablagh");
            entity.Property(e => e.Melino)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("melino");
            entity.Property(e => e.NohavaleK).HasColumnName("nohavale_k");
            entity.Property(e => e.Printed).HasColumnName("printed");

            entity.HasOne(d => d.IdChqpapNavigation).WithMany(p => p.Secheques)
                .HasForeignKey(d => d.IdChqpap)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_secheque_sechequepaper");
        });

        modelBuilder.Entity<Sechequeform>(entity =>
        {
            entity.HasKey(e => e.IdChqfrm);

            entity.ToTable("sechequeform");

            entity.Property(e => e.IdChqfrm)
                .ValueGeneratedNever()
                .HasColumnName("id_chqfrm");
            entity.Property(e => e.Gridline)
                .HasDefaultValue((byte)2)
                .HasColumnName("gridline");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Orient)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("9EH/J")
                .HasColumnName("orient");
            entity.Property(e => e.PicHeight)
                .HasDefaultValue((short)85)
                .HasColumnName("pic_height");
            entity.Property(e => e.PicLeft).HasColumnName("pic_left");
            entity.Property(e => e.PicTop).HasColumnName("pic_top");
            entity.Property(e => e.PicWidth)
                .HasDefaultValue((short)170)
                .HasColumnName("pic_width");
            entity.Property(e => e.Picture)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("picture");
            entity.Property(e => e.Tartib)
                .HasDefaultValue(1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sechequeformitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sechequeformitems");

            entity.HasIndex(e => new { e.IdChqfrm, e.IdCITyp }, "IX_sechequeformitems_id_chqfrm_id_c_i_typ").IsClustered();

            entity.Property(e => e.Fontbold).HasColumnName("fontbold");
            entity.Property(e => e.Fontitalic).HasColumnName("fontitalic");
            entity.Property(e => e.Fontname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fontname");
            entity.Property(e => e.Fontsize).HasColumnName("fontsize");
            entity.Property(e => e.Fontunder).HasColumnName("fontunder");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.IdCITyp).HasColumnName("id_c_i_typ");
            entity.Property(e => e.IdChqfrm).HasColumnName("id_chqfrm");
            entity.Property(e => e.Left).HasColumnName("left");
            entity.Property(e => e.Lines).HasColumnName("lines");
            entity.Property(e => e.Right2left)
                .HasDefaultValue(true)
                .HasColumnName("right2left");
            entity.Property(e => e.Top).HasColumnName("top");
            entity.Property(e => e.Visible).HasColumnName("visible");
            entity.Property(e => e.Width).HasColumnName("width");

            entity.HasOne(d => d.IdCITypNavigation).WithMany()
                .HasForeignKey(d => d.IdCITyp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sechequeformitems_sechequeitemstype");

            entity.HasOne(d => d.IdChqfrmNavigation).WithMany()
                .HasForeignKey(d => d.IdChqfrm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sechequeformitems_sechequeform");
        });

        modelBuilder.Entity<Sechequeitemstype>(entity =>
        {
            entity.HasKey(e => e.IdCITyp);

            entity.ToTable("sechequeitemstype");

            entity.Property(e => e.IdCITyp).HasColumnName("id_c_i_typ");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sechequepaper>(entity =>
        {
            entity.HasKey(e => e.IdChqpap).HasName("PK_secheque");

            entity.ToTable("sechequepaper");

            entity.HasIndex(e => new { e.IdHsbdtl, e.IdChqfrm }, "IX_sechequepaper_id_hsbdtl_id_chqfrm");

            entity.HasIndex(e => new { e.IdHsbdtl, e.IdBank, e.Shobeh, e.Hesabno, e.ChequeNo }, "UQ_sechequepaper_id_hsbdtl_id_bank_shobeh_hesabno_cheque_no").IsUnique();

            entity.Property(e => e.IdChqpap)
                .ValueGeneratedNever()
                .HasColumnName("id_chqpap");
            entity.Property(e => e.ChequeNo)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("cheque_no");
            entity.Property(e => e.GeldNo).HasColumnName("geld_no");
            entity.Property(e => e.Hesabno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("hesabno");
            entity.Property(e => e.Hesabowner)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("hesabowner");
            entity.Property(e => e.IdBank).HasColumnName("id_bank");
            entity.Property(e => e.IdChqfrm).HasColumnName("id_chqfrm");
            entity.Property(e => e.IdHsbdtl).HasColumnName("id_hsbdtl");
            entity.Property(e => e.Shobeh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("shobeh");

            entity.HasOne(d => d.IdBankNavigation).WithMany(p => p.Sechequepapers)
                .HasForeignKey(d => d.IdBank)
                .HasConstraintName("FK_sechequepaper_sebank");

            entity.HasOne(d => d.IdChqfrmNavigation).WithMany(p => p.Sechequepapers)
                .HasForeignKey(d => d.IdChqfrm)
                .HasConstraintName("FK_sechequepaper_sechequeform");

            entity.HasOne(d => d.IdHsbdtlNavigation).WithMany(p => p.Sechequepapers)
                .HasForeignKey(d => d.IdHsbdtl)
                .HasConstraintName("FK_secheque_sehesabgroupdetail");
        });

        modelBuilder.Entity<Sechequestate>(entity =>
        {
            entity.HasKey(e => e.IdChqstat);

            entity.ToTable("sechequestate");

            entity.Property(e => e.IdChqstat).HasColumnName("id_chqstat");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Secollection>(entity =>
        {
            entity.HasKey(e => e.IdCol);

            entity.ToTable("secollection");

            entity.Property(e => e.IdCol)
                .ValueGeneratedNever()
                .HasColumnName("id_col");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Secollections)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_secollection_active");
        });

        modelBuilder.Entity<Secollectiondetail>(entity =>
        {
            entity.HasKey(e => e.IdColdtl);

            entity.ToTable("secollectiondetail");

            entity.HasIndex(e => new { e.IdCol, e.IdHsb, e.IdHsbdtl }, "IX_secollectiondetail_id_col_id_hsb_id_hsbdtl");

            entity.Property(e => e.IdColdtl)
                .ValueGeneratedNever()
                .HasColumnName("id_coldtl");
            entity.Property(e => e.IdCol).HasColumnName("id_col");
            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.IdHsbdtl).HasColumnName("id_hsbdtl");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
            entity.Property(e => e.Undertype).HasColumnName("undertype");

            entity.HasOne(d => d.IdColNavigation).WithMany(p => p.Secollectiondetails)
                .HasForeignKey(d => d.IdCol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_secollectiondetail_secollection");

            entity.HasOne(d => d.IdHsbNavigation).WithMany(p => p.Secollectiondetails)
                .HasForeignKey(d => d.IdHsb)
                .HasConstraintName("FK_secollectiondetail_sehesab");

            entity.HasOne(d => d.IdHsbdtlNavigation).WithMany(p => p.Secollectiondetails)
                .HasForeignKey(d => d.IdHsbdtl)
                .HasConstraintName("FK_secollectiondetail_sehesabgroupdetail");
        });

        modelBuilder.Entity<Secustomertitle>(entity =>
        {
            entity.HasKey(e => e.IdCtmtit);

            entity.ToTable("secustomertitles");

            entity.Property(e => e.IdCtmtit).HasColumnName("id_ctmtit");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sedatainput>(entity =>
        {
            entity.HasKey(e => e.IdInput);

            entity.ToTable("sedatainput");

            entity.Property(e => e.IdInput)
                .ValueGeneratedNever()
                .HasColumnName("id_input");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Sedatainputdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sedatainputdetail");

            entity.HasIndex(e => new { e.IdInput, e.IdHsbgIn }, "ClusteredIndex-20180710-103054").IsClustered();

            entity.Property(e => e.IdHsbgIn).HasColumnName("id_hsbg_in");
            entity.Property(e => e.IdHsbgOu).HasColumnName("id_hsbg_ou");
            entity.Property(e => e.IdInput).HasColumnName("id_input");
            entity.Property(e => e.Tartib).HasColumnName("tartib");

            entity.HasOne(d => d.IdHsbgInNavigation).WithMany()
                .HasForeignKey(d => d.IdHsbgIn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sedatainputdetail_sehesabgroup");

            entity.HasOne(d => d.IdInputNavigation).WithMany()
                .HasForeignKey(d => d.IdInput)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sedatainputdetail_sedatainput");
        });

        modelBuilder.Entity<Sedataoutput>(entity =>
        {
            entity.HasKey(e => e.IdOutput);

            entity.ToTable("sedataoutput");

            entity.Property(e => e.IdOutput)
                .ValueGeneratedNever()
                .HasColumnName("id_output");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Sedataoutputdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sedataoutputdetail");

            entity.HasIndex(e => new { e.IdOutput, e.IdHsbgrp }, "ClusteredIndex-20180710-103135").IsClustered();

            entity.Property(e => e.IdHsbgrp).HasColumnName("id_hsbgrp");
            entity.Property(e => e.IdOutput).HasColumnName("id_output");
            entity.Property(e => e.Tartib).HasColumnName("tartib");

            entity.HasOne(d => d.IdHsbgrpNavigation).WithMany()
                .HasForeignKey(d => d.IdHsbgrp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sedataoutput_sehesabgroup");

            entity.HasOne(d => d.IdOutputNavigation).WithMany()
                .HasForeignKey(d => d.IdOutput)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sedataoutputdetail_sedataoutput");
        });

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

            entity.HasOne(d => d.HsbBzrNavigation).WithMany(p => p.SefactorHsbBzrNavigations)
                .HasForeignKey(d => d.HsbBzr)
                .HasConstraintName("FK_sefactor_sehesab2");

            entity.HasOne(d => d.HsbCtmNavigation).WithMany(p => p.SefactorHsbCtmNavigations)
                .HasForeignKey(d => d.HsbCtm)
                .HasConstraintName("FK_sefactor_sehesab");

            entity.HasOne(d => d.HsbToNavigation).WithMany(p => p.SefactorHsbToNavigations)
                .HasForeignKey(d => d.HsbTo)
                .HasConstraintName("FK_sefactor_sehesab1");

            entity.HasOne(d => d.HsbdtlAnbNavigation).WithMany(p => p.SefactorHsbdtlAnbNavigations)
                .HasForeignKey(d => d.HsbdtlAnb)
                .HasConstraintName("FK_sefactor_sehesabgroupdetail2");

            entity.HasOne(d => d.HsbdtlBzrNavigation).WithMany(p => p.SefactorHsbdtlBzrNavigations)
                .HasForeignKey(d => d.HsbdtlBzr)
                .HasConstraintName("FK_sefactor_sehesabgroupdetail3");

            entity.HasOne(d => d.HsbdtlCtmNavigation).WithMany(p => p.SefactorHsbdtlCtmNavigations)
                .HasForeignKey(d => d.HsbdtlCtm)
                .HasConstraintName("FK_sefactor_sehesabgroupdetail");

            entity.HasOne(d => d.HsbdtlToNavigation).WithMany(p => p.SefactorHsbdtlToNavigations)
                .HasForeignKey(d => d.HsbdtlTo)
                .HasConstraintName("FK_sefactor_sehesabgroupdetail1");

            entity.HasOne(d => d.IdBarNavigation).WithMany(p => p.Sefactors)
                .HasForeignKey(d => d.IdBar)
                .HasConstraintName("FK_sefactor_sebarnameh");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Sefactors)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK_sefactor_sebranch");

            entity.HasOne(d => d.IdBrngrpNavigation).WithMany(p => p.Sefactors)
                .HasForeignKey(d => d.IdBrngrp)
                .HasConstraintName("FK_sefactor_sebranchgroup");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Sefactors)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactor_seforms");

            entity.HasOne(d => d.IdFshtypNavigation).WithMany(p => p.Sefactors)
                .HasForeignKey(d => d.IdFshtyp)
                .HasConstraintName("FK_sefactor_seforooshtype");

            entity.HasOne(d => d.IdKoshtarNavigation).WithMany(p => p.Sefactors)
                .HasForeignKey(d => d.IdKoshtar)
                .HasConstraintName("FK_sefactor_sekoshtar");

            entity.HasOne(d => d.IdOkNavigation).WithMany(p => p.Sefactors)
                .HasForeignKey(d => d.IdOk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactor_seok");

            entity.HasOne(d => d.IdPeriodNavigation).WithMany(p => p.Sefactors)
                .HasForeignKey(d => d.IdPeriod)
                .HasConstraintName("FK_sefactor_seperiod");
        });

        modelBuilder.Entity<Sefactorbarnameh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sefactorbarnameh");

            entity.HasIndex(e => e.IdBar, "IX_sefactorbarnameh_id_bar").IsUnique();

            entity.HasIndex(e => e.IdFactor, "IX_sefactorbarnameh_id_factor");

            entity.HasIndex(e => new { e.IdFactor, e.IdBar }, "IX_sefactorbarnameh_id_factor_id_bar");

            entity.Property(e => e.IdBar).HasColumnName("id_bar");
            entity.Property(e => e.IdFactor).HasColumnName("id_factor");
            entity.Property(e => e.Radif).HasColumnName("radif");

            entity.HasOne(d => d.IdBarNavigation).WithOne()
                .HasForeignKey<Sefactorbarnameh>(d => d.IdBar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactorbarnameh_sebarnameh");

            entity.HasOne(d => d.IdFactorNavigation).WithMany()
                .HasForeignKey(d => d.IdFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactorbarnameh_sefactor");
        });

        modelBuilder.Entity<Sefactorbazaryab>(entity =>
        {
            entity.HasKey(e => e.IdFctbzr);

            entity.ToTable("sefactorbazaryab");

            entity.HasIndex(e => new { e.IdFactor, e.HsbBzr, e.HsbdtlBzr, e.HsbTrf, e.HsbdtlTrf, e.Calctype }, "IX_sefactorbazaryab_id_factor_hsb_bzr_hsbdtl_bzr_hsb_trf_hsbdtl_trf_calctype");

            entity.Property(e => e.IdFctbzr).HasColumnName("id_fctbzr");
            entity.Property(e => e.Autoadd).HasColumnName("autoadd");
            entity.Property(e => e.Calctype).HasColumnName("calctype");
            entity.Property(e => e.Comment)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.Darsad)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("darsad");
            entity.Property(e => e.HsbBzr).HasColumnName("hsb_bzr");
            entity.Property(e => e.HsbTrf).HasColumnName("hsb_trf");
            entity.Property(e => e.HsbdtlBzr).HasColumnName("hsbdtl_bzr");
            entity.Property(e => e.HsbdtlTrf).HasColumnName("hsbdtl_trf");
            entity.Property(e => e.IdFactor).HasColumnName("id_factor");
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
            entity.Property(e => e.Mablagh).HasColumnName("mablagh");
            entity.Property(e => e.Tartib).HasColumnName("tartib");

            entity.HasOne(d => d.HsbBzrNavigation).WithMany(p => p.SefactorbazaryabHsbBzrNavigations)
                .HasForeignKey(d => d.HsbBzr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactorbazaryab_sehesab");

            entity.HasOne(d => d.HsbTrfNavigation).WithMany(p => p.SefactorbazaryabHsbTrfNavigations)
                .HasForeignKey(d => d.HsbTrf)
                .HasConstraintName("FK_sefactorbazaryab_sehesab1");

            entity.HasOne(d => d.HsbdtlBzrNavigation).WithMany(p => p.SefactorbazaryabHsbdtlBzrNavigations)
                .HasForeignKey(d => d.HsbdtlBzr)
                .HasConstraintName("FK_sefactorbazaryab_sehesabgroupdetail");

            entity.HasOne(d => d.HsbdtlTrfNavigation).WithMany(p => p.SefactorbazaryabHsbdtlTrfNavigations)
                .HasForeignKey(d => d.HsbdtlTrf)
                .HasConstraintName("FK_sefactorbazaryab_sehesabgroupdetail1");

            entity.HasOne(d => d.IdFactorNavigation).WithMany(p => p.Sefactorbazaryabs)
                .HasForeignKey(d => d.IdFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactorbazaryab_sefactor");
        });

        modelBuilder.Entity<Sefactorbeton>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sefactorbeton");

            entity.HasIndex(e => e.IdBeton, "IX_sefactorbeton_id_beton");

            entity.HasIndex(e => e.IdFactor, "IX_sefactorbeton_id_factor");

            entity.HasIndex(e => new { e.IdFactor, e.IdBeton }, "IX_sefactorbeton_id_factor_id_beton").IsClustered();

            entity.Property(e => e.IdBeton).HasColumnName("id_beton");
            entity.Property(e => e.IdFactor).HasColumnName("id_factor");
            entity.Property(e => e.Radif).HasColumnName("radif");

            entity.HasOne(d => d.IdBetonNavigation).WithMany()
                .HasForeignKey(d => d.IdBeton)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactorbeton_sebeton");

            entity.HasOne(d => d.IdFactorNavigation).WithMany()
                .HasForeignKey(d => d.IdFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactorbeton_sefactor");
        });

        modelBuilder.Entity<Sefactordetail>(entity =>
        {
            entity.HasKey(e => e.IdFctdtl);

            entity.ToTable("sefactordetail");

            entity.HasIndex(e => e.DateKal, "IX_sefactordetail_date_kal");

            entity.HasIndex(e => e.HsbKal, "IX_sefactordetail_hsb_kal");

            entity.HasIndex(e => e.HsbdtlKal, "IX_sefactordetail_hsbdtl_kal");

            entity.HasIndex(e => e.IdAnb, "IX_sefactordetail_id_anb");

            entity.HasIndex(e => e.IdFactor, "IX_sefactordetail_id_factor");

            entity.HasIndex(e => new { e.IdFactor, e.Detailtype, e.IdAnb, e.HsbKal, e.HsbdtlKal, e.HsbdtlPlt, e.IdHrDtl, e.IdFctscl }, "IX_sefactordetail_id_factor_detailtype_id_anb_hsb_kal_hsbdtl_kal_hsbdtl_plt_id_hr_dtl_id_fctscl");

            entity.HasIndex(e => e.IdFctscl, "IX_sefactordetail_id_fctscl");

            entity.HasIndex(e => e.IdHrDtl, "IX_sefactordetail_id_hr_dtl");

            entity.HasIndex(e => e.SerialKal, "IX_sefactordetail_serial_kal");

            entity.Property(e => e.IdFctdtl)
                .ValueGeneratedNever()
                .HasColumnName("id_fctdtl");
            entity.Property(e => e.Afzoodeh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("afzoodeh");
            entity.Property(e => e.AfzoodehD)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("afzoodeh_d");
            entity.Property(e => e.AnbShfDtl).HasColumnName("anb_shf_dtl");
            entity.Property(e => e.Autoadd).HasColumnName("autoadd");
            entity.Property(e => e.Autobar).HasColumnName("autobar");
            entity.Property(e => e.Autobeton).HasColumnName("autobeton");
            entity.Property(e => e.CommPrint)
                .HasDefaultValue((byte)1)
                .HasColumnName("comm_print");
            entity.Property(e => e.CommRadif)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comm_radif");
            entity.Property(e => e.Count)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("count");
            entity.Property(e => e.CountPlt)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("count_plt");
            entity.Property(e => e.CountR)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("count_r");
            entity.Property(e => e.CountTot)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("count_tot");
            entity.Property(e => e.DateKal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("date_kal");
            entity.Property(e => e.Detailtype).HasColumnName("detailtype");
            entity.Property(e => e.Fi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi");
            entity.Property(e => e.FiR)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi_r");
            entity.Property(e => e.HsbKal).HasColumnName("hsb_kal");
            entity.Property(e => e.HsbdtlKal).HasColumnName("hsbdtl_kal");
            entity.Property(e => e.HsbdtlPlt).HasColumnName("hsbdtl_plt");
            entity.Property(e => e.IdAnb).HasColumnName("id_anb");
            entity.Property(e => e.IdFactor).HasColumnName("id_factor");
            entity.Property(e => e.IdFctscl).HasColumnName("id_fctscl");
            entity.Property(e => e.IdHrDtl).HasColumnName("id_hr_dtl");
            entity.Property(e => e.IdUnitR).HasColumnName("id_unit_r");
            entity.Property(e => e.MabFormul)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mab_formul");
            entity.Property(e => e.MergeRow).HasColumnName("merge_row");
            entity.Property(e => e.MergeSnd).HasColumnName("merge_snd");
            entity.Property(e => e.MergedPrn).HasColumnName("merged_prn");
            entity.Property(e => e.Noanbarout).HasColumnName("noanbarout");
            entity.Property(e => e.Noprint).HasColumnName("noprint");
            entity.Property(e => e.Noprintunt).HasColumnName("noprintunt");
            entity.Property(e => e.Radif).HasColumnName("radif");
            entity.Property(e => e.Roundtype).HasColumnName("roundtype");
            entity.Property(e => e.Roundtype1).HasColumnName("roundtype1");
            entity.Property(e => e.Roweffect).HasColumnName("roweffect");
            entity.Property(e => e.SerialKal)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("serial_kal");
            entity.Property(e => e.Takhfif)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("takhfif");
            entity.Property(e => e.TakhfifFi)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("takhfif_fi");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("total");
            entity.Property(e => e.Total1)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("total1");
            entity.Property(e => e.Total2)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("total2");
            entity.Property(e => e.Vazn1)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn1");
            entity.Property(e => e.Vazn1Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn1_date");
            entity.Property(e => e.Vazn1Row).HasColumnName("vazn1_row");
            entity.Property(e => e.Vazn1Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn1_time");
            entity.Property(e => e.Vazn2)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn2");
            entity.Property(e => e.Vazn2Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn2_date");
            entity.Property(e => e.Vazn2Row).HasColumnName("vazn2_row");
            entity.Property(e => e.Vazn2Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn2_time");

            entity.HasOne(d => d.HsbKalNavigation).WithMany(p => p.Sefactordetails)
                .HasForeignKey(d => d.HsbKal)
                .HasConstraintName("FK_sefactordetail_sehesab");

            entity.HasOne(d => d.HsbdtlKalNavigation).WithMany(p => p.SefactordetailHsbdtlKalNavigations)
                .HasForeignKey(d => d.HsbdtlKal)
                .HasConstraintName("FK_sefactordetail_sehesabgroupdetail");

            entity.HasOne(d => d.HsbdtlPltNavigation).WithMany(p => p.SefactordetailHsbdtlPltNavigations)
                .HasForeignKey(d => d.HsbdtlPlt)
                .HasConstraintName("FK_sefactordetail_sehesabgroupdetail1");

            entity.HasOne(d => d.IdAnbNavigation).WithMany(p => p.SefactordetailIdAnbNavigations)
                .HasForeignKey(d => d.IdAnb)
                .HasConstraintName("FK_sefactordetail_sehesabgroupdetail2");

            entity.HasOne(d => d.IdFactorNavigation).WithMany(p => p.Sefactordetails)
                .HasForeignKey(d => d.IdFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactordetail_sefactor");

            entity.HasOne(d => d.IdFctsclNavigation).WithMany(p => p.Sefactordetails)
                .HasForeignKey(d => d.IdFctscl)
                .HasConstraintName("FK_sefactordetail_sefactorscale");

            entity.HasOne(d => d.IdHrDtlNavigation).WithMany(p => p.Sefactordetails)
                .HasForeignKey(d => d.IdHrDtl)
                .HasConstraintName("FK_sefactordetail_sehvlrsddetail");

            entity.HasOne(d => d.Sekalaunit).WithMany(p => p.Sefactordetails)
                .HasForeignKey(d => new { d.HsbdtlKal, d.IdUnitR })
                .HasConstraintName("FK_sefactordetail_sekalaunit");
        });

        modelBuilder.Entity<Sefactordetailpallet>(entity =>
        {
            entity.HasKey(e => e.IdFctplt);

            entity.ToTable("sefactordetailpallet");

            entity.HasIndex(e => new { e.IdFctdtl, e.HsbdtlPlt }, "IX_sefactordetailpallet_id_fctdtl_hsbdtl_plt");

            entity.Property(e => e.IdFctplt)
                .ValueGeneratedNever()
                .HasColumnName("id_fctplt");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.HsbdtlPlt).HasColumnName("hsbdtl_plt");
            entity.Property(e => e.IdFctdtl).HasColumnName("id_fctdtl");
            entity.Property(e => e.Radif).HasColumnName("radif");
            entity.Property(e => e.Vazn)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn");
            entity.Property(e => e.Vazntotal)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazntotal");

            entity.HasOne(d => d.HsbdtlPltNavigation).WithMany(p => p.Sefactordetailpallets)
                .HasForeignKey(d => d.HsbdtlPlt)
                .HasConstraintName("FK_sefactordetailpallet_sehesabgroupdetail");

            entity.HasOne(d => d.IdFctdtlNavigation).WithMany(p => p.Sefactordetailpallets)
                .HasForeignKey(d => d.IdFctdtl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactordetailpallet_sefactordetail");
        });

        modelBuilder.Entity<Sefactorrel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sefactorrel");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.IdFactor).HasColumnName("id_factor");
            entity.Property(e => e.IdFactorr).HasColumnName("id_factorr");
            entity.Property(e => e.IndtUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("indt_user");
            entity.Property(e => e.Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("time");

            entity.HasOne(d => d.IdFactorNavigation).WithMany()
                .HasForeignKey(d => d.IdFactor)
                .HasConstraintName("FK_sefactorrel_sefactor");

            entity.HasOne(d => d.IdFactorrNavigation).WithMany()
                .HasForeignKey(d => d.IdFactorr)
                .HasConstraintName("FK_sefactorrel_sefactor1");

            entity.HasOne(d => d.IndtUserNavigation).WithMany()
                .HasForeignKey(d => d.IndtUser)
                .HasConstraintName("FK_sefactorrel_users");
        });

        modelBuilder.Entity<Sefactorsanadrel>(entity =>
        {
            entity.HasKey(e => e.IdFctrel);

            entity.ToTable("sefactorsanadrel");

            entity.HasIndex(e => new { e.IdFactor, e.IdSanad, e.IdRow }, "IX_sefactorsanadrel_id_factor_id_sanad_id_row");

            entity.Property(e => e.IdFctrel).HasColumnName("id_fctrel");
            entity.Property(e => e.IdFactor).HasColumnName("id_factor");
            entity.Property(e => e.IdRow).HasColumnName("id_row");
            entity.Property(e => e.IdSanad).HasColumnName("id_sanad");
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
            entity.Property(e => e.Mablagh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mablagh");

            entity.HasOne(d => d.IdFactorNavigation).WithMany(p => p.Sefactorsanadrels)
                .HasForeignKey(d => d.IdFactor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sefactorsanadrel_sefactor");

            entity.HasOne(d => d.Sesanadrow).WithMany(p => p.Sefactorsanadrels)
                .HasForeignKey(d => new { d.IdSanad, d.IdRow })
                .HasConstraintName("FK_sefactorsanadrel_sesanadrows");
        });

        modelBuilder.Entity<Sefactorscale>(entity =>
        {
            entity.HasKey(e => e.IdFctscl).HasName("PK_factorscale");

            entity.ToTable("sefactorscale");

            entity.HasIndex(e => new { e.IdBranch, e.Date, e.IdScl, e.FactSerno, e.RowNo }, "IX_U_sefactorscale_id_branch_date_id_scl_fact_serno_row_no").IsUnique();

            entity.Property(e => e.IdFctscl).HasColumnName("id_fctscl");
            entity.Property(e => e.Cancel).HasColumnName("cancel");
            entity.Property(e => e.CellNo).HasColumnName("cell_no");
            entity.Property(e => e.Codekala)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("codekala");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("date");
            entity.Property(e => e.Devicecode).HasColumnName("devicecode");
            entity.Property(e => e.FactMegh)
                .HasColumnType("decimal(15, 6)")
                .HasColumnName("fact_megh");
            entity.Property(e => e.FactNo).HasColumnName("fact_no");
            entity.Property(e => e.FactRows).HasColumnName("fact_rows");
            entity.Property(e => e.FactSerno).HasColumnName("fact_serno");
            entity.Property(e => e.FactTotal).HasColumnName("fact_total");
            entity.Property(e => e.Fi).HasColumnName("fi");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdScl).HasColumnName("id_scl");
            entity.Property(e => e.IndexNo).HasColumnName("index_no");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ip");
            entity.Property(e => e.Marketcode).HasColumnName("marketcode");
            entity.Property(e => e.Meghdar)
                .HasColumnType("decimal(15, 6)")
                .HasColumnName("meghdar");
            entity.Property(e => e.RowNo).HasColumnName("row_no");
            entity.Property(e => e.Saletype)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("saletype");
            entity.Property(e => e.Storecode).HasColumnName("storecode");
            entity.Property(e => e.Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("time");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Vending).HasColumnName("vending");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Sefactorscales)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK_sefactorscale_sebranch");

            entity.HasOne(d => d.IdSclNavigation).WithMany(p => p.Sefactorscales)
                .HasForeignKey(d => d.IdScl)
                .HasConstraintName("FK_sefactorscale_sescale");
        });

        modelBuilder.Entity<Seform>(entity =>
        {
            entity.HasKey(e => e.IdForm);

            entity.ToTable("seforms");

            entity.HasIndex(e => new { e.IdFrmgrp, e.IdFormtyp, e.IdVajhtyp, e.IdActive }, "IX_seforms_id_frmgrp_id_formtyp_id_vajhtyp_id_active");

            entity.Property(e => e.IdForm)
                .ValueGeneratedNever()
                .HasColumnName("id_form");
            entity.Property(e => e.AnamixDar)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("anamix_dar");
            entity.Property(e => e.AnamixHaz)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("anamix_haz");
            entity.Property(e => e.AnapmpDar)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("anapmp_dar");
            entity.Property(e => e.AnapmpHaz)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("anapmp_haz");
            entity.Property(e => e.AnbCtm)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("anb_ctm");
            entity.Property(e => e.AutoFact)
                .HasDefaultValue(true)
                .HasColumnName("auto_fact");
            entity.Property(e => e.AutoSanad).HasColumnName("auto_sanad");
            entity.Property(e => e.Barnameh).HasColumnName("barnameh");
            entity.Property(e => e.BedbesChq).HasColumnName("bedbes_chq");
            entity.Property(e => e.BedbesSam).HasColumnName("bedbes_sam");
            entity.Property(e => e.Beton).HasColumnName("beton");
            entity.Property(e => e.Chequestat).HasColumnName("chequestat");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CommPrv)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comm_prv");
            entity.Property(e => e.CommPub)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comm_pub");
            entity.Property(e => e.Darpar).HasColumnName("darpar");
            entity.Property(e => e.FirstChq).HasColumnName("first_chq");
            entity.Property(e => e.Forceser)
                .HasDefaultValue(true)
                .HasColumnName("forceser");
            entity.Property(e => e.Forfactor).HasColumnName("forfactor");
            entity.Property(e => e.FrtFile)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frt_file");
            entity.Property(e => e.FrtFile1)
                .IsUnicode(false)
                .HasColumnName("frt_file1");
            entity.Property(e => e.FrtFile2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frt_file2");
            entity.Property(e => e.FrtFile3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frt_file3");
            entity.Property(e => e.FrtFile4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frt_file4");
            entity.Property(e => e.FrxFile)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frx_file");
            entity.Property(e => e.FrxFile1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frx_file1");
            entity.Property(e => e.FrxFile2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frx_file2");
            entity.Property(e => e.FrxFile3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frx_file3");
            entity.Property(e => e.FrxFile4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frx_file4");
            entity.Property(e => e.Ghabzsame).HasColumnName("ghabzsame");
            entity.Property(e => e.HsbgrpPlt).HasColumnName("hsbgrp_plt");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdFormtyp).HasColumnName("id_formtyp");
            entity.Property(e => e.IdFrmRel).HasColumnName("id_frm_rel");
            entity.Property(e => e.IdFrmgrp).HasColumnName("id_frmgrp");
            entity.Property(e => e.IdVajhtyp).HasColumnName("id_vajhtyp");
            entity.Property(e => e.KoshAmani).HasColumnName("kosh_amani");
            entity.Property(e => e.KoshClose).HasColumnName("kosh_close");
            entity.Property(e => e.Koshtar).HasColumnName("koshtar");
            entity.Property(e => e.KrymixDar)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("krymix_dar");
            entity.Property(e => e.KrymixHaz)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("krymix_haz");
            entity.Property(e => e.KrypmpDar)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("krypmp_dar");
            entity.Property(e => e.KrypmpHaz)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("krypmp_haz");
            entity.Property(e => e.MergeKb).HasColumnName("merge_kb");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Openbarcod).HasColumnName("openbarcod");
            entity.Property(e => e.Printtype)
                .HasDefaultValue((byte)1)
                .HasColumnName("printtype");
            entity.Property(e => e.PrnDesc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prn_desc1");
            entity.Property(e => e.PrnDesc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prn_desc2");
            entity.Property(e => e.PrnDesc3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prn_desc3");
            entity.Property(e => e.PrnDesc4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prn_desc4");
            entity.Property(e => e.PrnFixrow)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prn_fixrow");
            entity.Property(e => e.PrnInfo1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prn_info1");
            entity.Property(e => e.PrnInfo2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prn_info2");
            entity.Property(e => e.PrnInfo3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prn_info3");
            entity.Property(e => e.PrnInfo4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prn_info4");
            entity.Property(e => e.PrnMandeh).HasColumnName("prn_mandeh");
            entity.Property(e => e.PrnSumcnt).HasColumnName("prn_sumcnt");
            entity.Property(e => e.Prnnos1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prnnos1");
            entity.Property(e => e.Prnnos2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prnnos2");
            entity.Property(e => e.Prnnos3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prnnos3");
            entity.Property(e => e.Prnnos4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("prnnos4");
            entity.Property(e => e.Showvazn).HasColumnName("showvazn");
            entity.Property(e => e.Sndedgham).HasColumnName("sndedgham");
            entity.Property(e => e.TaxFcttas)
                .HasDefaultValue((byte)4)
                .HasColumnName("tax_fcttas");
            entity.Property(e => e.TaxFcttyp)
                .HasDefaultValue((byte)1)
                .HasColumnName("tax_fcttyp");
            entity.Property(e => e.TitleBed)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("title_bed");
            entity.Property(e => e.TitleBes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("title_bes");
            entity.Property(e => e.Transfer).HasColumnName("transfer");
            entity.Property(e => e.Vaseteh).HasColumnName("vaseteh");
            entity.Property(e => e.Vaznsecure).HasColumnName("vaznsecure");
            entity.Property(e => e.Zerorows).HasColumnName("zerorows");

            entity.HasOne(d => d.HsbgrpPltNavigation).WithMany(p => p.Seforms)
                .HasForeignKey(d => d.HsbgrpPlt)
                .HasConstraintName("FK_seforms_sehesabgroup");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Seforms)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seforms_seactive");

            entity.HasOne(d => d.IdFormtypNavigation).WithMany(p => p.Seforms)
                .HasForeignKey(d => d.IdFormtyp)
                .HasConstraintName("FK_seforms_seformtype");

            entity.HasOne(d => d.IdFrmRelNavigation).WithMany(p => p.InverseIdFrmRelNavigation)
                .HasForeignKey(d => d.IdFrmRel)
                .HasConstraintName("FK_seforms_seforms");

            entity.HasOne(d => d.IdFrmgrpNavigation).WithMany(p => p.Seforms)
                .HasForeignKey(d => d.IdFrmgrp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seforms_seformsgroup");

            entity.HasOne(d => d.IdVajhtypNavigation).WithMany(p => p.Seforms)
                .HasForeignKey(d => d.IdVajhtyp)
                .HasConstraintName("FK_seforms_sesanadvajhtype");
        });

        modelBuilder.Entity<Seformsgroup>(entity =>
        {
            entity.HasKey(e => e.IdFrmgrp);

            entity.ToTable("seformsgroup");

            entity.Property(e => e.IdFrmgrp)
                .ValueGeneratedNever()
                .HasColumnName("id_frmgrp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Seformshesab>(entity =>
        {
            entity.HasKey(e => e.IdFrmhsb);

            entity.ToTable("seformshesab");

            entity.HasIndex(e => new { e.IdForm, e.ParType, e.IdHsb, e.IdHsbdtl, e.IdHsbgrp }, "IX_seformshesab_id_form_par_type_id_hsb_id_hsbdtl_id_hsbgrp");

            entity.Property(e => e.IdFrmhsb)
                .ValueGeneratedNever()
                .HasColumnName("id_frmhsb");
            entity.Property(e => e.Ask).HasColumnName("ask");
            entity.Property(e => e.CommPrint)
                .HasDefaultValue((byte)1)
                .HasColumnName("comm_print");
            entity.Property(e => e.CommRadif)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comm_radif");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.IdHsbdtl).HasColumnName("id_hsbdtl");
            entity.Property(e => e.IdHsbgrp).HasColumnName("id_hsbgrp");
            entity.Property(e => e.MabFormul)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mab_formul");
            entity.Property(e => e.OrderC)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("order_c");
            entity.Property(e => e.ParType).HasColumnName("par_type");
            entity.Property(e => e.Roundtype).HasColumnName("roundtype");
            entity.Property(e => e.Roundtype1).HasColumnName("roundtype1");
            entity.Property(e => e.Roweffect).HasColumnName("roweffect");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
            entity.Property(e => e.Undertype).HasColumnName("undertype");
            entity.Property(e => e.WhereC)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("where_c");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Seformshesabs)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seformshesab_seforms");

            entity.HasOne(d => d.IdHsbNavigation).WithMany(p => p.Seformshesabs)
                .HasForeignKey(d => d.IdHsb)
                .HasConstraintName("FK_seformshesab_sehesab");

            entity.HasOne(d => d.IdHsbdtlNavigation).WithMany(p => p.Seformshesabs)
                .HasForeignKey(d => d.IdHsbdtl)
                .HasConstraintName("FK_seformshesab_sehesabgroupdetail");

            entity.HasOne(d => d.IdHsbgrpNavigation).WithMany(p => p.Seformshesabs)
                .HasForeignKey(d => d.IdHsbgrp)
                .HasConstraintName("FK_seformshesab_sehesabgroup");
        });

        modelBuilder.Entity<Seformsrelation>(entity =>
        {
            entity.HasKey(e => e.IdFrmrel);

            entity.ToTable("seformsrelation");

            entity.HasIndex(e => new { e.IdFormM, e.IdForm }, "IX_seformsrelation_id_form_m_id_form");

            entity.Property(e => e.IdFrmrel)
                .ValueGeneratedNever()
                .HasColumnName("id_frmrel");
            entity.Property(e => e.CtmBedtyp).HasColumnName("ctm_bedtyp");
            entity.Property(e => e.CtmBestyp).HasColumnName("ctm_bestyp");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdFormM).HasColumnName("id_form_m");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.SeformsrelationIdFormNavigations)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seformsrelation_seforms1");

            entity.HasOne(d => d.IdFormMNavigation).WithMany(p => p.SeformsrelationIdFormMNavigations)
                .HasForeignKey(d => d.IdFormM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seformsrelation_seforms");
        });

        modelBuilder.Entity<Seformtype>(entity =>
        {
            entity.HasKey(e => e.IdFormtyp).HasName("PK_sesanadtype");

            entity.ToTable("seformtype");

            entity.Property(e => e.IdFormtyp)
                .ValueGeneratedNever()
                .HasColumnName("id_formtyp");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Relfiles)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("relfiles");
            entity.Property(e => e.Repfile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("repfile");
            entity.Property(e => e.Repfileinf)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("repfileinf");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Seformtypepermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seformtypepermission");

            entity.HasIndex(e => new { e.IdFormtyp, e.IdPermis, e.Active }, "IX_seformtypepermission_id_formtyp_id_permis_active").IsClustered();

            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.IdFormtyp).HasColumnName("id_formtyp");
            entity.Property(e => e.IdPermis).HasColumnName("id_permis");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdFormtypNavigation).WithMany()
                .HasForeignKey(d => d.IdFormtyp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seformtypepermission_seformtype");

            entity.HasOne(d => d.IdPermisNavigation).WithMany()
                .HasForeignKey(d => d.IdPermis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seformtypepermission_sepermission");
        });

        modelBuilder.Entity<Seformuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seformusers");

            entity.HasIndex(e => new { e.IdForm, e.IdFrmgrp, e.IdUser, e.IdPermis }, "IX_seformusers_id_form_id_frmgrp_id_user_id_permis").IsClustered();

            entity.Property(e => e.Add).HasColumnName("add");
            entity.Property(e => e.Add1).HasColumnName("add_1");
            entity.Property(e => e.Delete).HasColumnName("delete");
            entity.Property(e => e.Delete1).HasColumnName("delete_1");
            entity.Property(e => e.Edit).HasColumnName("edit");
            entity.Property(e => e.Edit1).HasColumnName("edit_1");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdFrmgrp).HasColumnName("id_frmgrp");
            entity.Property(e => e.IdPermis).HasColumnName("id_permis");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");
            entity.Property(e => e.Print).HasColumnName("print");
            entity.Property(e => e.Print1).HasColumnName("print_1");
            entity.Property(e => e.View).HasColumnName("view");
            entity.Property(e => e.View1).HasColumnName("view_1");

            entity.HasOne(d => d.IdFormNavigation).WithMany()
                .HasForeignKey(d => d.IdForm)
                .HasConstraintName("FK_seformusers_seforms");

            entity.HasOne(d => d.IdFrmgrpNavigation).WithMany()
                .HasForeignKey(d => d.IdFrmgrp)
                .HasConstraintName("FK_seformusers_seformsgroup");

            entity.HasOne(d => d.IdPermisNavigation).WithMany()
                .HasForeignKey(d => d.IdPermis)
                .HasConstraintName("FK_seformusers_sepermission");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seformusers_users");
        });

        modelBuilder.Entity<Seforooshtype>(entity =>
        {
            entity.HasKey(e => e.IdFshtyp);

            entity.ToTable("seforooshtype");

            entity.Property(e => e.IdFshtyp).HasColumnName("id_fshtyp");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Sehesab>(entity =>
        {
            entity.HasKey(e => e.IdHsb);

            entity.ToTable("sehesab");

            entity.HasIndex(e => e.Code, "IX_sehesab_code");

            entity.HasIndex(e => new { e.Code, e.Name, e.ParentHsb, e.IdActive }, "IX_sehesab_code_name_parent_hsb_id_active");

            entity.HasIndex(e => e.IdHsbgrp, "IX_sehesab_id_hsbgrp");

            entity.HasIndex(e => e.KeyStr, "IX_sehesab_key_str");

            entity.HasIndex(e => e.ParentHsb, "IX_sehesab_parent_hsb");

            entity.Property(e => e.IdHsb)
                .ValueGeneratedNever()
                .HasColumnName("id_hsb");
            entity.Property(e => e.Aqsat).HasColumnName("aqsat");
            entity.Property(e => e.Code)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("code");
            entity.Property(e => e.CodeHsb)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("code_hsb");
            entity.Property(e => e.Enteghal)
                .HasDefaultValue(true)
                .HasColumnName("enteghal");
            entity.Property(e => e.Forceaqsat).HasColumnName("forceaqsat");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdHpar1).HasColumnName("id_hpar1");
            entity.Property(e => e.IdHpar10).HasColumnName("id_hpar10");
            entity.Property(e => e.IdHpar11).HasColumnName("id_hpar11");
            entity.Property(e => e.IdHpar12).HasColumnName("id_hpar12");
            entity.Property(e => e.IdHpar13).HasColumnName("id_hpar13");
            entity.Property(e => e.IdHpar14).HasColumnName("id_hpar14");
            entity.Property(e => e.IdHpar15).HasColumnName("id_hpar15");
            entity.Property(e => e.IdHpar16).HasColumnName("id_hpar16");
            entity.Property(e => e.IdHpar17).HasColumnName("id_hpar17");
            entity.Property(e => e.IdHpar18).HasColumnName("id_hpar18");
            entity.Property(e => e.IdHpar19).HasColumnName("id_hpar19");
            entity.Property(e => e.IdHpar2).HasColumnName("id_hpar2");
            entity.Property(e => e.IdHpar20).HasColumnName("id_hpar20");
            entity.Property(e => e.IdHpar21).HasColumnName("id_hpar21");
            entity.Property(e => e.IdHpar22).HasColumnName("id_hpar22");
            entity.Property(e => e.IdHpar23).HasColumnName("id_hpar23");
            entity.Property(e => e.IdHpar24).HasColumnName("id_hpar24");
            entity.Property(e => e.IdHpar25).HasColumnName("id_hpar25");
            entity.Property(e => e.IdHpar26).HasColumnName("id_hpar26");
            entity.Property(e => e.IdHpar27).HasColumnName("id_hpar27");
            entity.Property(e => e.IdHpar28).HasColumnName("id_hpar28");
            entity.Property(e => e.IdHpar29).HasColumnName("id_hpar29");
            entity.Property(e => e.IdHpar3).HasColumnName("id_hpar3");
            entity.Property(e => e.IdHpar30).HasColumnName("id_hpar30");
            entity.Property(e => e.IdHpar31).HasColumnName("id_hpar31");
            entity.Property(e => e.IdHpar32).HasColumnName("id_hpar32");
            entity.Property(e => e.IdHpar33).HasColumnName("id_hpar33");
            entity.Property(e => e.IdHpar34).HasColumnName("id_hpar34");
            entity.Property(e => e.IdHpar35).HasColumnName("id_hpar35");
            entity.Property(e => e.IdHpar36).HasColumnName("id_hpar36");
            entity.Property(e => e.IdHpar37).HasColumnName("id_hpar37");
            entity.Property(e => e.IdHpar38).HasColumnName("id_hpar38");
            entity.Property(e => e.IdHpar39).HasColumnName("id_hpar39");
            entity.Property(e => e.IdHpar4).HasColumnName("id_hpar4");
            entity.Property(e => e.IdHpar40).HasColumnName("id_hpar40");
            entity.Property(e => e.IdHpar41).HasColumnName("id_hpar41");
            entity.Property(e => e.IdHpar42).HasColumnName("id_hpar42");
            entity.Property(e => e.IdHpar43).HasColumnName("id_hpar43");
            entity.Property(e => e.IdHpar44).HasColumnName("id_hpar44");
            entity.Property(e => e.IdHpar45).HasColumnName("id_hpar45");
            entity.Property(e => e.IdHpar46).HasColumnName("id_hpar46");
            entity.Property(e => e.IdHpar47).HasColumnName("id_hpar47");
            entity.Property(e => e.IdHpar48).HasColumnName("id_hpar48");
            entity.Property(e => e.IdHpar49).HasColumnName("id_hpar49");
            entity.Property(e => e.IdHpar5).HasColumnName("id_hpar5");
            entity.Property(e => e.IdHpar50).HasColumnName("id_hpar50");
            entity.Property(e => e.IdHpar6).HasColumnName("id_hpar6");
            entity.Property(e => e.IdHpar7).HasColumnName("id_hpar7");
            entity.Property(e => e.IdHpar8).HasColumnName("id_hpar8");
            entity.Property(e => e.IdHpar9).HasColumnName("id_hpar9");
            entity.Property(e => e.IdHsbd).HasColumnName("id_hsbd");
            entity.Property(e => e.IdHsbgrp).HasColumnName("id_hsbgrp");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.KeyStr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("key_str");
            entity.Property(e => e.NaAfter)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("na_after");
            entity.Property(e => e.NaBefore)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("na_before");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NameComp)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name_comp");
            entity.Property(e => e.ParentHsb).HasColumnName("parent_hsb");
            entity.Property(e => e.Type)
                .HasDefaultValue((byte)1)
                .HasColumnName("type");
            entity.Property(e => e.Typemandeh)
                .HasDefaultValue((byte)1)
                .HasColumnName("typemandeh");
            entity.Property(e => e.VaHpar501)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar501");
            entity.Property(e => e.VaHpar502)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar502");
            entity.Property(e => e.VaHpar503)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar503");
            entity.Property(e => e.VaHpar504)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar504");
            entity.Property(e => e.VaHpar505)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar505");
            entity.Property(e => e.VaHpar506)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar506");
            entity.Property(e => e.VaHpar507)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar507");
            entity.Property(e => e.VaHpar508)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar508");
            entity.Property(e => e.VaHpar509)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar509");
            entity.Property(e => e.VaHpar510)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar510");
            entity.Property(e => e.VaHpar511)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar511");
            entity.Property(e => e.VaHpar512)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar512");
            entity.Property(e => e.VaHpar513)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar513");
            entity.Property(e => e.VaHpar514)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar514");
            entity.Property(e => e.VaHpar515)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar515");
            entity.Property(e => e.VaHpar516)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar516");
            entity.Property(e => e.VaHpar517)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar517");
            entity.Property(e => e.VaHpar518)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar518");
            entity.Property(e => e.VaHpar519)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar519");
            entity.Property(e => e.VaHpar520)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar520");
            entity.Property(e => e.VaHpar521)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar521");
            entity.Property(e => e.VaHpar522)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar522");
            entity.Property(e => e.VaHpar523)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar523");
            entity.Property(e => e.VaHpar524)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar524");
            entity.Property(e => e.VaHpar525)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar525");
            entity.Property(e => e.VaHpar526)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar526");
            entity.Property(e => e.VaHpar527)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar527");
            entity.Property(e => e.VaHpar528)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar528");
            entity.Property(e => e.VaHpar529)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar529");
            entity.Property(e => e.VaHpar530)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar530");
            entity.Property(e => e.VaHpar531)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar531");
            entity.Property(e => e.VaHpar532)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar532");
            entity.Property(e => e.VaHpar533)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar533");
            entity.Property(e => e.VaHpar534)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar534");
            entity.Property(e => e.VaHpar535)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar535");
            entity.Property(e => e.VaHpar536)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar536");
            entity.Property(e => e.VaHpar537)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar537");
            entity.Property(e => e.VaHpar538)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar538");
            entity.Property(e => e.VaHpar539)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar539");
            entity.Property(e => e.VaHpar540)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar540");
            entity.Property(e => e.VaHpar541)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar541");
            entity.Property(e => e.VaHpar542)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar542");
            entity.Property(e => e.VaHpar543)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar543");
            entity.Property(e => e.VaHpar544)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar544");
            entity.Property(e => e.VaHpar545)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar545");
            entity.Property(e => e.VaHpar546)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar546");
            entity.Property(e => e.VaHpar547)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar547");
            entity.Property(e => e.VaHpar548)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar548");
            entity.Property(e => e.VaHpar549)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar549");
            entity.Property(e => e.VaHpar550)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar550");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Sehesabs)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesab_active");

            entity.HasOne(d => d.IdHpar1Navigation).WithMany(p => p.SehesabIdHpar1Navigations)
                .HasForeignKey(d => d.IdHpar1)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail");

            entity.HasOne(d => d.IdHpar10Navigation).WithMany(p => p.SehesabIdHpar10Navigations)
                .HasForeignKey(d => d.IdHpar10)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail9");

            entity.HasOne(d => d.IdHpar11Navigation).WithMany(p => p.SehesabIdHpar11Navigations)
                .HasForeignKey(d => d.IdHpar11)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail10");

            entity.HasOne(d => d.IdHpar12Navigation).WithMany(p => p.SehesabIdHpar12Navigations)
                .HasForeignKey(d => d.IdHpar12)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail11");

            entity.HasOne(d => d.IdHpar13Navigation).WithMany(p => p.SehesabIdHpar13Navigations)
                .HasForeignKey(d => d.IdHpar13)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail12");

            entity.HasOne(d => d.IdHpar14Navigation).WithMany(p => p.SehesabIdHpar14Navigations)
                .HasForeignKey(d => d.IdHpar14)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail13");

            entity.HasOne(d => d.IdHpar15Navigation).WithMany(p => p.SehesabIdHpar15Navigations)
                .HasForeignKey(d => d.IdHpar15)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail14");

            entity.HasOne(d => d.IdHpar16Navigation).WithMany(p => p.SehesabIdHpar16Navigations)
                .HasForeignKey(d => d.IdHpar16)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail15");

            entity.HasOne(d => d.IdHpar17Navigation).WithMany(p => p.SehesabIdHpar17Navigations)
                .HasForeignKey(d => d.IdHpar17)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail16");

            entity.HasOne(d => d.IdHpar18Navigation).WithMany(p => p.SehesabIdHpar18Navigations)
                .HasForeignKey(d => d.IdHpar18)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail17");

            entity.HasOne(d => d.IdHpar19Navigation).WithMany(p => p.SehesabIdHpar19Navigations)
                .HasForeignKey(d => d.IdHpar19)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail18");

            entity.HasOne(d => d.IdHpar2Navigation).WithMany(p => p.SehesabIdHpar2Navigations)
                .HasForeignKey(d => d.IdHpar2)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail1");

            entity.HasOne(d => d.IdHpar20Navigation).WithMany(p => p.SehesabIdHpar20Navigations)
                .HasForeignKey(d => d.IdHpar20)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail19");

            entity.HasOne(d => d.IdHpar21Navigation).WithMany(p => p.SehesabIdHpar21Navigations)
                .HasForeignKey(d => d.IdHpar21)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail20");

            entity.HasOne(d => d.IdHpar22Navigation).WithMany(p => p.SehesabIdHpar22Navigations)
                .HasForeignKey(d => d.IdHpar22)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail21");

            entity.HasOne(d => d.IdHpar23Navigation).WithMany(p => p.SehesabIdHpar23Navigations)
                .HasForeignKey(d => d.IdHpar23)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail22");

            entity.HasOne(d => d.IdHpar24Navigation).WithMany(p => p.SehesabIdHpar24Navigations)
                .HasForeignKey(d => d.IdHpar24)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail23");

            entity.HasOne(d => d.IdHpar25Navigation).WithMany(p => p.SehesabIdHpar25Navigations)
                .HasForeignKey(d => d.IdHpar25)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail24");

            entity.HasOne(d => d.IdHpar26Navigation).WithMany(p => p.SehesabIdHpar26Navigations)
                .HasForeignKey(d => d.IdHpar26)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail25");

            entity.HasOne(d => d.IdHpar27Navigation).WithMany(p => p.SehesabIdHpar27Navigations)
                .HasForeignKey(d => d.IdHpar27)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail26");

            entity.HasOne(d => d.IdHpar28Navigation).WithMany(p => p.SehesabIdHpar28Navigations)
                .HasForeignKey(d => d.IdHpar28)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail27");

            entity.HasOne(d => d.IdHpar29Navigation).WithMany(p => p.SehesabIdHpar29Navigations)
                .HasForeignKey(d => d.IdHpar29)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail28");

            entity.HasOne(d => d.IdHpar3Navigation).WithMany(p => p.SehesabIdHpar3Navigations)
                .HasForeignKey(d => d.IdHpar3)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail2");

            entity.HasOne(d => d.IdHpar30Navigation).WithMany(p => p.SehesabIdHpar30Navigations)
                .HasForeignKey(d => d.IdHpar30)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail29");

            entity.HasOne(d => d.IdHpar31Navigation).WithMany(p => p.SehesabIdHpar31Navigations)
                .HasForeignKey(d => d.IdHpar31)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail30");

            entity.HasOne(d => d.IdHpar32Navigation).WithMany(p => p.SehesabIdHpar32Navigations)
                .HasForeignKey(d => d.IdHpar32)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail31");

            entity.HasOne(d => d.IdHpar33Navigation).WithMany(p => p.SehesabIdHpar33Navigations)
                .HasForeignKey(d => d.IdHpar33)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail32");

            entity.HasOne(d => d.IdHpar34Navigation).WithMany(p => p.SehesabIdHpar34Navigations)
                .HasForeignKey(d => d.IdHpar34)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail33");

            entity.HasOne(d => d.IdHpar35Navigation).WithMany(p => p.SehesabIdHpar35Navigations)
                .HasForeignKey(d => d.IdHpar35)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail34");

            entity.HasOne(d => d.IdHpar36Navigation).WithMany(p => p.SehesabIdHpar36Navigations)
                .HasForeignKey(d => d.IdHpar36)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail35");

            entity.HasOne(d => d.IdHpar37Navigation).WithMany(p => p.SehesabIdHpar37Navigations)
                .HasForeignKey(d => d.IdHpar37)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail36");

            entity.HasOne(d => d.IdHpar38Navigation).WithMany(p => p.SehesabIdHpar38Navigations)
                .HasForeignKey(d => d.IdHpar38)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail37");

            entity.HasOne(d => d.IdHpar39Navigation).WithMany(p => p.SehesabIdHpar39Navigations)
                .HasForeignKey(d => d.IdHpar39)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail38");

            entity.HasOne(d => d.IdHpar4Navigation).WithMany(p => p.SehesabIdHpar4Navigations)
                .HasForeignKey(d => d.IdHpar4)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail3");

            entity.HasOne(d => d.IdHpar40Navigation).WithMany(p => p.SehesabIdHpar40Navigations)
                .HasForeignKey(d => d.IdHpar40)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail39");

            entity.HasOne(d => d.IdHpar41Navigation).WithMany(p => p.SehesabIdHpar41Navigations)
                .HasForeignKey(d => d.IdHpar41)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail40");

            entity.HasOne(d => d.IdHpar42Navigation).WithMany(p => p.SehesabIdHpar42Navigations)
                .HasForeignKey(d => d.IdHpar42)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail41");

            entity.HasOne(d => d.IdHpar43Navigation).WithMany(p => p.SehesabIdHpar43Navigations)
                .HasForeignKey(d => d.IdHpar43)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail42");

            entity.HasOne(d => d.IdHpar44Navigation).WithMany(p => p.SehesabIdHpar44Navigations)
                .HasForeignKey(d => d.IdHpar44)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail43");

            entity.HasOne(d => d.IdHpar45Navigation).WithMany(p => p.SehesabIdHpar45Navigations)
                .HasForeignKey(d => d.IdHpar45)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail44");

            entity.HasOne(d => d.IdHpar46Navigation).WithMany(p => p.SehesabIdHpar46Navigations)
                .HasForeignKey(d => d.IdHpar46)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail45");

            entity.HasOne(d => d.IdHpar47Navigation).WithMany(p => p.SehesabIdHpar47Navigations)
                .HasForeignKey(d => d.IdHpar47)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail46");

            entity.HasOne(d => d.IdHpar48Navigation).WithMany(p => p.SehesabIdHpar48Navigations)
                .HasForeignKey(d => d.IdHpar48)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail47");

            entity.HasOne(d => d.IdHpar49Navigation).WithMany(p => p.SehesabIdHpar49Navigations)
                .HasForeignKey(d => d.IdHpar49)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail48");

            entity.HasOne(d => d.IdHpar5Navigation).WithMany(p => p.SehesabIdHpar5Navigations)
                .HasForeignKey(d => d.IdHpar5)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail4");

            entity.HasOne(d => d.IdHpar50Navigation).WithMany(p => p.SehesabIdHpar50Navigations)
                .HasForeignKey(d => d.IdHpar50)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail49");

            entity.HasOne(d => d.IdHpar6Navigation).WithMany(p => p.SehesabIdHpar6Navigations)
                .HasForeignKey(d => d.IdHpar6)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail5");

            entity.HasOne(d => d.IdHpar7Navigation).WithMany(p => p.SehesabIdHpar7Navigations)
                .HasForeignKey(d => d.IdHpar7)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail6");

            entity.HasOne(d => d.IdHpar8Navigation).WithMany(p => p.SehesabIdHpar8Navigations)
                .HasForeignKey(d => d.IdHpar8)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail7");

            entity.HasOne(d => d.IdHpar9Navigation).WithMany(p => p.SehesabIdHpar9Navigations)
                .HasForeignKey(d => d.IdHpar9)
                .HasConstraintName("FK_sehesab_sehesabparametersdetail8");

            entity.HasOne(d => d.IdHsbdNavigation).WithMany(p => p.Sehesabs)
                .HasForeignKey(d => d.IdHsbd)
                .HasConstraintName("FK_sehesab_sehesabgroupdetail");

            entity.HasOne(d => d.IdHsbgrpNavigation).WithMany(p => p.Sehesabs)
                .HasForeignKey(d => d.IdHsbgrp)
                .HasConstraintName("FK_sehesab_sehesabgroup");

            entity.HasOne(d => d.ParentHsbNavigation).WithMany(p => p.InverseParentHsbNavigation)
                .HasForeignKey(d => d.ParentHsb)
                .HasConstraintName("FK_sehesab_sehesab");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.SehesabTypeNavigations)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesab_sehesabtype");

            entity.HasOne(d => d.TypemandehNavigation).WithMany(p => p.SehesabTypemandehNavigations)
                .HasForeignKey(d => d.Typemandeh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesab_sehesabtype1");
        });

        modelBuilder.Entity<Sehesabfield>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sehesabfields");

            entity.HasIndex(e => new { e.IdHsb, e.IdHpar }, "IX_sehesabfields_id_hsb_id_hpar").IsClustered();

            entity.Property(e => e.IdHpar).HasColumnName("id_hpar");
            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdHparNavigation).WithMany()
                .HasForeignKey(d => d.IdHpar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabparam_sehesabparameters");

            entity.HasOne(d => d.IdHsbNavigation).WithMany()
                .HasForeignKey(d => d.IdHsb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabfields_sehesab");
        });

        modelBuilder.Entity<Sehesabgroup>(entity =>
        {
            entity.HasKey(e => e.IdHsbgrp);

            entity.ToTable("sehesabgroup");

            entity.HasIndex(e => new { e.CoHsbgrp, e.IdHsbgtyp, e.IdActive }, "NonClusteredIndex-20180710-111209");

            entity.Property(e => e.IdHsbgrp)
                .ValueGeneratedNever()
                .HasColumnName("id_hsbgrp");
            entity.Property(e => e.CoHsbgrp).HasColumnName("co_hsbgrp");
            entity.Property(e => e.CodeFr).HasColumnName("code_fr");
            entity.Property(e => e.CodeTo).HasColumnName("code_to");
            entity.Property(e => e.Codelength)
                .HasDefaultValue((byte)1)
                .HasColumnName("codelength");
            entity.Property(e => e.Comment)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdHsbgtyp)
                .HasDefaultValue((short)50)
                .HasColumnName("id_hsbgtyp");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.NameEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name_en");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Sehesabgroups)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabgroup_active");

            entity.HasOne(d => d.IdHsbgtypNavigation).WithMany(p => p.Sehesabgroups)
                .HasForeignKey(d => d.IdHsbgtyp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabgroup_sehesabgrouptype");
        });

        modelBuilder.Entity<Sehesabgroupdetail>(entity =>
        {
            entity.HasKey(e => e.IdHsbdtl);

            entity.ToTable("sehesabgroupdetail");

            entity.HasIndex(e => e.IdHsbgrp, "IX_sehesabgroupdetail_id_hsbgrp");

            entity.HasIndex(e => new { e.IdHsbgrp, e.ParHsbdtl, e.IdCtmtit, e.IdCtmtyp, e.IdActive }, "IX_sehesabgroupdetail_id_hsbgrp_par_hsbdtl_id_ctmtit_id_ctmtyp_id_active");

            entity.HasIndex(e => new { e.IdHsbgrp, e.Code }, "UQ_sehesabgroupdetail_id_hsbgrp_code").IsUnique();

            entity.Property(e => e.IdHsbdtl)
                .ValueGeneratedNever()
                .HasColumnName("id_hsbdtl");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("address");
            entity.Property(e => e.Birthdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("birthdate");
            entity.Property(e => e.Birthshahr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("birthshahr");
            entity.Property(e => e.Code)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("code");
            entity.Property(e => e.Codekala)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codekala");
            entity.Property(e => e.Codepost)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("codepost");
            entity.Property(e => e.Comment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.Credit)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("credit");
            entity.Property(e => e.Credittype)
                .HasDefaultValue((byte)1)
                .HasColumnName("credittype");
            entity.Property(e => e.Darsad3).HasColumnName("darsad3");
            entity.Property(e => e.Eghtesadno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("eghtesadno");
            entity.Property(e => e.Father)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
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
                .HasDefaultValue("")
                .HasColumnName("fname");
            entity.Property(e => e.Hesabno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("hesabno");
            entity.Property(e => e.Hesabowner)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("hesabowner");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdBank).HasColumnName("id_bank");
            entity.Property(e => e.IdBnkhtyp).HasColumnName("id_bnkhtyp");
            entity.Property(e => e.IdCtmtit).HasColumnName("id_ctmtit");
            entity.Property(e => e.IdCtmtyp).HasColumnName("id_ctmtyp");
            entity.Property(e => e.IdHpar1).HasColumnName("id_hpar1");
            entity.Property(e => e.IdHpar10).HasColumnName("id_hpar10");
            entity.Property(e => e.IdHpar11).HasColumnName("id_hpar11");
            entity.Property(e => e.IdHpar12).HasColumnName("id_hpar12");
            entity.Property(e => e.IdHpar13).HasColumnName("id_hpar13");
            entity.Property(e => e.IdHpar14).HasColumnName("id_hpar14");
            entity.Property(e => e.IdHpar15).HasColumnName("id_hpar15");
            entity.Property(e => e.IdHpar16).HasColumnName("id_hpar16");
            entity.Property(e => e.IdHpar17).HasColumnName("id_hpar17");
            entity.Property(e => e.IdHpar18).HasColumnName("id_hpar18");
            entity.Property(e => e.IdHpar19).HasColumnName("id_hpar19");
            entity.Property(e => e.IdHpar2).HasColumnName("id_hpar2");
            entity.Property(e => e.IdHpar20).HasColumnName("id_hpar20");
            entity.Property(e => e.IdHpar21).HasColumnName("id_hpar21");
            entity.Property(e => e.IdHpar22).HasColumnName("id_hpar22");
            entity.Property(e => e.IdHpar23).HasColumnName("id_hpar23");
            entity.Property(e => e.IdHpar24).HasColumnName("id_hpar24");
            entity.Property(e => e.IdHpar25).HasColumnName("id_hpar25");
            entity.Property(e => e.IdHpar26).HasColumnName("id_hpar26");
            entity.Property(e => e.IdHpar27).HasColumnName("id_hpar27");
            entity.Property(e => e.IdHpar28).HasColumnName("id_hpar28");
            entity.Property(e => e.IdHpar29).HasColumnName("id_hpar29");
            entity.Property(e => e.IdHpar3).HasColumnName("id_hpar3");
            entity.Property(e => e.IdHpar30).HasColumnName("id_hpar30");
            entity.Property(e => e.IdHpar31).HasColumnName("id_hpar31");
            entity.Property(e => e.IdHpar32).HasColumnName("id_hpar32");
            entity.Property(e => e.IdHpar33).HasColumnName("id_hpar33");
            entity.Property(e => e.IdHpar34).HasColumnName("id_hpar34");
            entity.Property(e => e.IdHpar35).HasColumnName("id_hpar35");
            entity.Property(e => e.IdHpar36).HasColumnName("id_hpar36");
            entity.Property(e => e.IdHpar37).HasColumnName("id_hpar37");
            entity.Property(e => e.IdHpar38).HasColumnName("id_hpar38");
            entity.Property(e => e.IdHpar39).HasColumnName("id_hpar39");
            entity.Property(e => e.IdHpar4).HasColumnName("id_hpar4");
            entity.Property(e => e.IdHpar40).HasColumnName("id_hpar40");
            entity.Property(e => e.IdHpar41).HasColumnName("id_hpar41");
            entity.Property(e => e.IdHpar42).HasColumnName("id_hpar42");
            entity.Property(e => e.IdHpar43).HasColumnName("id_hpar43");
            entity.Property(e => e.IdHpar44).HasColumnName("id_hpar44");
            entity.Property(e => e.IdHpar45).HasColumnName("id_hpar45");
            entity.Property(e => e.IdHpar46).HasColumnName("id_hpar46");
            entity.Property(e => e.IdHpar47).HasColumnName("id_hpar47");
            entity.Property(e => e.IdHpar48).HasColumnName("id_hpar48");
            entity.Property(e => e.IdHpar49).HasColumnName("id_hpar49");
            entity.Property(e => e.IdHpar5).HasColumnName("id_hpar5");
            entity.Property(e => e.IdHpar50).HasColumnName("id_hpar50");
            entity.Property(e => e.IdHpar6).HasColumnName("id_hpar6");
            entity.Property(e => e.IdHpar7).HasColumnName("id_hpar7");
            entity.Property(e => e.IdHpar8).HasColumnName("id_hpar8");
            entity.Property(e => e.IdHpar9).HasColumnName("id_hpar9");
            entity.Property(e => e.IdHsbgrp).HasColumnName("id_hsbgrp");
            entity.Property(e => e.IdKalagrp).HasColumnName("id_kalagrp");
            entity.Property(e => e.IdSex).HasColumnName("id_sex");
            entity.Property(e => e.IdUnit).HasColumnName("id_unit");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");
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
            entity.Property(e => e.KalHsbtyp)
                .HasDefaultValue((byte)1)
                .HasColumnName("kal_hsbtyp");
            entity.Property(e => e.Lname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("lname");
            entity.Property(e => e.Machinetyp).HasColumnName("machinetyp");
            entity.Property(e => e.Mahal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mahal");
            entity.Property(e => e.Melino)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("melino");
            entity.Property(e => e.Mobile)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mobile");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Noanbar).HasColumnName("noanbar");
            entity.Property(e => e.ParHsbdtl).HasColumnName("par_hsbdtl");
            entity.Property(e => e.PriceType).HasColumnName("price_type");
            entity.Property(e => e.Sefaresh)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("sefaresh");
            entity.Property(e => e.Shanasno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
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
                .HasDefaultValue("")
                .HasColumnName("shobeh");
            entity.Property(e => e.Sodoor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sodoor");
            entity.Property(e => e.Sodoordate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sodoordate");
            entity.Property(e => e.StrCode1)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("str_code1");
            entity.Property(e => e.StrCode2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("str_code2");
            entity.Property(e => e.StrKey)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("str_key");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tel");
            entity.Property(e => e.VaHpar501)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar501");
            entity.Property(e => e.VaHpar502)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar502");
            entity.Property(e => e.VaHpar503)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar503");
            entity.Property(e => e.VaHpar504)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar504");
            entity.Property(e => e.VaHpar505)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar505");
            entity.Property(e => e.VaHpar506)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar506");
            entity.Property(e => e.VaHpar507)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar507");
            entity.Property(e => e.VaHpar508)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar508");
            entity.Property(e => e.VaHpar509)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar509");
            entity.Property(e => e.VaHpar510)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar510");
            entity.Property(e => e.VaHpar511)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar511");
            entity.Property(e => e.VaHpar512)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar512");
            entity.Property(e => e.VaHpar513)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar513");
            entity.Property(e => e.VaHpar514)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar514");
            entity.Property(e => e.VaHpar515)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar515");
            entity.Property(e => e.VaHpar516)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar516");
            entity.Property(e => e.VaHpar517)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar517");
            entity.Property(e => e.VaHpar518)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar518");
            entity.Property(e => e.VaHpar519)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar519");
            entity.Property(e => e.VaHpar520)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar520");
            entity.Property(e => e.VaHpar521)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar521");
            entity.Property(e => e.VaHpar522)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar522");
            entity.Property(e => e.VaHpar523)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar523");
            entity.Property(e => e.VaHpar524)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar524");
            entity.Property(e => e.VaHpar525)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar525");
            entity.Property(e => e.VaHpar526)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar526");
            entity.Property(e => e.VaHpar527)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar527");
            entity.Property(e => e.VaHpar528)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar528");
            entity.Property(e => e.VaHpar529)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar529");
            entity.Property(e => e.VaHpar530)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar530");
            entity.Property(e => e.VaHpar531)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar531");
            entity.Property(e => e.VaHpar532)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar532");
            entity.Property(e => e.VaHpar533)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar533");
            entity.Property(e => e.VaHpar534)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar534");
            entity.Property(e => e.VaHpar535)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar535");
            entity.Property(e => e.VaHpar536)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar536");
            entity.Property(e => e.VaHpar537)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar537");
            entity.Property(e => e.VaHpar538)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar538");
            entity.Property(e => e.VaHpar539)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar539");
            entity.Property(e => e.VaHpar540)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar540");
            entity.Property(e => e.VaHpar541)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar541");
            entity.Property(e => e.VaHpar542)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar542");
            entity.Property(e => e.VaHpar543)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar543");
            entity.Property(e => e.VaHpar544)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar544");
            entity.Property(e => e.VaHpar545)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar545");
            entity.Property(e => e.VaHpar546)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar546");
            entity.Property(e => e.VaHpar547)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar547");
            entity.Property(e => e.VaHpar548)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar548");
            entity.Property(e => e.VaHpar549)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar549");
            entity.Property(e => e.VaHpar550)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar550");
            entity.Property(e => e.Vazn)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("vazn");
            entity.Property(e => e.Vin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vin");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_secustomer_seactiveitems");

            entity.HasOne(d => d.IdBankNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.IdBank)
                .HasConstraintName("FK_sehesab_sebank");

            entity.HasOne(d => d.IdBnkhtypNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.IdBnkhtyp)
                .HasConstraintName("FK_sehesab_seBankHesabType");

            entity.HasOne(d => d.IdCtmtitNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.IdCtmtit)
                .HasConstraintName("FK_sehesabgroupdetail_secustomertitles");

            entity.HasOne(d => d.IdCtmtypNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.IdCtmtyp)
                .HasConstraintName("FK_secustomer_secustomertype");

            entity.HasOne(d => d.IdHpar1Navigation).WithMany(p => p.SehesabgroupdetailIdHpar1Navigations)
                .HasForeignKey(d => d.IdHpar1)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail");

            entity.HasOne(d => d.IdHpar10Navigation).WithMany(p => p.SehesabgroupdetailIdHpar10Navigations)
                .HasForeignKey(d => d.IdHpar10)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail9");

            entity.HasOne(d => d.IdHpar11Navigation).WithMany(p => p.SehesabgroupdetailIdHpar11Navigations)
                .HasForeignKey(d => d.IdHpar11)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail10");

            entity.HasOne(d => d.IdHpar12Navigation).WithMany(p => p.SehesabgroupdetailIdHpar12Navigations)
                .HasForeignKey(d => d.IdHpar12)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail11");

            entity.HasOne(d => d.IdHpar13Navigation).WithMany(p => p.SehesabgroupdetailIdHpar13Navigations)
                .HasForeignKey(d => d.IdHpar13)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail12");

            entity.HasOne(d => d.IdHpar14Navigation).WithMany(p => p.SehesabgroupdetailIdHpar14Navigations)
                .HasForeignKey(d => d.IdHpar14)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail13");

            entity.HasOne(d => d.IdHpar15Navigation).WithMany(p => p.SehesabgroupdetailIdHpar15Navigations)
                .HasForeignKey(d => d.IdHpar15)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail14");

            entity.HasOne(d => d.IdHpar16Navigation).WithMany(p => p.SehesabgroupdetailIdHpar16Navigations)
                .HasForeignKey(d => d.IdHpar16)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail15");

            entity.HasOne(d => d.IdHpar17Navigation).WithMany(p => p.SehesabgroupdetailIdHpar17Navigations)
                .HasForeignKey(d => d.IdHpar17)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail16");

            entity.HasOne(d => d.IdHpar18Navigation).WithMany(p => p.SehesabgroupdetailIdHpar18Navigations)
                .HasForeignKey(d => d.IdHpar18)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail17");

            entity.HasOne(d => d.IdHpar19Navigation).WithMany(p => p.SehesabgroupdetailIdHpar19Navigations)
                .HasForeignKey(d => d.IdHpar19)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail18");

            entity.HasOne(d => d.IdHpar2Navigation).WithMany(p => p.SehesabgroupdetailIdHpar2Navigations)
                .HasForeignKey(d => d.IdHpar2)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail1");

            entity.HasOne(d => d.IdHpar20Navigation).WithMany(p => p.SehesabgroupdetailIdHpar20Navigations)
                .HasForeignKey(d => d.IdHpar20)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail19");

            entity.HasOne(d => d.IdHpar21Navigation).WithMany(p => p.SehesabgroupdetailIdHpar21Navigations)
                .HasForeignKey(d => d.IdHpar21)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail20");

            entity.HasOne(d => d.IdHpar22Navigation).WithMany(p => p.SehesabgroupdetailIdHpar22Navigations)
                .HasForeignKey(d => d.IdHpar22)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail21");

            entity.HasOne(d => d.IdHpar23Navigation).WithMany(p => p.SehesabgroupdetailIdHpar23Navigations)
                .HasForeignKey(d => d.IdHpar23)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail22");

            entity.HasOne(d => d.IdHpar24Navigation).WithMany(p => p.SehesabgroupdetailIdHpar24Navigations)
                .HasForeignKey(d => d.IdHpar24)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail23");

            entity.HasOne(d => d.IdHpar25Navigation).WithMany(p => p.SehesabgroupdetailIdHpar25Navigations)
                .HasForeignKey(d => d.IdHpar25)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail24");

            entity.HasOne(d => d.IdHpar26Navigation).WithMany(p => p.SehesabgroupdetailIdHpar26Navigations)
                .HasForeignKey(d => d.IdHpar26)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail25");

            entity.HasOne(d => d.IdHpar27Navigation).WithMany(p => p.SehesabgroupdetailIdHpar27Navigations)
                .HasForeignKey(d => d.IdHpar27)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail26");

            entity.HasOne(d => d.IdHpar28Navigation).WithMany(p => p.SehesabgroupdetailIdHpar28Navigations)
                .HasForeignKey(d => d.IdHpar28)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail27");

            entity.HasOne(d => d.IdHpar29Navigation).WithMany(p => p.SehesabgroupdetailIdHpar29Navigations)
                .HasForeignKey(d => d.IdHpar29)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail28");

            entity.HasOne(d => d.IdHpar3Navigation).WithMany(p => p.SehesabgroupdetailIdHpar3Navigations)
                .HasForeignKey(d => d.IdHpar3)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail2");

            entity.HasOne(d => d.IdHpar30Navigation).WithMany(p => p.SehesabgroupdetailIdHpar30Navigations)
                .HasForeignKey(d => d.IdHpar30)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail29");

            entity.HasOne(d => d.IdHpar31Navigation).WithMany(p => p.SehesabgroupdetailIdHpar31Navigations)
                .HasForeignKey(d => d.IdHpar31)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail30");

            entity.HasOne(d => d.IdHpar32Navigation).WithMany(p => p.SehesabgroupdetailIdHpar32Navigations)
                .HasForeignKey(d => d.IdHpar32)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail31");

            entity.HasOne(d => d.IdHpar33Navigation).WithMany(p => p.SehesabgroupdetailIdHpar33Navigations)
                .HasForeignKey(d => d.IdHpar33)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail32");

            entity.HasOne(d => d.IdHpar34Navigation).WithMany(p => p.SehesabgroupdetailIdHpar34Navigations)
                .HasForeignKey(d => d.IdHpar34)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail33");

            entity.HasOne(d => d.IdHpar35Navigation).WithMany(p => p.SehesabgroupdetailIdHpar35Navigations)
                .HasForeignKey(d => d.IdHpar35)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail34");

            entity.HasOne(d => d.IdHpar36Navigation).WithMany(p => p.SehesabgroupdetailIdHpar36Navigations)
                .HasForeignKey(d => d.IdHpar36)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail35");

            entity.HasOne(d => d.IdHpar37Navigation).WithMany(p => p.SehesabgroupdetailIdHpar37Navigations)
                .HasForeignKey(d => d.IdHpar37)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail36");

            entity.HasOne(d => d.IdHpar38Navigation).WithMany(p => p.SehesabgroupdetailIdHpar38Navigations)
                .HasForeignKey(d => d.IdHpar38)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail37");

            entity.HasOne(d => d.IdHpar39Navigation).WithMany(p => p.SehesabgroupdetailIdHpar39Navigations)
                .HasForeignKey(d => d.IdHpar39)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail38");

            entity.HasOne(d => d.IdHpar4Navigation).WithMany(p => p.SehesabgroupdetailIdHpar4Navigations)
                .HasForeignKey(d => d.IdHpar4)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail3");

            entity.HasOne(d => d.IdHpar40Navigation).WithMany(p => p.SehesabgroupdetailIdHpar40Navigations)
                .HasForeignKey(d => d.IdHpar40)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail39");

            entity.HasOne(d => d.IdHpar41Navigation).WithMany(p => p.SehesabgroupdetailIdHpar41Navigations)
                .HasForeignKey(d => d.IdHpar41)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail40");

            entity.HasOne(d => d.IdHpar42Navigation).WithMany(p => p.SehesabgroupdetailIdHpar42Navigations)
                .HasForeignKey(d => d.IdHpar42)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail41");

            entity.HasOne(d => d.IdHpar43Navigation).WithMany(p => p.SehesabgroupdetailIdHpar43Navigations)
                .HasForeignKey(d => d.IdHpar43)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail42");

            entity.HasOne(d => d.IdHpar44Navigation).WithMany(p => p.SehesabgroupdetailIdHpar44Navigations)
                .HasForeignKey(d => d.IdHpar44)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail43");

            entity.HasOne(d => d.IdHpar45Navigation).WithMany(p => p.SehesabgroupdetailIdHpar45Navigations)
                .HasForeignKey(d => d.IdHpar45)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail44");

            entity.HasOne(d => d.IdHpar46Navigation).WithMany(p => p.SehesabgroupdetailIdHpar46Navigations)
                .HasForeignKey(d => d.IdHpar46)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail45");

            entity.HasOne(d => d.IdHpar47Navigation).WithMany(p => p.SehesabgroupdetailIdHpar47Navigations)
                .HasForeignKey(d => d.IdHpar47)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail46");

            entity.HasOne(d => d.IdHpar48Navigation).WithMany(p => p.SehesabgroupdetailIdHpar48Navigations)
                .HasForeignKey(d => d.IdHpar48)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail47");

            entity.HasOne(d => d.IdHpar49Navigation).WithMany(p => p.SehesabgroupdetailIdHpar49Navigations)
                .HasForeignKey(d => d.IdHpar49)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail48");

            entity.HasOne(d => d.IdHpar5Navigation).WithMany(p => p.SehesabgroupdetailIdHpar5Navigations)
                .HasForeignKey(d => d.IdHpar5)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail4");

            entity.HasOne(d => d.IdHpar50Navigation).WithMany(p => p.SehesabgroupdetailIdHpar50Navigations)
                .HasForeignKey(d => d.IdHpar50)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail49");

            entity.HasOne(d => d.IdHpar6Navigation).WithMany(p => p.SehesabgroupdetailIdHpar6Navigations)
                .HasForeignKey(d => d.IdHpar6)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail5");

            entity.HasOne(d => d.IdHpar7Navigation).WithMany(p => p.SehesabgroupdetailIdHpar7Navigations)
                .HasForeignKey(d => d.IdHpar7)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail6");

            entity.HasOne(d => d.IdHpar8Navigation).WithMany(p => p.SehesabgroupdetailIdHpar8Navigations)
                .HasForeignKey(d => d.IdHpar8)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail7");

            entity.HasOne(d => d.IdHpar9Navigation).WithMany(p => p.SehesabgroupdetailIdHpar9Navigations)
                .HasForeignKey(d => d.IdHpar9)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabparametersdetail8");

            entity.HasOne(d => d.IdHsbgrpNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.IdHsbgrp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabgroup");

            entity.HasOne(d => d.IdKalagrpNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.IdKalagrp)
                .HasConstraintName("FK_sehesabgroupdetail_sekalagroup");

            entity.HasOne(d => d.IdSexNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.IdSex)
                .HasConstraintName("FK_secustomer_sesex");

            entity.HasOne(d => d.IdUnitNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.IdUnit)
                .HasConstraintName("FK_sehesabgroupdetail_seunit");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_sehesabgroupdetail_users");

            entity.HasOne(d => d.KalHsbNavigation).WithMany(p => p.Sehesabgroupdetails)
                .HasForeignKey(d => d.KalHsb)
                .HasConstraintName("FK_sehesabgroupdetail_sehesab");

            entity.HasOne(d => d.KalHsbdtlNavigation).WithMany(p => p.InverseKalHsbdtlNavigation)
                .HasForeignKey(d => d.KalHsbdtl)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabgroupdetail");

            entity.HasOne(d => d.ParHsbdtlNavigation).WithMany(p => p.InverseParHsbdtlNavigation)
                .HasForeignKey(d => d.ParHsbdtl)
                .HasConstraintName("FK_sehesabgroupdetail_sehesabgroupdetail1");
        });

        modelBuilder.Entity<Sehesabgroupfield>(entity =>
        {
            entity.HasKey(e => e.IdHgrfld);

            entity.ToTable("sehesabgroupfields");

            entity.HasIndex(e => new { e.IdHsbgrp, e.IdHpar }, "IX_sehesabgroupfields_id_hsbgrp_id_hpar");

            entity.Property(e => e.IdHgrfld)
                .ValueGeneratedNever()
                .HasColumnName("id_hgrfld");
            entity.Property(e => e.IdHpar).HasColumnName("id_hpar");
            entity.Property(e => e.IdHsbgrp).HasColumnName("id_hsbgrp");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdHparNavigation).WithMany(p => p.Sehesabgroupfields)
                .HasForeignKey(d => d.IdHpar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabgroupfields_sehesabparameters");

            entity.HasOne(d => d.IdHsbgrpNavigation).WithMany(p => p.Sehesabgroupfields)
                .HasForeignKey(d => d.IdHsbgrp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabgroupfields_sehesabgroup");
        });

        modelBuilder.Entity<Sehesabgrouptype>(entity =>
        {
            entity.HasKey(e => e.IdHsbgtyp).HasName("PK_sehesabtype");

            entity.ToTable("sehesabgrouptype");

            entity.Property(e => e.IdHsbgtyp)
                .ValueGeneratedNever()
                .HasColumnName("id_hsbgtyp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sehesabgrouptypeconvert>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sehesabgrouptypeconvert");

            entity.HasIndex(e => new { e.IdHsbgT1, e.IdHsbgT2 }, "IX_sehesabgrouptypeconvert_id_hsbg_t1_id_hsbg_t2").IsClustered();

            entity.Property(e => e.IdHsbgT1).HasColumnName("id_hsbg_t1");
            entity.Property(e => e.IdHsbgT2).HasColumnName("id_hsbg_t2");

            entity.HasOne(d => d.IdHsbgT1Navigation).WithMany()
                .HasForeignKey(d => d.IdHsbgT1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabgrouptypeconvert_sehesabgrouptype");

            entity.HasOne(d => d.IdHsbgT2Navigation).WithMany()
                .HasForeignKey(d => d.IdHsbgT2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabgrouptypeconvert_sehesabgrouptype1");
        });

        modelBuilder.Entity<Sehesabgrouptypepermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sehesabgrouptypepermission");

            entity.HasIndex(e => new { e.IdHsbgtyp, e.IdPermis }, "IX_sehesabgrouptypepermissi_id_hsbgtyp_id_permis").IsClustered();

            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.IdHsbgtyp).HasColumnName("id_hsbgtyp");
            entity.Property(e => e.IdPermis).HasColumnName("id_permis");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdHsbgtypNavigation).WithMany()
                .HasForeignKey(d => d.IdHsbgtyp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabgrouptypepermission_sehesabgrouptype");

            entity.HasOne(d => d.IdPermisNavigation).WithMany()
                .HasForeignKey(d => d.IdPermis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabgrouptypepermission_sepermission");
        });

        modelBuilder.Entity<Sehesabgroupuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sehesabgroupusers");

            entity.HasIndex(e => new { e.IdHsbgrp, e.IdUser, e.IdPermis }, "IX_sehesabgroupusers_id_hsbgrp_id_user_id_permis").IsClustered();

            entity.Property(e => e.IdHsbgrp).HasColumnName("id_hsbgrp");
            entity.Property(e => e.IdPermis).HasColumnName("id_permis");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");

            entity.HasOne(d => d.IdHsbgrpNavigation).WithMany()
                .HasForeignKey(d => d.IdHsbgrp)
                .HasConstraintName("FK_sehesabgroupusers_sehesabgroup");

            entity.HasOne(d => d.IdPermisNavigation).WithMany()
                .HasForeignKey(d => d.IdPermis)
                .HasConstraintName("FK_sehesabgroupusers_sepermission");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabgroupusers_users");
        });

        modelBuilder.Entity<Sehesablevel>(entity =>
        {
            entity.HasKey(e => e.IdHsblvl);

            entity.ToTable("sehesablevels");

            entity.Property(e => e.IdHsblvl).HasColumnName("id_hsblvl");
            entity.Property(e => e.Codelength)
                .HasDefaultValue((byte)1)
                .HasColumnName("codelength");
            entity.Property(e => e.Kol).HasColumnName("kol");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Sehesablevelname>(entity =>
        {
            entity.HasKey(e => e.Levelname);

            entity.ToTable("sehesablevelnames");

            entity.Property(e => e.Levelname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("levelname");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sehesabmarkaz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sehesabmarkaz");

            entity.HasIndex(e => new { e.IdHsb, e.IdMkz }, "UQ_sehesabmarkaz_id_hsb_id_mkz").IsUnique();

            entity.Property(e => e.Force).HasColumnName("force");
            entity.Property(e => e.Fromlast).HasColumnName("fromlast");
            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.IdMkz).HasColumnName("id_mkz");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdHsbNavigation).WithMany()
                .HasForeignKey(d => d.IdHsb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabmarkaz_sehesab");

            entity.HasOne(d => d.IdMkzNavigation).WithMany()
                .HasForeignKey(d => d.IdMkz)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabmarkaz_semarkaz");
        });

        modelBuilder.Entity<Sehesabparameter>(entity =>
        {
            entity.HasKey(e => e.IdHpar);

            entity.ToTable("sehesabparameters");

            entity.HasIndex(e => new { e.IdActive, e.IdHpartyp }, "IX_sehesabparameters_id_active_id_hpartyp");

            entity.Property(e => e.IdHpar)
                .ValueGeneratedNever()
                .HasColumnName("id_hpar");
            entity.Property(e => e.Ashar).HasColumnName("ashar");
            entity.Property(e => e.Codelength)
                .HasDefaultValue((byte)1)
                .HasColumnName("codelength");
            entity.Property(e => e.Comment)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.Fieldnum).HasColumnName("fieldnum");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdHpartyp)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_hpartyp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
            entity.Property(e => e.Zamantype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("HMS")
                .HasColumnName("zamantype");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Sehesabparameters)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabparameters_active");

            entity.HasOne(d => d.IdHpartypNavigation).WithMany(p => p.Sehesabparameters)
                .HasForeignKey(d => d.IdHpartyp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabparameters_sehesabparameterstype");
        });

        modelBuilder.Entity<Sehesabparametersdetail>(entity =>
        {
            entity.HasKey(e => e.IdHpardtl);

            entity.ToTable("sehesabparametersdetail");

            entity.HasIndex(e => new { e.IdHpar, e.IdActive, e.IdCtmtit, e.IdCtmtyp, e.IdSex, e.IdBank }, "IX_sehesabparametersdetail_id_hpar_id_active_id_ctmtit_id_ctmtyp_id_sex_id_bank");

            entity.Property(e => e.IdHpardtl)
                .ValueGeneratedNever()
                .HasColumnName("id_hpardtl");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("address");
            entity.Property(e => e.Birthdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("birthdate");
            entity.Property(e => e.Birthshahr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("birthshahr");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Credit)
                .HasColumnType("decimal(12, 0)")
                .HasColumnName("credit");
            entity.Property(e => e.Father)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("father");
            entity.Property(e => e.Hesabno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("hesabno");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdBank).HasColumnName("id_bank");
            entity.Property(e => e.IdBnkhtyp).HasColumnName("id_bnkhtyp");
            entity.Property(e => e.IdCtmtit).HasColumnName("id_ctmtit");
            entity.Property(e => e.IdCtmtyp).HasColumnName("id_ctmtyp");
            entity.Property(e => e.IdHpar).HasColumnName("id_hpar");
            entity.Property(e => e.IdSex).HasColumnName("id_sex");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.Melino)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("melino");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Para1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para1");
            entity.Property(e => e.Para10)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para10");
            entity.Property(e => e.Para11)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para11");
            entity.Property(e => e.Para12)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para12");
            entity.Property(e => e.Para13)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para13");
            entity.Property(e => e.Para14)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para14");
            entity.Property(e => e.Para15)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para15");
            entity.Property(e => e.Para16)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para16");
            entity.Property(e => e.Para17)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para17");
            entity.Property(e => e.Para18)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para18");
            entity.Property(e => e.Para19)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para19");
            entity.Property(e => e.Para2)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para2");
            entity.Property(e => e.Para20)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para20");
            entity.Property(e => e.Para21)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para21");
            entity.Property(e => e.Para22)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para22");
            entity.Property(e => e.Para23)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para23");
            entity.Property(e => e.Para24)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para24");
            entity.Property(e => e.Para25)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para25");
            entity.Property(e => e.Para26)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para26");
            entity.Property(e => e.Para27)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para27");
            entity.Property(e => e.Para28)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para28");
            entity.Property(e => e.Para29)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para29");
            entity.Property(e => e.Para3)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para3");
            entity.Property(e => e.Para30)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para30");
            entity.Property(e => e.Para31)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para31");
            entity.Property(e => e.Para32)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para32");
            entity.Property(e => e.Para33)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para33");
            entity.Property(e => e.Para34)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para34");
            entity.Property(e => e.Para35)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para35");
            entity.Property(e => e.Para36)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para36");
            entity.Property(e => e.Para37)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para37");
            entity.Property(e => e.Para38)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para38");
            entity.Property(e => e.Para39)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para39");
            entity.Property(e => e.Para4)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para4");
            entity.Property(e => e.Para40)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para40");
            entity.Property(e => e.Para41)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para41");
            entity.Property(e => e.Para42)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para42");
            entity.Property(e => e.Para43)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para43");
            entity.Property(e => e.Para44)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para44");
            entity.Property(e => e.Para45)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para45");
            entity.Property(e => e.Para46)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para46");
            entity.Property(e => e.Para47)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para47");
            entity.Property(e => e.Para48)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para48");
            entity.Property(e => e.Para49)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para49");
            entity.Property(e => e.Para5)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para5");
            entity.Property(e => e.Para50)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para50");
            entity.Property(e => e.Para6)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para6");
            entity.Property(e => e.Para7)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para7");
            entity.Property(e => e.Para8)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para8");
            entity.Property(e => e.Para9)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para9");
            entity.Property(e => e.Shanasno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shanasno");
            entity.Property(e => e.Shobeh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shobeh");
            entity.Property(e => e.Sodoor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sodoor");
            entity.Property(e => e.Sodoordate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sodoordate");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tel");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Sehesabparametersdetails)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabparametersdetail_active");

            entity.HasOne(d => d.IdBankNavigation).WithMany(p => p.Sehesabparametersdetails)
                .HasForeignKey(d => d.IdBank)
                .HasConstraintName("FK_sehesabparametersdetail_sebank");

            entity.HasOne(d => d.IdBnkhtypNavigation).WithMany(p => p.Sehesabparametersdetails)
                .HasForeignKey(d => d.IdBnkhtyp)
                .HasConstraintName("FK_sehesabparametersdetail_sebankhesabtype");

            entity.HasOne(d => d.IdCtmtitNavigation).WithMany(p => p.Sehesabparametersdetails)
                .HasForeignKey(d => d.IdCtmtit)
                .HasConstraintName("FK_sehesabparametersdetail_secustomertitles");

            entity.HasOne(d => d.IdCtmtypNavigation).WithMany(p => p.Sehesabparametersdetails)
                .HasForeignKey(d => d.IdCtmtyp)
                .HasConstraintName("FK_sehesabparametersdetail_secustomertype");

            entity.HasOne(d => d.IdHparNavigation).WithMany(p => p.Sehesabparametersdetails)
                .HasForeignKey(d => d.IdHpar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabparametersdetail_sehesabparameters");

            entity.HasOne(d => d.IdSexNavigation).WithMany(p => p.Sehesabparametersdetails)
                .HasForeignKey(d => d.IdSex)
                .HasConstraintName("FK_sehesabparametersdetail_sex");
        });

        modelBuilder.Entity<Sehesabparametersfield>(entity =>
        {
            entity.HasKey(e => e.IdHparfld);

            entity.ToTable("sehesabparametersfields");

            entity.HasIndex(e => new { e.IdHpar, e.IdActive }, "IX_sehesabparametersfields_id_hpar_id_active");

            entity.Property(e => e.IdHparfld)
                .ValueGeneratedNever()
                .HasColumnName("id_hparfld");
            entity.Property(e => e.Ashar).HasColumnName("ashar");
            entity.Property(e => e.Fieldcode).HasColumnName("fieldcode");
            entity.Property(e => e.Fieldname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fieldname");
            entity.Property(e => e.Fieldnum).HasColumnName("fieldnum");
            entity.Property(e => e.Fieldtype)
                .HasDefaultValue((byte)1)
                .HasColumnName("fieldtype");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdHpar).HasColumnName("id_hpar");
            entity.Property(e => e.Inputtype)
                .HasDefaultValue((byte)1)
                .HasColumnName("inputtype");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
            entity.Property(e => e.Zamantype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("HMS")
                .HasColumnName("zamantype");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Sehesabparametersfields)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabparametersfields_active");

            entity.HasOne(d => d.IdHparNavigation).WithMany(p => p.Sehesabparametersfields)
                .HasForeignKey(d => d.IdHpar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabparametersfields_sehesabparameters");
        });

        modelBuilder.Entity<Sehesabparametersfielditem>(entity =>
        {
            entity.ToTable("sehesabparametersfielditems");

            entity.HasIndex(e => new { e.IdActive, e.IdHparfld, e.Typeitem }, "IX_sehesabparametersfieldit_id_active_id_hparfld_typeitem");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdHparfld).HasColumnName("id_hparfld");
            entity.Property(e => e.Tartib).HasColumnName("tartib");
            entity.Property(e => e.Typeitem)
                .HasDefaultValue((byte)1)
                .HasColumnName("typeitem");
            entity.Property(e => e.Valueitem)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("valueitem");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Sehesabparametersfielditems)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabparametersfielditems_active");

            entity.HasOne(d => d.IdHparfldNavigation).WithMany(p => p.Sehesabparametersfielditems)
                .HasForeignKey(d => d.IdHparfld)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabparametersfielditems_sehesabparametersfields");
        });

        modelBuilder.Entity<Sehesabparameterstype>(entity =>
        {
            entity.HasKey(e => e.IdHpartyp);

            entity.ToTable("sehesabparameterstype");

            entity.Property(e => e.IdHpartyp).HasColumnName("id_hpartyp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sehesabpermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sehesabpermission");

            entity.HasIndex(e => new { e.IdPermis, e.IdHsbgtyp, e.Active }, "IX_sehesabpermission_id_permis_id_hsbgtyp_active").IsClustered();

            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.IdHsbgtyp).HasColumnName("id_hsbgtyp");
            entity.Property(e => e.IdPermis).HasColumnName("id_permis");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdHsbgtypNavigation).WithMany()
                .HasForeignKey(d => d.IdHsbgtyp)
                .HasConstraintName("FK_sehesabpermission_sehesabgrouptype");

            entity.HasOne(d => d.IdPermisNavigation).WithMany()
                .HasForeignKey(d => d.IdPermis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabpermission_sepermission");
        });

        modelBuilder.Entity<Sehesabtype>(entity =>
        {
            entity.HasKey(e => e.IdHsbtyp).HasName("PK_sehesabtype_1");

            entity.ToTable("sehesabtypes");

            entity.Property(e => e.IdHsbtyp).HasColumnName("id_hsbtyp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sehesabuser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sehesabusers");

            entity.HasIndex(e => new { e.IdHsb, e.IdHsbdtl, e.IdUser, e.IdPermis }, "IX_sehesabusers_id_hsb_id_hsbdtl_id_user_id_permis").IsClustered();

            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.IdHsbdtl).HasColumnName("id_hsbdtl");
            entity.Property(e => e.IdPermis).HasColumnName("id_permis");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");

            entity.HasOne(d => d.IdHsbNavigation).WithMany()
                .HasForeignKey(d => d.IdHsb)
                .HasConstraintName("FK_sehesabusers_sehesab");

            entity.HasOne(d => d.IdHsbdtlNavigation).WithMany()
                .HasForeignKey(d => d.IdHsbdtl)
                .HasConstraintName("FK_sehesabusers_sehesabgroupdetail");

            entity.HasOne(d => d.IdPermisNavigation).WithMany()
                .HasForeignKey(d => d.IdPermis)
                .HasConstraintName("FK_sehesabusers_sepermission");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehesabusers_users");
        });

        modelBuilder.Entity<Sehvlrsd>(entity =>
        {
            entity.HasKey(e => e.IdHvlrsd);

            entity.ToTable("sehvlrsd", tb =>
                {
                    tb.HasTrigger("sehvlrsd_delete");
                    tb.HasTrigger("sehvlrsd_insert");
                    tb.HasTrigger("sehvlrsd_update");
                });

            entity.HasIndex(e => e.Date, "IX_sehvlrsd_date");

            entity.HasIndex(e => e.DateroozS, "IX_sehvlrsd_daterooz_s");

            entity.HasIndex(e => e.HsbCtm, "IX_sehvlrsd_hsb_ctm");

            entity.HasIndex(e => e.HsbdtlCtm, "IX_sehvlrsd_hsbdtl_ctm");

            entity.HasIndex(e => e.HsbdtlTrf, "IX_sehvlrsd_hsbdtl_trf");

            entity.HasIndex(e => e.HvlrsdNo, "IX_sehvlrsd_hvlrsd_no");

            entity.HasIndex(e => e.IdBar, "IX_sehvlrsd_id_bar");

            entity.HasIndex(e => e.IdBranch, "IX_sehvlrsd_id_branch");

            entity.HasIndex(e => e.IdBrngrp, "IX_sehvlrsd_id_brngrp");

            entity.HasIndex(e => e.IdFactor, "IX_sehvlrsd_id_factor");

            entity.HasIndex(e => e.IdForm, "IX_sehvlrsd_id_form");

            entity.HasIndex(e => e.IdHrRel, "IX_sehvlrsd_id_hr_rel");

            entity.HasIndex(e => e.IdKoshtar, "IX_sehvlrsd_id_koshtar");

            entity.HasIndex(e => e.IdOk, "IX_sehvlrsd_id_ok");

            entity.HasIndex(e => new { e.IdPeriod, e.IdForm, e.HvlrsdNo, e.IdBranch }, "IX_sehvlrsd_id_period_id_branch_id_form_hvlrsd_no").IsUnique();

            entity.HasIndex(e => new { e.IdBranch, e.IdBrngrp, e.IdPeriod, e.IdForm, e.IdBrnTrn, e.IdHrRel, e.IdAoRel, e.HsbdtlTrf, e.HsbCtm, e.HsbdtlCtm, e.IdFactor, e.IdBar, e.HsbdtlDrv }, "NonClusteredIndex-20180710-113140");

            entity.Property(e => e.IdHvlrsd)
                .ValueGeneratedNever()
                .HasColumnName("id_hvlrsd");
            entity.Property(e => e.AutoEf).HasColumnName("auto_ef");
            entity.Property(e => e.BarNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("bar_no");
            entity.Property(e => e.Comment)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.CountM)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("count_m");
            entity.Property(e => e.Dahandeh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("dahandeh");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("date");
            entity.Property(e => e.DateroozS)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("daterooz_s");
            entity.Property(e => e.FactNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fact_no");
            entity.Property(e => e.Girandeh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("girandeh");
            entity.Property(e => e.HsbCtm).HasColumnName("hsb_ctm");
            entity.Property(e => e.HsbctmDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("hsbctm_des");
            entity.Property(e => e.HsbdtlCtm).HasColumnName("hsbdtl_ctm");
            entity.Property(e => e.HsbdtlDrv).HasColumnName("hsbdtl_drv");
            entity.Property(e => e.HsbdtlTrf).HasColumnName("hsbdtl_trf");
            entity.Property(e => e.HvlrsdNo).HasColumnName("hvlrsd_no");
            entity.Property(e => e.IdAoRel).HasColumnName("id_ao_rel");
            entity.Property(e => e.IdBar).HasColumnName("id_bar");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdBrnTrn).HasColumnName("id_brn_trn");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
            entity.Property(e => e.IdFactor).HasColumnName("id_factor");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdHrRel).HasColumnName("id_hr_rel");
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
            entity.Property(e => e.MachineNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("machine_no");
            entity.Property(e => e.RoozRadif).HasColumnName("rooz_radif");
            entity.Property(e => e.Sabt).HasColumnName("sabt");
            entity.Property(e => e.Sharh)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sharh");
            entity.Property(e => e.Sharhsanad)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sharhsanad");
            entity.Property(e => e.Tshbymegh).HasColumnName("tshbymegh");
            entity.Property(e => e.Vazn3)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn3");
            entity.Property(e => e.Vazn34)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn34");
            entity.Property(e => e.Vazn3Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn3_date");
            entity.Property(e => e.Vazn3Row).HasColumnName("vazn3_row");
            entity.Property(e => e.Vazn3Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn3_time");
            entity.Property(e => e.Vazn4)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn4");
            entity.Property(e => e.Vazn4Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn4_date");
            entity.Property(e => e.Vazn4Row).HasColumnName("vazn4_row");
            entity.Property(e => e.Vazn4Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn4_time");

            entity.HasOne(d => d.HsbCtmNavigation).WithMany(p => p.Sehvlrsds)
                .HasForeignKey(d => d.HsbCtm)
                .HasConstraintName("FK_sehvlrsd_sehesab");

            entity.HasOne(d => d.HsbdtlCtmNavigation).WithMany(p => p.SehvlrsdHsbdtlCtmNavigations)
                .HasForeignKey(d => d.HsbdtlCtm)
                .HasConstraintName("FK_sehvlrsd_sehesabgroupdetail2");

            entity.HasOne(d => d.HsbdtlDrvNavigation).WithMany(p => p.SehvlrsdHsbdtlDrvNavigations)
                .HasForeignKey(d => d.HsbdtlDrv)
                .HasConstraintName("FK_sehvlrsd_sehesabgroupdetail1");

            entity.HasOne(d => d.HsbdtlTrfNavigation).WithMany(p => p.SehvlrsdHsbdtlTrfNavigations)
                .HasForeignKey(d => d.HsbdtlTrf)
                .HasConstraintName("FK_sehvlrsd_sehesabgroupdetail");

            entity.HasOne(d => d.IdAoRelNavigation).WithMany(p => p.Sehvlrsds)
                .HasForeignKey(d => d.IdAoRel)
                .HasConstraintName("FK_sehvlrsd_seanboth");

            entity.HasOne(d => d.IdBarNavigation).WithMany(p => p.Sehvlrsds)
                .HasForeignKey(d => d.IdBar)
                .HasConstraintName("FK_sehvlrsd_sebarnameh");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.SehvlrsdIdBranchNavigations)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK_sehvlrsd_sebranch");

            entity.HasOne(d => d.IdBrnTrnNavigation).WithMany(p => p.SehvlrsdIdBrnTrnNavigations)
                .HasForeignKey(d => d.IdBrnTrn)
                .HasConstraintName("FK_sehvlrsd_sebranch1");

            entity.HasOne(d => d.IdBrngrpNavigation).WithMany(p => p.Sehvlrsds)
                .HasForeignKey(d => d.IdBrngrp)
                .HasConstraintName("FK_sehvlrsd_sebranchgroup");

            entity.HasOne(d => d.IdFactorNavigation).WithMany(p => p.Sehvlrsds)
                .HasForeignKey(d => d.IdFactor)
                .HasConstraintName("FK_sehvlrsd_sefactor");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Sehvlrsds)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehvlrsd_seforms");

            entity.HasOne(d => d.IdHrRelNavigation).WithMany(p => p.InverseIdHrRelNavigation)
                .HasForeignKey(d => d.IdHrRel)
                .HasConstraintName("FK_sehvlrsd_sehvlrsd");

            entity.HasOne(d => d.IdKoshtarNavigation).WithMany(p => p.Sehvlrsds)
                .HasForeignKey(d => d.IdKoshtar)
                .HasConstraintName("FK_sehvlrsd_sekoshtar");

            entity.HasOne(d => d.IdOkNavigation).WithMany(p => p.Sehvlrsds)
                .HasForeignKey(d => d.IdOk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehvlrsd_seok");

            entity.HasOne(d => d.IdPeriodNavigation).WithMany(p => p.Sehvlrsds)
                .HasForeignKey(d => d.IdPeriod)
                .HasConstraintName("FK_sehvlrsd_seperiod");
        });

        modelBuilder.Entity<Sehvlrsddetail>(entity =>
        {
            entity.HasKey(e => e.IdHrDtl);

            entity.ToTable("sehvlrsddetail", tb =>
                {
                    tb.HasTrigger("sehvlrsddetail_delete");
                    tb.HasTrigger("sehvlrsddetail_insert");
                    tb.HasTrigger("sehvlrsddetail_update");
                });

            entity.HasIndex(e => e.DateKal, "IX_sehvlrsddetail_date_kal");

            entity.HasIndex(e => e.HsbKal, "IX_sehvlrsddetail_hsb_kal");

            entity.HasIndex(e => e.HsbdtlKal, "IX_sehvlrsddetail_hsbdtl_kal");

            entity.HasIndex(e => e.IdAnb, "IX_sehvlrsddetail_id_anb");

            entity.HasIndex(e => e.IdHvlrsd, "IX_sehvlrsddetail_id_hvlrsd");

            entity.HasIndex(e => e.IdIoTyp, "IX_sehvlrsddetail_id_io_typ");

            entity.HasIndex(e => e.RadifS, "IX_sehvlrsddetail_radif_s");

            entity.HasIndex(e => e.SerialKal, "IX_sehvlrsddetail_serial_kal");

            entity.HasIndex(e => new { e.IdHvlrsd, e.Detailtype, e.IdAnb, e.IdIoTyp, e.HsbKal, e.HsbdtlKal, e.HsbdtlPlt }, "NonClusteredIndex-20180710-113258");

            entity.Property(e => e.IdHrDtl)
                .ValueGeneratedNever()
                .HasColumnName("id_hr_dtl");
            entity.Property(e => e.Afzoodeh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("afzoodeh");
            entity.Property(e => e.AfzoodehD)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("afzoodeh_d");
            entity.Property(e => e.AnbShfDtl).HasColumnName("anb_shf_dtl");
            entity.Property(e => e.Autoadd).HasColumnName("autoadd");
            entity.Property(e => e.Autobar).HasColumnName("autobar");
            entity.Property(e => e.Autotoulid).HasColumnName("autotoulid");
            entity.Property(e => e.Cancelfct).HasColumnName("cancelfct");
            entity.Property(e => e.CommPrint)
                .HasDefaultValue((byte)1)
                .HasColumnName("comm_print");
            entity.Property(e => e.CommRadif)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comm_radif");
            entity.Property(e => e.Count)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("count");
            entity.Property(e => e.CountM)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("count_m");
            entity.Property(e => e.CountPlt)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("count_plt");
            entity.Property(e => e.CountR)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("count_r");
            entity.Property(e => e.CountTot)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("count_tot");
            entity.Property(e => e.DarsadMab)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("darsad_mab");
            entity.Property(e => e.DateKal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("date_kal");
            entity.Property(e => e.Detailtype).HasColumnName("detailtype");
            entity.Property(e => e.Fi)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi");
            entity.Property(e => e.FiR)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("fi_r");
            entity.Property(e => e.HsbKal).HasColumnName("hsb_kal");
            entity.Property(e => e.HsbdtlKal).HasColumnName("hsbdtl_kal");
            entity.Property(e => e.HsbdtlPlt).HasColumnName("hsbdtl_plt");
            entity.Property(e => e.IdAnb).HasColumnName("id_anb");
            entity.Property(e => e.IdHvlrsd).HasColumnName("id_hvlrsd");
            entity.Property(e => e.IdIoTyp).HasColumnName("id_io_typ");
            entity.Property(e => e.IdUnitR).HasColumnName("id_unit_r");
            entity.Property(e => e.MabFormul)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mab_formul");
            entity.Property(e => e.MergeRow).HasColumnName("merge_row");
            entity.Property(e => e.MergeSnd).HasColumnName("merge_snd");
            entity.Property(e => e.MergedPrn).HasColumnName("merged_prn");
            entity.Property(e => e.Noprint).HasColumnName("noprint");
            entity.Property(e => e.Noprintunt).HasColumnName("noprintunt");
            entity.Property(e => e.Radif).HasColumnName("radif");
            entity.Property(e => e.RadifS)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("radif_s");
            entity.Property(e => e.Roundtype).HasColumnName("roundtype");
            entity.Property(e => e.Roundtype1).HasColumnName("roundtype1");
            entity.Property(e => e.Roweffect).HasColumnName("roweffect");
            entity.Property(e => e.Serial)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("serial");
            entity.Property(e => e.SerialKal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("serial_kal");
            entity.Property(e => e.Takhfif)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("takhfif");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("total");
            entity.Property(e => e.Total1)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("total1");
            entity.Property(e => e.Total2)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("total2");
            entity.Property(e => e.Vazn1)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn1");
            entity.Property(e => e.Vazn1Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn1_date");
            entity.Property(e => e.Vazn1Row).HasColumnName("vazn1_row");
            entity.Property(e => e.Vazn1Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn1_time");
            entity.Property(e => e.Vazn2)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn2");
            entity.Property(e => e.Vazn2Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn2_date");
            entity.Property(e => e.Vazn2Row).HasColumnName("vazn2_row");
            entity.Property(e => e.Vazn2Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vazn2_time");

            entity.HasOne(d => d.HsbKalNavigation).WithMany(p => p.Sehvlrsddetails)
                .HasForeignKey(d => d.HsbKal)
                .HasConstraintName("FK_sehvlrsddetail_sehesab");

            entity.HasOne(d => d.HsbdtlKalNavigation).WithMany(p => p.SehvlrsddetailHsbdtlKalNavigations)
                .HasForeignKey(d => d.HsbdtlKal)
                .HasConstraintName("FK_sehvlrsddetail_sehesabgroupdetail1");

            entity.HasOne(d => d.HsbdtlPltNavigation).WithMany(p => p.SehvlrsddetailHsbdtlPltNavigations)
                .HasForeignKey(d => d.HsbdtlPlt)
                .HasConstraintName("FK_sehvlrsddetail_sehesabgroupdetail2");

            entity.HasOne(d => d.IdAnbNavigation).WithMany(p => p.SehvlrsddetailIdAnbNavigations)
                .HasForeignKey(d => d.IdAnb)
                .HasConstraintName("FK_sehvlrsddetail_sehesabgroupdetail");

            entity.HasOne(d => d.IdHvlrsdNavigation).WithMany(p => p.Sehvlrsddetails)
                .HasForeignKey(d => d.IdHvlrsd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehvlrsddetail_sehvlrsd");

            entity.HasOne(d => d.IdIoTypNavigation).WithMany(p => p.Sehvlrsddetails)
                .HasForeignKey(d => d.IdIoTyp)
                .HasConstraintName("FK_sehvlrsddetail_seiotype");

            entity.HasOne(d => d.Sekalaunit).WithMany(p => p.Sehvlrsddetails)
                .HasForeignKey(d => new { d.HsbdtlKal, d.IdUnitR })
                .HasConstraintName("FK_sehvlrsddetail_sekalaunit");
        });

        modelBuilder.Entity<Sehvlrsddetailpallet>(entity =>
        {
            entity.HasKey(e => e.IdHrPlt);

            entity.ToTable("sehvlrsddetailpallet");

            entity.HasIndex(e => new { e.IdHrDtl, e.HsbdtlPlt }, "IX_sehvlrsddetailpallet_id_hr_dtl_hsbdtl_plt");

            entity.Property(e => e.IdHrPlt)
                .ValueGeneratedNever()
                .HasColumnName("id_hr_plt");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.HsbdtlPlt).HasColumnName("hsbdtl_plt");
            entity.Property(e => e.IdHrDtl).HasColumnName("id_hr_dtl");
            entity.Property(e => e.Radif).HasColumnName("radif");
            entity.Property(e => e.Vazn)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn");
            entity.Property(e => e.Vazntotal)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazntotal");

            entity.HasOne(d => d.HsbdtlPltNavigation).WithMany(p => p.Sehvlrsddetailpallets)
                .HasForeignKey(d => d.HsbdtlPlt)
                .HasConstraintName("FK_sehvlrsddetailpallet_sehesabgroupdetail");

            entity.HasOne(d => d.IdHrDtlNavigation).WithMany(p => p.Sehvlrsddetailpallets)
                .HasForeignKey(d => d.IdHrDtl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sehvlrsddetailpallet_sehvlrsddetail");
        });

        modelBuilder.Entity<Seiotype>(entity =>
        {
            entity.HasKey(e => e.IdIoTyp);

            entity.ToTable("seiotype");

            entity.Property(e => e.IdIoTyp).HasColumnName("id_io_typ");
            entity.Property(e => e.Io).HasColumnName("io");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib).HasColumnName("tartib");
        });

        modelBuilder.Entity<Sekalaformul>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sekalaformul");

            entity.HasIndex(e => new { e.IdKalaM, e.IdKala, e.IdKalagrp }, "IX_sekalaformul_id_kala_m_id_kala_id_kalagrp").IsClustered();

            entity.Property(e => e.IdKala).HasColumnName("id_kala");
            entity.Property(e => e.IdKalaM).HasColumnName("id_kala_m");
            entity.Property(e => e.IdKalagrp).HasColumnName("id_kalagrp");
            entity.Property(e => e.Meghdar)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("meghdar");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdKalaNavigation).WithMany()
                .HasForeignKey(d => d.IdKala)
                .HasConstraintName("FK_sekalaformul_sehesabgroupdetail");

            entity.HasOne(d => d.IdKalaMNavigation).WithMany()
                .HasForeignKey(d => d.IdKalaM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sekalaformul_sehesabgroupdetail1");

            entity.HasOne(d => d.IdKalagrpNavigation).WithMany()
                .HasForeignKey(d => d.IdKalagrp)
                .HasConstraintName("FK_sekalaformul_sekalagroup");
        });

        modelBuilder.Entity<Sekalagroup>(entity =>
        {
            entity.HasKey(e => e.IdKalagrp);

            entity.ToTable("sekalagroup");

            entity.Property(e => e.IdKalagrp)
                .ValueGeneratedNever()
                .HasColumnName("id_kalagrp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sekalaunit>(entity =>
        {
            entity.HasKey(e => new { e.IdHsbdtl, e.IdUnit });

            entity.ToTable("sekalaunit");

            entity.Property(e => e.IdHsbdtl).HasColumnName("id_hsbdtl");
            entity.Property(e => e.IdUnit).HasColumnName("id_unit");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
            entity.Property(e => e.Zarib)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("zarib");

            entity.HasOne(d => d.IdHsbdtlNavigation).WithMany(p => p.Sekalaunits)
                .HasForeignKey(d => d.IdHsbdtl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sekalaunit_sehesabgroupdetail");

            entity.HasOne(d => d.IdUnitNavigation).WithMany(p => p.Sekalaunits)
                .HasForeignKey(d => d.IdUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sekalaunit_seunit");
        });

        modelBuilder.Entity<Sekoshtar>(entity =>
        {
            entity.HasKey(e => e.IdKoshtar);

            entity.ToTable("sekoshtar");

            entity.HasIndex(e => e.IdBranch, "IX_sekoshtar_id_branch");

            entity.HasIndex(e => new { e.IdBranch, e.IdBrngrp, e.IdPeriod, e.IdForm, e.KoshtarNo, e.Date, e.IdMordar, e.IdCtm, e.IdDrv, e.IdManteg, e.IdAmani, e.IdKamion, e.IdToyor }, "IX_sekoshtar_id_branch_id_brngrp_id_period_id_form_koshtar_no_date_id_mordar_id_ctm_id_drv_id_manteg_id_amani_id_kamion_id_toyor");

            entity.HasIndex(e => e.IdBrngrp, "IX_sekoshtar_id_brngrp");

            entity.HasIndex(e => e.IdPeriod, "IX_sekoshtar_id_period");

            entity.HasIndex(e => new { e.IdPeriod, e.IdForm, e.KoshtarNo, e.IdBranch }, "UQ_sekoshtar_id_period_id_form_koshtar_no_id_branch").IsUnique();

            entity.Property(e => e.IdKoshtar)
                .ValueGeneratedNever()
                .HasColumnName("id_koshtar");
            entity.Property(e => e.Amani).HasColumnName("amani");
            entity.Property(e => e.B1eDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b1e_date");
            entity.Property(e => e.B1eRadif).HasColumnName("b1e_radif");
            entity.Property(e => e.B1eTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b1e_time");
            entity.Property(e => e.B1eVazn)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("b1e_vazn");
            entity.Property(e => e.B1fDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b1f_date");
            entity.Property(e => e.B1fRadif).HasColumnName("b1f_radif");
            entity.Property(e => e.B1fTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b1f_time");
            entity.Property(e => e.B1fVazn)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("b1f_vazn");
            entity.Property(e => e.B2eDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b2e_date");
            entity.Property(e => e.B2eRadif).HasColumnName("b2e_radif");
            entity.Property(e => e.B2eTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b2e_time");
            entity.Property(e => e.B2eVazn)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("b2e_vazn");
            entity.Property(e => e.B2fDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b2f_date");
            entity.Property(e => e.B2fRadif).HasColumnName("b2f_radif");
            entity.Property(e => e.B2fTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b2f_time");
            entity.Property(e => e.B2fVazn)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("b2f_vazn");
            entity.Property(e => e.B3Anaam)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("b3_anaam");
            entity.Property(e => e.B3Oft)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("b3_oft");
            entity.Property(e => e.B3Sookht)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("b3_sookht");
            entity.Property(e => e.B3eDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b3e_date");
            entity.Property(e => e.B3eRadif).HasColumnName("b3e_radif");
            entity.Property(e => e.B3eTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b3e_time");
            entity.Property(e => e.B3eVazn)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("b3e_vazn");
            entity.Property(e => e.B3fDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b3f_date");
            entity.Property(e => e.B3fRadif).HasColumnName("b3f_radif");
            entity.Property(e => e.B3fTime)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("b3f_time");
            entity.Property(e => e.B3fVazn)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("b3f_vazn");
            entity.Property(e => e.Closed).HasColumnName("closed");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("date");
            entity.Property(e => e.EndDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("end_da");
            entity.Property(e => e.EndTi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("end_ti");
            entity.Property(e => e.IdAmani).HasColumnName("id_amani");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
            entity.Property(e => e.IdCtm).HasColumnName("id_ctm");
            entity.Property(e => e.IdDrv).HasColumnName("id_drv");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdKamion).HasColumnName("id_kamion");
            entity.Property(e => e.IdManteg).HasColumnName("id_manteg");
            entity.Property(e => e.IdMordar).HasColumnName("id_mordar");
            entity.Property(e => e.IdOk)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_ok");
            entity.Property(e => e.IdPeriod).HasColumnName("id_period");
            entity.Property(e => e.IdToyor).HasColumnName("id_toyor");
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
            entity.Property(e => e.KamionNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("kamion_no");
            entity.Property(e => e.KhorojDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("khoroj_da");
            entity.Property(e => e.KhorojTi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("khoroj_ti");
            entity.Property(e => e.KoshtarNo).HasColumnName("koshtar_no");
            entity.Property(e => e.Masafat)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("masafat");
            entity.Property(e => e.Sabad1).HasColumnName("sabad1");
            entity.Property(e => e.Sabad1In).HasColumnName("sabad1_in");
            entity.Property(e => e.Sabad2).HasColumnName("sabad2");
            entity.Property(e => e.Sabad2In).HasColumnName("sabad2_in");
            entity.Property(e => e.Sabad3).HasColumnName("sabad3");
            entity.Property(e => e.Sabad3In).HasColumnName("sabad3_in");
            entity.Property(e => e.Sabad4).HasColumnName("sabad4");
            entity.Property(e => e.Sabad4In).HasColumnName("sabad4_in");
            entity.Property(e => e.Sabad5).HasColumnName("sabad5");
            entity.Property(e => e.Sabad5In).HasColumnName("sabad5_in");
            entity.Property(e => e.Sharh)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sharh");
            entity.Property(e => e.StartDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("start_da");
            entity.Property(e => e.StartTi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("start_ti");
            entity.Property(e => e.TalafCnt).HasColumnName("talaf_cnt");
            entity.Property(e => e.TalafVazn)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("talaf_vazn");
            entity.Property(e => e.VorodDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vorod_da");
            entity.Property(e => e.VorodTi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vorod_ti");
            entity.Property(e => e.ZayeCnt).HasColumnName("zaye_cnt");
            entity.Property(e => e.ZayeVazn)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("zaye_vazn");
            entity.Property(e => e.ZayenCnt).HasColumnName("zayen_cnt");
            entity.Property(e => e.ZayenVazn)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("zayen_vazn");

            entity.HasOne(d => d.IdAmaniNavigation).WithMany(p => p.SekoshtarIdAmaniNavigations)
                .HasForeignKey(d => d.IdAmani)
                .HasConstraintName("FK_sekoshtar_sehesabgroupdetail4");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Sekoshtars)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK_sekoshtar_sebranch");

            entity.HasOne(d => d.IdBrngrpNavigation).WithMany(p => p.Sekoshtars)
                .HasForeignKey(d => d.IdBrngrp)
                .HasConstraintName("FK_sekoshtar_sebranchgroup");

            entity.HasOne(d => d.IdCtmNavigation).WithMany(p => p.SekoshtarIdCtmNavigations)
                .HasForeignKey(d => d.IdCtm)
                .HasConstraintName("FK_sekoshtar_sehesabgroupdetail1");

            entity.HasOne(d => d.IdDrvNavigation).WithMany(p => p.SekoshtarIdDrvNavigations)
                .HasForeignKey(d => d.IdDrv)
                .HasConstraintName("FK_sekoshtar_sehesabgroupdetail2");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Sekoshtars)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sekoshtar_seforms");

            entity.HasOne(d => d.IdKamionNavigation).WithMany(p => p.SekoshtarIdKamionNavigations)
                .HasForeignKey(d => d.IdKamion)
                .HasConstraintName("FK_sekoshtar_sehesabgroupdetail5");

            entity.HasOne(d => d.IdMantegNavigation).WithMany(p => p.SekoshtarIdMantegNavigations)
                .HasForeignKey(d => d.IdManteg)
                .HasConstraintName("FK_sekoshtar_sehesabgroupdetail3");

            entity.HasOne(d => d.IdMordarNavigation).WithMany(p => p.SekoshtarIdMordarNavigations)
                .HasForeignKey(d => d.IdMordar)
                .HasConstraintName("FK_sekoshtar_sehesabgroupdetail");

            entity.HasOne(d => d.IdOkNavigation).WithMany(p => p.Sekoshtars)
                .HasForeignKey(d => d.IdOk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sekoshtar_seok");

            entity.HasOne(d => d.IdPeriodNavigation).WithMany(p => p.Sekoshtars)
                .HasForeignKey(d => d.IdPeriod)
                .HasConstraintName("FK_sekoshtar_seperiod");

            entity.HasOne(d => d.IdToyorNavigation).WithMany(p => p.SekoshtarIdToyorNavigations)
                .HasForeignKey(d => d.IdToyor)
                .HasConstraintName("FK_sekoshtar_sehesabgroupdetail6");
        });

        modelBuilder.Entity<Selabbetonazmooneh>(entity =>
        {
            entity.HasKey(e => e.IdAzm);

            entity.ToTable("selabbetonazmooneh");

            entity.HasIndex(e => new { e.IdNem, e.AzmNo, e.Date, e.TchHsbd, e.MhlHsbd, e.HosHsbd }, "IX_selabbetonazmooneh_id_nem_azm_no_date_tch_hsbd_mhl_hsbd_hos_hsbd");

            entity.Property(e => e.IdAzm)
                .ValueGeneratedNever()
                .HasColumnName("id_azm");
            entity.Property(e => e.Anjam).HasColumnName("anjam");
            entity.Property(e => e.Arz).HasColumnName("arz");
            entity.Property(e => e.AzmNo).HasColumnName("azm_no");
            entity.Property(e => e.BarArea)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("bar_area");
            entity.Property(e => e.BarSorat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("bar_sorat");
            entity.Property(e => e.Calibzarib)
                .HasDefaultValue(1m)
                .HasColumnType("numeric(12, 7)")
                .HasColumnName("calibzarib");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.Dateanjam)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dateanjam");
            entity.Property(e => e.Datesar)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("datesar");
            entity.Property(e => e.Datetahvil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("datetahvil");
            entity.Property(e => e.Days).HasColumnName("days");
            entity.Property(e => e.Descrip)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("descrip");
            entity.Property(e => e.Ertefa).HasColumnName("ertefa");
            entity.Property(e => e.Hajm)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("hajm");
            entity.Property(e => e.HosHsbd).HasColumnName("hos_hsbd");
            entity.Property(e => e.IdNem).HasColumnName("id_nem");
            entity.Property(e => e.IndtDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_date");
            entity.Property(e => e.IndtTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("indt_time");
            entity.Property(e => e.IndtUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("indt_user");
            entity.Property(e => e.MdrHsbd).HasColumnName("mdr_hsbd");
            entity.Property(e => e.MhlHsbd).HasColumnName("mhl_hsbd");
            entity.Property(e => e.Moghavemat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("moghavemat");
            entity.Property(e => e.NaImage)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("na_image");
            entity.Property(e => e.Nemtype).HasColumnName("nemtype");
            entity.Property(e => e.Nemvaziat).HasColumnName("nemvaziat");
            entity.Property(e => e.Niroo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("niroo");
            entity.Property(e => e.TchHsbd).HasColumnName("tch_hsbd");
            entity.Property(e => e.Toazmvaziat).HasColumnName("toazmvaziat");
            entity.Property(e => e.Tool).HasColumnName("tool");
            entity.Property(e => e.Vazn)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vazn");
            entity.Property(e => e.VaznMakh)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("vazn_makh");
            entity.Property(e => e.Zaribshape)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("zaribshape");

            entity.HasOne(d => d.HosHsbdNavigation).WithMany(p => p.SelabbetonazmoonehHosHsbdNavigations)
                .HasForeignKey(d => d.HosHsbd)
                .HasConstraintName("FK_selabbetonazmooneh_sehesabgroupdetail3");

            entity.HasOne(d => d.IdNemNavigation).WithMany(p => p.Selabbetonazmoonehs)
                .HasForeignKey(d => d.IdNem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_selabbetonazmooneh_selabbetonnemooneh");

            entity.HasOne(d => d.IndtUserNavigation).WithMany(p => p.Selabbetonazmoonehs)
                .HasForeignKey(d => d.IndtUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_selabbetonazmooneh_users");

            entity.HasOne(d => d.MdrHsbdNavigation).WithMany(p => p.SelabbetonazmoonehMdrHsbdNavigations)
                .HasForeignKey(d => d.MdrHsbd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_selabbetonazmooneh_sehesabgroupdetail2");

            entity.HasOne(d => d.MhlHsbdNavigation).WithMany(p => p.SelabbetonazmoonehMhlHsbdNavigations)
                .HasForeignKey(d => d.MhlHsbd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_selabbetonazmooneh_sehesabgroupdetail1");

            entity.HasOne(d => d.TchHsbdNavigation).WithMany(p => p.SelabbetonazmoonehTchHsbdNavigations)
                .HasForeignKey(d => d.TchHsbd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_selabbetonazmooneh_sehesabgroupdetail");
        });

        modelBuilder.Entity<Selabbetonnemooneh>(entity =>
        {
            entity.HasKey(e => e.IdNem).HasName("PK_sdlabbetonnemooneh");

            entity.ToTable("selabbetonnemooneh");

            entity.HasIndex(e => new { e.IdForm, e.Type, e.IdBeton, e.Date, e.IdNemtem, e.CtmHsb, e.CtmHsbd, e.BtnDate, e.PosHsbdtl }, "IX_selabbetonnemooneh_id_form_type_id_beton_date_id_nemtem_ctm_hsb_ctm_hsbd_btn_date_pos_hsbdtl");

            entity.Property(e => e.IdNem)
                .ValueGeneratedNever()
                .HasColumnName("id_nem");
            entity.Property(e => e.Afz1Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("afz1_code");
            entity.Property(e => e.Afz1Karkh)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("afz1_karkh");
            entity.Property(e => e.Afz1Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("afz1_name");
            entity.Property(e => e.Afz1Vazn)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("afz1_vazn");
            entity.Property(e => e.Afz2Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("afz2_code");
            entity.Property(e => e.Afz2Karkh)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("afz2_karkh");
            entity.Property(e => e.Afz2Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("afz2_name");
            entity.Property(e => e.Afz2Vazn)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("afz2_vazn");
            entity.Property(e => e.BetonNo).HasColumnName("beton_no");
            entity.Property(e => e.BtnAyar).HasColumnName("btn_ayar");
            entity.Property(e => e.BtnDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("btn_date");
            entity.Property(e => e.BtnMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("btn_meter");
            entity.Property(e => e.BtnTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("btn_time");
            entity.Property(e => e.Contractor)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("contractor");
            entity.Property(e => e.CtmHsb).HasColumnName("ctm_hsb");
            entity.Property(e => e.CtmHsbd).HasColumnName("ctm_hsbd");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.Descrip)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("descrip");
            entity.Property(e => e.Eskelet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("eskelet");
            entity.Property(e => e.Eslamp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("eslamp");
            entity.Property(e => e.Floorcount).HasColumnName("floorcount");
            entity.Property(e => e.IdBeton).HasColumnName("id_beton");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdNemtem).HasColumnName("id_nemtem");
            entity.Property(e => e.IdSms).HasColumnName("id_sms");
            entity.Property(e => e.IndtDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_date");
            entity.Property(e => e.IndtTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("indt_time");
            entity.Property(e => e.IndtUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("indt_user");
            entity.Property(e => e.Maghsad)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("maghsad");
            entity.Property(e => e.Malek)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("malek");
            entity.Property(e => e.Manteghe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("manteghe");
            entity.Property(e => e.MasehM)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("maseh_m");
            entity.Property(e => e.MasehV)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("maseh_v");
            entity.Property(e => e.Mobilebo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mobilebo");
            entity.Property(e => e.MogHsbd).HasColumnName("mog_hsbd");
            entity.Property(e => e.MsfHsbd).HasColumnName("msf_hsbd");
            entity.Property(e => e.NaImage)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("na_image");
            entity.Property(e => e.Nazer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("nazer");
            entity.Property(e => e.Parvane)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("parvane");
            entity.Property(e => e.Pelak)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("pelak");
            entity.Property(e => e.PosDesc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("pos_desc");
            entity.Property(e => e.PosHsbdtl).HasColumnName("pos_hsbdtl");
            entity.Property(e => e.Prnvaziat).HasColumnName("prnvaziat");
            entity.Property(e => e.ProjArea)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("proj_area");
            entity.Property(e => e.Sendsms)
                .HasDefaultValue(true)
                .HasColumnName("sendsms");
            entity.Property(e => e.ShenM)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("shen_m");
            entity.Property(e => e.ShenV)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("shen_v");
            entity.Property(e => e.SimanM)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("siman_m");
            entity.Property(e => e.SimanV)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("siman_v");
            entity.Property(e => e.SmnHsbd).HasColumnName("smn_hsbd");
            entity.Property(e => e.TempBeton)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("temp_beton");
            entity.Property(e => e.TempMohit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("temp_mohit");
            entity.Property(e => e.TempWater)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("temp_water");
            entity.Property(e => e.Type)
                .HasDefaultValue((byte)1)
                .HasColumnName("type");
            entity.Property(e => e.WaterV)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("water_v");

            entity.HasOne(d => d.CtmHsbNavigation).WithMany(p => p.Selabbetonnemoonehs)
                .HasForeignKey(d => d.CtmHsb)
                .HasConstraintName("FK_selabbetonnemooneh_sehesab");

            entity.HasOne(d => d.CtmHsbdNavigation).WithMany(p => p.SelabbetonnemoonehCtmHsbdNavigations)
                .HasForeignKey(d => d.CtmHsbd)
                .HasConstraintName("FK_selabbetonnemooneh_selabbetonnemooneh");

            entity.HasOne(d => d.IdBetonNavigation).WithMany(p => p.Selabbetonnemoonehs)
                .HasForeignKey(d => d.IdBeton)
                .HasConstraintName("FK_selabbetonnemooneh_sebeton");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Selabbetonnemoonehs)
                .HasForeignKey(d => d.IdForm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_selabbetonnemooneh_seforms");

            entity.HasOne(d => d.IdNemtemNavigation).WithMany(p => p.Selabbetonnemoonehs)
                .HasForeignKey(d => d.IdNemtem)
                .HasConstraintName("FK_selabbetonnemooneh_selabbetontemplate");

            entity.HasOne(d => d.IdSmsNavigation).WithMany(p => p.Selabbetonnemoonehs)
                .HasForeignKey(d => d.IdSms)
                .HasConstraintName("FK_selabbetonnemooneh_sms");

            entity.HasOne(d => d.IndtUserNavigation).WithMany(p => p.Selabbetonnemoonehs)
                .HasForeignKey(d => d.IndtUser)
                .HasConstraintName("FK_selabbetonnemooneh_users");

            entity.HasOne(d => d.MogHsbdNavigation).WithMany(p => p.SelabbetonnemoonehMogHsbdNavigations)
                .HasForeignKey(d => d.MogHsbd)
                .HasConstraintName("FK_selabbetonnemooneh_sehesabgroupdetail3");

            entity.HasOne(d => d.MsfHsbdNavigation).WithMany(p => p.SelabbetonnemoonehMsfHsbdNavigations)
                .HasForeignKey(d => d.MsfHsbd)
                .HasConstraintName("FK_selabbetonnemooneh_sehesabgroupdetail1");

            entity.HasOne(d => d.PosHsbdtlNavigation).WithMany(p => p.SelabbetonnemoonehPosHsbdtlNavigations)
                .HasForeignKey(d => d.PosHsbdtl)
                .HasConstraintName("FK_selabbetonnemooneh_sehesabgroupdetail");

            entity.HasOne(d => d.SmnHsbdNavigation).WithMany(p => p.SelabbetonnemoonehSmnHsbdNavigations)
                .HasForeignKey(d => d.SmnHsbd)
                .HasConstraintName("FK_selabbetonnemooneh_sehesabgroupdetail2");
        });

        modelBuilder.Entity<Selabbetonnemoonehprint>(entity =>
        {
            entity.HasKey(e => e.IdNemprn);

            entity.ToTable("selabbetonnemoonehprint");

            entity.HasIndex(e => new { e.IdNem, e.Printno }, "IX_U_selabbetonnemoonehprint_id_nem_printno").IsUnique();

            entity.Property(e => e.IdNemprn)
                .ValueGeneratedNever()
                .HasColumnName("id_nemprn");
            entity.Property(e => e.Girandeh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("girandeh");
            entity.Property(e => e.IdNem).HasColumnName("id_nem");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("indt_ti");
            entity.Property(e => e.IndtUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("indt_user");
            entity.Property(e => e.Printno).HasColumnName("printno");
            entity.Property(e => e.Serialno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("serialno");
            entity.Property(e => e.Tel)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tel");

            entity.HasOne(d => d.IdNemNavigation).WithMany(p => p.Selabbetonnemoonehprints)
                .HasForeignKey(d => d.IdNem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_selabbetonnemoonehprint_selabbetonnemooneh");

            entity.HasOne(d => d.IndtUserNavigation).WithMany(p => p.Selabbetonnemoonehprints)
                .HasForeignKey(d => d.IndtUser)
                .HasConstraintName("FK_selabbetonnemoonehprint_users");
        });

        modelBuilder.Entity<Selabbetontemplate>(entity =>
        {
            entity.HasKey(e => e.IdNemtem);

            entity.ToTable("selabbetontemplate");

            entity.Property(e => e.IdNemtem)
                .ValueGeneratedNever()
                .HasColumnName("id_nemtem");
            entity.Property(e => e.Default).HasColumnName("default");
            entity.Property(e => e.Detail)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Tahvildays)
                .HasDefaultValue((byte)1)
                .HasColumnName("tahvildays");
        });

        modelBuilder.Entity<Semarkaz>(entity =>
        {
            entity.HasKey(e => e.IdMkz);

            entity.ToTable("semarkaz");

            entity.HasIndex(e => new { e.IdActive, e.IdMkztyp, e.Name }, "IX_semarkaz_id_active_id_mkztyp_name");

            entity.HasIndex(e => e.Fieldnum, "UQ_semarkaz_fieldnum").IsUnique();

            entity.Property(e => e.IdMkz)
                .ValueGeneratedNever()
                .HasColumnName("id_mkz");
            entity.Property(e => e.Ashar).HasColumnName("ashar");
            entity.Property(e => e.CoMkz).HasColumnName("co_mkz");
            entity.Property(e => e.Codelength)
                .HasDefaultValue((byte)1)
                .HasColumnName("codelength");
            entity.Property(e => e.Comment)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.Fieldnum).HasColumnName("fieldnum");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdMkztyp)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_mkztyp");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
            entity.Property(e => e.Zamantype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("HMS")
                .HasColumnName("zamantype");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Semarkazs)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_semarkaz_active");

            entity.HasOne(d => d.IdMkztypNavigation).WithMany(p => p.Semarkazs)
                .HasForeignKey(d => d.IdMkztyp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_semarkaz_semarkaztype");
        });

        modelBuilder.Entity<Semarkazdetail>(entity =>
        {
            entity.HasKey(e => e.IdMkzdtl);

            entity.ToTable("semarkazdetail");

            entity.HasIndex(e => new { e.IdMkz, e.IdActive, e.ParMkzdtl, e.IdCtmtit, e.IdCtmtyp, e.IdBnkhtyp }, "NonClusteredIndex-20180710-113839");

            entity.Property(e => e.IdMkzdtl)
                .ValueGeneratedNever()
                .HasColumnName("id_mkzdtl");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("address");
            entity.Property(e => e.Birthdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("birthdate");
            entity.Property(e => e.Birthshahr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("birthshahr");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Credit)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("credit");
            entity.Property(e => e.Father)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("father");
            entity.Property(e => e.Hesabno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("hesabno");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdBank).HasColumnName("id_bank");
            entity.Property(e => e.IdBnkhtyp).HasColumnName("id_bnkhtyp");
            entity.Property(e => e.IdCtmtit).HasColumnName("id_ctmtit");
            entity.Property(e => e.IdCtmtyp).HasColumnName("id_ctmtyp");
            entity.Property(e => e.IdMkz).HasColumnName("id_mkz");
            entity.Property(e => e.IdSex).HasColumnName("id_sex");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.Melino)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("melino");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.ParMkzdtl).HasColumnName("par_mkzdtl");
            entity.Property(e => e.Para1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para1");
            entity.Property(e => e.Para10)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para10");
            entity.Property(e => e.Para11)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para11");
            entity.Property(e => e.Para12)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para12");
            entity.Property(e => e.Para13)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para13");
            entity.Property(e => e.Para14)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para14");
            entity.Property(e => e.Para15)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para15");
            entity.Property(e => e.Para16)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para16");
            entity.Property(e => e.Para17)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para17");
            entity.Property(e => e.Para18)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para18");
            entity.Property(e => e.Para19)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para19");
            entity.Property(e => e.Para2)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para2");
            entity.Property(e => e.Para20)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para20");
            entity.Property(e => e.Para21)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para21");
            entity.Property(e => e.Para22)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para22");
            entity.Property(e => e.Para23)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para23");
            entity.Property(e => e.Para24)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para24");
            entity.Property(e => e.Para25)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para25");
            entity.Property(e => e.Para26)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para26");
            entity.Property(e => e.Para27)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para27");
            entity.Property(e => e.Para28)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para28");
            entity.Property(e => e.Para29)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para29");
            entity.Property(e => e.Para3)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para3");
            entity.Property(e => e.Para30)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para30");
            entity.Property(e => e.Para31)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para31");
            entity.Property(e => e.Para32)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para32");
            entity.Property(e => e.Para33)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para33");
            entity.Property(e => e.Para34)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para34");
            entity.Property(e => e.Para35)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para35");
            entity.Property(e => e.Para36)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para36");
            entity.Property(e => e.Para37)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para37");
            entity.Property(e => e.Para38)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para38");
            entity.Property(e => e.Para39)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para39");
            entity.Property(e => e.Para4)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para4");
            entity.Property(e => e.Para40)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para40");
            entity.Property(e => e.Para41)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para41");
            entity.Property(e => e.Para42)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para42");
            entity.Property(e => e.Para43)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para43");
            entity.Property(e => e.Para44)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para44");
            entity.Property(e => e.Para45)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para45");
            entity.Property(e => e.Para46)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para46");
            entity.Property(e => e.Para47)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para47");
            entity.Property(e => e.Para48)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para48");
            entity.Property(e => e.Para49)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para49");
            entity.Property(e => e.Para5)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para5");
            entity.Property(e => e.Para50)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para50");
            entity.Property(e => e.Para6)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para6");
            entity.Property(e => e.Para7)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para7");
            entity.Property(e => e.Para8)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para8");
            entity.Property(e => e.Para9)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para9");
            entity.Property(e => e.Shanasno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shanasno");
            entity.Property(e => e.Shobeh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("shobeh");
            entity.Property(e => e.Sodoor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sodoor");
            entity.Property(e => e.Sodoordate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sodoordate");
            entity.Property(e => e.StrCode1)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("str_code1");
            entity.Property(e => e.StrCode2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("str_code2");
            entity.Property(e => e.StrKey)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("str_key");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("tel");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Semarkazdetails)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_semarkazdetail_seactive");

            entity.HasOne(d => d.IdBankNavigation).WithMany(p => p.Semarkazdetails)
                .HasForeignKey(d => d.IdBank)
                .HasConstraintName("FK_semarkazdetail_sebank");

            entity.HasOne(d => d.IdBnkhtypNavigation).WithMany(p => p.Semarkazdetails)
                .HasForeignKey(d => d.IdBnkhtyp)
                .HasConstraintName("FK_semarkazdetail_sebankhesabtype");

            entity.HasOne(d => d.IdCtmtitNavigation).WithMany(p => p.Semarkazdetails)
                .HasForeignKey(d => d.IdCtmtit)
                .HasConstraintName("FK_semarkazdetail_secustomertitles");

            entity.HasOne(d => d.IdCtmtypNavigation).WithMany(p => p.Semarkazdetails)
                .HasForeignKey(d => d.IdCtmtyp)
                .HasConstraintName("FK_semarkazdetail_secustomertype");

            entity.HasOne(d => d.IdMkzNavigation).WithMany(p => p.Semarkazdetails)
                .HasForeignKey(d => d.IdMkz)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_semarkazdetail_semarkaz");

            entity.HasOne(d => d.IdSexNavigation).WithMany(p => p.Semarkazdetails)
                .HasForeignKey(d => d.IdSex)
                .HasConstraintName("FK_semarkazdetail_sesex");

            entity.HasOne(d => d.ParMkzdtlNavigation).WithMany(p => p.InverseParMkzdtlNavigation)
                .HasForeignKey(d => d.ParMkzdtl)
                .HasConstraintName("FK_semarkazdetail_semarkazdetail");
        });

        modelBuilder.Entity<Semarkazfield>(entity =>
        {
            entity.HasKey(e => e.IdMkzfld);

            entity.ToTable("semarkazfields");

            entity.HasIndex(e => new { e.IdMkz, e.Fieldnum }, "IX_semarkaztable").IsUnique();

            entity.HasIndex(e => new { e.IdMkz, e.IdActive }, "NonClusteredIndex-20180710-113942");

            entity.Property(e => e.IdMkzfld)
                .ValueGeneratedNever()
                .HasColumnName("id_mkzfld");
            entity.Property(e => e.Ashar).HasColumnName("ashar");
            entity.Property(e => e.Fieldcode).HasColumnName("fieldcode");
            entity.Property(e => e.Fieldname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fieldname");
            entity.Property(e => e.Fieldnum).HasColumnName("fieldnum");
            entity.Property(e => e.Fieldtype)
                .HasDefaultValue((byte)1)
                .HasColumnName("fieldtype");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdMkz).HasColumnName("id_mkz");
            entity.Property(e => e.Inputtype)
                .HasDefaultValue((byte)1)
                .HasColumnName("inputtype");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
            entity.Property(e => e.Zamantype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("HMS")
                .HasColumnName("zamantype");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Semarkazfields)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_semarkazfields_active");

            entity.HasOne(d => d.IdMkzNavigation).WithMany(p => p.Semarkazfields)
                .HasForeignKey(d => d.IdMkz)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_semarkaztable_semarkaz");
        });

        modelBuilder.Entity<Semarkazfielditem>(entity =>
        {
            entity.ToTable("semarkazfielditems");

            entity.HasIndex(e => new { e.IdActive, e.IdMkzfld }, "IX_semarkazfielditems_id_active_id_mkzfld");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdMkzfld).HasColumnName("id_mkzfld");
            entity.Property(e => e.Tartib).HasColumnName("tartib");
            entity.Property(e => e.Typeitem)
                .HasDefaultValue((byte)1)
                .HasColumnName("typeitem");
            entity.Property(e => e.Valueitem)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("valueitem");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Semarkazfielditems)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_semarkazfielditems_active");

            entity.HasOne(d => d.IdMkzfldNavigation).WithMany(p => p.Semarkazfielditems)
                .HasForeignKey(d => d.IdMkzfld)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_semarkazfielditems_semarkazfields");
        });

        modelBuilder.Entity<Semarkaztype>(entity =>
        {
            entity.HasKey(e => e.IdMkztyp);

            entity.ToTable("semarkaztype");

            entity.Property(e => e.IdMkztyp).HasColumnName("id_mkztyp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Seok>(entity =>
        {
            entity.HasKey(e => e.IdOk).HasName("PK_sesanadok");

            entity.ToTable("seok");

            entity.Property(e => e.IdOk).HasColumnName("id_ok");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Seperiod>(entity =>
        {
            entity.HasKey(e => e.IdPeriod).HasName("PK_sepriod");

            entity.ToTable("seperiod");

            entity.HasIndex(e => e.Code, "IX_sepriod").IsUnique();

            entity.HasIndex(e => new { e.IdActive, e.Code, e.Name, e.Datestart, e.Dateend }, "NonClusteredIndex-20180710-114056");

            entity.Property(e => e.IdPeriod)
                .ValueGeneratedNever()
                .HasColumnName("id_period");
            entity.Property(e => e.AfzoodehD)
                .HasColumnType("numeric(5, 1)")
                .HasColumnName("afzoodeh_d");
            entity.Property(e => e.Anbchafrom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("anbchafrom");
            entity.Property(e => e.Anbhsbtyp)
                .HasDefaultValue((byte)1)
                .HasColumnName("anbhsbtyp");
            entity.Property(e => e.Anbprctyp)
                .HasDefaultValue((byte)1)
                .HasColumnName("anbprctyp");
            entity.Property(e => e.Closeuntil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("closeuntil");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Dateend)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("dateend");
            entity.Property(e => e.Datestart)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("datestart");
            entity.Property(e => e.Fcttasvieh).HasColumnName("fcttasvieh");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.Integrated)
                .HasDefaultValue(true)
                .HasColumnName("integrated");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.SndClose).HasColumnName("snd_close");
            entity.Property(e => e.SndSood).HasColumnName("snd_sood");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Seperiods)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sepriod_seactive");
        });

        modelBuilder.Entity<Seperiodbranch>(entity =>
        {
            entity.HasKey(e => e.IdPrdbrn).IsClustered(false);

            entity.ToTable("seperiodbranch");

            entity.HasIndex(e => new { e.IdPeriod, e.IdBranch }, "IX_U_seperiodbranch_id_period_id_branch").IsUnique();

            entity.HasIndex(e => new { e.IdPeriod, e.IdBranch, e.IdBrngrp }, "IX_seperiodbranch_id_period_id_branch_id_brngrp").IsClustered();

            entity.Property(e => e.IdPrdbrn)
                .ValueGeneratedNever()
                .HasColumnName("id_prdbrn");
            entity.Property(e => e.Anbchafrom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("anbchafrom");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
            entity.Property(e => e.IdPeriod).HasColumnName("id_period");
            entity.Property(e => e.SndClose).HasColumnName("snd_close");
            entity.Property(e => e.SndSood).HasColumnName("snd_sood");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Seperiodbranches)
                .HasForeignKey(d => d.IdBranch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seperiodbranch_sebranch");

            entity.HasOne(d => d.IdBrngrpNavigation).WithMany(p => p.Seperiodbranches)
                .HasForeignKey(d => d.IdBrngrp)
                .HasConstraintName("FK_seperiodbranch_sebranchgroup");

            entity.HasOne(d => d.IdPeriodNavigation).WithMany(p => p.Seperiodbranches)
                .HasForeignKey(d => d.IdPeriod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seperiodbranch_seperiod");
        });

        modelBuilder.Entity<Seperiodpermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seperiodpermission");

            entity.HasIndex(e => new { e.IdPermis, e.Active }, "IX_seperiodpermission_id_permis_active").IsClustered();

            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.IdPermis).HasColumnName("id_permis");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdPermisNavigation).WithMany()
                .HasForeignKey(d => d.IdPermis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seperiodpermission_sepermission");
        });

        modelBuilder.Entity<Seperioduser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("seperiodusers");

            entity.HasIndex(e => new { e.IdPeriod, e.IdUser, e.IdPermis }, "IX_seperiodusers_id_period_id_user_id_permis").IsClustered();

            entity.Property(e => e.IdPeriod).HasColumnName("id_period");
            entity.Property(e => e.IdPermis).HasColumnName("id_permis");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");

            entity.HasOne(d => d.IdPeriodNavigation).WithMany()
                .HasForeignKey(d => d.IdPeriod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seperiodusers_seperiod");

            entity.HasOne(d => d.IdPermisNavigation).WithMany()
                .HasForeignKey(d => d.IdPermis)
                .HasConstraintName("FK_seperiodusers_sepermission");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seperiodusers_users");
        });

        modelBuilder.Entity<Sepermission>(entity =>
        {
            entity.HasKey(e => e.IdPermis);

            entity.ToTable("sepermission");

            entity.Property(e => e.IdPermis)
                .ValueGeneratedNever()
                .HasColumnName("id_permis");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Serasidprintform>(entity =>
        {
            entity.ToTable("serasidprintform");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Default)
                .HasDefaultValue(true)
                .HasColumnName("default");
            entity.Property(e => e.FrtFile)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frt_file");
            entity.Property(e => e.FrxFile)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("frx_file");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Orgrepfile)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("orgrepfile");
            entity.Property(e => e.Relfiles)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("relfiles");
        });

        modelBuilder.Entity<Sesanad>(entity =>
        {
            entity.HasKey(e => e.IdSanad);

            entity.ToTable("sesanad");

            entity.HasIndex(e => e.Date, "IX_sesanad_date");

            entity.HasIndex(e => e.IdBranch, "IX_sesanad_id_branch");

            entity.HasIndex(e => new { e.IdBranch, e.IdBrngrp, e.IdPeriod, e.SanadNo, e.Date, e.IdFormM, e.SndLevel, e.IdOk, e.Sharhtotal }, "IX_sesanad_id_branch_id_brngrp_id_period_sanad_no_date_id_form_m_snd_level_id_ok_sharhtotal");

            entity.HasIndex(e => e.IdBrngrp, "IX_sesanad_id_brngrp");

            entity.HasIndex(e => e.IdFormM, "IX_sesanad_id_form_m");

            entity.HasIndex(e => e.IdOk, "IX_sesanad_id_ok");

            entity.HasIndex(e => e.IdPeriod, "IX_sesanad_id_period");

            entity.HasIndex(e => e.SanadNo, "IX_sesanad_sanad_no");

            entity.HasIndex(e => new { e.IdPeriod, e.SanadNo, e.IdBranch }, "UQ_sesanad_id_period_sanad_no_id_branch").IsUnique();

            entity.Property(e => e.IdSanad)
                .ValueGeneratedNever()
                .HasColumnName("id_sanad");
            entity.Property(e => e.AutoEf).HasColumnName("auto_ef");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("date");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
            entity.Property(e => e.IdFormM).HasColumnName("id_form_m");
            entity.Property(e => e.IdOk)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_ok");
            entity.Property(e => e.IdPeriod).HasColumnName("id_period");
            entity.Property(e => e.SanadNo).HasColumnName("sanad_no");
            entity.Property(e => e.Sharhtotal)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sharhtotal");
            entity.Property(e => e.SndLevel)
                .HasDefaultValue((byte)1)
                .HasColumnName("snd_level");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Sesanads)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK_sesanad_sebranch");

            entity.HasOne(d => d.IdBrngrpNavigation).WithMany(p => p.Sesanads)
                .HasForeignKey(d => d.IdBrngrp)
                .HasConstraintName("FK_sesanad_sebranchgroup");

            entity.HasOne(d => d.IdFormMNavigation).WithMany(p => p.Sesanads)
                .HasForeignKey(d => d.IdFormM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sesanad_seforms");

            entity.HasOne(d => d.IdOkNavigation).WithMany(p => p.Sesanads)
                .HasForeignKey(d => d.IdOk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sesanad_sesanadok");

            entity.HasOne(d => d.IdPeriodNavigation).WithMany(p => p.Sesanads)
                .HasForeignKey(d => d.IdPeriod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sesanad_seperiod");
        });

        modelBuilder.Entity<Sesanadlog>(entity =>
        {
            entity.HasKey(e => e.IdSanad);

            entity.ToTable("sesanadlog");

            entity.HasIndex(e => new { e.IdBranch, e.IdBrngrp, e.IdPeriod }, "IX_sesanadlog_id_branch_id_brngrp_id_period");

            entity.Property(e => e.IdSanad)
                .ValueGeneratedNever()
                .HasColumnName("id_sanad");
            entity.Property(e => e.Comment)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
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
            entity.Property(e => e.SanadNo).HasColumnName("sanad_no");
            entity.Property(e => e.SndrowNo).HasColumnName("sndrow_no");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Sesanadlogs)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK_sesanadlog_sebranch");

            entity.HasOne(d => d.IdBrngrpNavigation).WithMany(p => p.Sesanadlogs)
                .HasForeignKey(d => d.IdBrngrp)
                .HasConstraintName("FK_sesanadlog_sebranchgroup");

            entity.HasOne(d => d.IdPeriodNavigation).WithMany(p => p.Sesanadlogs)
                .HasForeignKey(d => d.IdPeriod)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sesanadlog_seperiod");
        });

        modelBuilder.Entity<Sesanadrow>(entity =>
        {
            entity.HasKey(e => new { e.IdSanad, e.IdRow });

            entity.ToTable("sesanadrows");

            entity.HasIndex(e => e.IdFactor, "IX_sesanadrows_id_factor");

            entity.HasIndex(e => e.IdForm, "IX_sesanadrows_id_form");

            entity.HasIndex(e => e.IdHsb, "IX_sesanadrows_id_hsb");

            entity.HasIndex(e => e.IdHsbdtl, "IX_sesanadrows_id_hsbdtl");

            entity.HasIndex(e => e.IdHvlrsd, "IX_sesanadrows_id_hvlrsd");

            entity.HasIndex(e => e.IdOk, "IX_sesanadrows_id_ok");

            entity.HasIndex(e => e.IdQstdtl, "IX_sesanadrows_id_qstdtl");

            entity.HasIndex(e => e.LinkNo, "IX_sesanadrows_link_no");

            entity.HasIndex(e => e.RowNo, "IX_sesanadrows_row_no");

            entity.HasIndex(e => new { e.IdHsb, e.IdHsbdtl, e.IdOk, e.IdForm, e.IdForosh, e.IdFactor, e.IdHvlrsd, e.Sabt }, "NonClusteredIndex-20180710-114504");

            entity.Property(e => e.IdSanad).HasColumnName("id_sanad");
            entity.Property(e => e.IdRow).HasColumnName("id_row");
            entity.Property(e => e.EditDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("edit_da");
            entity.Property(e => e.EditTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("edit_ti");
            entity.Property(e => e.EditUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("edit_user");
            entity.Property(e => e.IdFactor).HasColumnName("id_factor");
            entity.Property(e => e.IdFctbzr).HasColumnName("id_fctbzr");
            entity.Property(e => e.IdFctrel).HasColumnName("id_fctrel");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdForosh).HasColumnName("id_forosh");
            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.IdHsbdtl).HasColumnName("id_hsbdtl");
            entity.Property(e => e.IdHvlrsd).HasColumnName("id_hvlrsd");
            entity.Property(e => e.IdMkzd1).HasColumnName("id_mkzd1");
            entity.Property(e => e.IdMkzd10).HasColumnName("id_mkzd10");
            entity.Property(e => e.IdMkzd11).HasColumnName("id_mkzd11");
            entity.Property(e => e.IdMkzd12).HasColumnName("id_mkzd12");
            entity.Property(e => e.IdMkzd13).HasColumnName("id_mkzd13");
            entity.Property(e => e.IdMkzd14).HasColumnName("id_mkzd14");
            entity.Property(e => e.IdMkzd15).HasColumnName("id_mkzd15");
            entity.Property(e => e.IdMkzd16).HasColumnName("id_mkzd16");
            entity.Property(e => e.IdMkzd17).HasColumnName("id_mkzd17");
            entity.Property(e => e.IdMkzd18).HasColumnName("id_mkzd18");
            entity.Property(e => e.IdMkzd19).HasColumnName("id_mkzd19");
            entity.Property(e => e.IdMkzd2).HasColumnName("id_mkzd2");
            entity.Property(e => e.IdMkzd20).HasColumnName("id_mkzd20");
            entity.Property(e => e.IdMkzd3).HasColumnName("id_mkzd3");
            entity.Property(e => e.IdMkzd4).HasColumnName("id_mkzd4");
            entity.Property(e => e.IdMkzd5).HasColumnName("id_mkzd5");
            entity.Property(e => e.IdMkzd6).HasColumnName("id_mkzd6");
            entity.Property(e => e.IdMkzd7).HasColumnName("id_mkzd7");
            entity.Property(e => e.IdMkzd8).HasColumnName("id_mkzd8");
            entity.Property(e => e.IdMkzd9).HasColumnName("id_mkzd9");
            entity.Property(e => e.IdOk)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_ok");
            entity.Property(e => e.IdQst).HasColumnName("id_qst");
            entity.Property(e => e.IdQstdtl).HasColumnName("id_qstdtl");
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
                .IsFixedLength()
                .HasColumnName("indt_user");
            entity.Property(e => e.LinkNo).HasColumnName("link_no");
            entity.Property(e => e.Mablagh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mablagh");
            entity.Property(e => e.RowNo).HasColumnName("row_no");
            entity.Property(e => e.Sabt).HasColumnName("sabt");
            entity.Property(e => e.Sharh)
                .HasMaxLength(3500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sharh");
            entity.Property(e => e.VaMkz501)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz501");
            entity.Property(e => e.VaMkz502)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz502");
            entity.Property(e => e.VaMkz503)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz503");
            entity.Property(e => e.VaMkz504)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz504");
            entity.Property(e => e.VaMkz505)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz505");
            entity.Property(e => e.VaMkz506)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz506");
            entity.Property(e => e.VaMkz507)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz507");
            entity.Property(e => e.VaMkz508)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz508");
            entity.Property(e => e.VaMkz509)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz509");
            entity.Property(e => e.VaMkz510)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz510");
            entity.Property(e => e.VaMkz511)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz511");
            entity.Property(e => e.VaMkz512)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz512");
            entity.Property(e => e.VaMkz513)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz513");
            entity.Property(e => e.VaMkz514)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz514");
            entity.Property(e => e.VaMkz515)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz515");
            entity.Property(e => e.VaMkz516)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz516");
            entity.Property(e => e.VaMkz517)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz517");
            entity.Property(e => e.VaMkz518)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz518");
            entity.Property(e => e.VaMkz519)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz519");
            entity.Property(e => e.VaMkz520)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz520");
            entity.Property(e => e.VaMkz521)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz521");
            entity.Property(e => e.VaMkz522)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz522");
            entity.Property(e => e.VaMkz523)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz523");
            entity.Property(e => e.VaMkz524)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz524");
            entity.Property(e => e.VaMkz525)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz525");
            entity.Property(e => e.VaMkz526)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz526");
            entity.Property(e => e.VaMkz527)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz527");
            entity.Property(e => e.VaMkz528)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz528");
            entity.Property(e => e.VaMkz529)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz529");
            entity.Property(e => e.VaMkz530)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz530");
            entity.Property(e => e.VaMkz531)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz531");
            entity.Property(e => e.VaMkz532)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz532");
            entity.Property(e => e.VaMkz533)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz533");
            entity.Property(e => e.VaMkz534)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz534");
            entity.Property(e => e.VaMkz535)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz535");
            entity.Property(e => e.VaMkz536)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz536");
            entity.Property(e => e.VaMkz537)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz537");
            entity.Property(e => e.VaMkz538)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz538");
            entity.Property(e => e.VaMkz539)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz539");
            entity.Property(e => e.VaMkz540)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz540");
            entity.Property(e => e.VaMkz541)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz541");
            entity.Property(e => e.VaMkz542)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz542");
            entity.Property(e => e.VaMkz543)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz543");
            entity.Property(e => e.VaMkz544)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz544");
            entity.Property(e => e.VaMkz545)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz545");
            entity.Property(e => e.VaMkz546)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz546");
            entity.Property(e => e.VaMkz547)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz547");
            entity.Property(e => e.VaMkz548)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz548");
            entity.Property(e => e.VaMkz549)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz549");
            entity.Property(e => e.VaMkz550)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_mkz550");

            entity.HasOne(d => d.EditUserNavigation).WithMany(p => p.SesanadrowEditUserNavigations)
                .HasForeignKey(d => d.EditUser)
                .HasConstraintName("FK_sesanadrows_users1");

            entity.HasOne(d => d.IdFactorNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdFactor)
                .HasConstraintName("FK_sesanadrows_sefactor");

            entity.HasOne(d => d.IdFctbzrNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdFctbzr)
                .HasConstraintName("FK_sesanadrows_sefactorbazaryab");

            entity.HasOne(d => d.IdFctrelNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdFctrel)
                .HasConstraintName("FK_sesanadrows_sefactorsanadrel");

            entity.HasOne(d => d.IdFormNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdForm)
                .HasConstraintName("FK_sesanadrows_seforms");

            entity.HasOne(d => d.IdForoshNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdForosh)
                .HasConstraintName("FK_sesanadrows_seforoosh");

            entity.HasOne(d => d.IdHsbNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdHsb)
                .HasConstraintName("FK_sesanadrows_sehesab");

            entity.HasOne(d => d.IdHsbdtlNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdHsbdtl)
                .HasConstraintName("FK_sesanadrows_sehesabgroupdetail");

            entity.HasOne(d => d.IdHvlrsdNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdHvlrsd)
                .HasConstraintName("FK_sesanadrows_sehvlrsd");

            entity.HasOne(d => d.IdMkzd1Navigation).WithMany(p => p.SesanadrowIdMkzd1Navigations)
                .HasForeignKey(d => d.IdMkzd1)
                .HasConstraintName("FK_sesanadrows_semarkazdetail51");

            entity.HasOne(d => d.IdMkzd10Navigation).WithMany(p => p.SesanadrowIdMkzd10Navigations)
                .HasForeignKey(d => d.IdMkzd10)
                .HasConstraintName("FK_sesanadrows_semarkazdetail60");

            entity.HasOne(d => d.IdMkzd11Navigation).WithMany(p => p.SesanadrowIdMkzd11Navigations)
                .HasForeignKey(d => d.IdMkzd11)
                .HasConstraintName("FK_sesanadrows_semarkazdetail61");

            entity.HasOne(d => d.IdMkzd12Navigation).WithMany(p => p.SesanadrowIdMkzd12Navigations)
                .HasForeignKey(d => d.IdMkzd12)
                .HasConstraintName("FK_sesanadrows_semarkazdetail62");

            entity.HasOne(d => d.IdMkzd13Navigation).WithMany(p => p.SesanadrowIdMkzd13Navigations)
                .HasForeignKey(d => d.IdMkzd13)
                .HasConstraintName("FK_sesanadrows_semarkazdetail63");

            entity.HasOne(d => d.IdMkzd14Navigation).WithMany(p => p.SesanadrowIdMkzd14Navigations)
                .HasForeignKey(d => d.IdMkzd14)
                .HasConstraintName("FK_sesanadrows_semarkazdetail64");

            entity.HasOne(d => d.IdMkzd15Navigation).WithMany(p => p.SesanadrowIdMkzd15Navigations)
                .HasForeignKey(d => d.IdMkzd15)
                .HasConstraintName("FK_sesanadrows_semarkazdetail65");

            entity.HasOne(d => d.IdMkzd16Navigation).WithMany(p => p.SesanadrowIdMkzd16Navigations)
                .HasForeignKey(d => d.IdMkzd16)
                .HasConstraintName("FK_sesanadrows_semarkazdetail66");

            entity.HasOne(d => d.IdMkzd17Navigation).WithMany(p => p.SesanadrowIdMkzd17Navigations)
                .HasForeignKey(d => d.IdMkzd17)
                .HasConstraintName("FK_sesanadrows_semarkazdetail67");

            entity.HasOne(d => d.IdMkzd18Navigation).WithMany(p => p.SesanadrowIdMkzd18Navigations)
                .HasForeignKey(d => d.IdMkzd18)
                .HasConstraintName("FK_sesanadrows_semarkazdetail68");

            entity.HasOne(d => d.IdMkzd19Navigation).WithMany(p => p.SesanadrowIdMkzd19Navigations)
                .HasForeignKey(d => d.IdMkzd19)
                .HasConstraintName("FK_sesanadrows_semarkazdetail69");

            entity.HasOne(d => d.IdMkzd2Navigation).WithMany(p => p.SesanadrowIdMkzd2Navigations)
                .HasForeignKey(d => d.IdMkzd2)
                .HasConstraintName("FK_sesanadrows_semarkazdetail52");

            entity.HasOne(d => d.IdMkzd20Navigation).WithMany(p => p.SesanadrowIdMkzd20Navigations)
                .HasForeignKey(d => d.IdMkzd20)
                .HasConstraintName("FK_sesanadrows_semarkazdetail70");

            entity.HasOne(d => d.IdMkzd3Navigation).WithMany(p => p.SesanadrowIdMkzd3Navigations)
                .HasForeignKey(d => d.IdMkzd3)
                .HasConstraintName("FK_sesanadrows_semarkazdetail53");

            entity.HasOne(d => d.IdMkzd4Navigation).WithMany(p => p.SesanadrowIdMkzd4Navigations)
                .HasForeignKey(d => d.IdMkzd4)
                .HasConstraintName("FK_sesanadrows_semarkazdetail54");

            entity.HasOne(d => d.IdMkzd5Navigation).WithMany(p => p.SesanadrowIdMkzd5Navigations)
                .HasForeignKey(d => d.IdMkzd5)
                .HasConstraintName("FK_sesanadrows_semarkazdetail55");

            entity.HasOne(d => d.IdMkzd6Navigation).WithMany(p => p.SesanadrowIdMkzd6Navigations)
                .HasForeignKey(d => d.IdMkzd6)
                .HasConstraintName("FK_sesanadrows_semarkazdetail56");

            entity.HasOne(d => d.IdMkzd7Navigation).WithMany(p => p.SesanadrowIdMkzd7Navigations)
                .HasForeignKey(d => d.IdMkzd7)
                .HasConstraintName("FK_sesanadrows_semarkazdetail57");

            entity.HasOne(d => d.IdMkzd8Navigation).WithMany(p => p.SesanadrowIdMkzd8Navigations)
                .HasForeignKey(d => d.IdMkzd8)
                .HasConstraintName("FK_sesanadrows_semarkazdetail58");

            entity.HasOne(d => d.IdMkzd9Navigation).WithMany(p => p.SesanadrowIdMkzd9Navigations)
                .HasForeignKey(d => d.IdMkzd9)
                .HasConstraintName("FK_sesanadrows_semarkazdetail59");

            entity.HasOne(d => d.IdOkNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdOk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sesanadrows_sesanadok");

            entity.HasOne(d => d.IdQstNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdQst)
                .HasConstraintName("FK_sesanadrows_seaqsat");

            entity.HasOne(d => d.IdQstdtlNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdQstdtl)
                .HasConstraintName("FK_sesanadrows_seaqsatdetail");

            entity.HasOne(d => d.IdSanadNavigation).WithMany(p => p.Sesanadrows)
                .HasForeignKey(d => d.IdSanad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sesanadrows_sesanad");

            entity.HasOne(d => d.IndtUserNavigation).WithMany(p => p.SesanadrowIndtUserNavigations)
                .HasForeignKey(d => d.IndtUser)
                .HasConstraintName("FK_sesanadrows_users");
        });

        modelBuilder.Entity<Sesanadvajh>(entity =>
        {
            entity.HasKey(e => new { e.IdSanad, e.IdRow }).HasName("PK_sesanadinfo");

            entity.ToTable("sesanadvajh");

            entity.HasIndex(e => e.IdChq, "IX_sesanadvajh_id_chq");

            entity.HasIndex(e => e.IdChqstat, "IX_sesanadvajh_id_chqstat");

            entity.HasIndex(e => e.IdVajhtyp, "IX_sesanadvajh_id_vajhtyp");

            entity.HasIndex(e => new { e.IdVajhtyp, e.IdChq, e.IdChqstat }, "IX_sesanadvajh_id_vajhtyp_id_chq_id_chqstat");

            entity.HasIndex(e => new { e.VajhNo, e.VajhDate, e.VajhHsbno, e.VajhHsbow }, "IX_sesanadvajh_vajh_no_vajh_date_vajh_hsbno_vajh_hsbow");

            entity.Property(e => e.IdSanad).HasColumnName("id_sanad");
            entity.Property(e => e.IdRow).HasColumnName("id_row");
            entity.Property(e => e.Comment)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.Dahandeh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("dahandeh");
            entity.Property(e => e.FirstChq).HasColumnName("first_chq");
            entity.Property(e => e.Girandeh)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("girandeh");
            entity.Property(e => e.IdChq).HasColumnName("id_chq");
            entity.Property(e => e.IdChqstat).HasColumnName("id_chqstat");
            entity.Property(e => e.IdVajhtyp).HasColumnName("id_vajhtyp");
            entity.Property(e => e.Mablagh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("mablagh");
            entity.Property(e => e.VajhDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vajh_date");
            entity.Property(e => e.VajhHsbno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vajh_hsbno");
            entity.Property(e => e.VajhHsbow)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vajh_hsbow");
            entity.Property(e => e.VajhMaker)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vajh_maker");
            entity.Property(e => e.VajhNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("vajh_no");

            entity.HasOne(d => d.IdChqNavigation).WithMany(p => p.Sesanadvajhs)
                .HasForeignKey(d => d.IdChq)
                .HasConstraintName("FK_sesanadvajh_secheque");

            entity.HasOne(d => d.IdChqstatNavigation).WithMany(p => p.Sesanadvajhs)
                .HasForeignKey(d => d.IdChqstat)
                .HasConstraintName("FK_sesanadvajh_sechequestate");

            entity.HasOne(d => d.IdVajhtypNavigation).WithMany(p => p.Sesanadvajhs)
                .HasForeignKey(d => d.IdVajhtyp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sesanadvajh_sesanadvajhtype");

            entity.HasOne(d => d.Sesanadrow).WithOne(p => p.Sesanadvajh)
                .HasForeignKey<Sesanadvajh>(d => new { d.IdSanad, d.IdRow })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sesanadvajh_sesanadrows");
        });

        modelBuilder.Entity<Sesanadvajhtype>(entity =>
        {
            entity.HasKey(e => e.IdVajhtyp).HasName("PK_sesanadinfotype");

            entity.ToTable("sesanadvajhtype");

            entity.Property(e => e.IdVajhtyp).HasColumnName("id_vajhtyp");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sescale>(entity =>
        {
            entity.HasKey(e => e.IdScl);

            entity.ToTable("sescale");

            entity.HasIndex(e => new { e.IdBranch, e.IdSclmdl, e.IdUnit, e.IdActive }, "NonClusteredIndex-20180710-114840");

            entity.Property(e => e.IdScl)
                .ValueGeneratedNever()
                .HasColumnName("id_scl");
            entity.Property(e => e.Code)
                .HasDefaultValue(1)
                .HasColumnName("code");
            entity.Property(e => e.Currency)
                .HasDefaultValue((byte)1)
                .HasColumnName("currency");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdSclmdl).HasColumnName("id_sclmdl");
            entity.Property(e => e.IdUnit).HasColumnName("id_unit");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Port).HasColumnName("port");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Sescales)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sescale_active");

            entity.HasOne(d => d.IdBranchNavigation).WithMany(p => p.Sescales)
                .HasForeignKey(d => d.IdBranch)
                .HasConstraintName("FK_sescale_sebranch");

            entity.HasOne(d => d.IdSclmdlNavigation).WithMany(p => p.Sescales)
                .HasForeignKey(d => d.IdSclmdl)
                .HasConstraintName("FK_sescale_sescalemodel");

            entity.HasOne(d => d.IdUnitNavigation).WithMany(p => p.Sescales)
                .HasForeignKey(d => d.IdUnit)
                .HasConstraintName("FK_sescale_seunit");
        });

        modelBuilder.Entity<Sescalemodel>(entity =>
        {
            entity.HasKey(e => e.IdSclmdl).HasName("PK_setrazocompany");

            entity.ToTable("sescalemodel");

            entity.Property(e => e.IdSclmdl)
                .ValueGeneratedNever()
                .HasColumnName("id_sclmdl");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Sescalemodels)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_sescalemodel_sescalemodel");
        });

        modelBuilder.Entity<Setahlil>(entity =>
        {
            entity.HasKey(e => e.IdThl);

            entity.ToTable("setahlil");

            entity.HasIndex(e => new { e.Code, e.IdActive }, "IX_setahlil_code_id_active");

            entity.Property(e => e.IdThl)
                .ValueGeneratedNever()
                .HasColumnName("id_thl");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.IdActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("id_active");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");

            entity.HasOne(d => d.IdActiveNavigation).WithMany(p => p.Setahlils)
                .HasForeignKey(d => d.IdActive)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_setahlil_active");
        });

        modelBuilder.Entity<Setahlildetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("setahlildetail");

            entity.HasIndex(e => new { e.IdThl, e.IdCol, e.IdThl1 }, "IX_setahlildetail_id_thl_id_col_id_thl_").IsClustered();

            entity.Property(e => e.Ashar).HasColumnName("ashar");
            entity.Property(e => e.Caption)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("caption");
            entity.Property(e => e.ColType)
                .HasDefaultValue((byte)1)
                .HasColumnName("col_type");
            entity.Property(e => e.Formul)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("formul");
            entity.Property(e => e.IdCol).HasColumnName("id_col");
            entity.Property(e => e.IdThl).HasColumnName("id_thl");
            entity.Property(e => e.IdThl1).HasColumnName("id_thl_");
            entity.Property(e => e.LatinName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("latin_name");
            entity.Property(e => e.OutType)
                .HasDefaultValue((byte)1)
                .HasColumnName("out_type");
            entity.Property(e => e.Sign)
                .HasDefaultValue((byte)1)
                .HasColumnName("sign");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");

            entity.HasOne(d => d.IdColNavigation).WithMany()
                .HasForeignKey(d => d.IdCol)
                .HasConstraintName("FK_setahlildetail_secollection");

            entity.HasOne(d => d.IdThlNavigation).WithMany()
                .HasForeignKey(d => d.IdThl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_setahlildetail_setahlil");

            entity.HasOne(d => d.IdThl1Navigation).WithMany()
                .HasForeignKey(d => d.IdThl1)
                .HasConstraintName("FK_setahlildetail_setahlil1");
        });

        modelBuilder.Entity<Seunit>(entity =>
        {
            entity.HasKey(e => e.IdUnit);

            entity.ToTable("seunit");

            entity.Property(e => e.IdUnit)
                .ValueGeneratedNever()
                .HasColumnName("id_unit");
            entity.Property(e => e.Decimal).HasColumnName("decimal");
            entity.Property(e => e.IdStdunt).HasColumnName("id_stdunt");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Seunitconvert>(entity =>
        {
            entity.ToTable("seunitconvert");

            entity.HasIndex(e => new { e.IdUnit1, e.IdUnit2 }, "IX_seunitconvert_id_unit1_id_unit2");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdUnit1).HasColumnName("id_unit1");
            entity.Property(e => e.IdUnit2).HasColumnName("id_unit2");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((byte)1)
                .HasColumnName("tartib");
            entity.Property(e => e.Zarib)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("zarib");

            entity.HasOne(d => d.IdUnit1Navigation).WithMany(p => p.SeunitconvertIdUnit1Navigations)
                .HasForeignKey(d => d.IdUnit1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seunitconvert_seunit");

            entity.HasOne(d => d.IdUnit2Navigation).WithMany(p => p.SeunitconvertIdUnit2Navigations)
                .HasForeignKey(d => d.IdUnit2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_seunitconvert_seunit1");
        });

        modelBuilder.Entity<Sex>(entity =>
        {
            entity.HasKey(e => e.IdSex).HasName("PK_sesex");

            entity.ToTable("sex");

            entity.Property(e => e.IdSex).HasColumnName("id_sex");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Tartib).HasColumnName("tartib");
        });

        modelBuilder.Entity<Sm>(entity =>
        {
            entity.HasKey(e => e.IdSms);

            entity.ToTable("sms");

            entity.HasIndex(e => e.IdSms, "IX_sms");

            entity.HasIndex(e => e.IdSmsmdl, "IX_sms_id_smsmdl");

            entity.HasIndex(e => e.ToNo, "IX_sms_to_no");

            entity.Property(e => e.IdSms).HasColumnName("id_sms");
            entity.Property(e => e.Computer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("computer");
            entity.Property(e => e.Descrip)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("descrip");
            entity.Property(e => e.Errorcode).HasColumnName("errorcode");
            entity.Property(e => e.Expireday)
                .HasDefaultValue((byte)5)
                .HasColumnName("expireday");
            entity.Property(e => e.FromNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("from_no");
            entity.Property(e => e.IdSmsmdl).HasColumnName("id_smsmdl");
            entity.Property(e => e.IdWs)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("id_ws");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("indt_ti");
            entity.Property(e => e.Sent).HasColumnName("sent");
            entity.Property(e => e.SentDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sent_da");
            entity.Property(e => e.SentTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("sent_ti");
            entity.Property(e => e.ToNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("to_no");
            entity.Property(e => e.WsType).HasColumnName("ws_type");

            entity.HasOne(d => d.IdSmsmdlNavigation).WithMany(p => p.Sms)
                .HasForeignKey(d => d.IdSmsmdl)
                .HasConstraintName("FK_sms_smsmodule");
        });

        modelBuilder.Entity<Smsmodule>(entity =>
        {
            entity.HasKey(e => e.IdSmsmdl).HasName("PK_smsmodule_1");

            entity.ToTable("smsmodule");

            entity.Property(e => e.IdSmsmdl).HasColumnName("id_smsmdl");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.IdSmTyp).HasColumnName("id_sm_typ");
            entity.Property(e => e.Max)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("max");
            entity.Property(e => e.Min)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("min");
            entity.Property(e => e.No)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("no");
            entity.Property(e => e.Time)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("time");

            entity.HasOne(d => d.IdSmTypNavigation).WithMany(p => p.Smsmodules)
                .HasForeignKey(d => d.IdSmTyp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_smsmodule_smsmoduletype");
        });

        modelBuilder.Entity<Smsmoduleno>(entity =>
        {
            entity.HasKey(e => e.IdSmNo).HasName("PK_smsmoduleNo");

            entity.ToTable("smsmoduleno");

            entity.HasIndex(e => e.IdSmsmdl, "IX_smsmoduleno_id_smsmdl");

            entity.Property(e => e.IdSmNo).HasColumnName("id_sm_no");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.IdSmsmdl).HasColumnName("id_smsmdl");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("mobileno");

            entity.HasOne(d => d.IdSmsmdlNavigation).WithMany(p => p.Smsmodulenos)
                .HasForeignKey(d => d.IdSmsmdl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_smsmoduleNo_smsmodule");
        });

        modelBuilder.Entity<Smsmoduletype>(entity =>
        {
            entity.HasKey(e => e.IdSmTyp).HasName("PK_smsModule");

            entity.ToTable("smsmoduletype");

            entity.Property(e => e.IdSmTyp)
                .ValueGeneratedNever()
                .HasColumnName("id_sm_typ");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Alwayschk).HasColumnName("alwayschk");
            entity.Property(e => e.Expire)
                .HasDefaultValue((byte)1)
                .HasColumnName("expire");
            entity.Property(e => e.Group).HasColumnName("group");
            entity.Property(e => e.Hmax).HasColumnName("hmax");
            entity.Property(e => e.Hmin).HasColumnName("hmin");
            entity.Property(e => e.Hmobileno).HasColumnName("hmobileno");
            entity.Property(e => e.Hno).HasColumnName("hno");
            entity.Property(e => e.Htime).HasColumnName("htime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Nodescrip)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("nodescrip");
            entity.Property(e => e.Tartib)
                .HasDefaultValue((short)1)
                .HasColumnName("tartib");
        });

        modelBuilder.Entity<Sqlprocess>(entity =>
        {
            entity.HasKey(e => e.Spid).HasName("PK_sqlprocess");

            entity.ToTable("sqlprocesses");

            entity.Property(e => e.Spid)
                .ValueGeneratedNever()
                .HasColumnName("spid");
            entity.Property(e => e.Comment)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.Exitcomm)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("exitcomm");
            entity.Property(e => e.Exitcommsh).HasColumnName("exitcommsh");
            entity.Property(e => e.Exittime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("exittime");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.IdTbl).HasName("PK_tables_1");

            entity.ToTable("tables");

            entity.HasIndex(e => e.Name, "IX_U_tables_name").IsUnique();

            entity.Property(e => e.IdTbl)
                .ValueGeneratedNever()
                .HasColumnName("id_tbl");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Tanzimclient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tanzimclients", tb =>
                {
                    tb.HasTrigger("tanzimclients_delete_after");
                    tb.HasTrigger("tanzimclients_insert_after");
                    tb.HasTrigger("tanzimclients_update_after");
                });

            entity.HasIndex(e => new { e.IdClt, e.IdCltgrp, e.Id }, "IX_U_tanzimclients_id_clt_id_cltgrp_id")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.C1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c1");
            entity.Property(e => e.C2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c2");
            entity.Property(e => e.C3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c3");
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.IdClt).HasColumnName("id_clt");
            entity.Property(e => e.IdCltgrp).HasColumnName("id_cltgrp");

            entity.HasOne(d => d.IdNavigation).WithMany()
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tanzimclients_tanzimclients_");

            entity.HasOne(d => d.IdCltNavigation).WithMany()
                .HasForeignKey(d => d.IdClt)
                .HasConstraintName("FK_tanzimclients_clients");

            entity.HasOne(d => d.IdCltgrpNavigation).WithMany()
                .HasForeignKey(d => d.IdCltgrp)
                .HasConstraintName("FK_tanzimclients_clientsgroup");
        });

        modelBuilder.Entity<Tanzimclient1>(entity =>
        {
            entity.ToTable("tanzimclients_", tb =>
                {
                    tb.HasTrigger("tanzimclients__delete_after");
                    tb.HasTrigger("tanzimclients__insert_after");
                    tb.HasTrigger("tanzimclients__update_after");
                });

            entity.HasIndex(e => e.Tanzim, "IX_tanzimclients__tanzim");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.C1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c1");
            entity.Property(e => e.C2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c2");
            entity.Property(e => e.C3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c3");
            entity.Property(e => e.Tanzim)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tanzim");
        });

        modelBuilder.Entity<Tanzimtotal>(entity =>
        {
            entity.HasKey(e => e.Tanzim).IsClustered(false);

            entity.ToTable("tanzimtotal", tb =>
                {
                    tb.HasTrigger("tanzimtotal_delete_after");
                    tb.HasTrigger("tanzimtotal_insert_after");
                    tb.HasTrigger("tanzimtotal_update_after");
                    tb.HasTrigger("tanzimtotal_update_updated_at");
                });

            entity.HasIndex(e => e.Tanzim, "IX_tanzimtotal_tanzim").IsClustered();

            entity.HasIndex(e => e.UpdatedAt, "IX_tanzimtotal_updated_at");

            entity.Property(e => e.Tanzim)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tanzim");
            entity.Property(e => e.C1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c1");
            entity.Property(e => e.C2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c2");
            entity.Property(e => e.C3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c3");
            entity.Property(e => e.DefaultC1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("default_c1");
            entity.Property(e => e.DefaultC2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("default_c2");
            entity.Property(e => e.DefaultC3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("default_c3");
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Tanzimuser>(entity =>
        {
            entity.HasKey(e => new { e.IdUser, e.Id }).IsClustered(false);

            entity.ToTable("tanzimusers", tb =>
                {
                    tb.HasTrigger("tanzimusers_delete_after");
                    tb.HasTrigger("tanzimusers_insert_after");
                    tb.HasTrigger("tanzimusers_update_after");
                    tb.HasTrigger("tanzimusers_update_updated_at");
                });

            entity.HasIndex(e => new { e.IdUser, e.Id }, "ClusteredIndex-20180718-124841").IsClustered();

            entity.HasIndex(e => e.UpdatedAt, "tanzimusers_updated_at");

            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.C1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c1");
            entity.Property(e => e.C2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c2");
            entity.Property(e => e.C3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c3");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.Tanzimusers)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tanzim1__tanzim1");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Tanzimusers)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tanzim1__users");
        });

        modelBuilder.Entity<Tanzimuser1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tanzim1");

            entity.ToTable("tanzimusers_", tb =>
                {
                    tb.HasTrigger("tanzimusers__delete_after");
                    tb.HasTrigger("tanzimusers__insert_after");
                    tb.HasTrigger("tanzimusers__update_after");
                });

            entity.HasIndex(e => e.Tanzim, "IX_tanzimusers__tanzim");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.C1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c1");
            entity.Property(e => e.C2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c2");
            entity.Property(e => e.C3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c3");
            entity.Property(e => e.Tanzim)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tanzim");
        });

        modelBuilder.Entity<Tatilat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tatilat");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date");
        });

        modelBuilder.Entity<Undo>(entity =>
        {
            entity.HasKey(e => e.IdUndo);

            entity.ToTable("undo");

            entity.Property(e => e.IdUndo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("id_undo");
            entity.Property(e => e.C1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c1");
            entity.Property(e => e.C10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c10");
            entity.Property(e => e.C2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c2");
            entity.Property(e => e.C3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c3");
            entity.Property(e => e.C4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c4");
            entity.Property(e => e.C5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c5");
            entity.Property(e => e.C6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c6");
            entity.Property(e => e.C7)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c7");
            entity.Property(e => e.C8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c8");
            entity.Property(e => e.C9)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("c9");
            entity.Property(e => e.Memo1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("memo1");
            entity.Property(e => e.Memo10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("memo10");
            entity.Property(e => e.Memo2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("memo2");
            entity.Property(e => e.Memo3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("memo3");
            entity.Property(e => e.Memo4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("memo4");
            entity.Property(e => e.Memo5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("memo5");
            entity.Property(e => e.Memo6)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("memo6");
            entity.Property(e => e.Memo7)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("memo7");
            entity.Property(e => e.Memo8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("memo8");
            entity.Property(e => e.Memo9)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("memo9");
            entity.Property(e => e.N1)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("n1");
            entity.Property(e => e.N2)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("n2");
            entity.Property(e => e.N3)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("n3");
            entity.Property(e => e.Subject)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("subject");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users", tb =>
                {
                    tb.HasTrigger("users_delete_after");
                    tb.HasTrigger("users_insert_after");
                    tb.HasTrigger("users_update_after");
                    tb.HasTrigger("users_update_updated_at");
                });

            entity.HasIndex(e => e.UpdatedAt, "IX_users_updated_at");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Code)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("code");
            entity.Property(e => e.Comment)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.Karbar)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("karbar");
            entity.Property(e => e.Karbarname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("karbarname");
            entity.Property(e => e.Melino)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("melino");
            entity.Property(e => e.Melino1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("melino_");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mobileno");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("name");
            entity.Property(e => e.Passchk1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("passchk1");
            entity.Property(e => e.Passchk2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("passchk2");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("password");
            entity.Property(e => e.Sex)
                .HasDefaultValue((byte)1)
                .HasColumnName("sex");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Usersgrp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("usersgrp", tb =>
                {
                    tb.HasTrigger("usersgrp_delete_after");
                    tb.HasTrigger("usersgrp_insert_after");
                    tb.HasTrigger("usersgrp_update_after");
                    tb.HasTrigger("usersgrp_update_updated_at");
                });

            entity.HasIndex(e => new { e.IdGrp, e.IdUser }, "ClusteredIndex-20180717-092043").IsClustered();

            entity.HasIndex(e => new { e.IdGrp, e.IdUser }, "IX_usersgroup").IsUnique();

            entity.HasIndex(e => e.UpdatedAt, "usersgrp_updated_at");

            entity.Property(e => e.IdGrp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_grp");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.IdGrpNavigation).WithMany()
                .HasForeignKey(d => d.IdGrp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_usersgroup_users1");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_usersgroup_users");
        });

        modelBuilder.Entity<Userwork>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("userwork");

            entity.Property(e => e.Comment)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comment");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("date");
            entity.Property(e => e.Hostname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("hostname");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("id_user");
            entity.Property(e => e.Sys).HasColumnName("sys");
            entity.Property(e => e.Time)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("time");
            entity.Property(e => e.Work)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("work");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_userwork_users");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("version");

            entity.Property(e => e.Bim1Sess)
                .HasDefaultValue("")
                .HasColumnName("bim1_sess");
            entity.Property(e => e.Bim1Token)
                .HasDefaultValue("")
                .HasColumnName("bim1_token");
            entity.Property(e => e.Updatespid).HasColumnName("updatespid");
            entity.Property(e => e.VersionD)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("version_d");
            entity.Property(e => e.VersionT)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("version_t");
        });

        modelBuilder.Entity<Vwclientsconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWclientsconfig");

            entity.Property(e => e.C1)
                .IsUnicode(false)
                .HasColumnName("c1");
            entity.Property(e => e.C1Type)
                .IsUnicode(false)
                .HasColumnName("c1_type");
            entity.Property(e => e.C2)
                .IsUnicode(false)
                .HasColumnName("c2");
            entity.Property(e => e.C2Type)
                .IsUnicode(false)
                .HasColumnName("c2_type");
            entity.Property(e => e.C3)
                .IsUnicode(false)
                .HasColumnName("c3");
            entity.Property(e => e.C3Type)
                .IsUnicode(false)
                .HasColumnName("c3_type");
            entity.Property(e => e.Config)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("config");
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.IdClt).HasColumnName("id_clt");
            entity.Property(e => e.IdCltgrp).HasColumnName("id_cltgrp");
            entity.Property(e => e.Source)
                .HasMaxLength(21)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vwsebeton>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWsebeton");

            entity.Property(e => e.Afz1Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("afz1_code");
            entity.Property(e => e.Afz1Karkh)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("afz1_karkh");
            entity.Property(e => e.Afz1Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("afz1_name");
            entity.Property(e => e.Afz1Vazn)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("afz1_vazn");
            entity.Property(e => e.Afz2Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("afz2_code");
            entity.Property(e => e.Afz2Karkh)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("afz2_karkh");
            entity.Property(e => e.Afz2Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("afz2_name");
            entity.Property(e => e.Afz2Vazn)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("afz2_vazn");
            entity.Property(e => e.BchHsbd).HasColumnName("bch_hsbd");
            entity.Property(e => e.BchName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("bch_name");
            entity.Property(e => e.BetonNo).HasColumnName("beton_no");
            entity.Property(e => e.BtnAyar).HasColumnName("btn_ayar");
            entity.Property(e => e.BtnFi)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("btn_fi");
            entity.Property(e => e.BtnHsb).HasColumnName("btn_hsb");
            entity.Property(e => e.BtnHsbd).HasColumnName("btn_hsbd");
            entity.Property(e => e.BtnKharid).HasColumnName("btn_kharid");
            entity.Property(e => e.BtnMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("btn_meter");
            entity.Property(e => e.BtnName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("btn_name");
            entity.Property(e => e.BtnSefar)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("btn_sefar");
            entity.Property(e => e.BzrHsb).HasColumnName("bzr_hsb");
            entity.Property(e => e.BzrHsbd).HasColumnName("bzr_hsbd");
            entity.Property(e => e.BzrMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("bzr_mab");
            entity.Property(e => e.Cancel).HasColumnName("cancel");
            entity.Property(e => e.Comment)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.CtmCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ctm_code");
            entity.Property(e => e.CtmHsb).HasColumnName("ctm_hsb");
            entity.Property(e => e.CtmHsbd).HasColumnName("ctm_hsbd");
            entity.Property(e => e.CtmName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ctm_name");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("date");
            entity.Property(e => e.Datetahvil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("datetahvil");
            entity.Property(e => e.DrvName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("drv_name");
            entity.Property(e => e.Eskelet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("eskelet");
            entity.Property(e => e.Eslamp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("eslamp");
            entity.Property(e => e.FullMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("full_meter");
            entity.Property(e => e.IdBeton).HasColumnName("id_beton");
            entity.Property(e => e.IdBranch).HasColumnName("id_branch");
            entity.Property(e => e.IdBrngrp).HasColumnName("id_brngrp");
            entity.Property(e => e.IdForm).HasColumnName("id_form");
            entity.Property(e => e.IdPeriod).HasColumnName("id_period");
            entity.Property(e => e.IdSms).HasColumnName("id_sms");
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
            entity.Property(e => e.KharidNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kharid_no");
            entity.Property(e => e.Kharidtype).HasColumnName("kharidtype");
            entity.Property(e => e.KhrComp).HasColumnName("khr_comp");
            entity.Property(e => e.KhrFi).HasColumnName("khr_fi");
            entity.Property(e => e.KhrHsb).HasColumnName("khr_hsb");
            entity.Property(e => e.KhrHsbd).HasColumnName("khr_hsbd");
            entity.Property(e => e.KhrMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("khr_meter");
            entity.Property(e => e.KraDesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("kra_desc");
            entity.Property(e => e.KraMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kra_mab");
            entity.Property(e => e.KrnHsb).HasColumnName("krn_hsb");
            entity.Property(e => e.KrnHsbd).HasColumnName("krn_hsbd");
            entity.Property(e => e.KrnMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("krn_mab");
            entity.Property(e => e.KrnctmMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("krnctm_mab");
            entity.Property(e => e.KrndarMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("krndar_mab");
            entity.Property(e => e.KrnzarMab).HasColumnName("krnzar_mab");
            entity.Property(e => e.KrtFi).HasColumnName("krt_fi");
            entity.Property(e => e.KrtMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("krt_mab");
            entity.Property(e => e.KrtMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("krt_meter");
            entity.Property(e => e.KrtMode).HasColumnName("krt_mode");
            entity.Property(e => e.KryFi).HasColumnName("kry_fi");
            entity.Property(e => e.KryMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kry_mab");
            entity.Property(e => e.KryMabtot)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("kry_mabtot");
            entity.Property(e => e.Looleh)
                .HasColumnType("numeric(10, 1)")
                .HasColumnName("looleh");
            entity.Property(e => e.Maghsad)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("maghsad");
            entity.Property(e => e.Manualend).HasColumnName("manualend");
            entity.Property(e => e.MasehAnb).HasColumnName("maseh_anb");
            entity.Property(e => e.MasehM)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("maseh_m");
            entity.Property(e => e.MasehV)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("maseh_v");
            entity.Property(e => e.MashinNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mashin_no");
            entity.Property(e => e.MasoolK)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("masool_k");
            entity.Property(e => e.MazMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("maz_meter");
            entity.Property(e => e.MixCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("mix_code");
            entity.Property(e => e.MixHsb).HasColumnName("mix_hsb");
            entity.Property(e => e.MixHsbd).HasColumnName("mix_hsbd");
            entity.Property(e => e.MixName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("mix_name");
            entity.Property(e => e.MixbesFi).HasColumnName("mixbes_fi");
            entity.Property(e => e.MixbesFul)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("mixbes_ful");
            entity.Property(e => e.MixbesKra)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mixbes_kra");
            entity.Property(e => e.MixbesKrt).HasColumnName("mixbes_krt");
            entity.Property(e => e.MixbesKtf).HasColumnName("mixbes_ktf");
            entity.Property(e => e.MixbesKtm)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mixbes_ktm");
            entity.Property(e => e.MixbesKtt)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("mixbes_ktt");
            entity.Property(e => e.MixbesMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mixbes_mab");
            entity.Property(e => e.MixbesMbt)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mixbes_mbt");
            entity.Property(e => e.MixbesTyp).HasColumnName("mixbes_typ");
            entity.Property(e => e.MntHsbd).HasColumnName("mnt_hsbd");
            entity.Property(e => e.MntName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("mnt_name");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("mobileno");
            entity.Property(e => e.MogHsbd).HasColumnName("mog_hsbd");
            entity.Property(e => e.Mogheiat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mogheiat");
            entity.Property(e => e.MsfHsbd).HasColumnName("msf_hsbd");
            entity.Property(e => e.NaMog)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("na_mog");
            entity.Property(e => e.NaMsf)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("na_msf");
            entity.Property(e => e.NaSmn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("na_smn");
            entity.Property(e => e.NaTkt)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("na_tkt");
            entity.Property(e => e.Naghes).HasColumnName("naghes");
            entity.Property(e => e.NewEdit).HasColumnName("new_edit");
            entity.Property(e => e.OrdMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("ord_meter");
            entity.Property(e => e.PmpbesFi).HasColumnName("pmpbes_fi");
            entity.Property(e => e.PmpbesMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("pmpbes_mab");
            entity.Property(e => e.PmpbesMin)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("pmpbes_min");
            entity.Property(e => e.PmpbesTka)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("pmpbes_tka");
            entity.Property(e => e.PmpbesTkf).HasColumnName("pmpbes_tkf");
            entity.Property(e => e.PmpbesTkm).HasColumnName("pmpbes_tkm");
            entity.Property(e => e.PmpbesTyp).HasColumnName("pmpbes_typ");
            entity.Property(e => e.Sendsms).HasColumnName("sendsms");
            entity.Property(e => e.ShenAnb).HasColumnName("shen_anb");
            entity.Property(e => e.ShenM)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("shen_m");
            entity.Property(e => e.ShenV)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("shen_v");
            entity.Property(e => e.ShiftNo).HasColumnName("shift_no");
            entity.Property(e => e.SimanAnb).HasColumnName("siman_anb");
            entity.Property(e => e.SimanM)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("siman_m");
            entity.Property(e => e.SimanV)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("siman_v");
            entity.Property(e => e.SmnHsbd).HasColumnName("smn_hsbd");
            entity.Property(e => e.TahvilG)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tahvil_g");
            entity.Property(e => e.TempBeton)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("temp_beton");
            entity.Property(e => e.TempMohit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("temp_mohit");
            entity.Property(e => e.TempWater)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("temp_water");
            entity.Property(e => e.Time)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("time");
            entity.Property(e => e.TkaDesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("tka_desc");
            entity.Property(e => e.TkaMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tka_mab");
            entity.Property(e => e.TkhCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tkh_code");
            entity.Property(e => e.TkhDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tkh_desc");
            entity.Property(e => e.TkhFi).HasColumnName("tkh_fi");
            entity.Property(e => e.TkhHsb).HasColumnName("tkh_hsb");
            entity.Property(e => e.TkhHsbd).HasColumnName("tkh_hsbd");
            entity.Property(e => e.TkhMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tkh_mab");
            entity.Property(e => e.TkhMeter)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("tkh_meter");
            entity.Property(e => e.TkhMin)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("tkh_min");
            entity.Property(e => e.TkhName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tkh_name");
            entity.Property(e => e.TkmCalc).HasColumnName("tkm_calc");
            entity.Property(e => e.TkmFi).HasColumnName("tkm_fi");
            entity.Property(e => e.TknHsb).HasColumnName("tkn_hsb");
            entity.Property(e => e.TknHsbd).HasColumnName("tkn_hsbd");
            entity.Property(e => e.TknMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tkn_mab");
            entity.Property(e => e.TknctmMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tknctm_mab");
            entity.Property(e => e.TkndarMab)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("tkndar_mab");
            entity.Property(e => e.TktHsbd).HasColumnName("tkt_hsbd");
            entity.Property(e => e.Vazn)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn");
            entity.Property(e => e.Vazn1)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn1");
            entity.Property(e => e.Vazn1Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vazn1_date");
            entity.Property(e => e.Vazn1Row).HasColumnName("vazn1_row");
            entity.Property(e => e.Vazn1Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("vazn1_time");
            entity.Property(e => e.Vazn2)
                .HasColumnType("decimal(15, 3)")
                .HasColumnName("vazn2");
            entity.Property(e => e.Vazn2Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vazn2_date");
            entity.Property(e => e.Vazn2Row).HasColumnName("vazn2_row");
            entity.Property(e => e.Vazn2Time)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("vazn2_time");
            entity.Property(e => e.VaznMakh)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("vazn_makh");
            entity.Property(e => e.VaznpkPrn).HasColumnName("vaznpk_prn");
            entity.Property(e => e.WaterV)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("water_v");
        });

        modelBuilder.Entity<Vwsebetonctmlastdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWsebetonctmlastdate");

            entity.Property(e => e.CtmHsb).HasColumnName("ctm_hsb");
            entity.Property(e => e.CtmHsbd).HasColumnName("ctm_hsbd");
            entity.Property(e => e.CtmName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ctm_name");
            entity.Property(e => e.Lastdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("lastdate");
        });

        modelBuilder.Entity<Vwsefactorsanadrel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWsefactorsanadrel");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("date");
            entity.Property(e => e.Datecash)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datecash");
            entity.Property(e => e.IdFactor).HasColumnName("id_factor");
            entity.Property(e => e.IdFctrel).HasColumnName("id_fctrel");
            entity.Property(e => e.IdRow).HasColumnName("id_row");
            entity.Property(e => e.IdSanad).HasColumnName("id_sanad");
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
            entity.Property(e => e.MabSanad)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mab_sanad");
            entity.Property(e => e.Mablagh)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("mablagh");
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

            entity.HasOne(d => d.IdBankNavigation).WithMany()
                .HasForeignKey(d => d.IdBank)
                .HasConstraintName("FK_vwsehesab_sebank");

            entity.HasOne(d => d.IdBnkhtypNavigation).WithMany()
                .HasForeignKey(d => d.IdBnkhtyp)
                .HasConstraintName("FK_vwsehesab_sebankhesabtype");

            entity.HasOne(d => d.IdCtmtitNavigation).WithMany()
                .HasForeignKey(d => d.IdCtmtit)
                .HasConstraintName("FK_vwsehesab_secustomertitles");

            entity.HasOne(d => d.IdCtmtypNavigation).WithMany()
                .HasForeignKey(d => d.IdCtmtyp)
                .HasConstraintName("FK_vwsehesab_persontype");

            entity.HasOne(d => d.IdHsbNavigation).WithMany()
                .HasForeignKey(d => d.IdHsb)
                .HasConstraintName("FK_vwsehesab_sehesab");

            entity.HasOne(d => d.IdHsbdtlNavigation).WithMany()
                .HasForeignKey(d => d.IdHsbdtl)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_vwsehesab_sehesabgroupdetail");

            entity.HasOne(d => d.IdHsbgrpNavigation).WithMany()
                .HasForeignKey(d => d.IdHsbgrp)
                .HasConstraintName("FK_vwsehesab_sehesabgroup");

            entity.HasOne(d => d.IdKalagrpNavigation).WithMany()
                .HasForeignKey(d => d.IdKalagrp)
                .HasConstraintName("FK_vwsehesab_sekalagroup");

            entity.HasOne(d => d.IdSexNavigation).WithMany()
                .HasForeignKey(d => d.IdSex)
                .HasConstraintName("FK_vwsehesab_sex");

            entity.HasOne(d => d.IdUnitNavigation).WithMany()
                .HasForeignKey(d => d.IdUnit)
                .HasConstraintName("FK_vwsehesab_seunit");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_vwsehesab_users");
        });

        modelBuilder.Entity<Vwsehesabmarkaz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vwsehesabmarkaz");

            entity.Property(e => e.CodesMkz)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("codes_mkz");
            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.IdMkzd1).HasColumnName("id_mkzd1");
            entity.Property(e => e.IdMkzd10).HasColumnName("id_mkzd10");
            entity.Property(e => e.IdMkzd11).HasColumnName("id_mkzd11");
            entity.Property(e => e.IdMkzd12).HasColumnName("id_mkzd12");
            entity.Property(e => e.IdMkzd13).HasColumnName("id_mkzd13");
            entity.Property(e => e.IdMkzd14).HasColumnName("id_mkzd14");
            entity.Property(e => e.IdMkzd15).HasColumnName("id_mkzd15");
            entity.Property(e => e.IdMkzd16).HasColumnName("id_mkzd16");
            entity.Property(e => e.IdMkzd17).HasColumnName("id_mkzd17");
            entity.Property(e => e.IdMkzd18).HasColumnName("id_mkzd18");
            entity.Property(e => e.IdMkzd19).HasColumnName("id_mkzd19");
            entity.Property(e => e.IdMkzd2).HasColumnName("id_mkzd2");
            entity.Property(e => e.IdMkzd20).HasColumnName("id_mkzd20");
            entity.Property(e => e.IdMkzd3).HasColumnName("id_mkzd3");
            entity.Property(e => e.IdMkzd4).HasColumnName("id_mkzd4");
            entity.Property(e => e.IdMkzd5).HasColumnName("id_mkzd5");
            entity.Property(e => e.IdMkzd6).HasColumnName("id_mkzd6");
            entity.Property(e => e.IdMkzd7).HasColumnName("id_mkzd7");
            entity.Property(e => e.IdMkzd8).HasColumnName("id_mkzd8");
            entity.Property(e => e.IdMkzd9).HasColumnName("id_mkzd9");
            entity.Property(e => e.IdsMkz)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("ids_mkz");
            entity.Property(e => e.NaMkzd1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd1");
            entity.Property(e => e.NaMkzd10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd10");
            entity.Property(e => e.NaMkzd11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd11");
            entity.Property(e => e.NaMkzd12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd12");
            entity.Property(e => e.NaMkzd13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd13");
            entity.Property(e => e.NaMkzd14)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd14");
            entity.Property(e => e.NaMkzd15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd15");
            entity.Property(e => e.NaMkzd16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd16");
            entity.Property(e => e.NaMkzd17)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd17");
            entity.Property(e => e.NaMkzd18)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd18");
            entity.Property(e => e.NaMkzd19)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd19");
            entity.Property(e => e.NaMkzd2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd2");
            entity.Property(e => e.NaMkzd20)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd20");
            entity.Property(e => e.NaMkzd3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd3");
            entity.Property(e => e.NaMkzd4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd4");
            entity.Property(e => e.NaMkzd5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd5");
            entity.Property(e => e.NaMkzd6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd6");
            entity.Property(e => e.NaMkzd7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd7");
            entity.Property(e => e.NaMkzd8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd8");
            entity.Property(e => e.NaMkzd9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkzd9");
            entity.Property(e => e.NameMkz)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("name_mkz");

            entity.HasOne(d => d.IdHsbNavigation).WithMany()
                .HasForeignKey(d => d.IdHsb)
                .HasConstraintName("FK_vwsehesabmarkaz_sehesab");

            entity.HasOne(d => d.IdMkzd1Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd1)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_1");

            entity.HasOne(d => d.IdMkzd10Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd10)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_10");

            entity.HasOne(d => d.IdMkzd11Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd11)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_11");

            entity.HasOne(d => d.IdMkzd12Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd12)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_12");

            entity.HasOne(d => d.IdMkzd13Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd13)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_13");

            entity.HasOne(d => d.IdMkzd14Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd14)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_14");

            entity.HasOne(d => d.IdMkzd15Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd15)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_15");

            entity.HasOne(d => d.IdMkzd16Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd16)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_16");

            entity.HasOne(d => d.IdMkzd17Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd17)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_17");

            entity.HasOne(d => d.IdMkzd18Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd18)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_18");

            entity.HasOne(d => d.IdMkzd19Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd19)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_19");

            entity.HasOne(d => d.IdMkzd2Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd2)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_2");

            entity.HasOne(d => d.IdMkzd20Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd20)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_20");

            entity.HasOne(d => d.IdMkzd3Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd3)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_3");

            entity.HasOne(d => d.IdMkzd4Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd4)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_4");

            entity.HasOne(d => d.IdMkzd5Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd5)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_5");

            entity.HasOne(d => d.IdMkzd6Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd6)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_6");

            entity.HasOne(d => d.IdMkzd7Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd7)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_7");

            entity.HasOne(d => d.IdMkzd8Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd8)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_8");

            entity.HasOne(d => d.IdMkzd9Navigation).WithMany()
                .HasForeignKey(d => d.IdMkzd9)
                .HasConstraintName("FK_vwsehesabmarkaz_semarkazdetail_9");
        });

        modelBuilder.Entity<Vwsehesabmarkazdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWsehesabmarkazdetail");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Ashar).HasColumnName("ashar");
            entity.Property(e => e.Birthdate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("birthdate");
            entity.Property(e => e.Birthshahr)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("birthshahr");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Codelength).HasColumnName("codelength");
            entity.Property(e => e.Comment)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.Credit)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("credit");
            entity.Property(e => e.Father)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("father");
            entity.Property(e => e.Fieldnum).HasColumnName("fieldnum");
            entity.Property(e => e.Hesabno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hesabno");
            entity.Property(e => e.IdActive).HasColumnName("id_active");
            entity.Property(e => e.IdBank).HasColumnName("id_bank");
            entity.Property(e => e.IdBnkhtyp).HasColumnName("id_bnkhtyp");
            entity.Property(e => e.IdCtmtit).HasColumnName("id_ctmtit");
            entity.Property(e => e.IdCtmtyp).HasColumnName("id_ctmtyp");
            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.IdMkz).HasColumnName("id_mkz");
            entity.Property(e => e.IdMkzdtl).HasColumnName("id_mkzdtl");
            entity.Property(e => e.IdMkztyp).HasColumnName("id_mkztyp");
            entity.Property(e => e.IdSex).HasColumnName("id_sex");
            entity.Property(e => e.IndtDa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("indt_da");
            entity.Property(e => e.IndtTi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("indt_ti");
            entity.Property(e => e.Melino)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("melino");
            entity.Property(e => e.NaMkz)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("na_mkz");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.ParMkzdtl).HasColumnName("par_mkzdtl");
            entity.Property(e => e.Para1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para1");
            entity.Property(e => e.Para10)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para10");
            entity.Property(e => e.Para11)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para11");
            entity.Property(e => e.Para12)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para12");
            entity.Property(e => e.Para13)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para13");
            entity.Property(e => e.Para14)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para14");
            entity.Property(e => e.Para15)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para15");
            entity.Property(e => e.Para16)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para16");
            entity.Property(e => e.Para17)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para17");
            entity.Property(e => e.Para18)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para18");
            entity.Property(e => e.Para19)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para19");
            entity.Property(e => e.Para2)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para2");
            entity.Property(e => e.Para20)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para20");
            entity.Property(e => e.Para21)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para21");
            entity.Property(e => e.Para22)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para22");
            entity.Property(e => e.Para23)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para23");
            entity.Property(e => e.Para24)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para24");
            entity.Property(e => e.Para25)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para25");
            entity.Property(e => e.Para26)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para26");
            entity.Property(e => e.Para27)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para27");
            entity.Property(e => e.Para28)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para28");
            entity.Property(e => e.Para29)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para29");
            entity.Property(e => e.Para3)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para3");
            entity.Property(e => e.Para30)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para30");
            entity.Property(e => e.Para31)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para31");
            entity.Property(e => e.Para32)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para32");
            entity.Property(e => e.Para33)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para33");
            entity.Property(e => e.Para34)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para34");
            entity.Property(e => e.Para35)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para35");
            entity.Property(e => e.Para36)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para36");
            entity.Property(e => e.Para37)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para37");
            entity.Property(e => e.Para38)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para38");
            entity.Property(e => e.Para39)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para39");
            entity.Property(e => e.Para4)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para4");
            entity.Property(e => e.Para40)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para40");
            entity.Property(e => e.Para41)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para41");
            entity.Property(e => e.Para42)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para42");
            entity.Property(e => e.Para43)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para43");
            entity.Property(e => e.Para44)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para44");
            entity.Property(e => e.Para45)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para45");
            entity.Property(e => e.Para46)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para46");
            entity.Property(e => e.Para47)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para47");
            entity.Property(e => e.Para48)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para48");
            entity.Property(e => e.Para49)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para49");
            entity.Property(e => e.Para5)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para5");
            entity.Property(e => e.Para50)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para50");
            entity.Property(e => e.Para6)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para6");
            entity.Property(e => e.Para7)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para7");
            entity.Property(e => e.Para8)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para8");
            entity.Property(e => e.Para9)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("para9");
            entity.Property(e => e.Shanasno)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("shanasno");
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
            entity.Property(e => e.Tartib).HasColumnName("tartib");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Zamantype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("zamantype");
        });

        modelBuilder.Entity<Vwsehesabparameter>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWsehesabparameters");

            entity.Property(e => e.IdHpar1).HasColumnName("id_hpar1");
            entity.Property(e => e.IdHpar10).HasColumnName("id_hpar10");
            entity.Property(e => e.IdHpar11).HasColumnName("id_hpar11");
            entity.Property(e => e.IdHpar12).HasColumnName("id_hpar12");
            entity.Property(e => e.IdHpar13).HasColumnName("id_hpar13");
            entity.Property(e => e.IdHpar14).HasColumnName("id_hpar14");
            entity.Property(e => e.IdHpar15).HasColumnName("id_hpar15");
            entity.Property(e => e.IdHpar16).HasColumnName("id_hpar16");
            entity.Property(e => e.IdHpar17).HasColumnName("id_hpar17");
            entity.Property(e => e.IdHpar18).HasColumnName("id_hpar18");
            entity.Property(e => e.IdHpar19).HasColumnName("id_hpar19");
            entity.Property(e => e.IdHpar2).HasColumnName("id_hpar2");
            entity.Property(e => e.IdHpar20).HasColumnName("id_hpar20");
            entity.Property(e => e.IdHpar21).HasColumnName("id_hpar21");
            entity.Property(e => e.IdHpar22).HasColumnName("id_hpar22");
            entity.Property(e => e.IdHpar23).HasColumnName("id_hpar23");
            entity.Property(e => e.IdHpar24).HasColumnName("id_hpar24");
            entity.Property(e => e.IdHpar25).HasColumnName("id_hpar25");
            entity.Property(e => e.IdHpar26).HasColumnName("id_hpar26");
            entity.Property(e => e.IdHpar27).HasColumnName("id_hpar27");
            entity.Property(e => e.IdHpar28).HasColumnName("id_hpar28");
            entity.Property(e => e.IdHpar29).HasColumnName("id_hpar29");
            entity.Property(e => e.IdHpar3).HasColumnName("id_hpar3");
            entity.Property(e => e.IdHpar30).HasColumnName("id_hpar30");
            entity.Property(e => e.IdHpar31).HasColumnName("id_hpar31");
            entity.Property(e => e.IdHpar32).HasColumnName("id_hpar32");
            entity.Property(e => e.IdHpar33).HasColumnName("id_hpar33");
            entity.Property(e => e.IdHpar34).HasColumnName("id_hpar34");
            entity.Property(e => e.IdHpar35).HasColumnName("id_hpar35");
            entity.Property(e => e.IdHpar36).HasColumnName("id_hpar36");
            entity.Property(e => e.IdHpar37).HasColumnName("id_hpar37");
            entity.Property(e => e.IdHpar38).HasColumnName("id_hpar38");
            entity.Property(e => e.IdHpar39).HasColumnName("id_hpar39");
            entity.Property(e => e.IdHpar4).HasColumnName("id_hpar4");
            entity.Property(e => e.IdHpar40).HasColumnName("id_hpar40");
            entity.Property(e => e.IdHpar41).HasColumnName("id_hpar41");
            entity.Property(e => e.IdHpar42).HasColumnName("id_hpar42");
            entity.Property(e => e.IdHpar43).HasColumnName("id_hpar43");
            entity.Property(e => e.IdHpar44).HasColumnName("id_hpar44");
            entity.Property(e => e.IdHpar45).HasColumnName("id_hpar45");
            entity.Property(e => e.IdHpar46).HasColumnName("id_hpar46");
            entity.Property(e => e.IdHpar47).HasColumnName("id_hpar47");
            entity.Property(e => e.IdHpar48).HasColumnName("id_hpar48");
            entity.Property(e => e.IdHpar49).HasColumnName("id_hpar49");
            entity.Property(e => e.IdHpar5).HasColumnName("id_hpar5");
            entity.Property(e => e.IdHpar50).HasColumnName("id_hpar50");
            entity.Property(e => e.IdHpar6).HasColumnName("id_hpar6");
            entity.Property(e => e.IdHpar7).HasColumnName("id_hpar7");
            entity.Property(e => e.IdHpar8).HasColumnName("id_hpar8");
            entity.Property(e => e.IdHpar9).HasColumnName("id_hpar9");
            entity.Property(e => e.IdHsb).HasColumnName("id_hsb");
            entity.Property(e => e.IdHsbdtl).HasColumnName("id_hsbdtl");
            entity.Property(e => e.VaHpar501)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar501");
            entity.Property(e => e.VaHpar502)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar502");
            entity.Property(e => e.VaHpar503)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar503");
            entity.Property(e => e.VaHpar504)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar504");
            entity.Property(e => e.VaHpar505)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar505");
            entity.Property(e => e.VaHpar506)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar506");
            entity.Property(e => e.VaHpar507)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar507");
            entity.Property(e => e.VaHpar508)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar508");
            entity.Property(e => e.VaHpar509)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar509");
            entity.Property(e => e.VaHpar510)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar510");
            entity.Property(e => e.VaHpar511)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar511");
            entity.Property(e => e.VaHpar512)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar512");
            entity.Property(e => e.VaHpar513)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar513");
            entity.Property(e => e.VaHpar514)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar514");
            entity.Property(e => e.VaHpar515)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar515");
            entity.Property(e => e.VaHpar516)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar516");
            entity.Property(e => e.VaHpar517)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar517");
            entity.Property(e => e.VaHpar518)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar518");
            entity.Property(e => e.VaHpar519)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar519");
            entity.Property(e => e.VaHpar520)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar520");
            entity.Property(e => e.VaHpar521)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar521");
            entity.Property(e => e.VaHpar522)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar522");
            entity.Property(e => e.VaHpar523)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar523");
            entity.Property(e => e.VaHpar524)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar524");
            entity.Property(e => e.VaHpar525)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar525");
            entity.Property(e => e.VaHpar526)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar526");
            entity.Property(e => e.VaHpar527)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar527");
            entity.Property(e => e.VaHpar528)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar528");
            entity.Property(e => e.VaHpar529)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar529");
            entity.Property(e => e.VaHpar530)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar530");
            entity.Property(e => e.VaHpar531)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar531");
            entity.Property(e => e.VaHpar532)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar532");
            entity.Property(e => e.VaHpar533)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar533");
            entity.Property(e => e.VaHpar534)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar534");
            entity.Property(e => e.VaHpar535)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar535");
            entity.Property(e => e.VaHpar536)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar536");
            entity.Property(e => e.VaHpar537)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar537");
            entity.Property(e => e.VaHpar538)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar538");
            entity.Property(e => e.VaHpar539)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar539");
            entity.Property(e => e.VaHpar540)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar540");
            entity.Property(e => e.VaHpar541)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar541");
            entity.Property(e => e.VaHpar542)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar542");
            entity.Property(e => e.VaHpar543)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar543");
            entity.Property(e => e.VaHpar544)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar544");
            entity.Property(e => e.VaHpar545)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar545");
            entity.Property(e => e.VaHpar546)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar546");
            entity.Property(e => e.VaHpar547)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar547");
            entity.Property(e => e.VaHpar548)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar548");
            entity.Property(e => e.VaHpar549)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar549");
            entity.Property(e => e.VaHpar550)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("va_hpar550");
        });

        modelBuilder.Entity<Vwsewsgetcustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWsewsgetcustomer");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Code).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Id)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Mobile)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.NationalNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false);
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

        modelBuilder.Entity<Vwtotalconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWtotalconfig");

            entity.Property(e => e.C1)
                .IsUnicode(false)
                .HasColumnName("c1");
            entity.Property(e => e.C1Type)
                .IsUnicode(false)
                .HasColumnName("c1_type");
            entity.Property(e => e.C2)
                .IsUnicode(false)
                .HasColumnName("c2");
            entity.Property(e => e.C2Type)
                .IsUnicode(false)
                .HasColumnName("c2_type");
            entity.Property(e => e.C3)
                .IsUnicode(false)
                .HasColumnName("c3");
            entity.Property(e => e.C3Type)
                .IsUnicode(false)
                .HasColumnName("c3_type");
            entity.Property(e => e.Config)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("config");
            entity.Property(e => e.DefaultC1)
                .IsUnicode(false)
                .HasColumnName("default_c1");
            entity.Property(e => e.DefaultC1Type)
                .IsUnicode(false)
                .HasColumnName("default_c1_type");
            entity.Property(e => e.DefaultC2)
                .IsUnicode(false)
                .HasColumnName("default_c2");
            entity.Property(e => e.DefaultC2Type)
                .IsUnicode(false)
                .HasColumnName("default_c2_type");
            entity.Property(e => e.DefaultC3)
                .IsUnicode(false)
                .HasColumnName("default_c3");
            entity.Property(e => e.DefaultC3Type)
                .IsUnicode(false)
                .HasColumnName("default_c3_type");
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Vwusersconfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VWusersconfig");

            entity.Property(e => e.C1)
                .IsUnicode(false)
                .HasColumnName("c1");
            entity.Property(e => e.C1Type)
                .IsUnicode(false)
                .HasColumnName("c1_type");
            entity.Property(e => e.C2)
                .IsUnicode(false)
                .HasColumnName("c2");
            entity.Property(e => e.C2Type)
                .IsUnicode(false)
                .HasColumnName("c2_type");
            entity.Property(e => e.C3)
                .IsUnicode(false)
                .HasColumnName("c3");
            entity.Property(e => e.C3Type)
                .IsUnicode(false)
                .HasColumnName("c3_type");
            entity.Property(e => e.Config)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("config");
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id_user");
            entity.Property(e => e.Source)
                .HasMaxLength(21)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

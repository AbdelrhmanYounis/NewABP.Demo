using Microsoft.EntityFrameworkCore;
using NewABP.Demo.Bands;
using NewABP.Demo.Common.Areas;
using NewABP.Demo.Common.Cities;
using NewABP.Demo.Common.Governorates;
using NewABP.Demo.Common.Grades;
using NewABP.Demo.Parks;
using NewABP.Demo.SurveyBands;
using NewABP.Demo.Surveys;
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

namespace NewABP.Demo.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class DemoDbContext :
    AbpDbContext<DemoDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{

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
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }
    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    #region Application's Entities 
    public DbSet<Park> Parks { get; set; }
    public DbSet<Area> Areas { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Governorate> Governorates { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Band> Bands { get; set; }
    public DbSet<SurveyBand> SurveyBands { get; set; }
    public DbSet<Survey> Surveys { get; set; }
    #endregion

    public DemoDbContext(DbContextOptions<DemoDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region ABP modules
        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();
        #endregion

        #region Application's Entities Configures
        
        builder.Entity<Grade>(b =>
        {
            b.ToTable("Grades", "Demo");
            b.Property(x => x.NameAr).HasMaxLength(50).IsRequired();
            b.Property(x => x.NameEn).HasMaxLength(50).IsRequired();
        });
        builder.Entity<Park>(b =>
        {
            b.ToTable("Parks", "Demo");
            b.Property(x=>x.NameAr).HasMaxLength(50).IsRequired();
            b.Property(x=>x.NameEn).HasMaxLength(50).IsRequired();
            b.HasOne(x=>x.Area).WithMany().HasForeignKey(x=>x.AreaId).IsRequired();
        });
        builder.Entity<Area>(b =>
        {
            b.ToTable("Areas", "Demo");
            b.Property(x => x.NameAr).HasMaxLength(50).IsRequired();
            b.Property(x => x.NameEn).HasMaxLength(50).IsRequired();
            b.HasOne(x => x.City).WithMany().HasForeignKey(x => x.CityId).IsRequired();
        });
        builder.Entity<City>(b =>
        {
            b.ToTable("Cities", "Demo");
            b.Property(x => x.NameAr).HasMaxLength(50).IsRequired();
            b.Property(x => x.NameEn).HasMaxLength(50).IsRequired();
            b.HasOne(x => x.Governorate).WithMany().HasForeignKey(x => x.GovernorateId).IsRequired();
        });
        builder.Entity<Governorate>(b =>
        {
            b.ToTable("Governorates", "Demo");
            b.Property(x => x.NameAr).HasMaxLength(50).IsRequired();
            b.Property(x => x.NameEn).HasMaxLength(50).IsRequired();
        });
        builder.Entity<Band>(b =>
        {
            b.ToTable("Bands", "Demo");
            b.Property(x => x.NameAr).HasMaxLength(100).IsRequired();
            b.Property(x => x.NameEn).HasMaxLength(100).IsRequired();
        });
        builder.Entity<SurveyBand>(b =>
        {
            b.ToTable("SurveyBands", "Demo");
            b.HasKey(x=>new { x.SurveyId ,x.BandId});
            b.HasOne(x => x.Survey).WithMany().HasForeignKey(x => x.SurveyId).IsRequired();
            b.HasOne(x => x.Band).WithMany().HasForeignKey(x => x.BandId).IsRequired();
            b.HasOne(x => x.Grade).WithMany().HasForeignKey(x => x.GradeId).IsRequired();
        });
        builder.Entity<Survey>(b =>
        {
            b.ToTable("Surveys","Demo");
            b.HasOne(x => x.Park).WithMany().HasForeignKey(x => x.ParkId).IsRequired();
            b.ConfigureByConvention();
        });
        #endregion
    }
}

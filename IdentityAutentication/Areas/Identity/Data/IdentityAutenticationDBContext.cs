using IdentityAutentication.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityAutentication.Areas.Identity.Data;

public class IdentityAutenticationDBContext : IdentityDbContext<AutenticationUser>
{
    public IdentityAutenticationDBContext(DbContextOptions<IdentityAutenticationDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);


        // ------------ Need to write
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

    }

    // ------------ Need to write
    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<AutenticationUser>
    {
        public void Configure(EntityTypeBuilder<AutenticationUser> builder)
        {
            builder.Property(f => f.FirstName).HasMaxLength(256);
            builder.Property(f => f.LastName).HasMaxLength(256);
        }
    }

}

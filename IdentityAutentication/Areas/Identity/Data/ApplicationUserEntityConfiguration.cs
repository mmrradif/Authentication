using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityAutentication.Areas.Identity.Data
{
    internal class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<AutenticationUser>
    {
        public void Configure(EntityTypeBuilder<AutenticationUser> builder)
        {
            builder.Property(f => f.FirstName).HasMaxLength(256);
            builder.Property(f => f.LastName).HasMaxLength(256);
        }
    }
}
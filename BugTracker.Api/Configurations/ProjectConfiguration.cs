using BugTracker.Api.Models.Projects;
using BugTracker.Api.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace BugTracker.Api.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");

            builder.Property(user => user.Name)
                .IsRequired();

            builder.Property(user => user.Description)
                .IsRequired(false)
            .HasMaxLength(500);

            builder
                .HasOne(a => a.User)
                .WithMany(b => b.Projects)
                .HasForeignKey(b => b.OwnerId);
        }
    }
}

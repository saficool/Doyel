using Doyel.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Doyel.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);

		builder.Entity<ApplicationUser>(entity =>
		{
			entity.ToTable("DoyelUsers");
		});

		builder.Entity<IdentityRole>(entity =>
		{
			entity.ToTable("DoyelRoles");
		});

		builder.Entity<IdentityUserRole<string>>(entity =>
		{
			entity.ToTable("DoyelUserRoles");
		});

		builder.Entity<IdentityUserClaim<string>>(entity =>
		{
			entity.ToTable("DoyelUserClaims");
		});

		builder.Entity<IdentityUserLogin<string>>(entity =>
		{
			entity.ToTable("DoyelUserLogins");
		});

		builder.Entity<IdentityRoleClaim<string>>(entity =>
		{
			entity.ToTable("DoyelRoleClaims");
		});

		builder.Entity<IdentityUserToken<string>>(entity =>
		{
			entity.ToTable("DoyelUserTokens");
		});
	}
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TurnipExchange.Data
{
	public class ApplicationDbContext : IdentityDbContext<User>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<InterestedParty>()
				.HasOne(ip => ip.User)
				.WithMany(u => u.InterestedIn)
				.HasForeignKey(ip => ip.UserId);
			builder.Entity<InterestedParty>()
				.HasOne(ip => ip.SaleOffer)
				.WithMany(c => c.InterestedParties)
				.HasForeignKey(bc => bc.SaleOfferId);

			builder.Entity<SaleOffer>()
				.Property(so => so.UserId)
				.IsRequired(true);

			Data.TimeZone.Seed(builder.Entity<TimeZone>());

			base.OnModelCreating(builder);
		}

		public DbSet<TimeZone> TimeZone { get; set; }
		public DbSet<SaleOffer> SaleOffer { get; set; }
		public DbSet<InterestedParty> InterestedParty { get; set; }
	}
}
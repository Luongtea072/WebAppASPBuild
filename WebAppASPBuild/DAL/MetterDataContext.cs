using aueProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace aueProject.DAL
{
	public class MetterDataContext : DbContext
	{

		public MetterDataContext() : base("MetterDataContext")
		{
		}

		public DbSet<MetterData> Metter { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
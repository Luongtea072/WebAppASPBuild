using aueProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace aueProject.DAL
{
	public class DataQuery : DbContext
	{

		public DataQuery() : base("MetterDataContext")
		{
		}

		public DbSet<DataQuery> DataQueries { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
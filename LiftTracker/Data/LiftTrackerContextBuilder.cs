using LiftTracker.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LiftTracker.Data
{
	public class LiftTrackerContextBuilder
	{
		private string ConnectionString;

		public LiftTrackerContextBuilder(IConfiguration configuration) {
			ConnectionString = configuration.GetConnectionString("DefaultConnection");
		}

		public ApplicationDbContext Build() {
			var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
			optionsBuilder.UseSqlServer(ConnectionString);
			return new ApplicationDbContext(optionsBuilder.Options);
		}
	}
}

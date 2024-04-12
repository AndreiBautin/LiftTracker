using Microsoft.AspNetCore.Identity;

namespace LiftTracker.Data
{
	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : IdentityUser
	{
		public IEnumerable<MacroCycle>? MacroCycles { get; set; }
	}

}

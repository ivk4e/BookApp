using BookApp.Data;

namespace BookApp.Forms.Services
{
	public class UserLogin
	{
		private readonly BookAppContext dbContext;

		public UserLogin()
		{
			dbContext = new BookAppContext();
		}

		public bool AuthenticateUser(string username, string password)
		{
			var user = dbContext.Users.FirstOrDefault(u => u.Username == username);

			if (user != null && HashPassword.VerifyPassword(password, user.Password)) { return true; }

			return false;
		}

		public string AuthenticateUserType(string username)
		{
			var user = dbContext.Users.FirstOrDefault(u => u.Username == username);

			if (user != null)
			{
				switch (user.UserTypeId)
				{
					case 1:
						return "admin";
					case 2:
						return "worker";
					case 3:
						return "user";
					default:
						return "unkown";
				}
			}

			return "unkown";
		}
	}
}

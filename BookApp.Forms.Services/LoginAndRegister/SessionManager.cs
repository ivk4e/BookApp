using BookApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Forms.Services.LoginAndRegister
{
    public class SessionManager
    {
        private static User currentUser;

        public static void SetCurrentUser(User user)
        {
            currentUser = user;
        }

        public static User GetCurrentUser()
        {
            return currentUser;
        }

        public static void ClearCurrentUser()
        {
            currentUser = null;
        }
    }
}

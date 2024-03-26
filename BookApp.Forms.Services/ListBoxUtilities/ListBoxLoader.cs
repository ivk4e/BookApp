using BookApp.Data;
using BookApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp.Forms.Services.ListBoxUtilities
{
    public class ListBoxLoader
    {
        private readonly BookAppContext dbContext;

        public ListBoxLoader()
        {
            dbContext = new BookAppContext();
        }

        public void PopulateListBox(ListBox listBox, int userTypeId, Func<User, string> userFormatter)
        {
            listBox.Items.Clear();

            try
            {
                var users = dbContext.Users
                    .Where(u => u.UserTypeId == userTypeId)
                    .Select(userFormatter)
                    .OrderBy(u => u)
                    .ToList();

                foreach (var user in users)
                {
                    listBox.Items.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

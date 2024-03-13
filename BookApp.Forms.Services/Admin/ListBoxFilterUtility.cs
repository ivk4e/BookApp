using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp.Forms.Services.Admin
{
	public static class ListBoxFilterUtility<T>
	{
		public static void FilterItems(ListBox listBox, string emailInput)
		{
			var matchedItems = new List<string>();

			bool emailFound = false;

			foreach (var item in listBox.Items.OfType<T>())
			{
				string itemEmail = item.ToString()[(item.ToString().LastIndexOf('-') + 1)..].Trim(); // item.ToString().Substring(item.ToString().LastIndexOf('-') + 1).Trim();
				if (itemEmail.Equals(emailInput, StringComparison.OrdinalIgnoreCase) ||
					itemEmail.StartsWith(emailInput, StringComparison.OrdinalIgnoreCase))
				{
					matchedItems.Add(item.ToString());
					emailFound = true;
				}
			}

			listBox.Items.Clear();
			listBox.Items.AddRange(matchedItems.ToArray());

			if (!emailFound)
			{
				MessageBox.Show("Не намерих такъв email.");
			}
		}
	}
}

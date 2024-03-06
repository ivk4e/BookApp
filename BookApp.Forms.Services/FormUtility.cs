using System.Windows.Forms;

namespace BookApp.Forms.Services
{
	public class FormUtility
	{
		public static void ShowNewForm<T>(Form currentForm)
			where T : Form, new()
		{
			currentForm.Hide();

			T newForm = new();
			newForm.ShowDialog();

			currentForm.Close();
		}
	}
}

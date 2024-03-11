using System.Windows.Forms;

namespace BookApp.Forms.Services
{
	public static class FormUtility
	{
		public static void ShowNewForm<T>(Form currentForm)
			where T : Form, new()
		{
			currentForm.Hide();

			T newForm = new();
			newForm.ShowDialog();

			currentForm.Close();
		}

		public static void ShowDialogAndHideCurrent<T>(Form currentForm) where T : Form, new()
		{
			currentForm.Visible = false;

			T newForm = new();
			newForm.ShowDialog();

			currentForm.Visible = true;
		}
	}
}

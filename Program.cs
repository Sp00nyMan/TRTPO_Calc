using System;
using System.Windows.Forms;

namespace TRTPO_CALC
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		public static MainForm MainForm;
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainForm = new MainForm();
			Application.Run(MainForm);
		}
	}
}

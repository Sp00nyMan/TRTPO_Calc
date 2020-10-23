using System;
using System.Windows.Forms;
using TRTPO_CALC.Module;

namespace TRTPO_CALC
{
	public partial class MainForm : Form
	{
		public Type CurrentModule;

		public MainForm()
		{
			InitializeComponent();
			CurrentModule = typeof(Calculator);
		}

		private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			MessageBox.Show(e.KeyChar.ToString());
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			MessageBox.Show(e.KeyCode.ToString());

		}
	}
}

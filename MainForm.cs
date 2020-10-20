using System;
using System.Windows.Forms;

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
	}
}

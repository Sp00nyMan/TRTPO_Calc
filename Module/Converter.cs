using System;
using System.Windows.Forms;

namespace TRTPO_CALC.Module
{
	public partial class Converter : UserControl
	{
		public event MainForm.ModuleEvent OnModuleChanged;

		public Converter()
		{
			InitializeComponent();
		}

		private void OnCalcClick(object sender, EventArgs e)
		{
			OnModuleChanged?.Invoke(this);
		}

	}

}

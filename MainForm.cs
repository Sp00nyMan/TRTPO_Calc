using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TRTPO_CALC
{
	public partial class MainForm : Form
	{
		public delegate void ModuleEvent(object sender);

		LinkedList<UserControl> modules = new LinkedList<UserControl>();
		UserControl currentModule;
		public MainForm()
		{
			InitializeComponent();

			calculator.OnModuleChanged += ChangeModule;
			converter.OnModuleChanged += ChangeModule;
			
			modules.AddLast(calculator);
			modules.AddLast(converter);
			currentModule = converter;
		}

		private void ChangeModule(object sender)
		{
			currentModule.Visible = false;
			currentModule = modules.Find(currentModule)?.Next?.Value ?? modules.First.Value;
			currentModule.Visible = true;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			currentModule.Visible = true;
		}
	}
}

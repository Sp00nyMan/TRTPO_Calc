using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TRTPO_CALC.Module;

namespace TRTPO_CALC
{
	public partial class MainForm : Form
	{
		private readonly ButtonHandler buttonHandler;

		internal event EventHandler onOperation;
		internal event EventHandler onOperandChanged;
		internal event EventHandler onButtonClick;
		public Type CurrentModule;

		private Calculator calculator;
		public MainForm()
		{
			InitializeComponent();
			buttonHandler = new ButtonHandler(onOperation, onOperandChanged);
			calculator = new Calculator(onOperation, onOperandChanged, onButtonClick);
			CurrentModule = typeof(Calculator);
		}

		public void Print(object data)
		{
			switch (CurrentModule.Name.ToLower())
			{
				case "calculator":
					OutputBox.Clear();
					OutputBox.AppendText((string) data);
					break;
			}
		}
		private void OnButtonClick(object sender, EventArgs e)
		{
			if(sender is Button button)
				buttonHandler.HandleClick(button, e);
		}
	}
}

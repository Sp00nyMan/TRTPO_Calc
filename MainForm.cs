using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TRTPO_CALC.Operations;

namespace TRTPO_CALC
{
	public partial class MainForm : Form
	{
		private readonly ButtonHandler buttonHandler;
		private string input = string.Empty;
		private string operand = string.Empty;
		private Operation operation = null;
		private bool operandChange;

		public MainForm()
		{
			InitializeComponent();
			buttonHandler = new ButtonHandler(OnOperationChanged, OnOperandChanged);
			Button_Plus.Tag = OperationHandler.Operations.summation;
			Button_Minus.Tag = OperationHandler.Operations.subtraction;
			Button_Mult.Tag = OperationHandler.Operations.multiplication;
			Button_Divide.Tag = OperationHandler.Operations.division;
			Button_Power.Tag = OperationHandler.Operations.power;
			Button_Equals.Tag = OperationHandler.Operations.equals;
		}

		private void PerformOperation()
		{
			if (operation == null)
				return;
			input = Math.Round(OperationHandler.PerformOperation(operation, double.Parse(input), double.Parse(operand)), 10).ToString();
			operation = null;
			operand = string.Empty;
		}

		private void OnOperationChanged(object sender, EventArgs e)
		{
			Button button = (Button) sender;
			Operation operation = (Operation) button.Tag;
			if(input.Length != 0)
			{
				if (operand.Length != 0)
				{
					PerformOperation();
				} 
				
			}
			else
			{
				input = operand;
				operand = string.Empty;
			}

			if (!(operation is Equals))
				this.operation = operation;
		}
		private void OnOperandChanged(object digit, EventArgs e)
		{
			if (operation == null)
				input = string.Empty;
			operand += digit;
		}
		private void OnButtonClick(object sender, EventArgs e)
		{
			if(sender is Button button)
				buttonHandler.HandleClick(button, e);
			OutputBox.Clear();
			OutputBox.AppendText($"{input} {operation?.symbol} {operand}".Trim());
		}
	}
}

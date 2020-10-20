using System;
using System.Windows.Forms;
using TRTPO_CALC.Operations;

namespace TRTPO_CALC.Module
{
	public class Calculator
	{
		private string input = string.Empty;
		private string operand = string.Empty;
		private Operation operation;

		public Calculator(EventHandler onOperation, EventHandler onOperandChanged, EventHandler onButtonClick)
		{
			onOperation += this.OnOperation;
			onOperandChanged += this.OnOperandChanged;
			onButtonClick += this.OnButtonClick;
		}
		private void PerformOperation()
		{
			if (operation == null)
				return;
			input = Math.Round(OperationHandler.PerformOperation(operation, double.Parse(input), double.Parse(operand)),
				10).ToString();
			operation = null;
			operand = string.Empty;
		}
		private void OnOperation(object sender, EventArgs e)
		{
			Operation operation = (Operation) ((Button) sender).Tag;
			if (input.Length != 0)
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

		}
	}
}

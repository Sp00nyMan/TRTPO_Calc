using System;
using System.Windows.Forms;
using TRTPO_CALC.Handler;
using TRTPO_CALC.Operations;

namespace TRTPO_CALC.Module
{
	public partial class Calculator : UserControl
	{
		private readonly ButtonHandler buttonHandler;
		private readonly KeyHandler keyHandler;

		private string input = string.Empty;
		private string operand = string.Empty;
		private Operation operation;

		public Calculator()
		{
			InitializeComponent();
			buttonHandler = new ButtonHandler();
			buttonHandler.OnOperation += OnOperation;
			buttonHandler.OnDigit += OnOperandChanged;
			buttonHandler.OnControl += OnControl;

			keyHandler = new KeyHandler();
			keyHandler.OnOperation += OnOperation;
			keyHandler.OnDigit += OnOperandChanged;
			keyHandler.OnControl += OnControl;
		}

		private void PerformOperation()
		{
			if (operation == null)
				return;
			input = Math.Round(operation.Perform(double.Parse(input), double.Parse(operand)), 10).ToString();
			operation = null;
			operand = string.Empty;
		}

		private void OnOperation(object sender, object oper)
		{
			Operation operation = (Operation) oper;
			if (operand.Length == 0 && operation is Subtraction)
			{
				operand = "-";
				return;
			}

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

		private void OnOperandChanged(object sender, object digit)
		{
			if (operation == null)
				input = string.Empty;
			if(!(digit.ToString() == Button_Comma.Text && operand.Contains(Button_Comma.Text)))
				operand += digit.ToString();
		}

		private void OnControl(object sender, object argumens)
		{
			switch ((string)argumens)
			{
				case "clear":
					input = string.Empty;
					operand = string.Empty;
					operation = null;
					break;
				case "backspace":
					if (operand.Length != 0)
					{
						operand = operand.Remove(operand.Length - 1, 1);
					}
					else if (operation != null)
					{
						operation = null;
						operand = input;
						input = string.Empty;
					}
					else if (input.Length != 0)
					{
						input = string.Empty;
					}
					break;
			}
		}

		private void OnWindowChange()
		{
			OutputBox.Clear();
			OutputBox.AppendText($"{input} {operation?.symbol} {operand}".Trim());
		}
		private void OnButtonClick(object sender, EventArgs e)
		{
			buttonHandler.Handle(this, sender);
			OnWindowChange();
		}

		private void OnKeyPressed(object sender, KeyPressEventArgs e)
		{
			keyHandler.Handle(this, e);
			e.Handled = true;
			OnWindowChange();
		}

		private void Calculator_Load(object sender, EventArgs e)
		{
			Parent.KeyPress += OnKeyPressed;
		}
	}
}

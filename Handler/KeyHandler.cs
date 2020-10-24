using System;
using System.Windows.Forms;
using TRTPO_CALC.Operations;

namespace TRTPO_CALC.Handler
{
	class KeyHandler : Handler
	{	
		public override event CalculatorEventHandler OnOperation;
		public override event CalculatorEventHandler OnDigit;
		public override event CalculatorEventHandler OnControl;
		public override void Handle(object sender, object args)
		{
			if (args == null)
				throw new ArgumentNullException();
			KeyPressEventArgs e = (KeyPressEventArgs) args;
			
			if (char.IsDigit(e.KeyChar) ||
				e.KeyChar == ',')
			{
				OnDigit?.Invoke(this, e.KeyChar);
			} else
				switch (e.KeyChar)
				{
					case (char) Keys.Back:
						OnControl?.Invoke(this, "backspace");
						break;
					case (char) Keys.Escape :
						OnControl?.Invoke(this, "clear");
						break;
					case '+':
						OnOperation?.Invoke(this, new Summation());
						break;
					case '-':
						OnOperation?.Invoke(this, new Subtraction());
						break;
					case '*':
						OnOperation?.Invoke(this, new Multiplication());
						break;
					case '/':
						OnOperation?.Invoke(this, new Division());
						break;
					case (char) Keys.Return:
					case '=':
						OnOperation?.Invoke(this, new Equals());
						break;
					case '^':
						OnOperation?.Invoke(this, new Power());
						break;
				}
		}


	}
}

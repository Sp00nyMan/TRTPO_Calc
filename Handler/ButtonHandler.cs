using System;
using System.Windows.Forms;

namespace TRTPO_CALC.Handler
{
	public class ButtonHandler : Handler
	{
		public override event CalculatorEventHandler OnOperation;
		public override event CalculatorEventHandler OnDigit;
		public override event CalculatorEventHandler OnControl;

		public override void Handle(object sender, object args)
		{
			Button button = (Button) args;
			if(button.Tag is Operation)
				OnOperation?.Invoke(this, button.Tag);
			else
				switch(button.Tag.GetType().Name.ToLower())
				{
					case "string":
						switch ((string) button.Tag)
						{
							case "digit":
								OnDigit?.Invoke(this, button.Text);
								break;
							case "control":
								OnControl?.Invoke(this, button.AccessibleName);
								break;
						}
						break;
				}
		}
	}
}

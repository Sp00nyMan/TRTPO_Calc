using System;
using System.Linq;
using System.Windows.Forms;
using TRTPO_CALC.Operations;

namespace TRTPO_CALC
{
	public class ButtonHandler
	{
		private event EventHandler onOperation;
		private event EventHandler onDigit;

		public ButtonHandler(EventHandler onOperation, EventHandler onDigit)
		{
			this.onOperation += onOperation;
			this.onDigit += onDigit;
		}
		public void HandleClick(Button sender, EventArgs args)
		{
			if(sender.Tag is Operation)
			{
				onOperation?.Invoke(sender, null);
			}
			else if (sender.Tag is string)
			{
				switch ((string) sender.Tag)
				{
					case "digit":
						onDigit?.Invoke(sender.Text, null);
						break;
				}
			}
		}
	}
}

namespace TRTPO_CALC.Handler
{
	public abstract class Handler
	{
		public delegate void CalculatorEventHandler(object sender, object arguments);
		public abstract event CalculatorEventHandler OnOperation;
		public abstract event CalculatorEventHandler OnDigit;
		public abstract event CalculatorEventHandler OnControl;

		public abstract void Handle(object sender, object args);
	}
}

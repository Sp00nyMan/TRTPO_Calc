namespace TRTPO_CALC
{
	public abstract class Operation
	{
		public string symbol;
		protected Operation(string symbol)
		{
			this.symbol = symbol;
		}
		public abstract double Perform(double operand1, double operand2);
	}
}

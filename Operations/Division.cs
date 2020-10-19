namespace TRTPO_CALC.Operations
{
	class Division : Operation
	{
		public Division() : base("/"){}
		public override double Perform(double operand1, double operand2) => operand1 / operand2;
	}
}

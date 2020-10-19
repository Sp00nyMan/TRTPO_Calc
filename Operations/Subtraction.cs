namespace TRTPO_CALC.Operations
{
	class Subtraction : Operation
	{
		public Subtraction() : base("-"){}
		public override double Perform(double operand1, double operand2) => operand1 - operand2;
	}
}

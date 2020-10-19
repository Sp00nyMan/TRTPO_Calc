namespace TRTPO_CALC.Operations
{
	class Multiplication : Operation
	{
		public Multiplication() : base("x"){}
		public override double Perform(double operand1, double operand2) => operand1 * operand2;
	}
}

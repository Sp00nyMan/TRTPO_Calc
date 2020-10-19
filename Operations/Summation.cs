namespace TRTPO_CALC.Operations
{
	public class Summation : Operation
	{
		public Summation() : base("+"){ }
		public override double Perform(double operand1, double operand2) => operand1 + operand2;
	}
}

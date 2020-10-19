using System;

namespace TRTPO_CALC.Operations
{
	class Power : Operation
	{
		public Power() : base("^"){}

		public override double Perform(double operand1, double operand2) => Math.Pow(operand1, operand2);
	}
}
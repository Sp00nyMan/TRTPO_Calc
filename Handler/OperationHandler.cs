using System;

namespace TRTPO_CALC.Operations
{
	public static class OperationHandler
	{
		public abstract class Operations
		{
			public static Operation summation = new Summation();
			public static Operation subtraction = new Subtraction();
			public static Operation multiplication = new Multiplication();
			public static Operation division = new Division();
			public static Operation power = new Power();
			public static Operation equals = new Equals();
		}

		public static double PerformOperation(Operation operation, double operand1, double operand2)
		{
			if (operation is Equals)
				throw new ArgumentException();
			return operation.Perform(operand1, operand2);
		}
	}
}

namespace CSharpKata.Rules
{
	public static class RuleFactory
	{
		public static IMultipleRule CreateMultiple(int value, string result) =>
			new MultipleRule(value, result);

		public static IMinusRule CreateMinus(int value, string result) =>
			new MinusRule(value, result);

		public static IFizzBuzzWithoutModuleRule CreateFizzBuzzWithout() =>
			new FizzBuzzWithoutModuleRule();

		public static IMultipleWithoutRule CreateMultipleWithoutModule(int value, string result) =>
			new MultipleWithoutModuleRule(value, result);
	}
	
}

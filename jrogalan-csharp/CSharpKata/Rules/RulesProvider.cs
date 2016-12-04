namespace CSharpKata.Rules
{
	public static class RulesProvider
	{
		public static IMultipleRule FizzMultiple => 
			RuleFactory.CreateMultiple(RuleMultiples.FIZZ_MULTIPLE, RuleResults.FIZZ_RESULT);

		public static IMultipleRule BuzzMultiple => 
			RuleFactory.CreateMultiple(RuleMultiples.BUZZ_MULTIPLE, RuleResults.BUZZ_RESULT);

		public static IMultipleRule BangMultiple => 
			RuleFactory.CreateMultiple(RuleMultiples.BANG_MULTIPLE, RuleResults.BANG_RESULT);

		public static IMultipleRule RestMultiple => 
			RuleFactory.CreateMultiple(RuleMultiples.REST_MULTIPLE, RuleResults.REST_RESULT);

		public static IMultipleRule BoomMultiple => 
			RuleFactory.CreateMultiple(RuleMultiples.BOOM_MULTIPLE, RuleResults.BOOM_RESULT);

		public static IMinusRule FizzMinus => 
			RuleFactory.CreateMinus(RuleMultiples.FIZZ_MULTIPLE, RuleResults.FIZZ_RESULT);

		public static IMinusRule BuzzMinus => 
			RuleFactory.CreateMinus(RuleMultiples.BUZZ_MULTIPLE, RuleResults.BUZZ_RESULT);

		public static IFizzBuzzWithoutModuleRule FizzBuzzWithoutModule => 
			RuleFactory.CreateFizzBuzzWithout();

		public static IMultipleWithoutRule FizzMultipleWModule => 
			RuleFactory.CreateMultipleWithoutModule(RuleMultiples.FIZZ_MULTIPLE, RuleResults.FIZZ_RESULT);

		public static IMultipleWithoutRule BuzzMultipleWModule => 
			RuleFactory.CreateMultipleWithoutModule(RuleMultiples.BUZZ_MULTIPLE, RuleResults.BUZZ_RESULT);
	}
}

using CSharpKata.Rules;

namespace CSharpKata.Katas
{
	public interface IFizzBuzzKata : IRuleKata { }

	public class FizzBuzzKata : RuleKata, IFizzBuzzKata
	{
		public FizzBuzzKata()
		{
			AddRule(
				RulesProvider.FizzMultiple,
				RulesProvider.BuzzMultiple);
		}
	}

}

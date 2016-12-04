using CSharpKata.Rules;

namespace CSharpKata.Katas
{
	public interface ISubstitutionsKata : IRuleKata { }

	public class SubstitutionsKata : RuleKata, ISubstitutionsKata
	{
		public SubstitutionsKata(params IRule[] rules)
		{
			AddRule(rules);
		}
	}
}

using System.Collections.Generic;
using System.Linq;
using CSharpKata.Extensions;
using CSharpKata.Rules;

namespace CSharpKata.Katas
{
	public interface IRuleKata
	{
		string Verify(int value);
	}

	public abstract class RuleKata : IRuleKata
	{
		readonly string _delimiter;
		readonly IList<IRule> _rules;

		protected RuleKata()
		{
			_delimiter = Delimiters.EMPTY_DELIMITER;
			_rules = new List<IRule>();
		}

		protected void AddRule(params IRule[] rules)
		{
			foreach (var rule in rules) 
				_rules.Add(rule);
		}

		public virtual string Verify(int number) =>
			_rules.Where(rule => rule.Validate(number))
		          .ToString(_delimiter)
				  .IfEmptyUse(number);
	}
}

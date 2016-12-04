namespace CSharpKata.Rules
{
	public interface IMinusRule : IRule { }

	public class MinusRule : Rule, IMinusRule
	{
		public MinusRule(int value, string result)
			: base(value, result)
		{ }

		public override bool Validate(int number) =>
			number - _value == Rests.REST_ZERO;
	}
}

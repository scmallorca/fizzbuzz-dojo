namespace CSharpKata.Rules
{
	public interface IMultipleRule : IRule { }

	public class MultipleRule : Rule, IMultipleRule
	{
		public MultipleRule(int value, string result)
			: base(value, result)
		{ }

		public override bool Validate(int number) =>
			number % _value == Rests.REST_ZERO;
	}
}

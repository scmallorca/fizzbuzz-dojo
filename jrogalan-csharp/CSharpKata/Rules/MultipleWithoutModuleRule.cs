namespace CSharpKata.Rules
{
	public interface IMultipleWithoutRule : IRule { }

	public class MultipleWithoutModuleRule : Rule, IMultipleWithoutRule
	{
		public MultipleWithoutModuleRule(int value, string result)
			: base(value, result)
		{ }

		public override bool Validate(int number)
		{
			while (number > 0)
				number -= _value;
			return number == Rests.REST_ZERO;
		}
	}
}

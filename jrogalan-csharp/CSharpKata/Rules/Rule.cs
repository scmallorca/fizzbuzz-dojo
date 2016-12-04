using System.Linq;

namespace CSharpKata.Rules
{
	public interface IRule
	{
		string Result { get; }

		bool Validate(int number);
	}

	public abstract class Rule : IRule
	{
		protected int _value;

		protected Rule(int value, string result)
		{
			_value = value;
			Result = result;
		}

		public string Result { protected set; get; }

		public abstract bool Validate(int number);
	}
}

using System.Linq;

namespace CSharpKata.Rules
{
	public interface IFizzBuzzWithoutModuleRule : IRule { }

	public class FizzBuzzWithoutModuleRule : IFizzBuzzWithoutModuleRule
	{
		bool IsRestZero(int value) => value == Rests.REST_ZERO;

		public bool Validate(int number)
		{
			var fizzer = RuleMultiples.FIZZ_MULTIPLE;
			var buzzer = RuleMultiples.BUZZ_MULTIPLE;
			for (int i = 1; i <= number; ++i)
			{
				fizzer--;
				buzzer--;
				Result = string.Empty;
				if (IsRestZero(fizzer))
				{
					Result += RuleResults.FIZZ_RESULT;
					fizzer = RuleMultiples.FIZZ_MULTIPLE;
				}
				if (IsRestZero(buzzer))
				{
					Result += RuleResults.BUZZ_RESULT;
					buzzer = RuleMultiples.BUZZ_MULTIPLE;
				}
			}
			return !string.IsNullOrEmpty(Result);
		}

		public string Result { private set; get; }
	}
	
}

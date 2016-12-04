using CSharpKata.Rules;

namespace CSharpKata.Katas
{
	public interface IFizzBuzzBangKata : IFizzBuzzKata { }

	public class FizzBuzzBangKata : FizzBuzzKata, IFizzBuzzBangKata
	{
		public FizzBuzzBangKata()
		{
			AddRule(RulesProvider.BangMultiple);
		}
	}

}

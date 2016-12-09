using System.Linq;
using CSharpKata.Rules;
using CSharpKata.Katas;
using NUnit.Framework;

namespace CSharpKata.Tests.TDD
{
	[TestFixture()]
	public class KataTests
	{
		[TestCase(1, "1")]
		[TestCase(2, "2")]
		[TestCase(3, "Fizz")]
		[TestCase(5, "Buzz")]
		[TestCase(15, "FizzBuzz")]
		public void ShouldReturnMixedFizzBuzzOrNumber(int value, string expected)
		{
			// arrange
			var kata = new FizzBuzzKata();

			// act
			var result = kata.Verify(value);

			// assert
			Assert.That(result, Is.EqualTo(expected));
		}

		[TestCase(1, "1")]
		[TestCase(2, "2")]
		[TestCase(3, "Fizz")]
		[TestCase(5, "Buzz")]
		[TestCase(15, "FizzBuzz")]
		[TestCase(105, "FizzBuzzBang")]
		public void ShouldReturnMixedFizzBuzzBangOrNumber(int value, string expected)
		{
			// arrange
			var kata = new FizzBuzzBangKata();

			// act
			var result = kata.Verify(value);

			// assert
			Assert.That(result, Is.EqualTo(expected));
		}

		[TestCase(1, "1")]
		[TestCase(2, "2")]
		[TestCase(3, "FizzFizz")]
		[TestCase(5, "Buzz")]
		[TestCase(15, "FizzBuzz")]
		[TestCase(1200, "FizzBuzzRestBoom")]
		public void ShouldReturnMixedSubstitutionsOrNumber(int value, string expected)
		{
			// arrange
			var kata = new SubstitutionsKata(
				RulesProvider.FizzMinus, 
				RulesProvider.FizzMultiple,
				RulesProvider.BuzzMultiple, 
				RulesProvider.RestMultiple, 
				RulesProvider.BoomMultiple);

			// act
			var result = kata.Verify(value);

			// assert
			Assert.That(result, Is.EqualTo(expected));
		}

		[TestCase(1, "1")]
		[TestCase(2, "2")]
		[TestCase(3, "Fizz")]
		[TestCase(5, "Buzz")]
		[TestCase(15, "FizzBuzz")]
		[TestCase(75, "FizzBuzz")]
		public void ShouldReturnSubstitutionsWithoutModuleOrNumber(int value, string expected)
		{
			// arrange
			var kata = new SubstitutionsKata(
				RulesProvider.FizzBuzzWithoutModule);

			// act
			var result = kata.Verify(value);

			// assert
			Assert.That(result, Is.EqualTo(expected));

			// rule iterations:
			// 1  - 2, 4
			// 2 - 1, 3
			// 3 - 0, 2 Fizz 3, 2
			// 4 - 2, 1
			// 5 - 1, 0 Buzz 1, 5
			// 6 - 0, 4 Fizz 3, 4
			// 7 - 2, 3
			// 8 - 1, 2
			// 9 - 0, 1 Fizz 3, 1
			// 10 - 2, 0 Buzz 2, 5
			// 11 - 1, 4
			// 12 - 0, 3 Fizz 3, 3
			// 13 - 2, 2
			// 14 - 1, 1
			// 15 - 0, 0 FizzBuzz
		}

		[TestCase(1, "1")]
		[TestCase(2, "2")]
		[TestCase(3, "Fizz")]
		[TestCase(5, "Buzz")]
		[TestCase(15, "FizzBuzz")]
		[TestCase(75, "FizzBuzz")]
		public void ShouldReturnMixedSubstitutionsWithoutModuleOrNumber(int value, string expected)
		{
			// arrange
			var kata = new SubstitutionsKata(
				RulesProvider.FizzMultipleWModule,
				RulesProvider.BuzzMultipleWModule);

			// act
			var result = kata.Verify(value);

			// assert
			Assert.That(result, Is.EqualTo(expected));
		}

	}
}
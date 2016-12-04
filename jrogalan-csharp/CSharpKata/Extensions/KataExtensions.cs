using System.Collections.Generic;
using System.Linq;
using CSharpKata.Rules;

namespace CSharpKata.Extensions
{
	public static class KataExtensions
	{
		public static string ToString(this IEnumerable<IRule> source, string delimiter = "") =>
				string.Join(delimiter, source.Select(x => x.Result));

		public static string IfEmptyUse(this string result, object value) =>
				string.IsNullOrEmpty(result) ? value.ToString() : result;
	}
}

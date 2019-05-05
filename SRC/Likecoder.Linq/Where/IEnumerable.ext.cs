using System;
using System.Collections.Generic;
using System.Linq;

namespace Likecoder.Linq
{
	partial class extLikecoder
	{
		public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> me, Func<T, bool> predicate, bool @if)
			=> @if ? me.Where(predicate) : me;

		public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> me, Func<T, bool> predicate, string value)
			=> me.WhereIf(predicate, value.IsTrue());


		public static IEnumerable<T> WhereTrue<T>(this IEnumerable<T> me) => me.Where(x => x.IsTrue());
		public static IEnumerable<T> WhereFalse<T>(this IEnumerable<T> me) => me.Where(x => x.IsFalse());
	}
}

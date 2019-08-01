using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Likecoder.Linq
{
	partial class extLikecoder
	{
		public static IQueryable<T> WhereIf<T>(this IQueryable<T> me, Expression<Func<T, bool>> predicate, bool @if)
			=> @if ? me.Where(predicate) : me;

		public static IQueryable<T> WhereIf<T>(this IQueryable<T> me, Expression<Func<T, bool>> predicate, string value)
			=> me.WhereIf(predicate, value.IsTrue());


		public static IQueryable<T> WhereTrue<T>(this IQueryable<T> me) => me.Where(x => x.IsTrue());
		public static IQueryable<T> WhereFalse<T>(this IQueryable<T> me) => me.Where(x => x.IsFalse());
	}
}

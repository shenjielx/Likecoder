using System.Collections.Generic;
using System.Linq;

namespace Likecoder
{
	partial class extLikecoder
	{
		public static bool IsTrue<T>(this IQueryable<T> me) => !me.IsFalse();

		public static bool IsFalse<T>(this IQueryable<T> me) => me is null || !me.Any();
	}
}

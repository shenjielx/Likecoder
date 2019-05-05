using System;

namespace Likecoder
{
	using M = Object;
	partial class extLikecoder
	{
		public static bool IsTrue(this M me) => !me.IsFalse();
		public static bool IsFalse(this M me)
		{
			if (me is string) return ((string)me).IsFalse();
			if (me is int) return ((int)me).IsFalse();
			if (me is long) return ((long)me).IsFalse();
			if (me is short) return ((short)me).IsFalse();
			if (me is double) return ((double)me).IsFalse();
			if (me is decimal) return ((decimal)me).IsFalse();
			if (me is bool) return ((bool)me).IsFalse();

			return me is null;
		}
	}
}

using System;

namespace Likecoder
{
	using M = Double;
	partial class extLikecoder
	{
		public static bool IsTrue(this M me) => !me.IsFalse();
		public static bool IsFalse(this M me) => me == 0;

		public static bool IsTrue(this M? me) => !me.IsFalse();
		public static bool IsFalse(this M? me) => !me.HasValue || me.Value.IsFalse();
	}
}

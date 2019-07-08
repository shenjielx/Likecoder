using System;

namespace Likecoder
{
	using M = DateTime;
	partial class extLikecoder
	{
		public static bool IsTrue(this M me) => !me.IsFalse();
		public static bool IsFalse(this M me) => me <= new M(1970, 1, 1);

		public static bool IsTrue(this M? me) => !me.IsFalse();
		public static bool IsFalse(this M? me) => !me.HasValue || me.Value.IsFalse();
	}
}

using System;

namespace Likecoder
{
	using M = Boolean;
	partial class extLikecoder
	{
		public static bool IsTrue(this M me) => !me.IsFalse();
		public static bool IsFalse(this M me) => me != true;

		public static bool IsTrue(this M? me) => !me.IsFalse();
		public static bool IsFalse(this M? me) => !me.HasValue || me.Value.IsFalse();
	}
}

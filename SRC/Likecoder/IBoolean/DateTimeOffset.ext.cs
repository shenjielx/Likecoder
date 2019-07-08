using System;

namespace Likecoder
{
	using M = DateTimeOffset;
	partial class extLikecoder
	{
		public static bool IsTrue(this M me) => !me.IsFalse();
		public static bool IsFalse(this M me) => me <= new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

		public static bool IsTrue(this M? me) => !me.IsFalse();
		public static bool IsFalse(this M? me) => !me.HasValue || me.Value.IsFalse();
	}
}

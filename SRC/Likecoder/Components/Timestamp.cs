using System;

namespace Likecoder
{
	partial class extLikecoder
	{
		public static string ToUnixTimestampForNow() => DateTime.Now.ToUnixTimestamp();
		public static string ToUnixTimestampForUtcNow() => DateTime.UtcNow.ToUnixTimestamp();

		public static string ToUnixTimestamp(this DateTime me)
			=> new DateTimeOffset(me).ToUnixTimeSeconds().ToString();

		public static string ToUnixTimestamp(this DateTime? me)
			=> me.HasValue ? me.Value.ToUnixTimestamp() : string.Empty;

		public static string ToUnixTimestamp(this DateTimeOffset me)
			=> me.ToUnixTimeSeconds().ToString();

		public static string ToUnixTimestamp(this DateTimeOffset? me)
			=> me.HasValue ? me.Value.ToUnixTimestamp() : string.Empty;
	}
}

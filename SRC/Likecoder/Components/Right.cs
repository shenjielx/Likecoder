namespace Likecoder
{
	partial class extLikecoder
	{
		public static string Right(this string me, int count = 0)
			=> me is null ? string.Empty : (me.Length > count ? me.Substring(me.Length - count, count) : me);
	}
}

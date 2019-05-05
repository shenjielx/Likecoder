namespace Likecoder
{
	partial class extLikecoder
	{
		public static string Left(this string me, int count = 0)
			=> me is null ? string.Empty : (me.Length > count ? me.Substring(0, count) : me);
	}
}

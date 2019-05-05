namespace Likecoder
{
	partial class extLikecoder
	{
		public static bool IsTrue(this string me) => !me.IsFalse();

		public static bool IsFalse(this string me)
			=> string.IsNullOrEmpty(me) || string.IsNullOrWhiteSpace(me);
	}
}

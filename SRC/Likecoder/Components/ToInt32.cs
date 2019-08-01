using System;

namespace Likecoder
{
	using M = Int32;
	partial class extLikecoder
	{
		public static M ToInt32(this string me)
		{
			if (me is null) return 0;
			int.TryParse(me, out M result);
			return result;
		}

	}
}

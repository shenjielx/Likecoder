using System.Collections.Generic;
using System.Linq;
using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class IListTest
	{
		public IListTest()
		{

		}

		[Fact]
		public void TestIIListTest()
		{
			IList<string> val = null;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			IList<string> val2 = Enumerable.Empty<string>().ToList();
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			IList<string> val3 = new List<string> { };
			val3.IsTrue().ShouldBeFalse();
			val3.IsFalse().ShouldBeTrue();

			IList<string> val4 = new List<string> { "xx" };
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();
		}

	}
}

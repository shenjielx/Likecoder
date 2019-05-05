using System.Collections.Generic;
using System.Linq;
using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class ListTest
	{
		public ListTest()
		{

		}

		[Fact]
		public void TestIIListTest()
		{
			List<string> val = null;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			List<string> val2 = Enumerable.Empty<string>().ToList();
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			List<string> val3 = new List<string> { };
			val3.IsTrue().ShouldBeFalse();
			val3.IsFalse().ShouldBeTrue();

			List<string> val4 = new List<string> { "xx" };
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();
		}

	}
}

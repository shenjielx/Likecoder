using System.Collections.Generic;
using System.Linq;
using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class IEnumerableTest
	{
		public IEnumerableTest()
		{

		}

		[Fact]
		public void TestIEnumerable()
		{
			IEnumerable<string> val = null;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			IEnumerable<string> val2 = Enumerable.Empty<string>();
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			IEnumerable<string> val3 = new List<string> { };
			val3.IsTrue().ShouldBeFalse();
			val3.IsFalse().ShouldBeTrue();

			IEnumerable<string> val4 = new List<string> { "xx" };
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();
		}

	}
}

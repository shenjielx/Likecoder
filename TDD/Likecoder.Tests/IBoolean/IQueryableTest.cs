using System.Collections.Generic;
using System.Linq;
using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class IQueryableTest
	{
		public IQueryableTest()
		{

		}

		[Fact]
		public void TestIQueryable()
		{
			IQueryable<string> val = null;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			IQueryable<string> val2 = Enumerable.Empty<string>().AsQueryable();
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			IQueryable<string> val3 = new List<string> { }.AsQueryable();
			val3.IsTrue().ShouldBeFalse();
			val3.IsFalse().ShouldBeTrue();

			IQueryable<string> val4 = new List<string> { "xx" }.AsQueryable();
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();
		}

	}
}

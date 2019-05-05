using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class BolleanTest
	{
		public BolleanTest()
		{

		}

		[Fact]
		public void TestBollean()
		{
			bool val = false;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			bool val2 = true;
			val2.IsTrue().ShouldBeTrue();
			val2.IsFalse().ShouldBeFalse();
		}

		[Fact]
		public void TestDecimalWithNull()
		{
			bool? val = false;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			bool? val2 = true;
			val2.IsTrue().ShouldBeTrue();
			val2.IsFalse().ShouldBeFalse();

			bool? val7 = null;
			val7.IsTrue().ShouldBeFalse();
			val7.IsFalse().ShouldBeTrue();
		}

	}
}

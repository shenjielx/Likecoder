using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class DecimalTest
	{
		public DecimalTest()
		{

		}

		[Fact]
		public void TestDecimal()
		{
			decimal val = 0;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			decimal val2 = -0;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			decimal val3 = 1;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			decimal val4 = -1;
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();

			decimal val5 = decimal.MaxValue;
			val5.IsTrue().ShouldBeTrue();
			val5.IsFalse().ShouldBeFalse();

			decimal val6 = -decimal.MaxValue;
			val6.IsTrue().ShouldBeTrue();
			val6.IsFalse().ShouldBeFalse();
		}

		[Fact]
		public void TestDecimalWithNull()
		{
			decimal? val = 0;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			decimal? val2 = -0;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			decimal? val3 = 1;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			decimal? val4 = -1;
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();

			decimal? val5 = decimal.MaxValue;
			val5.IsTrue().ShouldBeTrue();
			val5.IsFalse().ShouldBeFalse();

			decimal? val6 = -decimal.MaxValue;
			val6.IsTrue().ShouldBeTrue();
			val6.IsFalse().ShouldBeFalse();

			decimal? val7 = null;
			val7.IsTrue().ShouldBeFalse();
			val7.IsFalse().ShouldBeTrue();
		}

	}
}

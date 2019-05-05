using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class DoubleTest
	{
		public DoubleTest()
		{

		}

		[Fact]
		public void TestDouble()
		{
			double val = 0;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			double val2 = -0;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			double val3 = 1;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			double val4 = -1;
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();

			double val5 = double.MaxValue;
			val5.IsTrue().ShouldBeTrue();
			val5.IsFalse().ShouldBeFalse();

			double val6 = -double.MaxValue;
			val6.IsTrue().ShouldBeTrue();
			val6.IsFalse().ShouldBeFalse();
		}

		[Fact]
		public void TestDoubleWithNull()
		{
			double? val = 0;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			double? val2 = -0;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			double? val3 = 1;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			double? val4 = -1;
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();

			double? val5 = double.MaxValue;
			val5.IsTrue().ShouldBeTrue();
			val5.IsFalse().ShouldBeFalse();

			double? val6 = -double.MaxValue;
			val6.IsTrue().ShouldBeTrue();
			val6.IsFalse().ShouldBeFalse();

			double? val7 = null;
			val7.IsTrue().ShouldBeFalse();
			val7.IsFalse().ShouldBeTrue();
		}

	}
}

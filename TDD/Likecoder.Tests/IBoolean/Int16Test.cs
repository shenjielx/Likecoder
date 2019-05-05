using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class Int16Test
	{
		public Int16Test()
		{

		}

		[Fact]
		public void TestInt16()
		{
			short val = 0;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			short val2 = -0;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			short val3 = 1;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			short val4 = -1;
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();

			short val5 = short.MaxValue;
			val5.IsTrue().ShouldBeTrue();
			val5.IsFalse().ShouldBeFalse();

			short val6 = -short.MaxValue;
			val6.IsTrue().ShouldBeTrue();
			val6.IsFalse().ShouldBeFalse();
		}

		[Fact]
		public void TestInt16WithNull()
		{
			short? val = 0;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			short? val2 = -0;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			short? val3 = 1;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			short? val4 = -1;
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();

			short? val5 = short.MaxValue;
			val5.IsTrue().ShouldBeTrue();
			val5.IsFalse().ShouldBeFalse();

			short? val6 = -short.MaxValue;
			val6.IsTrue().ShouldBeTrue();
			val6.IsFalse().ShouldBeFalse();

			short? val7 = null;
			val7.IsTrue().ShouldBeFalse();
			val7.IsFalse().ShouldBeTrue();
		}

	}
}

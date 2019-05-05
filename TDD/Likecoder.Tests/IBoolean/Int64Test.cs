using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class Int64Test
	{
		public Int64Test()
		{

		}


		[Fact]
		public void TestInt64()
		{
			long val = 0;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			long val2 = -0;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			long val3 = 1;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			long val4 = -1;
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();

			long val5 = long.MaxValue;
			val5.IsTrue().ShouldBeTrue();
			val5.IsFalse().ShouldBeFalse();

			long val6 = -long.MaxValue;
			val6.IsTrue().ShouldBeTrue();
			val6.IsFalse().ShouldBeFalse();
		}

		[Fact]
		public void TestInt64WithNull()
		{
			long? val = 0;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			long? val2 = -0;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			long? val3 = 1;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			long? val4 = -1;
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();

			long? val5 = long.MaxValue;
			val5.IsTrue().ShouldBeTrue();
			val5.IsFalse().ShouldBeFalse();

			long? val6 = -long.MaxValue;
			val6.IsTrue().ShouldBeTrue();
			val6.IsFalse().ShouldBeFalse();

			long? val7 = null;
			val7.IsTrue().ShouldBeFalse();
			val7.IsFalse().ShouldBeTrue();
		}
	}
}

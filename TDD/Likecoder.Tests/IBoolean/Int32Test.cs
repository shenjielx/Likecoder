using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class IInt32Test
	{
		public IInt32Test()
		{

		}

		[Fact]
		public void TestInt32()
		{
			int val = 0;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			int val2 = -0;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			int val3 = 1;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			int val4 = -1;
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();

			int val5 = int.MaxValue;
			val5.IsTrue().ShouldBeTrue();
			val5.IsFalse().ShouldBeFalse();

			int val6 = -int.MaxValue;
			val6.IsTrue().ShouldBeTrue();
			val6.IsFalse().ShouldBeFalse();
		}

		[Fact]
		public void TestInt32WithNull()
		{
			int? val = 0;
			val.IsTrue().ShouldBeFalse();
			val.IsFalse().ShouldBeTrue();

			int? val2 = -0;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			int? val3 = 1;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			int? val4 = -1;
			val4.IsTrue().ShouldBeTrue();
			val4.IsFalse().ShouldBeFalse();

			int? val5 = int.MaxValue;
			val5.IsTrue().ShouldBeTrue();
			val5.IsFalse().ShouldBeFalse();

			int? val6 = -int.MaxValue;
			val6.IsTrue().ShouldBeTrue();
			val6.IsFalse().ShouldBeFalse();

			int? val7 = null;
			val7.IsTrue().ShouldBeFalse();
			val7.IsFalse().ShouldBeTrue();
		}

	}
}

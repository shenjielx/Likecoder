using Shouldly;
using System;
using Xunit;

namespace Likecoder.Tests
{
	public class DateTimeTest
	{
		public DateTimeTest()
		{

		}

		[Fact]
		public void TestDateTime()
		{
			var val = DateTime.Now;
			val.IsTrue().ShouldBeTrue();
			val.IsFalse().ShouldBeFalse();

			var val2 = DateTime.MinValue;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			var val3 = DateTime.MaxValue;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			var val4 = new DateTime(1970, 1, 1);
			val4.IsTrue().ShouldBeFalse();
			val4.IsFalse().ShouldBeTrue();
		}

		[Fact]
		public void TestDateTimeWithNull()
		{
			DateTime? val = DateTime.Now;
			val.IsTrue().ShouldBeTrue();
			val.IsFalse().ShouldBeFalse();

			DateTime? val2 = DateTime.MinValue;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			DateTime? val3 = DateTime.MaxValue;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			DateTime? val4 = new DateTime(1970, 1, 1);
			val4.IsTrue().ShouldBeFalse();
			val4.IsFalse().ShouldBeTrue();

			DateTime? val5 = null;
			val5.IsTrue().ShouldBeFalse();
			val5.IsFalse().ShouldBeTrue();
		}

	}
}

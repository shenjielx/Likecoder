using Shouldly;
using System;
using Xunit;

namespace Likecoder.Tests
{
	public class DateTimeOffsetTest
	{
		public DateTimeOffsetTest()
		{

		}

		[Fact]
		public void TestDateTimeOffset()
		{
			var val = DateTimeOffset.Now;
			val.IsTrue().ShouldBeTrue();
			val.IsFalse().ShouldBeFalse();

			var val2 = DateTimeOffset.MinValue;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			var val3 = DateTimeOffset.MaxValue;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			var val4 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			val4.IsTrue().ShouldBeFalse();
			val4.IsFalse().ShouldBeTrue();
		}

		[Fact]
		public void TestDateTimeOffsetWithNull()
		{
			DateTimeOffset? val = DateTimeOffset.Now;
			val.IsTrue().ShouldBeTrue();
			val.IsFalse().ShouldBeFalse();

			DateTimeOffset? val2 = DateTimeOffset.MinValue;
			val2.IsTrue().ShouldBeFalse();
			val2.IsFalse().ShouldBeTrue();

			DateTimeOffset? val3 = DateTimeOffset.MaxValue;
			val3.IsTrue().ShouldBeTrue();
			val3.IsFalse().ShouldBeFalse();

			DateTimeOffset? val4 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			val4.IsTrue().ShouldBeFalse();
			val4.IsFalse().ShouldBeTrue();

			DateTimeOffset? val5 = null;
			val5.IsTrue().ShouldBeFalse();
			val5.IsFalse().ShouldBeTrue();
		}

	}
}

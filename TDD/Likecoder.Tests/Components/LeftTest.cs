using Shouldly;
using Xunit;

namespace Likecoder.Tests.Components
{
	public class LeftTest
	{
		public LeftTest()
		{

		}

		[Fact]
		public void TestLeft()
		{
			var val = "";
			val.Left(2).ShouldBe("");
			val.Left().ShouldBe("");

			var val2 = "123";
			val2.Left(2).ShouldBe("12");
			val2.Left().ShouldBe("");

			var val3 = "1234567";
			val3.Left(9).ShouldBe("1234567");
			val3.Left().ShouldBe("");

			var val4 = "1234567";
			val4.Left(7).ShouldBe("1234567");
			val4.Left().ShouldBe("");
		}
	}
}

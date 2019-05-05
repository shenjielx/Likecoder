using Shouldly;
using Xunit;

namespace Likecoder.Tests.Components
{
	public class RightTest
	{
		public RightTest()
		{

		}

		[Fact]
		public void TestRight()
		{
			var val = "";
			val.Right(2).ShouldBe("");
			val.Right().ShouldBe("");

			var val2 = "123";
			val2.Right(2).ShouldBe("23");
			val2.Right().ShouldBe("");

			var val3 = "1234567";
			val3.Right(9).ShouldBe("1234567");
			val3.Right().ShouldBe("");

			var val4 = "1234567";
			val4.Right(7).ShouldBe("1234567");
			val4.Right().ShouldBe("");
		}
	}
}

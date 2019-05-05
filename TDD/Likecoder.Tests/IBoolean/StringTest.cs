using Shouldly;
using Xunit;

namespace Likecoder.Tests
{
	public class StringTest
	{
		public StringTest()
		{

		}

		[Fact]
		public void TestString()
		{
			string str = "";
			str.IsTrue().ShouldBeFalse();
			str.IsFalse().ShouldBeTrue();

			string str2 = "  ";
			str2.IsTrue().ShouldBeFalse();
			str2.IsFalse().ShouldBeTrue();

			string str3 = null;
			str3.IsTrue().ShouldBeFalse();
			str3.IsFalse().ShouldBeTrue();

			string str4 = " x ";
			str4.IsTrue().ShouldBeTrue();
			str4.IsFalse().ShouldBeFalse();
		}

	}
}

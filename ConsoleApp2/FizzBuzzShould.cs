using ConsoleApp1;
using NSubstitute;
using NUnit.Framework;

namespace ConsoleApp2
{
	[TestFixture]
	class FizzBuzzShould
	{
		[Test]
		public void CallFormatterForEachNumberUntillTheOneGiven()
		{
			IFizzBuzzFormatter fizzBuzzFormatter = Substitute.For<FizzBuzzFormatter>();
			FizzBuzz fizzBuzz = new FizzBuzz();

			fizzBuzz.Run(5);

			fizzBuzzFormatter.Received(5).Format(Arg.Any<int>());
			fizzBuzzFormatter.Received(1).Format(1);
			fizzBuzzFormatter.Received(1).Format(2);
			fizzBuzzFormatter.Received(1).Format(3);
			fizzBuzzFormatter.Received(1).Format(4);
			fizzBuzzFormatter.Received(1).Format(5);
		}
	}
}

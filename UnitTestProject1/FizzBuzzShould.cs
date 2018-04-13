using System;
using NSubstitute;
using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
	[TestFixture]
	class FizzBuzzShould
	{
	    private IWriter _writer;

	    [SetUp]
	    public void SetUp()
	    {
	        _writer = Substitute.For<IWriter>();
        }

	    [TestCase(1)]
	    [TestCase(2)]
	    [TestCase(4)]
	    [TestCase(7)]
	    public void WriteNumberWhenNumberCanNotBeExactlyDividedByThreeOrFive(int number)
	    {
	        FizzBuzz fizzBuzz = new FizzBuzz(_writer);

	        fizzBuzz.Process(number);
	        _writer.Received(1).Write(number.ToString());
	        _writer.Received(1).Write(Arg.Any<String>());
	    }

        [TestCase(3)]
	    [TestCase(6)]
	    [TestCase(9)]
	    [TestCase(12)]
        public void WriteFizzWhenNumberCanBeExactlyDividedByThree(int number)
		{
			FizzBuzz fizzBuzz = new FizzBuzz(_writer);

			fizzBuzz.Process(number);
		    _writer.Received(1).Write("Fizz");
		    _writer.Received(1).Write(Arg.Any<String>());
        }

	    [TestCase(5)]
	    [TestCase(10)]
	    [TestCase(20)]
	    [TestCase(25)]
	    public void WriteBuzzWhenNumberCanBeExactlyDividedByFive(int number)
	    {
	        FizzBuzz fizzBuzz = new FizzBuzz(_writer);

	        fizzBuzz.Process(number);
	        _writer.Received(1).Write("Buzz");
	        _writer.Received(1).Write(Arg.Any<String>());
	    }

	    [TestCase(15)]
	    [TestCase(30)]
	    [TestCase(45)]
	    [TestCase(60)]
	    public void WriteNumberWhenNumberCanBeExactlyDividedByThreeAndFive(int number)
	    {
	        FizzBuzz fizzBuzz = new FizzBuzz(_writer);

	        fizzBuzz.Process(number);
	        _writer.Received(1).Write("FizzBuzz");
	        _writer.Received(1).Write(Arg.Any<String>());
	    }
    }
}

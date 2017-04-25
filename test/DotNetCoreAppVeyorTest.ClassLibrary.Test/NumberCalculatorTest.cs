namespace DotNetCoreAppVeyorTest.ClassLibrary.Test
{
	using Xunit;

	public class NumberCalculatorTest
	{
		[Fact]
		public void Add_For1And2_Returns3()
		{
			NumberCalculator numberCalculator = new NumberCalculator();

			Assert.True(numberCalculator.Add(1, 2) == 3);
		}
	}
}
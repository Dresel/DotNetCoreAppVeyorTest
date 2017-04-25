using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetCoreAppVeyorTest.ClassLibrary.Test
{
	[TestClass]
	public class NumberCalculatorTest
	{
		[TestMethod]
		public void Add_For1And2_Returns3()
		{
			NumberCalculator numberCalculator = new NumberCalculator();

			Assert.IsTrue(numberCalculator.Add(1, 2) == 3);
		}
	}
}

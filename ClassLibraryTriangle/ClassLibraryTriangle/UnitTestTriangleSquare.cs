using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTriangle
{
	[TestClass]
	public class UnitTestTriangleSquare
	{
		[TestMethod]
		public void TestMethod()
		{
			Assert.AreEqual(0, TriangleSquare.CalculateSquareFast(-1, -1, -1), 0.001, "Bad data: less than 0");
			Assert.AreEqual(0, TriangleSquare.CalculateSquareFast(1, 2, 3), 0.001, "Bad data: incorrect side");
			Assert.AreEqual(12.5, TriangleSquare.CalculateSquareFast(3, 4, 5), 0.001, "Good data");
		}
	}
}

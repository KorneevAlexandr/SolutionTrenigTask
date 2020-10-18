using System;
using FigursLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryFiguraTest
{
	[TestClass]
	public class TestCircle
	{
		[TestMethod]
		public void Perimetr_10_20Pi_returned()
		{
			double r = 10;
			double expected = 62.83;

			Figura figura = new Circle(r);
			double actual = figura.Perimetr();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Square_5_25Pi_returned()
		{
			double r = 5;
			double expected = 78.54;

			Figura figura = new Circle(r);
			double actual = figura.Square();

			Assert.AreEqual(expected, actual);
		}
	}
}

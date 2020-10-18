using System;
using FigursLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryFiguraTest
{
	[TestClass]
	public class TestTriangle
	{
		[TestMethod]
		public void Perimetr_17and9and10_36returned()
		{
			double basis = 17;
			double left = 9;
			double right = 10;
			double expected = 36;

			Figura figura = new Triangle(basis, left, right);
			double actual = figura.Perimetr();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Square_17and9and10_36returned()
		{
			double basis = 17;
			double left = 9;
			double right = 10;
			double expected = 36;

			Figura figura = new Triangle(basis, left, right);
			double actual = figura.Square();

			Assert.AreEqual(expected, actual);
		}

	}
}

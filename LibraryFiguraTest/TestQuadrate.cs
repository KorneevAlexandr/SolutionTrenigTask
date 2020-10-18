using System;
using FigursLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryFiguraTest
{
	[TestClass]
	public class TestQuadrate
	{
		[TestMethod]
		public void Perimetr_10_40returned()
		{
			double x = 10;
			double expected = 40;

			Figura figura = new Quadrate(x);
			double actual = figura.Perimetr();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Square_10_100returned()
		{
			double x = 10;
			double expected = 100;

			Figura figura = new Quadrate(x);
			double actual = figura.Square();

			Assert.AreEqual(expected, actual);
		}

	}
}

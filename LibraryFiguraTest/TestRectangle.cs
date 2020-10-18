using System;
using FigursLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryFiguraTest
{
	[TestClass]
	public class TestRectangle
	{
		[TestMethod]
		public void Perimetr_4and5_18returned()
		{
			double width = 4;
			double height = 5;
			double expected = 18;

			Figura figura = new Rectangle(width, height);
			double actual = figura.Perimetr();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Square_4and5_20returned()
		{
			double width = 4;
			double height = 5;
			double expected = 20;

			Figura figura = new Rectangle(width, height);
			double actual = figura.Square();

			Assert.AreEqual(expected, actual);
		}

	}
}

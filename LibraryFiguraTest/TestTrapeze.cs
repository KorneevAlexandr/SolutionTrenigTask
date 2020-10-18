using System;
using FigursLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryFiguraTest
{
	[TestClass]
	public class TestTrapeze
	{
		[TestMethod]
		public void Perimetr_13and7and5and5_30returned()
		{
			double basis = 13;
			double top = 7;
			double left = 5;
			double right = 5;
			double expected = 30;

			Figura figura = new Trapeze(basis, top, left, right);
			double actual = figura.Perimetr();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Square_13and7and5and5_40returned()
		{
			double basis = 13;
			double top = 7;
			double left = 5;
			double right = 5;
			double expected = 40;

			Figura figura = new Trapeze(basis, top, left, right);
			double actual = figura.Square();

			Assert.AreEqual(expected, actual);
		}

	}
}

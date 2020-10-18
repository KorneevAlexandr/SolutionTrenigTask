using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
	/// <summary>
	/// Класс с реализацие функций (логики)
	/// </summary>
	public class Options
	{
		List<Figura> NumerCircle = new List<Figura>();
		List<Figura> NumerQuadrate = new List<Figura>();
		List<Figura> NumerRectangle = new List<Figura>();
		List<Figura> NumerTriangle = new List<Figura>();
		List<Figura> NumerTrapeze = new List<Figura>();

		/// <summary>
		/// Инициализация полей класса (списков объектов)
		/// </summary>
		/// <param name="NumerCircle">Список окружностей</param>
		/// <param name="NumerQuadrate">Список квадратов</param>
		/// <param name="NumerRectangle">Список прямоугольников</param>
		/// <param name="NumerTriangle">Список треугольников</param>
		/// <param name="NumerTrapeze">Список трапеций</param>
		public Options(List<Figura> NumerCircle, List<Figura> NumerQuadrate, 
			List<Figura> NumerRectangle, List<Figura> NumerTriangle, List<Figura>NumerTrapeze)
		{
			for (int i = 0; i < NumerCircle.Count; i++)
				this.NumerCircle.Add(NumerCircle[i]);

			for (int i = 0; i < NumerQuadrate.Count; i++)
				this.NumerQuadrate.Add(NumerQuadrate[i]);

			for (int i = 0; i < NumerRectangle.Count; i++)
				this.NumerRectangle.Add(NumerRectangle[i]);

			for (int i = 0; i < NumerTriangle.Count; i++)
				this.NumerTriangle.Add(NumerTriangle[i]);

			for (int i = 0; i < NumerTrapeze.Count; i++)
				this.NumerTrapeze.Add(NumerTrapeze[i]);
		}

		/// <summary>
		/// Приватный метод, вычилсяющий периметр и площадь определенного типа фигуры
		/// </summary>
		/// <param name="TypeFigura">Список фигур определенного типа</param>
		/// <param name="NameFigura">Имя фигуры</param>
		/// <returns>Строка, содержащая информацию о всех фигурах одного типа</returns>
		private string PopertyOneType(List<Figura> TypeFigura, string NameFigura)
		{
			string itog_type;
			itog_type = "";
			int x;
			x = 1;
			foreach (Figura figur in TypeFigura)
			{
				itog_type += "\n" + NameFigura + " №" + Convert.ToString(x);
				itog_type += ("\nP = " + Convert.ToString(Math.Round(figur.Perimetr(), 2)) + "\nS = ");
				itog_type += (Convert.ToString(Math.Round(figur.Square(), 2)));
				x += 1;
			}
			return itog_type;
		}

		/// <summary>
		/// Метод вывода периметра и площади всех фигур
		/// </summary>
		/// <returns>Строка с значениями периметра и площадей всех фигур</returns>
		public string AllProperty()
		{
			string itog;
			itog = PopertyOneType(NumerCircle, "Circle") + "\n";
			itog += PopertyOneType(NumerQuadrate, "Quadrate") + "\n";
			itog += PopertyOneType(NumerRectangle, "Rectangle") + "\n";
			itog += PopertyOneType(NumerTriangle, "Triangle") + "\n";
			itog += PopertyOneType(NumerTrapeze, "Trapeze") + "\n";

			return itog;
		}

		/// <summary>
		/// Метод нахождения максимального значения площади среди всех фигур
		/// </summary>
		/// <returns>Численное значение максимальной площади</returns>
		public double Compare()
		{
			double max_square = 0;
			foreach (Figura figur in NumerCircle)
				max_square = (max_square < figur.Square()) ? figur.Square() : max_square;
			foreach (Figura figur in NumerQuadrate)
				max_square = (max_square < figur.Square()) ? figur.Square() : max_square;
			foreach (Figura figur in NumerRectangle)
				max_square = (max_square < figur.Square()) ? figur.Square() : max_square;
			foreach (Figura figur in NumerTriangle)
				max_square = (max_square < figur.Square()) ? figur.Square() : max_square;
			foreach (Figura figur in NumerTrapeze)
				max_square = (max_square < figur.Square()) ? figur.Square() : max_square;

			return max_square;
		}

		/// <summary>
		/// Метод нахождения периметра фигур
		/// </summary>
		/// <param name="TypeFigura">Список фигур</param>
		/// <param name="best_type">Строка, содержащая название типа фигуры, которая содержит макс. периметр</param>
		/// <param name="max_perimetr">Численное значение максимального периметра</param>
		/// <param name="NameFigura">Строка, содержащая имя типа фигуры</param>
		private void BiggerFigura(List<Figura> TypeFigura, ref string best_type, 
			ref double max_perimetr, string NameFigura)
		{
			foreach (Figura figur in TypeFigura)
				if (figur.Perimetr() > max_perimetr)
				{
					max_perimetr = figur.Perimetr();
					best_type = NameFigura;
				}
		}

		/// <summary>
		/// Метод нахождения типа фигуры, у которого максимальный периметр
		/// </summary>
		/// <returns>Строка с наименованием типа фигуры и значением макс.периметра</returns>
		public string BiggerType()
		{
			double max_perimetr;
			string best_type;
			max_perimetr = 0;
			best_type = "";
			BiggerFigura(NumerCircle, ref best_type, ref max_perimetr, "Circle:");
			BiggerFigura(NumerQuadrate, ref best_type, ref max_perimetr, "Quadrate:");
			BiggerFigura(NumerRectangle, ref best_type, ref max_perimetr, "Rectangle:");
			BiggerFigura(NumerTriangle, ref best_type, ref max_perimetr, "Triangle:");
			BiggerFigura(NumerTrapeze, ref best_type, ref max_perimetr, "Trapeze:");
	
			best_type += " P = " + Convert.ToString(max_perimetr);
			return best_type;
		}

	}
}

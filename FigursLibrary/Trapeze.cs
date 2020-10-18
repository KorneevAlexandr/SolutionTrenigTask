using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
	/// <summary>
	/// Класс для трапеций
	/// </summary>
	public class Trapeze : Figura
	{
		/// <summary>
		/// Основание трапеции
		/// </summary>
		double bottom;
		/// <summary>
		/// Верхнее основание трапеции
		/// </summary>
		double top;
		/// <summary>
		/// Левая сторона трапеции
		/// </summary>
		double left_side;
		/// <summary>
		/// правая сторона трапеции
		/// </summary>
		double right_side;

		/// <summary>
		/// Конструктор, инициализая сторон трапеции
		/// </summary>
		/// <param name="bottom">Основание трапеции</param>
		/// <param name="top">Верхнее основание трапеции</param>
		/// <param name="left_side">Левая сторона трапеции</param>
		/// <param name="right_side">Правая сторона трапеции</param>
		public Trapeze(double bottom, double top, double left_side, double right_side)
		{
			this.bottom = bottom;
			this.top = top;
			this.left_side = left_side;
			this.right_side = right_side;
		}

		/// <summary>
		/// Метод вычисления периметра трапеции
		/// </summary>
		/// <returns>Значение периметра</returns>
		public override double Perimetr()
		{
			return bottom + top + left_side + right_side;
		}

		/// <summary>
		/// Метод вычисления площади трапеции
		/// </summary>
		/// <returns>Значение площади</returns>
		public override double Square()
		{
			double a, b, c, d;
			a = bottom;
			b = top;
			c = left_side;
			d = right_side;

			double S;
			S = (Math.Pow((a - b), 2) + c * c - d * d) / (2 * (a - b));
			S = (Math.Sqrt((c * c) - (S * S)) * ((a + b) / 2));
			return S;
		}

	}
}

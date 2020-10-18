using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
	/// <summary>
	/// Класс для треугольников
	/// </summary>
	public class Triangle : Figura
	{
		/// <summary>
		/// основание треугольника
		/// </summary>
		double basis;
		/// <summary>
		/// Левая сторона треугольника
		/// </summary>
		double left;
		/// <summary>
		/// Правая сторона треугольника
		/// </summary>
		double right;

		/// <summary>
		/// Конструктор, инициализация длин сторон треугольника
		/// </summary>
		/// <param name="basis">Основание треугольника</param>
		/// <param name="left">Левая сторона треугольника</param>
		/// <param name="right">Правая сторона треугольника</param>
		public Triangle(double basis, double left, double right)
		{
			this.basis = basis;
			this.left = left;
			this.right = right;
		}

		/// <summary>
		/// Метод вычисления периметра треугольника
		/// </summary>
		/// <returns>Значение периметра</returns>
		public override double Perimetr()
		{
			return basis + left + right;
		}

		/// <summary>
		/// Метод вычисления площади треугольника (формула Герона)
		/// </summary>
		/// <returns>Значение площади</returns>
		public override double Square()
		{
			double P;
			P = Perimetr() / 2;
			return Math.Sqrt(P * (P - basis) * (P - left) * (P - right));
		}

	}
}

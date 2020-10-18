using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
	/// <summary>
	/// Класс для квадратов
	/// </summary>
	public class Quadrate : Figura
	{
		/// <summary>
		/// Длина стороны квадрата
		/// </summary>
		private double length_side;

		/// <summary>
		/// Конструктор для иницализации длины стороны квадрата
		/// </summary>
		/// <param name="length_side">Аргумент, длина стороны квадрата</param>
		public Quadrate(double length_side)
		{
			this.length_side = length_side;
		}

		/// <summary>
		/// Метод вычисления периметра квадрата
		/// </summary>
		/// <returns>Значение периметра</returns>
		public override double Perimetr()
		{
			return length_side * 4;
		}

		/// <summary>
		/// Метод вычисления площади квадрата
		/// </summary>
		/// <returns>Значение площади</returns>
		public override double Square()
		{
			return length_side * length_side;
		}

	}
}

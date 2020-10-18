using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
	/// <summary>
	/// Класс для окружностей
	/// </summary>
	public class Circle : Figura
	{
		/// <summary>
		/// Длина радиуса окружности
		/// </summary>
		private double radius;

		/// <summary>
		/// Конструктор для иницализации радиуса окружности
		/// </summary>
		/// <param name="radius">Аргумент, радиус окружности</param>
		public Circle(double radius)
		{
			this.radius = radius;
		}

		/// <summary>
		/// Метод вычисления периметра окружности
		/// </summary>
		/// <returns>Значение периметра</returns>
		public override double Perimetr()
		{
			return Math.Round(2 * Math.PI * radius, 2);
		}

		/// <summary>
		/// Метод вычисления площади окружности
		/// </summary>
		/// <returns>Значение площади</returns>
		public override double Square()
		{
			return Math.Round(radius * radius * Math.PI, 2);
		}

	}
}

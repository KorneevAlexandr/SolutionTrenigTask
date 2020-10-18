using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
	/// <summary>
	/// Класс для прямоугольников
	/// </summary>
	public class Rectangle : Figura
	{
		/// <summary>
		/// Длина прямоугольника 
		/// </summary>
		private double width;
		/// <summary>
		/// Высота прямоугольника
		/// </summary>
		private double height;

		/// <summary>
		/// Конструктор, инициализация длин сторон прямоугольника
		/// </summary>
		/// <param name="width">Длина прямоугольника</param>
		/// <param name="height">Высота прямоугольника</param>
		public Rectangle(double width, double height)
		{
			this.width = width;
			this.height = height;
		}

		/// <summary>
		/// Метод вычисления периметра прямоугольника
		/// </summary>
		/// <returns>Значение периметра</returns>
		public override double Perimetr()
		{
			return (width + height) * 2;
		}

		/// <summary>
		/// Метод вычисления площади прямоугольника
		/// </summary>
		/// <returns>Значение площади</returns>
		public override double Square()
		{
			return width * height;
		}
	}
}

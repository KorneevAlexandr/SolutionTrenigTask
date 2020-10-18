using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
	/// <summary>
	/// Класс для фабричного метода создания объектов
	/// </summary>
	public class FabricObject
	{
		/// <summary>
		/// Фабричный метод создания объектов
		/// </summary>
		/// <param name="NameFigure">Имя фигуры</param>
		/// <param name="value">Аргументы для этой фигуры</param>
		/// <returns></returns>
		public Figura CreateFigure(string NameFigure, double[] value)
		{
			Figura figura = null;

			switch (NameFigure)
			{
				case "Circle(radius):" :
				    figura = new Circle(value[0]);
					break;

				case "Quadrate(length):" :
					figura = new Quadrate(value[0]);
					break;

				case "Rectangle(width, height):" :
					figura = new Rectangle(value[0], value[1]);
					break;

				case "Triangle(three sides):" :
					figura = new Triangle(value[0], value[1], value[2]);
					break;

				case "Trapeze(four sides):" :
					figura = new Trapeze(value[0], value[1], value[2], value[3]);
					break;

				default:
					Console.WriteLine("В вашем текстовом документе есть ошибки заполнения");
					break;
			}
			return figura;
		}
	}
}

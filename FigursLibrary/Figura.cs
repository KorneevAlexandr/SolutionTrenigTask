using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
	/// <summary>
	/// Абстрактный родительский класс фигур
	/// </summary>
	abstract public class Figura
	{
		/// <summary>
		///  абстрактная функция периметра
		/// </summary>
		/// <returns>Числовое значение периметра фигуры</returns>
		abstract public double Perimetr();

		/// <summary>
		///  абстрактная функция площади
		/// </summary>
		/// <returns>Числовое значение площади фигуры</returns>
		abstract public double Square();

		
	}
}

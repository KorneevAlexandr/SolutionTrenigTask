using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursLibrary
{
	/// <summary>
	/// Класс, содержищий интерфейс пользователя
	/// </summary>
	public class ShowMenu
	{
		/// <summary>
		/// Метод вывода меню на экран
		/// </summary>
		/// <param name="options">Объект класса Options для необходимых функций</param>
		public void Menu(Options options)
		{
			int user;
			user = 0;
			while (user != 4)
			{
				Console.WriteLine("\n\tМеню");
				Console.WriteLine("1 - Вывод площади и периметра всех фигур");
				Console.WriteLine("2 - Найти фигуру большей площади");
				Console.WriteLine("3 - Найти тип фигуры с наибольшим значением периметра среди других типов");
				Console.WriteLine("4 - Выход");

				Console.WriteLine("Выберите пункт меню: ");
				try
				{
					user = Convert.ToInt32(Console.ReadLine());
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Console.ReadKey();
					continue;
				}

				switch (user)
				{
					case 1:
						Console.WriteLine("\nПлощади и периметры всех фигур: ");
						Console.WriteLine(options.AllProperty());
						break;
					case 2:
						Console.WriteLine("\nМаксимальная площадь фигуры = " + options.Compare());
						break;
					case 3:
						Console.WriteLine("Тип фигуры, у которой самый большой периметр: ");
						Console.WriteLine(options.BiggerType());
						break;
					case 4:
						Console.WriteLine("До свидания");
						break;

					default:
						Console.WriteLine("Такого пункта нет в меню, попробуйте еще");
						break;
				}

				Console.WriteLine("\nПонятно (Enter): ");
				Console.ReadKey();
				}

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigursLibrary;

namespace TreningTask
{
	/// <summary>
	/// Beginner class.
	/// </summary>
	class Program
	{
		/// <summary>
		/// Метод Main() является входной точкой работы программы
		/// </summary>
		/// <param name="args">аргумент Main()</param>
		static void Main(string[] args)
		{
			ReadFileValue read_file = new ReadFileValue();
			read_file.Start();	
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FigursLibrary
{
    /// <summary>
    /// Класс для считывания текстовоо файла.
    /// </summary>
    public class ReadFileValue
    {
        /// <summary>
        /// Метод считывания файла и 
        /// создание списков с объектами
        /// </summary>
        public void Start()
        {
            List<Figura> NumerCircle = new List<Figura>();
            List<Figura> NumerQuadrate = new List<Figura>();
            List<Figura> NumerRectangle = new List<Figura>();
            List<Figura> NumerTriangle = new List<Figura>();
            List<Figura> NumerTrapeze = new List<Figura>();

            FabricObject make_object = new FabricObject();

            string path = @"D:\Task\TreningTask\FigursLibrary\FigursParams.txt";
            string res;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    res = sr.ReadToEnd();
                    string[] lines = res.Split(new char[] { '\n' });
                    int number_figura;
                    number_figura = 0;
                    for (int i = 1; i < lines.Length; i++)
                    {
                        try
                        {
                            string[] value_string_mas = lines[i].Split(new char[] { ' ' });
                            double[] value_mas = new double[lines.Length];
                            for (int j = 0; j < value_string_mas.Length; j++)
                                value_mas[j] = Convert.ToDouble(value_string_mas[j]);
                            if (number_figura == 0)
                                NumerCircle.Add(make_object.CreateFigure("Circle(radius):", value_mas));
                            else if (number_figura == 1)
                                NumerQuadrate.Add(make_object.CreateFigure("Quadrate(length):", value_mas));
                            else if (number_figura == 2)
                                NumerRectangle.Add(make_object.CreateFigure("Rectangle(width, height):", value_mas));
                            else if (number_figura == 3)
                                NumerTriangle.Add(make_object.CreateFigure("Triangle(three sides):", value_mas));
                            else if (number_figura == 4)
                                NumerTrapeze.Add(make_object.CreateFigure("Trapeze(four sides):", value_mas));
                        }
                        catch 
                        {
                            number_figura++;
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Options options = new Options(NumerCircle, NumerQuadrate, NumerRectangle, NumerTriangle, NumerTrapeze);

            ShowMenu show_menu = new ShowMenu();
            show_menu.Menu(options);
        }
    }
}

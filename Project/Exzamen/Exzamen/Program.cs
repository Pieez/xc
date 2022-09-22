using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Exzamen
{
    /// <summary>
    ///   Основной метод программы 
    /// </summary>
  
        /// <summary>
        /// Выполнение простых математических действий над числами
        /// </summary>
        public class Calculator
        {
            /// <summary>
            /// Получаем результат операции деления (n1 / n2)
            /// </summary>
            /// <param name="n1">Первое число</param>
            /// <param name="n2">Второе число</param>
            /// <returns>Результат</returns>
            public double Div(double n1, double n2)
            {
                // Проверка деления на "0"
                if (n2 == 0.0D)
                    throw new DivideByZeroException();
                return n1 / n2;
            }

            /// <summary>
            /// Получаем результат сложения чисел и их увеличения на единицу
            /// </summary>
            /// <param name="n1"></param>
            /// <param name="n2"></param>
            /// <returns></returns>
            public double AddWithInc(double n1, double n2)
            {
                return n1 + n2 + 1;
            }
        }











    internal class Program
    {





        abstract class Trans
            {


                public double height;// высота кузова
                public double lengt; // длина кузова
                public double kuzov; // кузов
                public double liftPower; //грузоподьемность

                public Trans(double m, double numb, double s, double lif_pow)
                {
                    //привязки

                    height = m;
                    lengt = numb;
                    kuzov = s;
                    liftPower = lif_pow;
                }

                public void Print()
                {
                    Console.WriteLine("\nВысота кузова: {0} \nКузов {1}\nДлина кузова: {2}\nГрузоподьемность: {3} ", height, kuzov, lengt, liftPower);// для вывода на экран
                    Console.WriteLine();
                }
            }



            //подсчет грузовых
            class Gruzovie : Trans
            {
                public bool pricep;
                public Gruzovie(double m, double s, double numb, double lif_pow, bool pric)
                : base(m, numb, s, lif_pow)
                {
                    pricep = pric;
                    if (pricep == true)
                        lif_pow = 2 * lif_pow;
                }
            }

            class Programm
            {
                static void Main(string[] args)
                {
                    TextWriterTraceListener[] listeners = new TextWriterTraceListener[] {
                    new TextWriterTraceListener("\\main\\RDP\\43П\\СмолинИА\\Desktop\\Project pm 02\\Project Muhin\\Test.txt"),  // указать путь
                    new TextWriterTraceListener(Console.Out)};
                    Debug.Listeners.AddRange(listeners);
                    Debug.WriteLine("Ошибка"); // то что пишет в файл и в консоль
                    Debug.Flush();

                    //Определить тип грузовика
                    Gruzovie one11 = new Gruzovie(1.8, 12, 3.5, 1500, true);
                    one11.Print();//вывод груза
                    StreamReader fileObj = new StreamReader("\\main\\RDP\\43П\\СмолинИА\\Desktop\\Project pm 02\\Project Muhin\\Vivod.txt");



                Console.ReadKey();
                }
            }
        }
    }


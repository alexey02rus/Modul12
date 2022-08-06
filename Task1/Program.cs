using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool beR;
            bool beX;
            bool beY;
            double r;
            double x;
            double y;
            Console.WriteLine("Введите радиус окружности и координаты точки");
            do
            {
                Console.Write("R = ");
                beR = double.TryParse(Console.ReadLine(), out r);
                if (!beR || r<= 0)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных. Попробуйте ещё раз.");
                }
            } while (!beR);
            do
            {
                Console.Write("X = ");
                beX = double.TryParse(Console.ReadLine(), out x);
                if (!beX)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных. Попробуйте ещё раз.");
                }
            } while (!beX);
            do
            {
                Console.Write("Y = ");
                beY = double.TryParse(Console.ReadLine(), out y);
                if (!beY)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных. Попробуйте ещё раз.");
                }
            } while (!beY);
            Console.WriteLine();
            Console.WriteLine($"Длина окружности: {Math.Round(Circle.GetLength(r), 3, MidpointRounding.AwayFromZero)}");
            Console.WriteLine($"Площадь круга: {Math.Round(Circle.GetArea(r), 3, MidpointRounding.AwayFromZero)}");
            if (Circle.PointBelongs(r, x, y))
            {
                Console.WriteLine($"Указанная точка с координатами {x}:{y} принадлежит кругу радиусом {r} и координатами центра 0:0");
            }
            else
            {
                Console.WriteLine($"Указанная точка с координатами {x}:{y} не принадлежит кругу радиусом {r} и координатами центра 0:0");
            }
            Console.ReadKey();
        }
    }
}

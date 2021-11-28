using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    //Разработать статический класс для работы с окружностью.Класс должен содержать 3 метода:
    //метод, определяющий длину окружности по заданному радиусу;
    //метод, определяющий площадь круга по заданному радиусу;
    //метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.

    class Program
    {
        static void Main(string[] args)
        {

            double radius = ReadValue("Введите пожалуйста значение радиуса:");
            try
            {
                Console.WriteLine($"Длина окружности с радиусом {radius}, составляет: {Circle.Length(radius):f2}");
                Console.WriteLine($"Площадь окружности с радиусом {radius}, составляет: {Circle.Area(radius):f2}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            try
            {
                Console.WriteLine("Введите пожалуйста координаты центра окружности:");
                double centerCircle_x0 = ReadValue("x0:");
                double centerCircle_y0 = ReadValue("y0:");
                Console.WriteLine("Введите пожалуйста координаты точки для проверки принадлежности к кругу:");
                double point_x = ReadValue("x:");
                double point_y = ReadValue("y:");
                radius = ReadValue("Введите пожалуйста значение радиуса:");
                Console.WriteLine($"Точка с указанными координатами X: {point_x} Y: {point_y} {(Circle.PointPosition(radius, centerCircle_x0, centerCircle_y0, point_x, point_y) == true ? "принадлежит" : "не принадлежит")} " +
                    $"плоскости ограниченной окружностью с радиусом: {radius} и центром в точке X: {centerCircle_x0} Y: {centerCircle_y0}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadKey();
        }
        static double ReadValue(string text)   //метод проверяющий корректность ввода данных
        {
            double value;
            while (true)
            {
                Console.WriteLine(text);
                if (Double.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Ввод некорректен");
                }
            }
        }
    }
}





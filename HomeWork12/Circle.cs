using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    public static class Circle
    {
        public const double PI = 3.1415926535897931;   

        public static double Length(double radius)      //метод возвращает значение длины окружности
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус не может быть нулевым или отрицательным значением");
            }
            else
            {
                double circleLength = 2 * PI * radius;
                return circleLength;
            }
        }
        public static double Area(double radius)      //метод возвращает значение площади круга
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус не может быть нулевым или отрицательным значением");
            }
            else
            {
                double circleArea = Math.Pow(radius, 2) * PI;
                return circleArea;
            }
        }
        public static bool PointPosition(double radius, double centerCircleX0, double centerCircleY0, double pointX, double pointY)     //Метод определяет принадлежит ли точка с координатами x,y плоскостиб ограниченной окружностью с радиусом r и координатами центра x0, y0
        {                                                                                                                               //в параметрах метода указывается:
            bool value;                                                                                                                 //(радиус окружности, координата x центра окружности, координата y центра окружности, координата x проверяемой точки, координата y проверяемой точки) 
            if (radius <= 0)                                                                                                            //метод возвращает булевое значение true, если принадлежит и соответственно false если нет
            {
                throw new Exception("Радиус не может быть нулевым или отрицательным значением");
            }
            else if (Math.Sqrt(Math.Pow(pointX - centerCircleX0, 2) + Math.Pow(pointY - centerCircleY0, 2)) <= radius)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return value;
        }
    }
}

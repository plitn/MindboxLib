using System;

namespace MindboxLib
{
    public class Triangle : IFigure
    {
        private int a, b, c;
        private bool isRightAnge = false;
        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Реализуем интерфейс, площадь
        /// Тут логика не лучшая, можно вынести в отдельный метод определение прямоугольности и катетов
        /// </summary>
        /// <returns>Площадь либо произведение катетов, либо по формуле Герона</returns>
        public double getArea()
        {
            if (c * c == a * a + b * b)
            {
                isRightAnge = true;
                return a * b;
            }
            else if (a * a == b * b + c * c)
            {
                isRightAnge = true;
                return b * c;
            }
            else if (b * b == c * c + a * a)
            {
                isRightAnge = true;
                return c * a;
            }
            double p = this.getPerimeter() / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Реализуем интерфейс, периметр
        /// </summary>
        /// <returns>Периметр</returns>
        public double getPerimeter()
        {
            return a + b + c;
        }

        public bool isRight()
        {
            return isRightAnge;
        }
    }
}

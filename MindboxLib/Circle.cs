using System;


namespace MindboxLib
{
    public class Circle : IFigure
    {
        private int radius;
        public Circle()
        {
            radius = 0;
        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Реализуем интерфейс, площадь
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Реализуем интерфейс, периметер
        /// </summary>
        /// <returns>Периметер окружности</returns>
        public double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}

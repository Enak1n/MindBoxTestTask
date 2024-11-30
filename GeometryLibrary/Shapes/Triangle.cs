using GeometryLibrary.Exceptions;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    internal class Triangle : IShape
    {
        /// <summary>
        /// Сторона 1.
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Сторона 2.
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Сторона 3.
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Конструктор для создания фигуры типа треугольник.
        /// </summary>
        /// <param name="sideA">Сторона 1.</param>
        /// <param name="sideB">Сторона 2.</param>
        /// <param name="sideC">Сторона 3.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        ///<inheritdoc/>
        public double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        /// <summary>
        /// Проверка прямоугольный ли треугольник.
        /// </summary>
        /// <returns>Является ли треугольник прямоугольным.</returns>
        public bool IsTheTriangleRectangular()
        {
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
                   Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2) ||
                   Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
        }
    }
}

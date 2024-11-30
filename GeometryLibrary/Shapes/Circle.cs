using GeometryLibrary.Exceptions;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Круг.
    /// </summary>
    internal class Circle : IShape
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор для создания фигуры типа круг.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        ///<inheritdoc/>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

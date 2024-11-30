using GeometryLibrary.Exceptions;
using GeometryLibrary.Interfaces;
using GeometryLibrary.Shapes;

namespace GeometryLibrary.Factories
{
    /// <summary>
    /// Конкретная фабрика для создания объектов типа круг.
    /// </summary>
    public class CircleFactory : ShapeFactory
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        private readonly double _radius;

        /// <summary>
        /// Конструктор для создания фабрики.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        public CircleFactory(double radius) 
        {
            _radius = radius;
        }

        ///<inheritdoc/>
        public override IShape CreatreShape()
        {
            if (_radius <= 0)
                throw new InvalidShapeException("Радиус должен быть положительным числом.");

            var circle = new Circle(_radius);

            return circle;
        }
    }
}

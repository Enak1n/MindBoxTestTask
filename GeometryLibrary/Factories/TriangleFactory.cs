﻿using GeometryLibrary.Exceptions;
using GeometryLibrary.Interfaces;
using GeometryLibrary.Shapes;

namespace GeometryLibrary.Factories
{
    /// <summary>
    /// Конкретная фабрика для создания объектов типа треугольник.
    /// </summary>
    public class TriangleFactory : ShapeFactory
    {
        /// <summary>
        /// Сторона 1. 
        /// </summary>
        private readonly double _sideA;

        /// <summary>
        /// Сторона 2.
        /// </summary>
        private readonly double _sideB;

        /// <summary>
        /// Сторона 3.
        /// </summary>
        private readonly double _sideC;

        /// <summary>
        /// Конструкторо для создания объекта.
        /// </summary>
        /// <param name="sideA">Сторона 1.</param>
        /// <param name="sideB">Сторона 2.</param>
        /// <param name="sideC">Сторона 3.</param>
        public TriangleFactory(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        ///<inheritdoc/>
        public override IShape CreateShape()
        {
            if (_sideA <= 0 || _sideB <= 0 || _sideC <= 0)
                throw new InvalidShapeException("Стороны должны быть положительными числами.");

            if (_sideA + _sideB <= _sideC || _sideA + _sideC <= _sideB || _sideB + _sideC <= _sideA)
                throw new InvalidShapeException("Треугольник с такими сторонами не существует.");

            var triangle = new Triangle(_sideA, _sideB, _sideC);

            return triangle;
        }
    }
}

using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Factories
{
    /// <summary>
    /// Фабрика для создания фигур.
    /// </summary>
    public abstract class ShapeFactory
    {
        /// <summary>
        /// Метод создающий фигуру.
        /// </summary>
        /// <returns>Возвращает фигуру реализующую интерфейс IShape.</returns>
        public abstract IShape CreatreShape();
    }
}

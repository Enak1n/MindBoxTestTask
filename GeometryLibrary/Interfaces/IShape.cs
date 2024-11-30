namespace GeometryLibrary.Interfaces
{
    /// <summary>
    /// Общий интерфейс для рабоыт с фигурами.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Рассчитать площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        double CalculateArea();
    }
}

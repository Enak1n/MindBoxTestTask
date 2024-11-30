namespace GeometryLibrary.Exceptions
{
    /// <summary>
    /// Кастомное исключение для фигур.
    /// </summary>
    internal class InvalidShapeException : Exception
    {
        /// <summary>
        /// Исключение с сообщением.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        public InvalidShapeException(string message) : base(message) { }

        /// <summary>
        /// Исключение без сообщения.
        /// </summary>
        public InvalidShapeException() : base() { }
    }
}

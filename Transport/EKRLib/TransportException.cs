using System;

namespace EKRLib
{
    /// <summary>
    /// Класс для вывода ошибки.
    /// </summary>

    [Serializable]
    public class TransportException : Exception
    {
        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public TransportException() { }
        /// <summary>
        /// Конструктор при ошибке.
        /// </summary>
        /// <param name="message">Сообщение ошибки.</param>
        public TransportException(string message) : base(message) { }
        /// <summary>
        /// Конструктор при ошибке.
        /// </summary>
        /// <param name="message">Сообщение ошибки.</param>
        /// <param name="inner">Внутреннее исключение.</param>
        public TransportException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Конструктор при ошибке.
        /// </summary>
        /// <param name="info">Информация об ошибке.</param>
        /// <param name="context">Содержание ошибки.</param>
        protected TransportException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

namespace EKRLib
{
    /// <summary>
    /// Класс для описания лодки.
    /// </summary>
    public class MotorBoat : Transport
    {
        /// <summary>
        /// Конструктор для лодки.
        /// </summary>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность.</param>
        public MotorBoat(string model, int power) : base(model, power)
        {
        }
        /// <summary>
        /// изадет Звук при запуске.
        /// </summary>
        /// <returns>Возвращает Звук при запуске.</returns>
        public override string StartEngine()
        {
            return $"{Model}: Brrrbrr";
        }
        /// <summary>
        /// Выводит характеристики машины.
        /// </summary>
        /// <returns>характеристики машины.</returns>
        public override string ToString()
        {
            return "MotorBoat. " + base.ToString();
        }
    }
}

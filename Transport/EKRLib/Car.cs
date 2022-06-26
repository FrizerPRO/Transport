namespace EKRLib
{
    /// <summary>
    /// Класс для описания автомобиля.
    /// </summary>
    public class Car : Transport
    {
        /// <summary>
        /// Конструктор для Машины.
        /// </summary>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность.</param>
        public Car(string model, int power) : base(model, power)
        {
        }
        /// <summary>
        /// изадет Звук при запуске.
        /// </summary>
        /// <returns>Возвращает Звук при запуске.</returns>
        public override string StartEngine()
        {
            return $"{Model}: Vroom";
        }
        /// <summary>
        /// Выводит характеристики машины.
        /// </summary>
        /// <returns>характеристики машины.</returns>
        public override string ToString()
        {
            return "Car. " + base.ToString();
        }
    }
}

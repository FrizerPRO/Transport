namespace EKRLib
{
    /// <summary>
    /// Абстрактный класс для общих характеристик транспортных средств.
    /// </summary>
    public abstract class Transport
    {
        private string model;
        /// <summary>
        /// Модель ТС.
        /// </summary>
        internal string Model
        {

            get => model;
            set
            {

                foreach (char item in value)
                {
                    if (!((item <= 'Z' && item >= 'A') || (item <= '9' && item >= '0')) || value.Length != 5)
                    {
                        throw new TransportException($"Недопустимая модель {value}");
                    }
                }
                model = value;
            }
        }

        private int power;
        /// <summary>
        /// Мощность двигателя ТС.
        /// </summary>
        private int Power
        {
            get => power;
            set
            {
                if (value < 20)
                {
                    throw new TransportException("мощность не может быть меньше 20 л.с.");
                }
                power = value;
            }
        }
        /// <summary>
        /// Возвращает строку с общими характеристиками ТС.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Model:{Model}, Power: {Power}";
        }
        /// <summary>
        /// изадет Звук при запуске.
        /// </summary>
        /// <returns>Возвращает Звук при запуске.</returns>
        public abstract string StartEngine();
        /// <summary>
        /// Конструктор для ТС.
        /// </summary>
        /// <param name="model">Модель.</param>
        /// <param name="power">Мощность.</param>
        public Transport(string model, int power)
        {
            Model = model;
            Power = power;
        }
    }
}

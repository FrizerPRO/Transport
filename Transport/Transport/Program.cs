using EKRLib;
using System;
using System.IO;
using System.Text;

namespace TransportConsole
{
    /// <summary>
    /// Основная программа.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод Main.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Random random = new();
                int emountOfElements = random.Next(6, 10);
                Transport[] transportArray = new Transport[emountOfElements];
                FillTechArray(random, emountOfElements, transportArray);
                WriteToFile(transportArray);
                Console.WriteLine("чтобы завершить программу нажмите Enter. Любую другую кнопку чтобы продолжить.");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

        }
        /// <summary>
        /// Заполняет массив по указанным правилам.
        /// </summary>
        /// <param name="random">Рандоное число.</param>
        /// <param name="emountOfElements">Кол-во эллементов.</param>
        /// <param name="transportArray">Массив транспортов.</param>
        private static void FillTechArray(Random random, int emountOfElements, Transport[] transportArray)
        {
            for (int i = 0; i < emountOfElements; i++)
            {
                int chooseClass = random.Next(0, 2);
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                string modelName = "";
                for (int j = 0; j < 5; j++)
                {
                    modelName += chars[random.Next(0, chars.Length)];
                }
                try
                {
                    transportArray[i] = chooseClass switch
                    {
                        0 => new Car(modelName, random.Next(10, 100)),
                        1 => new MotorBoat(modelName, random.Next(10, 100)),
                        _ => null
                    };
                    Console.WriteLine(transportArray[i].StartEngine());
                }
                catch (TransportException exception)
                {
                    Console.WriteLine(exception.Message);
                    i--;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
        /// <summary>
        /// Запись в файл.
        /// </summary>
        /// <param name="transportArray">Массив транспортов.</param>
        private static void WriteToFile(Transport[] transportArray)
        {
            string carsData = "";
            string boatsData = "";
            foreach (Transport tech in transportArray)
            {

                if (tech is Car)
                {
                    carsData += tech.ToString() + "\n";
                }
                else if (tech is MotorBoat)
                {
                    boatsData += tech.ToString() + "\n";
                }
            }
            File.WriteAllText("..\\..\\..\\..\\Cars.txt", carsData, Encoding.Unicode);
            File.WriteAllText("..\\..\\..\\..\\MotorBoats.txt", boatsData, Encoding.Unicode);
        }
    }
}

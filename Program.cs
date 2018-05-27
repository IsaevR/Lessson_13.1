using System;
using System.IO;

namespace Lesson_13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\tПрограмма ШИФР ЦЕЗАРЯ");
            Console.WriteLine("\n\n\t\t\tВиберите действия");
            Console.WriteLine(" 1. Зашифровать файл\n 2. Декодировать файл\n 3. Криптоанализатор");
            
            Console.Write("\n\t\t\t\t:_\b");
            int action = int.Parse(Console.ReadLine());
            string path;
            int k;
            switch (action)
            {
                case 1:
                    Console.Write("\n\nВведите путь к файлу, который  будет зашифрован : ");
                    path = Console.ReadLine();
                    Console.Write("Введите ключ для шифровки (это любое целочисленное значение) :");
                    k = int.Parse(Console.ReadLine());
                    Encryption(path, k);
                    break;
                case 2:
                    Console.Write("\n\nВведите путь к файлу, который будет расшифрован : ");
                    path = Console.ReadLine();
                    Console.Write("Введите ключ для шифровки (это любое целочисленное значение) :");
                    k = int.Parse(Console.ReadLine());
                    Decipher(path, k);
                    break;
                case 3:
                    Console.Write("\n\nВведите путь к файлу, который подлежит криптоанализу : ");
                    path = Console.ReadLine();
                    Crypto_Analyzer(path);
                    break;
                default:
                    break;
            }
           

           

           
        }
       // метод шифрующий файл 
        static void Encryption(string s, int key)
        {
            byte[] bytes = File.ReadAllBytes(s); 

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)((bytes[i] + key) % 256);
            }
            File.WriteAllBytes(s, bytes);
        }
        // метод декодирования шифрованного файла
        static void Decipher(string s, int key)
        {
            byte[] bytes = File.ReadAllBytes(s);

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)((bytes[i] - key % 256) % 256);
            }
            File.WriteAllBytes(s, bytes);
        }
        // метод для расшифровки файла без ключа (подходит только к Шифру Цезаря)
        static void Crypto_Analyzer(string s)
        {

        }
        

    }
}

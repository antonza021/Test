
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин (от 4 до 12 символов, только английские буквы):");
            string login = Console.ReadLine().Trim();

            Console.WriteLine("Введите пароль (от 6 до 18 символов, английские буквы + оба регистра + 1 цифра + 1 спец символ):");
            string password = Console.ReadLine().Trim();

            Console.WriteLine("Введите email (один символ @, одна доменная точка):");
            string email = Console.ReadLine().Trim();

            if (ValidateInput(login, password, email))
            {
                Console.WriteLine("Данные введены правильно.");
            }
            else
            {
                Console.WriteLine("Ошибка валидации данных.");
            }
        }

        static bool ValidateInput(string login, string password, string email)
        {
            // Проверка логина
            if (login.Length < 4 || login.Length > 12)
            {
                return false;
            }
            foreach (char c in login)
            {
                if (!char.IsLetter(c) || !char.IsLower(c) && !char.IsUpper(c))
                {
                    return false;
                }
            }

            // Проверка пароля
            if (password.Length < 6 || password.Length > 18)
            {
                return false;
            }
            if (!(password.Any(char.IsDigit) && password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsPunctuation)))
            {
                return false;
            }

            // Проверка email
            if (!email.Contains('@') || !email.Contains('.'))
            {
                return false;
            }

            return true;
        }
    }
}
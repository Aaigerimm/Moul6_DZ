using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moul6_DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();


            Client client1 = new Client("Koshekova Aruzhan", "01", "Aru");
            Client client2 = new Client("Bolatbek Aigerim", "02", "Aiko");
            Client client3 = new Client("Adil Uldana", "03", "Uldako");
            Client client4 = new Client("Arapova Assylzhan", "04", "Assyl");
            Client client5 = new Client("Asylbekova Aiymgul", "05", "Aiym");
            bank.AddClient(client1);
            bank.AddClient(client2);
            bank.AddClient(client3);
            bank.AddClient(client4);
            bank.AddClient(client5);

            Console.WriteLine("Добро пожаловать в банковский кабинет!");

            int attempts = 3;
            while (attempts > 0)
            {
                Console.Write("Введите номер счета: ");
                string accountNumber = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();

                Client client = bank.FindClient(accountNumber);
                if (client != null && client.Account.ValidatePassword(password))
                {
                    while (true)
                    {
                        Console.WriteLine("Меню:");
                        Console.WriteLine("a. Вывести баланс");
                        Console.WriteLine("b. Пополнить счет");
                        Console.WriteLine("c. Снять деньги");
                        Console.WriteLine("d. Выход");
                        Console.Write("Выберите действие: ");
                        char choice = Console.ReadKey().KeyChar;

                        switch (choice)
                        {
                            case 'a':
                                Console.WriteLine($"\nБаланс: {client.Account.Balance}\n");
                                break;
                            case 'b':
                                Console.Write("\nВведите сумму для пополнения: ");
                                double depositAmount = double.Parse(Console.ReadLine());
                                client.Account.Deposit(depositAmount);
                                Console.WriteLine("Счет пополнен.\n");
                                break;
                            case 'c':
                                Console.Write("\nВведите сумму для снятия: ");
                                double withdrawAmount = double.Parse(Console.ReadLine());
                                if (client.Account.Withdraw(withdrawAmount))
                                {
                                    Console.WriteLine("Сумма снята со счета.\n");
                                }
                                else
                                {
                                    Console.WriteLine("Недостаточно средств на счете.\n");
                                }
                                break;
                            case 'd':
                                Console.WriteLine("\nВыход из аккаунта.");
                                return;
                            default:
                                Console.WriteLine("\nНеправильный выбор. Пожалуйста, выберите снова.\n");
                                break;
                        }
                    }
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Неправильный номер счета или пароль. Попыток осталось: {attempts}\n");
                }
            }

            Console.WriteLine("Ваш аккаунт заблокирован! Позвоните на номер 7711 для разблакировки!");
            Console.ReadKey();
        }
    }

}

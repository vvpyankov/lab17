using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создать класс для моделирования счета в банке. Предусмотреть закрытые
 * поля для номера счета, баланса, ФИО владельца.  Класс должен быть объявлен
 * как обобщенный. Универсальный параметр T должен определять тип номера счета.
 * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
 * Создать  несколько экземпляров класса, параметризированного различными типам.
 * Заполнить его поля и вывести информацию об экземпляре класса на печать.*/
namespace lab17zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите серию и номер банковского счета :");
            string numberStr = Convert.ToString(Console.ReadLine());
            Console.Write("Укажите баланс счета в рублях:");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите полное Имя владельца (Ф.И.О.):");
            string fullname = Convert.ToString(Console.ReadLine());
            bankAccount<string> bankAcc1 = new bankAccount<string>(numberStr, balance, fullname);
            bankAcc1.accountNum = numberStr;
            bankAcc1.accountBal = balance;
            bankAcc1.fullName = fullname;
            Console.WriteLine($"Банковский счет номер:{bankAcc1.accountNum}, баланс в рублях: {bankAcc1.accountBal}, клиент: {bankAcc1.fullName}");
            Console.Write("Укажите номер банковского счета:");
            int numberInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите баланс счета в рублях:");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите полное Имя владельца (Ф.И.О.):");
            fullname = Convert.ToString(Console.ReadLine());
            bankAccount<int> bankAcc2 = new bankAccount<int>(numberInt, balance, fullname);
            bankAcc2.accountNum = numberInt;
            bankAcc2.accountBal = balance;
            bankAcc2.fullName = fullname;
            Console.WriteLine($"Банковский счет номер:{bankAcc2.accountNum}, баланс в рублях: {bankAcc2.accountBal}, клиент: {bankAcc2.fullName}");
            Console.ReadKey();
        }
    }
    class bankAccount<T>
    {
        public T accountNum { get; set; }
        public double accountBal { get; set; }
        public string fullName { get; set; }
        public bankAccount(T number, double balance, string fullName)
        {
            accountNum = number;
            accountBal = balance;
            this.fullName = fullName;
        }
    }
}

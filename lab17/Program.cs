using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            print<int>(12);
            print<string>("hello!");
            Console.ReadKey();
            /*Apartment apartment1 = new Apartment();
            apartment1.Num = "1";
            int next = (int)apartment1.Num;*/
            /*Apartment<int, int> apartment1 = new Apartment<int, int>();
            apartment1.Num = 1;
            int next = apartment1.Num;

            Apartment<string, int> apartment2 = new Apartment<string, int>();
            apartment2.Num = "01";*/ //запис метода для обощенного класса, вместо него Print
        }
        static void print<T>(T value)
        {
            Console.WriteLine(value);
        }
    }


    /*class Apartment <T, U>
    {
        public U level { get; set; }
        public T Num { get; set; }
        // public Object Num { get; set; } - не удачная идея
    }*/ // обобщенный класс класс вместо которого создали обощенный метод
}

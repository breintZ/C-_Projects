using _6_zz;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _6_zz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Использование типа object");
            Person1 pr1 = new Person1("Иванов", 123);
            Person1 pr2 = new Person1("Петров", "456");
            Person1 pr3 = new Person1("Сидоров", 'f');
            Person1 pr4 = new Person1("Титов", false);
            Person1 pr5 = new Person1("Алексеев", pr1);
            Console.WriteLine("Фамилия {0}, информация {1}", pr1.Name, pr1.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr2.Name, pr2.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr3.Name, pr3.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr4.Name, pr4.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr5.Name, pr5.Info);

            pr1.Info = (int)pr1.Info + 1;
            pr2.Info = (string)pr2.Info + 1;
            pr3.Info = (char)pr3.Info + 1;
            pr4.Info = !((bool)pr4.Info);
            pr5.Info = pr5.Info.ToString();

            Console.WriteLine("\n");

            Console.WriteLine("Фамилия {0}, информация {1}", pr1.Name, pr1.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr2.Name, pr2.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr3.Name, pr3.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr4.Name, pr4.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr5.Name, pr5.Info);

            Console.WriteLine("\n");

            Console.WriteLine("Использование обобщенного класса");
            Person2<int> pr6 = new Person2<int>("Иванов", 123);
            Person2<string> pr7 = new Person2<string>("Петров", "456");
            Person2<char> pr8 = new Person2<char>("Сидоров", 'f');
            Person2<bool> pr9 = new Person2<bool>("Титов", false);
            Person2<object> pr10 = new Person2<object>("Алексеев", pr1);
            Console.WriteLine("Фамилия {0}, информация {1}", pr6.Name, pr6.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr7.Name, pr7.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr8.Name, pr8.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr9.Name, pr9.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr10.Name, pr10.Info);

            Console.WriteLine("\n");

            pr6.Info = pr6.Info + 1;
            pr7.Info = pr7.Info + 1;
            pr8.Info = (char)(pr8.Info + 1);
            pr9.Info = !pr9.Info;
            pr10.Info = pr10.Info.ToString();
            Console.WriteLine("Фамилия {0}, информация {1}", pr6.Name, pr6.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr7.Name, pr7.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr8.Name, pr8.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr9.Name, pr9.Info);
            Console.WriteLine("Фамилия {0}, информация {1}", pr10.Name, pr10.Info);

            Console.WriteLine("\n");

            Console.WriteLine("Использование нескольких параметров");
            Person3<int, int> pr11 = new Person3<int, int>("Иванов", 123, 101);
            Person3<string, int> pr12 = new Person3<string, int>("Петров", "456", 202);
            Person3<char, string> pr13 = new Person3<char, string>("Сидоров", 'f', "a12");

            Console.WriteLine("Фамилия {0}, инфо {1}, id {2}", pr11.Name, pr11.Info, pr11.Id);
            Console.WriteLine("Фамилия {0}, инфо {1}, id {2}", pr12.Name, pr12.Info, pr12.Id);
            Console.WriteLine("Фамилия {0}, инфо {1}, id {2}", pr13.Name, pr13.Info, pr13.Id);

            Console.WriteLine("\n");

            Console.WriteLine("Обобщенный класс как обобщенный тип");
            Game<Person2<int>> gm1 = new Game<Person2<int>>("КГАСУ", new Person2<int>("Иванов", 123));
            Console.WriteLine("Организация участника {0}, фамилия {1}, информация {2}", gm1.Company, gm1.Member.Name, gm1.Member.Info);

            Console.WriteLine("\n");

            Console.WriteLine("Статические члены");
            Person2<int>.Code = 765;
            Person2<string>.Code = "Hello!";
            Person2<char>.Code = 'w';
            Person2<bool>.Code = true;
            Console.WriteLine("Статическое поле имеет значение:\n для int {0} \n для string {1} \n для char {2} \n для bool {3}", Person2<int>.Code, Person2<string>.Code, Person2<char>.Code, Person2<bool>.Code);

            Console.WriteLine("\n");

            Console.WriteLine("Обобщенный метод");
            int a = 5;
            int b = 7;
            Sw<int>(ref a, ref b);
            Console.WriteLine("Для чисел a = {0}, b = {1}", a, b);
            string u = "Tom";
            string v = "Bob";
            Sw<string>(ref u, ref v);
            Console.WriteLine("Для строк u = {0}, v = {1}", u, v);
            char s = 'x';
            char t = 'y';
            Sw<char>(ref s, ref t);
            Console.WriteLine("Для символов s = {0}, t = {1}", s, t);
            bool p = true;
            bool q = false;
            Sw<bool>(ref p, ref q);
            Console.WriteLine("Для логического типа p = {0}, q = {1}",
             p, q);

            Console.WriteLine("\n");

            Console.WriteLine("Использование первого класса");
            PersonId1<string> prid1 =
             new PersonId1<string>("Иванов", "123", 321);
            Console.WriteLine("До преобразования info = {0}",
             prid1.Info);
            prid1.Info = prid1.Info + 1;
            Console.WriteLine("После преобразования info = {0}",
             prid1.Info);

            Console.WriteLine("\n Использование второго класса");
            PersonId2<string> prid2 = new PersonId2<string>("Иванов", "123", "321");
            Console.WriteLine("До преобразования info = {0}, id = {1}", prid2.Info, prid2.Id);
            prid2.Info = prid2.Info + 1;
            prid2.Id = prid2.Id + 1;
            Console.WriteLine("После преобразования info = {0}, id = {1}", prid2.Info, prid2.Id);

            Console.WriteLine("\n Использование третьего класса");
            PersonId3 prid3 = new PersonId3("Иванов", 'g', "321");
            Console.WriteLine("До преобразования info = {0}, id = {1}", prid3.Info, prid3.Id);
            prid3.Info = (char)(prid3.Info + 1);
            prid3.Id = prid3.Id + 1;
            Console.WriteLine("После преобразования info = {0}, id = {1}", prid3.Info, prid3.Id);

            Console.WriteLine("\n Использование четвертого класса");
            PersonId4<int> prid4 = new PersonId4<int>("Иванов", 'g', 321);
            Console.WriteLine("До преобразования info = {0}, id = {1}", prid4.Info, prid4.Id);
            prid4.Info = (char)(prid4.Info + 1);
            prid4.Id = prid4.Id + 1;
            Console.WriteLine("После преобразования info = {0}, id = {1}", prid4.Info, prid4.Id);

            Console.WriteLine("\n Использование пятого класса");
            PersonId5<int, string> prid5 = new PersonId5<int, string>("Иванов", 123, "321");
            Console.WriteLine("До преобразования info = {0},id = {1}", prid5.Info, prid5.Id);
            prid5.Info = prid5.Info + 1;
            prid5.Id = prid5.Id + 1;
            Console.WriteLine("После преобразования info = {0}, id = {1}", prid5.Info, prid5.Id);

            Console.WriteLine("\n ");

            Console.WriteLine("Использование ограничений на классы");
            Game1 < Person1 > gm2 = new Game1<Person1>("КГАСУ", new Person1("Иванов", 123));
            gm2.PrName();

            Game1<PersonId> gm3 = new Game1<PersonId>("КГАСУ", new PersonId("Петров", "345", 567));
            gm3.PrName();

            Console.WriteLine("\n ");

            Console.WriteLine("Использование ограничений на методы");
            Person1 pr14 = new Person1("Николаев", 423);
            PersonId pr15 = new PersonId("Михайлов", "543", 678);
            G(pr14);
            G(pr15);

            Console.WriteLine("\n ");
            string a1 = "хорошо", b1 = "плохо";
            SwCl<string>(ref a1, ref b1);
            Console.WriteLine("Первое = {0}, второе = {1}", a1, b1);

            Console.WriteLine("\n ");
            int a2 = 2, b2 = 5;
            SwSt<int>(ref a2, ref b2);
            Console.WriteLine("Первое = {0}, второе = {1}", a2, b2);
        }
        static void Sw<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }
        static void G<T>(T x) where T : Person1
        {
            Console.WriteLine("Фамилия {0}, информация {1}", x.Name, x.Info);
        }
        static void SwCl<T>(ref T x, ref T y) where T : class
        {
            T z = x;
            x = y;
            y = z;
        }
        static void SwSt<T>(ref T x, ref T y) where T : struct
        {
            T z = x;
            x = y;
            y = z;
        }




    }

}
    
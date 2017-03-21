using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control {
    class Program {
        static void Main(string[ ] args) {
            //1.А) Вывести минимально допустимое число типа Double
            //1.Б) Ввести с консоли 2 строки и соединить их. Результат вывести на консоль
            //1.В) Создать jagged массив целого типа с двумя строками. В нулевой строке должно быть 3 элемента, в первой - 5. Проинициализировать и вывести на консоль.
            Console.WriteLine("Exercise №1");
            Console.WriteLine(double.MinValue);
            Console.WriteLine("Enter 2 string: ");
            string s1 = Console.ReadLine( ).ToString( );
            string s2 = Console.ReadLine( ).ToString( );
            Console.WriteLine(s1 + s2);
            string[ ][ ] jagged = new string[2][ ];
            jagged[0] = new string[3];
            jagged[1] = new string[5];
            for (int i = 0; i < jagged.Length; i++) {
                for (int j = 0; j < jagged[i].Length; j++) {
                    jagged[i][j] = Console.ReadLine( );
                }
            }
            for (int i = 0; i < jagged.Length; i++) {
                for (int j = 0; j < jagged[i].Length; j++) {
                    Console.WriteLine("\t" + jagged[i][j]);
                }
                Console.WriteLine( );
            }
            Console.ReadLine( );

            //2  Создать класс Time с hours, minutes, seconds. Hours сделайте константой. Перегрузите операции == и < для сравнения двух объектов типа Time. Напишите демонстрацию.
            Console.WriteLine("Exercise №2");
            Time t1 = new Time(47, 56);
            Time t2 = new Time(17, 56);
            Time t3 = new Time(47, 22);
            Console.WriteLine("t1 = " + t1 + "\nt2 = " + t2 + "\nt3 = " + t3);
            Console.WriteLine("t2 < t3 - " + (t2 < t3));
            Console.WriteLine("t1 == t2 - " + (t1 == t2));

            // 3.
            Console.WriteLine("Exercise №3");
            Students st = new Students("Igor");
            Prepod pr = new Prepod("Sweta");
            st.study( );
            pr.study( );
            IStudy study = st;
            study.study( );
            study = pr;
            study.study( );
            (pr as Students).study( );
            //((Students)pr).study( );
            //((IStudy)pr).study( );

            //4.
            Console.WriteLine("Exercise №4");
            SuperHashSet<Time> shs = new SuperHashSet<Time>( );
            shs.Add(t1);
            shs.Add(t2);
            shs.Add(t3);
            shs.Add(t2);
            shs.Add(t2);
            shs.Add(t1);

            //5.
            var a =
                from elem in shs
                where elem == t2
                select elem;
            Console.WriteLine(a.Count( ));

#if DEBUG
            Console.ReadLine( );
#endif
        }
    }
}

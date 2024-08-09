using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        // Створіть клас MyClass і структуру MyStruct,
        // які містять поля public string change.
        // У класі Program створіть два методи:
        // static void ClassTaker(MyClass myClass),
        // який надає полю change екземпляра myClass значення «змінено».
        // static void StruktTaker(MyStruct myStruct),
        // який надає полю change екземпляра myStruct значення «змінено».
        // Продемонструйте різницю у використанні класів та структур,
        // створивши у методі Main() екземпляри структури та класу.
        // Змініть значення полів екземплярів на «не змінено»,
        // а потім викличте методи ClassTaker і StruktTaker.
        // Виведіть на екран значення полів екземплярів. Проаналізуйте отримані результати. 
        struct MyStruct
        {
            public string change;
        }

        class MyClass
        {
            public string change;
        }


        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "«змінено»";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "«змінено»";
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            MyStruct myStruct = new MyStruct() { change = "«не змінено»" };
            MyClass myClass = new MyClass() { change = "«не змінено»" };

            StruktTaker(myStruct);
            ClassTaker(myClass);

            Console.WriteLine("структура: {0}", myStruct.change);
            Console.WriteLine("клас: {0}", myClass.change);


            Console.ReadKey();
        }
    }

}

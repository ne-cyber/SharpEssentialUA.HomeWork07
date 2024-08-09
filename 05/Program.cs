using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        //Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        //Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість.
        //У структурі має бути реалізований конструктор для ініціалізації полів та метод для виведення
        //вмісту полів на екран.

        struct NoteBook
        {
            string model;
            string manufacturer;
            double cost;

            public NoteBook(string model, string manufacturer, double cost)
            {
                this.model = model;
                this.manufacturer = manufacturer;
                this.cost = cost;
            }

            public void Show()
            {
                Console.WriteLine("model: {0}, manufacturer {1}, cost {2:C}", model, manufacturer, cost);
            }
        }

        static void Main(string[] args)
        {
            NoteBook notebook = new NoteBook("asus m", "asus", 120_000);

            notebook.Show();

            Console.ReadKey();
        }
    }
}

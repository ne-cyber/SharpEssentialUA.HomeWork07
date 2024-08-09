using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        struct Train
        {
            string trainDestination;
            int trainNumber;
            DateTime trainDeparture;

            public Train(string trainDestination, int trainNumber, DateTime trainDeparture)
            {
                this.trainDestination = trainDestination;
                this.trainNumber = trainNumber;
                this.trainDeparture = trainDeparture;
            }

            public string TrainDestination
            {
                get { return trainDestination; }
            }

            public int TrainNumber
            {
                get { return trainNumber; }
            }
            public DateTime TrainDeparture
            {
                get { return trainDeparture; }
            }

        }



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Train[] trains = new Train[8];

            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write("Введіть пункт призначення поїзду: ");
            //    string dest = Console.ReadLine();
            //    Console.Write("Введіть номер поїзду: ");
            //    int number = int.Parse(Console.ReadLine());
            //    DateTime dep = DateTime.Parse(Console.ReadLine());

            //    trains[i] = new Train(dest, number, dep);

            //    Console.WriteLine(new string('-', 30));
            //}

            trains[0] = new Train("Odessa", 1, DateTime.Now);
            trains[1] = new Train("Odessa", 2, DateTime.Now);
            trains[2] = new Train("Kiev", 7, DateTime.Now);
            trains[3] = new Train("Lvov", 3, DateTime.Now);
            trains[4] = new Train("Donetsk", 8, DateTime.Now);
            trains[5] = new Train("Donetsk", 6, DateTime.Now);
            trains[6] = new Train("Donetsk", 5, DateTime.Now);
            trains[7] = new Train("Donetsk", 4, DateTime.Now);


            Array.Sort(trains, (t1, t2) => { return t1.TrainNumber - t2.TrainNumber; });


            while (true)
            {
                Console.Write("Введіть номер поїзда: ");
                int n = int.Parse(Console.ReadLine());

                Train train = Array.Find(trains, t => t.TrainNumber == n);

                if (train.Equals(default(Train)))
                    Console.WriteLine("Такого поїзда немає!");
                else
                    Console.WriteLine($"{train.TrainNumber,8} {train.TrainDestination,12}, {train.TrainDeparture}");

                Console.WriteLine(new string('-', 30));
            }

            Console.ReadKey();

        }
    }
}
using System;
using System.Linq;

namespace Z_1
{
    class Program
    {
        public struct TRAIN
        {
            public string destination;
            public int number;
            public int[] time;   
        }
        static void Main(string[] args)
        {
            TRAIN[] massTrain = new TRAIN[2];
            for (int i = 0; i < massTrain.Length; i++)
            {
                Console.WriteLine("Введите пункт назначения: ");
                massTrain[i].destination = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите номер поезда: ");
                massTrain[i].number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите время: ");
                massTrain[i].time = new int[2];
                for (int j = 0; j < massTrain[i].time.Length; j++)
                    massTrain[i].time[j] = int.Parse(Console.ReadLine());
            }            
            for (int i = 0; i < massTrain.Length; i++)
            {
                MyClass.SortAlph(massTrain);
                Console.WriteLine("TRAIN" + " " + (i + 1) + ":");
                Console.WriteLine("Пункт назначения: " + massTrain[i].destination);
                Console.WriteLine("Номер поезда: " + massTrain[i].number);
                Console.Write("Время");
                for (int j = 0; j < massTrain[i].time.Length; j++)
                    Console.Write(": " + massTrain[i].time[j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Введите время для поиска:");
            int[] timeSearch = new int[2];
            for (int j = 0; j < timeSearch.Length; j++)
                timeSearch[j] = int.Parse(Console.ReadLine());
            for (int i = 0; i < massTrain.Length; i++)
            {
                if ((massTrain[i].time[0] > timeSearch[0])) 
                {
                    Console.WriteLine("Пункт назначения: " + massTrain[i].destination);
                    Console.WriteLine("Номер поезда: " + massTrain[i].number);
                    Console.Write("Время");
                    for (int j = 0; j < massTrain[i].time.Length; j++)
                        Console.Write(": " + massTrain[i].time[j]);
                    Console.WriteLine();
                }
                else if ((massTrain[i].time[0] == timeSearch[0]))
                {
                    if ((massTrain[i].time[1] > timeSearch[1]))
                    {
                        Console.WriteLine("Пункт назначения: " + massTrain[i].destination);
                        Console.WriteLine("Номер поезда: " + massTrain[i].number);
                        Console.WriteLine("Время:");
                        for (int j = 0; j < massTrain[i].time.Length; j++)
                            Console.Write(": " + massTrain[i].time[j]);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Не найдено");
                }
            }
            Console.ReadKey();
        }
        public static class MyClass
        {
            public static void SortAlph(TRAIN[] trains)
            {
                var query = from u in trains
                            orderby u.destination
                            select u;
                int i = 0;
                foreach (var item in query)
                {
                    trains[i] = item;
                    i++;
                }
            }
        }
    }
}

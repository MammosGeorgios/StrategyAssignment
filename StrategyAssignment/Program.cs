using StrategyAssignment.Interfaces;
using StrategyAssignment.Models;
using StrategyAssignment.Strategies;
using StrategyAssignment.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan[,] times = new TimeSpan[3,8];
            TimeSpan temp;
            //column one is bubble sort, column 2 is quicksort and column 3 is bucket sort
            //
            Stopwatch stopWatch = new Stopwatch();

            Random rand = new Random();
            List<Tshirt> tshirtsOriginal = new List<Tshirt>();
            for (int i = 0; i < 2000; i++)
            {
                Tshirt newTshirt = new Tshirt("Tshirt" + i, (Color)rand.Next(1, 7), (Size)rand.Next(1, 7), (Fabric)rand.Next(1, 7));
                tshirtsOriginal.Add(newTshirt);
            }
            List<Tshirt> tshirts =  CloneList(tshirtsOriginal);


            #region BubbleSorts
            BubbleSort bubbleSort = new BubbleSort();
            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bubbleSort.SortByColorAscending(tshirts);
            stopWatch.Stop();
            times[0, 0] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bubbleSort.SortByColorDescending(tshirts);
            stopWatch.Stop();
            times[0, 1] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bubbleSort.SortBySizeAscending(tshirts);
            stopWatch.Stop();
            times[0, 2] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bubbleSort.SortBySizeDescending(tshirts);
            stopWatch.Stop();
            times[0, 3] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bubbleSort.SortByFabricAscending(tshirts);
            stopWatch.Stop();
            times[0, 4] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bubbleSort.SortByFabricDescending(tshirts);
            stopWatch.Stop();
            times[0, 5] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bubbleSort.SortBySizeThenColorThenFabricAscending (tshirts);
            stopWatch.Stop();
            times[0, 6] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bubbleSort.SortBySizeThenColorThenFabricDescending(tshirts);
            stopWatch.Stop();
            times[0, 7] = stopWatch.Elapsed;

            #endregion

            #region QuickSort
            QuickSortStrategy qs = new QuickSortStrategy();
            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            qs.SortByColorAscending(tshirts);
            stopWatch.Stop();
            times[1, 0] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            qs.SortByColorDescending(tshirts);
            stopWatch.Stop();
            times[1, 1] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            qs.SortBySizeAscending(tshirts);
            stopWatch.Stop();
            times[1, 2] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            qs.SortBySizeDescending(tshirts);
            stopWatch.Stop();
            times[1, 3] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            qs.SortByFabricAscending(tshirts);
            stopWatch.Stop();
            times[1, 4] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            qs.SortByFabricDescending(tshirts);
            stopWatch.Stop();
            times[1, 5] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            qs.SortBySizeThenColorThenFabricAscending(tshirts);
            stopWatch.Stop();
            times[1, 6] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            qs.SortBySizeThenColorThenFabricDescending(tshirts);
            stopWatch.Stop();
            times[1, 7] = stopWatch.Elapsed;


            #endregion

            #region BucketSort
            BucketSortStrategy bs = new BucketSortStrategy();
            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bs.SortByColorAscending(tshirts);
            stopWatch.Stop();
            times[2, 0] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bs.SortByColorDescending(tshirts);
            stopWatch.Stop();
            times[2, 1] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bs.SortBySizeAscending(tshirts);
            stopWatch.Stop();
            times[2, 2] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bs.SortBySizeDescending(tshirts);
            stopWatch.Stop();
            times[2, 3] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bs.SortByFabricAscending(tshirts);
            stopWatch.Stop();
            times[2, 4] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bs.SortByFabricDescending(tshirts);
            stopWatch.Stop();
            times[2, 5] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bs.SortBySizeThenColorThenFabricAscending(tshirts);
            stopWatch.Stop();
            times[2, 6] = stopWatch.Elapsed;

            tshirts = CloneList(tshirtsOriginal);
            stopWatch.Reset();
            stopWatch.Start();
            bs.SortBySizeThenColorThenFabricDescending(tshirts);
            stopWatch.Stop();
            times[2, 7] = stopWatch.Elapsed;


            #endregion

            PrintResults(times);

        }

     

        private static void Assignment3Example()
        {
            Tshirt t1 = new Tshirt("t1", Color.RED, Size.L, Fabric.SILK, new CashPaymentStrategy());
            t1.Pay();

            Tshirt t2 = new Tshirt("t2", Color.RED, Size.L, Fabric.SILK, new BankPaymentStrategy());
            t2.Pay();

            Tshirt t3 = new Tshirt("t3", Color.RED, Size.L, Fabric.SILK, new CreditPaymentStrategy());
            t3.Pay();


            //Console.OutputEncoding = Encoding.UTF8;
            int fabric, size, color, paymentMethod;


            Menu menu = new Menu();

            while (true)
            {
                menu.FabricMenu();
                while (!(int.TryParse(Console.ReadLine(), out fabric) && (fabric >= 1 && fabric <= 7)))
                {
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine();
                    menu.FabricMenu();
                }

                menu.ColorMenu();
                while (!(int.TryParse(Console.ReadLine(), out color) && (color >= 1 && color <= 7)))
                {
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine();
                    menu.ColorMenu();
                }

                menu.SizeMenu();
                while (!(int.TryParse(Console.ReadLine(), out size) && (size >= 1 && size <= 7)))
                {
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine();
                    menu.SizeMenu();
                }

                Tshirt tshirt = new Tshirt("menuTshirt", (Color)(color - 1), (Size)(size - 1), (Fabric)(fabric - 1));

                menu.PaymentMethodMenu();
                while (!(int.TryParse(Console.ReadLine(), out paymentMethod) && (paymentMethod >= 1 && paymentMethod <= 3)))
                {
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine();
                    menu.PaymentMethodMenu();
                }

                IPaymentStrategy paymentStrategy = null;
                switch (paymentMethod)
                {

                    case 1:
                        paymentStrategy = new CreditPaymentStrategy();
                        break;
                    case 2:
                        paymentStrategy = new BankPaymentStrategy();
                        break;
                    case 3:
                        paymentStrategy = new CashPaymentStrategy();
                        break;

                }
                tshirt.SetPaymentStrategy(paymentStrategy);
                tshirt.Pay();

                Console.WriteLine();
                Console.WriteLine("Do you want to buy another Tshirt?");
                string answer = Console.ReadLine();
                if (!(answer.Equals("yes", StringComparison.InvariantCultureIgnoreCase) || answer.Equals("y", StringComparison.InvariantCultureIgnoreCase)))
                {
                    break;
                }
                Console.WriteLine();
            }
        }

        public static  List<Tshirt> CloneList (List<Tshirt> original)
        {
            List<Tshirt> newList = new List<Tshirt>();
            foreach (var item in original)
            {
                Tshirt temp = item.DeepCopy();
                newList.Add(temp);
            }

            return (newList);
        }

        public static void PrintResults(TimeSpan[,] times)
        {
            Console.WriteLine("Tests Results Are:");

            Console.WriteLine("Sorting By   | BubbleSort     | QuickSort     | BucketSort");
            Console.WriteLine($"Color Asc    | {times[0, 0].TotalMilliseconds.ToString(),-10}  ms | {times[1, 0].TotalMilliseconds.ToString(),-10}  ms | {times[2, 0].TotalMilliseconds.ToString(),-10} ms");
            Console.WriteLine($"Color Desc   | {times[0, 1].TotalMilliseconds.ToString(),-10}  ms | {times[1, 1].TotalMilliseconds.ToString(),-10}  ms | {times[2, 1].TotalMilliseconds.ToString(),-10} ms");
            Console.WriteLine($"Size  Asc    | {times[0, 2].TotalMilliseconds.ToString(),-10}  ms | {times[1, 2].TotalMilliseconds.ToString(),-10}  ms | {times[2, 2].TotalMilliseconds.ToString(),-10} ms");
            Console.WriteLine($"Size Desc    | {times[0, 3].TotalMilliseconds.ToString(),-10}  ms | {times[1, 3].TotalMilliseconds.ToString(),-10}  ms | {times[2, 3].TotalMilliseconds.ToString(),-10} ms");
            Console.WriteLine($"Fabric Asc   | {times[0, 4].TotalMilliseconds.ToString(),-10}  ms | {times[1, 4].TotalMilliseconds.ToString(),-10}  ms | {times[2, 4].TotalMilliseconds.ToString(),-10} ms");
            Console.WriteLine($"Fabric Desc  | {times[0, 5].TotalMilliseconds.ToString(),-10}  ms | {times[1, 5].TotalMilliseconds.ToString(),-10}  ms | {times[2, 5].TotalMilliseconds.ToString(),-10} ms");
            Console.WriteLine($"Multiple Asc | {times[0, 6].TotalMilliseconds.ToString(),-10}  ms | {times[1, 6].TotalMilliseconds.ToString(),-10}  ms | {times[2, 6].TotalMilliseconds.ToString(),-10} ms");
            Console.WriteLine($"Multiple Desc| {times[0, 7].TotalMilliseconds.ToString(),-10}  ms | {times[1, 7].TotalMilliseconds.ToString(),-10}  ms | {times[2, 7].TotalMilliseconds.ToString(),-10} ms");
        }
        
    }
}

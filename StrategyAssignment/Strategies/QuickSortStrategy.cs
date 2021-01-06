using StrategyAssignment.Interfaces;
using StrategyAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.Strategies
{
    class QuickSortStrategy : ISortStrategy
    {
        public void SortByColorAscending(List<Tshirt> tshirts)
        {
            QuickSortByColorAscending(tshirts, 0, tshirts.Count - 1);
        }

        public void SortByColorDescending(List<Tshirt> tshirts)
        {
            QuickSortByColorDescending(tshirts, 0, tshirts.Count - 1);
        }

        public void SortByFabricAscending(List<Tshirt> tshirts)
        {
            QuickSortByFabricAscending(tshirts, 0, tshirts.Count - 1);
        }

        public void SortByFabricDescending(List<Tshirt> tshirts)
        {
            QuickSortByFabricDescending(tshirts, 0, tshirts.Count - 1);
        }

        public void SortBySizeAscending(List<Tshirt> tshirts)
        {
            QuickSortBySizeAscending(tshirts, 0, tshirts.Count - 1);
        }

        public void SortBySizeDescending(List<Tshirt> tshirts)
        {
            QuickSortBySizeDescending(tshirts, 0, tshirts.Count - 1);
        }

        public void SortBySizeThenColorThenFabricAscending(List<Tshirt> tshirts)
        {
            QuickSortBySizeThenColorThenFabricAscending(tshirts, 0, tshirts.Count - 1);
        }

        public void SortBySizeThenColorThenFabricDescending(List<Tshirt> tshirts)
        {
            QuickSortBySizeThenColorThenFabricDescending(tshirts, 0, tshirts.Count - 1);
        }
        //******************************************************************************************
        static void QuickSortBySizeAscending(List<Tshirt> tshirts,int low,int high)
        {
            if (low < high)
            {               
                int pi = QuickSortBySizePartitionAscending(tshirts, low, high);
                
                QuickSortBySizeAscending(tshirts, low, pi - 1);
                QuickSortBySizeAscending(tshirts, pi + 1, high);
            }
        }

        static int QuickSortBySizePartitionAscending(List<Tshirt> tshirts,int low,int high)
        {
            Tshirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Size < pivot.Size)
                {
                    i++;
                    //swap
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;
            
        }

        static void QuickSortBySizeDescending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {                
                int pi = QuickSortBySizePartitionDescending(tshirts, low, high);
                
                QuickSortBySizeDescending(tshirts, low, pi - 1);
                QuickSortBySizeDescending(tshirts, pi + 1, high);

            }
        }
        static int QuickSortBySizePartitionDescending(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Size > pivot.Size) //Here we change to descending 
                {
                    i++;
                    //swap
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;

        }

        //**********************************************************************


        static void QuickSortByColorAscending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByColorPartitionAscending(tshirts, low, high);

                QuickSortByColorAscending(tshirts, low, pi - 1);
                QuickSortByColorAscending(tshirts, pi + 1, high);
            }
        }

        static int QuickSortByColorPartitionAscending(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Color < pivot.Color)
                {
                    i++;
                    //swap
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;

        }

        static void QuickSortByColorDescending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByColorPartitionDescending(tshirts, low, high);

                QuickSortByColorDescending(tshirts, low, pi - 1);
                QuickSortByColorDescending(tshirts, pi + 1, high);

            }
        }
        static int QuickSortByColorPartitionDescending(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Color > pivot.Color) //Here we change to descending 
                {
                    i++;
                    //swap
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;

        }


        //*****************************************************************************************************


        static void QuickSortByFabricAscending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByFabricPartitionAscending(tshirts, low, high);

                QuickSortByFabricAscending(tshirts, low, pi - 1);
                QuickSortByFabricAscending(tshirts, pi + 1, high);
            }
        }

        static int QuickSortByFabricPartitionAscending(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Fabric < pivot.Fabric)
                {
                    i++;
                    //swap
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;

        }

        static void QuickSortByFabricDescending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByFabricPartitionDescending(tshirts, low, high);

                QuickSortByFabricDescending(tshirts, low, pi - 1);
                QuickSortByFabricDescending(tshirts, pi + 1, high);

            }
        }
        static int QuickSortByFabricPartitionDescending(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Fabric > pivot.Fabric) //Here we change to descending 
                {
                    i++;
                    //swap
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;

        }


        //*****************************************************************************************

        static void QuickSortBySizeThenColorThenFabricAscending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizeThenColorThenFabricPartitionAscending(tshirts, low, high);

                QuickSortBySizeThenColorThenFabricAscending(tshirts, low, pi - 1);
                QuickSortBySizeThenColorThenFabricAscending(tshirts, pi + 1, high);
            }
        }

        static int QuickSortBySizeThenColorThenFabricPartitionAscending(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {

                bool condition = (tshirts[j].Size < pivot.Size) ||
                                    ((tshirts[j].Size == pivot.Size) && (tshirts[j].Color < pivot.Color)) ||
                                    ((tshirts[j].Size == pivot.Size) && (tshirts[j].Color == pivot.Color) && (tshirts[j].Fabric < pivot.Fabric));

                if (condition)
                {
                    i++;
                    //swap
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
                
            }
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;

        }

        static void QuickSortBySizeThenColorThenFabricDescending(List<Tshirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizeThenColorThenFabricPartitionDescending(tshirts, low, high);

                QuickSortBySizeThenColorThenFabricDescending(tshirts, low, pi - 1);
                QuickSortBySizeThenColorThenFabricDescending(tshirts, pi + 1, high);

            }
        }
        static int QuickSortBySizeThenColorThenFabricPartitionDescending(List<Tshirt> tshirts, int low, int high)
        {
            Tshirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                bool condition = (tshirts[j].Size > pivot.Size) ||
                                    ((tshirts[j].Size == pivot.Size) && (tshirts[j].Color > pivot.Color)) ||
                                    ((tshirts[j].Size == pivot.Size) && (tshirts[j].Color == pivot.Color) && (tshirts[j].Fabric > pivot.Fabric));

                if (condition) //here we change to descending
                {
                    i++;
                    //swap
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;

        }



    }
}

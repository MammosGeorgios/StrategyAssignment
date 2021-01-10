using StrategyAssignment.Interfaces;
using StrategyAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.Strategies
{
    class BucketSortStrategy : ISortStrategy
    {
        public void SortByColorAscending(List<Tshirt> tshirts)
        {
            if(tshirts == null || tshirts.Count <= 1)
            {
                return;
            }

            Color maxValue = tshirts[0].Color;
            Color minValue = tshirts[0].Color;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Color > maxValue)
                    maxValue = tshirts[i].Color;

                if (tshirts[i].Color < minValue)
                    minValue = tshirts[i].Color;
            }

            LinkedList<Tshirt>[] bucket = new LinkedList<Tshirt>[maxValue - minValue + 1];

            for (int i = 0; i < tshirts.Count; i++)
            {
                if(bucket[tshirts[i].Color - minValue] == null)
                {
                    bucket[tshirts[i].Color - minValue] = new LinkedList<Tshirt>();
                }

                bucket[tshirts[i].Color - minValue].AddLast(tshirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if(bucket[i] != null)
                {
                    LinkedListNode<Tshirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tshirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }

            }

        }

        public void SortByColorDescending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
            {
                return;
            }

            Color maxValue = tshirts[0].Color;
            Color minValue = tshirts[0].Color;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Color > maxValue)
                    maxValue = tshirts[i].Color;

                if (tshirts[i].Color < minValue)
                    minValue = tshirts[i].Color;
            }

            LinkedList<Tshirt>[] bucket = new LinkedList<Tshirt>[maxValue - minValue + 1];

            for (int i = 0; i < tshirts.Count; i++)
            {
                if (bucket[maxValue -tshirts[i].Color] == null)
                {
                    bucket[maxValue - tshirts[i].Color] = new LinkedList<Tshirt>();
                }

                bucket[maxValue - tshirts[i].Color].AddLast(tshirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<Tshirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tshirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }

            }


        }

        public void SortByFabricAscending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
            {
                return;
            }

            Fabric maxValue = tshirts[0].Fabric;
            Fabric minValue = tshirts[0].Fabric;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Fabric > maxValue)
                    maxValue = tshirts[i].Fabric;

                if (tshirts[i].Fabric < minValue)
                    minValue = tshirts[i].Fabric;
            }

            LinkedList<Tshirt>[] bucket = new LinkedList<Tshirt>[maxValue - minValue + 1];

            for (int i = 0; i < tshirts.Count; i++)
            {
                if (bucket[tshirts[i].Fabric - minValue] == null)
                {
                    bucket[tshirts[i].Fabric - minValue] = new LinkedList<Tshirt>();
                }

                bucket[tshirts[i].Fabric - minValue].AddLast(tshirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<Tshirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tshirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }

            }
        }

        public void SortByFabricDescending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
            {
                return;
            }

            Fabric maxValue = tshirts[0].Fabric;
            Fabric minValue = tshirts[0].Fabric;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Fabric > maxValue)
                    maxValue = tshirts[i].Fabric;

                if (tshirts[i].Fabric < minValue)
                    minValue = tshirts[i].Fabric;
            }

            LinkedList<Tshirt>[] bucket = new LinkedList<Tshirt>[maxValue - minValue + 1];

            for (int i = 0; i < tshirts.Count; i++)
            {
                if (bucket[maxValue - tshirts[i].Fabric] == null)
                {
                    bucket[maxValue - tshirts[i].Fabric] = new LinkedList<Tshirt>();
                }

                bucket[maxValue - tshirts[i].Fabric].AddLast(tshirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<Tshirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tshirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }

            }
        }

        public void SortBySizeAscending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
            {
                return;
            }

            Size maxValue = tshirts[0].Size;
            Size minValue = tshirts[0].Size;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Size > maxValue)
                    maxValue = tshirts[i].Size;

                if (tshirts[i].Size < minValue)
                    minValue = tshirts[i].Size;
            }

            LinkedList<Tshirt>[] bucket = new LinkedList<Tshirt>[maxValue - minValue + 1];

            for (int i = 0; i < tshirts.Count; i++)
            {
                if (bucket[tshirts[i].Size - minValue] == null)
                {
                    bucket[tshirts[i].Size - minValue] = new LinkedList<Tshirt>();
                }

                bucket[tshirts[i].Size - minValue].AddLast(tshirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<Tshirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tshirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }

            }

        }

        public void SortBySizeDescending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
            {
                return;
            }

            Size maxValue = tshirts[0].Size;
            Size minValue = tshirts[0].Size;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Size > maxValue)
                    maxValue = tshirts[i].Size;

                if (tshirts[i].Size < minValue)
                    minValue = tshirts[i].Size;
            }

            LinkedList<Tshirt>[] bucket = new LinkedList<Tshirt>[maxValue - minValue + 1];

            for (int i = 0; i < tshirts.Count; i++)
            {
                if (bucket[maxValue - tshirts[i].Size] == null)
                {
                    bucket[maxValue - tshirts[i].Size] = new LinkedList<Tshirt>();
                }

                bucket[maxValue - tshirts[i].Size].AddLast(tshirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<Tshirt> node = bucket[i].First;

                    while (node != null)
                    {
                        tshirts[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }

            }

        }

        public void SortBySizeThenColorThenFabricAscending(List<Tshirt> tshirts)
        {
            if(tshirts ==null || tshirts.Count <= 1)
            {
                return;
            }

            Size maxSizeValue = tshirts[0].Size;
            Size minSizeValue = tshirts[0].Size;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Size > maxSizeValue) maxSizeValue = tshirts[i].Size;
                if (tshirts[i].Size < minSizeValue) minSizeValue = tshirts[i].Size;
            }

            Color maxColorValue = tshirts[0].Color;
            Color minColorValue = tshirts[0].Color;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Color > maxColorValue) maxColorValue = tshirts[i].Color;
                if (tshirts[i].Color < minColorValue) minColorValue = tshirts[i].Color;
            }

            Fabric maxFabricValue = tshirts[0].Fabric;
            Fabric minFabricValue = tshirts[0].Fabric;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Fabric > maxFabricValue) maxFabricValue = tshirts[i].Fabric;
                if (tshirts[i].Fabric < minFabricValue) minFabricValue = tshirts[i].Fabric;
            }

            LinkedList<Tshirt>[,,] bucket = new LinkedList<Tshirt>[maxSizeValue - minSizeValue + 1, maxColorValue - minColorValue + 1, maxFabricValue - minFabricValue + 1];

            for (int i = 0; i < tshirts.Count; i++)
            {
                if(bucket[tshirts[i].Size - minSizeValue, tshirts[i].Color - minColorValue, tshirts[i].Fabric - minFabricValue] == null)
                {
                    bucket[tshirts[i].Size - minSizeValue, tshirts[i].Color - minColorValue, tshirts[i].Fabric - minFabricValue] = new LinkedList<Tshirt>();
                }
                bucket[tshirts[i].Size - minSizeValue, tshirts[i].Color - minColorValue, tshirts[i].Fabric - minFabricValue].AddLast(tshirts[i]);
            }

            int k = 0;
            for(int i = 0; i < bucket.GetLength(0); i++)
            {
                for(int j = 0; j < bucket.GetLength(1); j++)
                {
                    for (int m = 0; m < bucket.GetLength(2); m++)
                    {
                        if (bucket[i, j, m] != null)
                        {
                            LinkedListNode<Tshirt> node = bucket[i, j, m].First;

                            while (node != null)
                            {
                                tshirts[k] = node.Value;
                                node = node.Next;
                                k++;

                            }
                        }
                    }
                }
            }

        }

        public void SortBySizeThenColorThenFabricDescending(List<Tshirt> tshirts)
        {
            if (tshirts == null || tshirts.Count <= 1)
            {
                return;
            }

            Size maxSizeValue = tshirts[0].Size;
            Size minSizeValue = tshirts[0].Size;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Size > maxSizeValue) maxSizeValue = tshirts[i].Size;
                if (tshirts[i].Size < minSizeValue) minSizeValue = tshirts[i].Size;
            }

            Color maxColorValue = tshirts[0].Color;
            Color minColorValue = tshirts[0].Color;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Color > maxColorValue) maxColorValue = tshirts[i].Color;
                if (tshirts[i].Color < minColorValue) minColorValue = tshirts[i].Color;
            }

            Fabric maxFabricValue = tshirts[0].Fabric;
            Fabric minFabricValue = tshirts[0].Fabric;

            for (int i = 1; i < tshirts.Count; i++)
            {
                if (tshirts[i].Fabric > maxFabricValue) maxFabricValue = tshirts[i].Fabric;
                if (tshirts[i].Fabric < minFabricValue) minFabricValue = tshirts[i].Fabric;
            }

            LinkedList<Tshirt>[,,] bucket = new LinkedList<Tshirt>[maxSizeValue - minSizeValue + 1, maxColorValue - minColorValue + 1, maxFabricValue - minFabricValue + 1];

            for (int i = 0; i < tshirts.Count; i++)
            {
                if (bucket[maxSizeValue- tshirts[i].Size,maxColorValue - tshirts[i].Color ,maxFabricValue- tshirts[i].Fabric ] == null)
                {
                    bucket[maxSizeValue - tshirts[i].Size, maxColorValue - tshirts[i].Color, maxFabricValue - tshirts[i].Fabric] = new LinkedList<Tshirt>();
                }
                bucket[maxSizeValue - tshirts[i].Size, maxColorValue - tshirts[i].Color, maxFabricValue - tshirts[i].Fabric].AddLast(tshirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.GetLength(0); i++)
            {
                for (int j = 0; j < bucket.GetLength(1); j++)
                {
                    for (int m = 0; m < bucket.GetLength(2); m++)
                    {
                        if (bucket[i, j, m] != null)
                        {
                            LinkedListNode<Tshirt> node = bucket[i, j, m].First;

                            while (node != null)
                            {
                                tshirts[k] = node.Value;
                                node = node.Next;
                                k++;

                            }
                        }
                    }
                }
            }
        }

       
    }
}

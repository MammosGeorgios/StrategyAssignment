using StrategyAssignment.Interfaces;
using StrategyAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.Strategies
{
    class BubbleSort : ISortStrategy
    {
        public void SortByColorAscending(List<Tshirt> tshirts)
        {
            bool didAtLeastOneSwap=false;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < tshirts.Count -1 -i; j++)
                {
                    didAtLeastOneSwap = false;
                    if (tshirts[j].Color > tshirts[j + 1].Color)
                    {
                        Tshirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                        didAtLeastOneSwap = true;
                    }
                }
                if (didAtLeastOneSwap)
                    break;
            }
        }

        public void SortByColorDescending(List<Tshirt> tshirts)
        {
            bool didAtLeastOneSwap = false;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    didAtLeastOneSwap = false;
                    if (tshirts[j].Color < tshirts[j + 1].Color)
                    {
                        Tshirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                        didAtLeastOneSwap = true;
                    }
                }
                if (didAtLeastOneSwap)
                    break;
            }
        }

        public void SortByFabricAscending(List<Tshirt> tshirts)
        {
            bool didAtLeastOneSwap = false;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    didAtLeastOneSwap = false;
                    if (tshirts[j].Fabric > tshirts[j + 1].Fabric)
                    {
                        Tshirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                        didAtLeastOneSwap = true;
                    }
                }
                if (didAtLeastOneSwap)
                    break;
            }
        }

        public void SortByFabricDescending(List<Tshirt> tshirts)
        {
            bool didAtLeastOneSwap = false;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    didAtLeastOneSwap = false;
                    if (tshirts[j].Fabric < tshirts[j + 1].Fabric)
                    {
                        Tshirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                        didAtLeastOneSwap = true;
                    }
                }
                if (didAtLeastOneSwap)
                    break;
            }
        }

        public void SortBySizeAscending(List<Tshirt> tshirts)
        {
            bool didAtLeastOneSwap = false;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    didAtLeastOneSwap = false;
                    if (tshirts[j].Size > tshirts[j + 1].Size)
                    {
                        Tshirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                        didAtLeastOneSwap = true;
                    }
                }
                if (didAtLeastOneSwap)
                    break;
            }
        }

        public void SortBySizeDescending(List<Tshirt> tshirts)
        {
            bool didAtLeastOneSwap = false;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    didAtLeastOneSwap = false;
                    if (tshirts[j].Size < tshirts[j + 1].Size)
                    {
                        Tshirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                        didAtLeastOneSwap = true;
                    }
                }
                if (didAtLeastOneSwap)
                    break;
            }
        }

        public void SortBySizeThenColorThenFabricAscending(List<Tshirt> tshirts)
        {
            bool didAtLeastOneSwap = false;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    didAtLeastOneSwap = false;
                    bool comparisonCondition = (tshirts[j].Size > tshirts[j + 1].Size) ||
                        (tshirts[j].Size == tshirts[j + 1].Size && tshirts[j].Color > tshirts[j + 1].Color) ||
                        (tshirts[j].Size == tshirts[j + 1].Size && tshirts[j].Color == tshirts[j + 1].Color && tshirts[j].Fabric > tshirts[j + 1].Fabric);


                    if (comparisonCondition)
                    {
                        Tshirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                        didAtLeastOneSwap = true;
                    }
                }
                if (didAtLeastOneSwap)
                    break;
            }
        }

        public void SortBySizeThenColorThenFabricDescending(List<Tshirt> tshirts)
        {
            bool didAtLeastOneSwap = false;
            for (int i = 0; i < tshirts.Count; i++)
            {
                for (int j = 0; j < tshirts.Count - 1 - i; j++)
                {
                    didAtLeastOneSwap = false;
                    bool comparisonCondition = (tshirts[j].Size < tshirts[j + 1].Size) ||
                        (tshirts[j].Size == tshirts[j + 1].Size && tshirts[j].Color < tshirts[j + 1].Color) ||
                        (tshirts[j].Size == tshirts[j + 1].Size && tshirts[j].Color == tshirts[j + 1].Color && tshirts[j].Fabric < tshirts[j + 1].Fabric);

                    if (comparisonCondition)
                    {
                        Tshirt temp = tshirts[j];
                        tshirts[j] = tshirts[j + 1];
                        tshirts[j + 1] = temp;
                        didAtLeastOneSwap = true;
                    }
                }
                if (didAtLeastOneSwap)
                    break;
            }
        }
    }
}

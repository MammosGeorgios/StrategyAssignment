using StrategyAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.Interfaces
{
    interface ISortStrategy
    {
        void SortBySizeAscending(List<Tshirt> tshirts);
        void SortBySizeDescending(List<Tshirt> tshirts);
        void SortByColorAscending(List<Tshirt> tshirts);
        void SortByColorDescending(List<Tshirt> tshirts);
        void SortByFabricAscending(List<Tshirt> tshirts);
        void SortByFabricDescending(List<Tshirt> tshirts);
        void SortBySizeThenColorThenFabricAscending(List<Tshirt> tshirts);
        void SortBySizeThenColorThenFabricDescending(List<Tshirt> tshirts);
    }
}

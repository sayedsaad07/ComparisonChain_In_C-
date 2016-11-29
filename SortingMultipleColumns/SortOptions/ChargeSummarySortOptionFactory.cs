using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMultipleColumns
{
    internal class ChargeSummarySortOptionFactory
    {
        internal static IChargeSummarySortOption<ClaimLine> GetInstance(SortingOptions sortOption)
        {
            switch (sortOption)
            {
                case SortingOptions.TotalCharges:
                    return new TotalChargeSortOption();    
                case SortingOptions.RVU:
                    return new RVUSortOption();
                case SortingOptions.RevCode:
                    return new RevenueCodeSortOption();
                case SortingOptions.None:
                default:
                    return null;
            }
        }
    }
}

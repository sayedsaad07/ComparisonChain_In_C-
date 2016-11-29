using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMultipleColumns
{
    internal class ChargeSummarySortOptionFactory
    {
        internal static IComparer<ClaimLine> GetInstance(SortingOptions sortOption)
        {
            switch (sortOption)
            {
                case SortingOptions.TotalCharges:
                    return new TotalChargesComparer();    
                case SortingOptions.RVU:
                    return new RVUComparer();
                case SortingOptions.RevCode:
                    return new RevCodeComparer();
                case SortingOptions.None:
                default:
                    return null;
            }
        }
    }
}

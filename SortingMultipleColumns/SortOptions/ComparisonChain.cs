using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMultipleColumns
{
    public class ComparisonChain : IComparer<ClaimLine>
    {
        List<IComparer<ClaimLine>> claimlineComparers;
        public ComparisonChain()
        {
            claimlineComparers = new List<IComparer<ClaimLine>>();
        }
        public void AddComparer(IComparer<ClaimLine> claimlineComparer)
        {
            claimlineComparers.Add(claimlineComparer);
        }
        public int Compare(ClaimLine first, ClaimLine second)
        {
            foreach (var Comparer in claimlineComparers)
            {
                var isequal = Comparer.Compare(first, second);
                if (isequal != 0)
                {
                    return isequal;
                }
                else
                {
                    continue;
                }
            }
            return 0;

        }
    }
}

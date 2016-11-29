using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMultipleColumns
{
    internal class RVUComparer : ClaimLineComparer
    {
        public RVUComparer(bool desc = false) : base(desc)
        {
        }
        public override int Compare(ClaimLine first, ClaimLine second)
        {
            if (DESC)
            {
                if (first.RVU < second.RVU) return 1;
                else if (first.RVU > second.RVU) return -1;
            }
            else
            {
                if (first.RVU < second.RVU) return -1;
                else if (first.RVU > second.RVU) return 1;
            }
            return 0;
        }
    }
    class RVUSortOption : IChargeSummarySortOption<ClaimLine>
    {
        public IComparer<ClaimLine> GetComparer()
        {
            return new RVUComparer(desc: true);
        }

        public void PreSort(List<ClaimLine> claimLines)
        {
            return;
        }
    }
}

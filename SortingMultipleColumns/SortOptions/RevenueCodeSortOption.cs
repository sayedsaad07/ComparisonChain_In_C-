using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMultipleColumns
{
    internal class RevCodeComparer : ClaimLineComparer
    {
        public RevCodeComparer(bool desc = false) : base(desc)
        {
        }
        public override int Compare(ClaimLine first, ClaimLine second)
        {
            if (DESC)
            {
                return first.RevCode.CompareTo(second.RevCode) * -1;
            }
            return first.RevCode.CompareTo(second.RevCode);
        }
    }
    internal class RevenueCodeSortOption : IChargeSummarySortOption<ClaimLine>
    {
        public IComparer<ClaimLine> GetComparer()
        {
            return new RevCodeComparer(desc: false);
        }

        public void PreSort(List<ClaimLine> claimLines)
        {
            return;
        }
    }
}

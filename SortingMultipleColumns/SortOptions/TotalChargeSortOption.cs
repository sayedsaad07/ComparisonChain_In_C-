using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMultipleColumns
{
    internal class TotalChargesComparer : ClaimLineComparer
    {
        public TotalChargesComparer(bool desc = false) : base(desc)
        {
        }
        public override int Compare(ClaimLine first, ClaimLine second)
        {
            if (DESC)
            {
                if (first.TotalCharge < second.TotalCharge) return 1;
                else if (first.TotalCharge > second.TotalCharge) return -1;
            }
            else
            {
                if (first.TotalCharge < second.TotalCharge) return -1;
                else if (first.TotalCharge > second.TotalCharge) return 1;
            }
            return 0;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMultipleColumns
{
    internal interface IChargeSummarySortOption<T>
    {
        void PreSort(List<T> claimLines);
        IComparer<T> GetComparer(); 
    }


    internal abstract class ClaimLineComparer : IComparer<ClaimLine>
    {
        protected bool DESC = false;
        public ClaimLineComparer(bool desc = false)
        {
            DESC = desc;
        }
        public abstract int Compare(ClaimLine first, ClaimLine second);
    }
    

}

using System;
using System.Collections.Generic;

namespace SortingMultipleColumns
{
    internal class ClaimlineSortBuilder
    {
        private List<ClaimLine> SortedClaimlines= null;
        private IComparer<ClaimLine> FirstSort = null;
        private IComparer<ClaimLine> SecondSort = null;
        private IComparer<ClaimLine> ThirdSort = null;
        public ClaimlineSortBuilder(List<ClaimLine> claimlines)
        {
            this.SortedClaimlines = claimlines;
        }

        internal IComparer<ClaimLine> SetFirstSort(SortingOptions sortOption)
        {
            FirstSort =  ChargeSummarySortOptionFactory.GetInstance(sortOption);
            return FirstSort;
        }

        internal IComparer<ClaimLine> SetSecondSort(SortingOptions sortOption)
        {
            SecondSort = ChargeSummarySortOptionFactory.GetInstance(sortOption);
            return SecondSort;
        }

        internal IComparer<ClaimLine> SetThirdSort(SortingOptions sortOption)
        {
            ThirdSort = ChargeSummarySortOptionFactory.GetInstance(sortOption);
            return ThirdSort;
        }

        internal List<ClaimLine> getSortedClaiLiness()
        {
            ComparisonChain comparisonlist = new ComparisonChain();
            if(FirstSort != null)
            comparisonlist.AddComparer(FirstSort);
            if (SecondSort != null)
                comparisonlist.AddComparer(SecondSort);
            if (ThirdSort != null)
                comparisonlist.AddComparer(ThirdSort);
            SortedClaimlines.Sort(comparisonlist);
            return SortedClaimlines;
        }
    }
}
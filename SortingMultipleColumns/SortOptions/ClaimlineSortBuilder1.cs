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
            var sortByOption =  ChargeSummarySortOptionFactory.GetInstance(sortOption);
            if (sortByOption == null) return null;
            sortByOption.PreSort(SortedClaimlines);
            FirstSort = sortByOption.GetComparer();
            return FirstSort;
        }

        internal IComparer<ClaimLine> SetSecondSort(SortingOptions sortOption)
        {
            var sortByOption = ChargeSummarySortOptionFactory.GetInstance(sortOption);
            if (sortByOption == null) return null;
            sortByOption.PreSort(SortedClaimlines);
            SecondSort = sortByOption.GetComparer();
            return SecondSort;
        }

        internal IComparer<ClaimLine> SetThirdSort(SortingOptions sortOption)
        {
            var sortByOption = ChargeSummarySortOptionFactory.GetInstance(sortOption);
            if (sortByOption == null) return null;
            sortByOption.PreSort(SortedClaimlines);
            ThirdSort = sortByOption.GetComparer();
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
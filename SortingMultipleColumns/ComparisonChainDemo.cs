using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMultipleColumns
{
    public class ComparisonChainDemo
    {
        public void process() {
            var claimlines = ClaimLineHelper.CreateClaimLines();
            ComparisonChain comparisonlist = new ComparisonChain();
            comparisonlist.AddComparer(new TotalChargesComparer(desc: true));
            comparisonlist.AddComparer(new RVUComparer(desc: false));
            //comparisonlist.AddComparer(new RevCodeComparer());
            claimlines.Sort(comparisonlist);

            foreach (var cl in claimlines)
            {
                Console.WriteLine(cl.ToString());
            }


            Console.ReadLine();
        }
      
    }
}

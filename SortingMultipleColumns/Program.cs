using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SortingMultipleColumns
{
    class Program
    {
        //static void Main(string[] args)
        //rename Main to test constructor
        static void Main(string[] args)
        {
            var claimlines = ClaimLineHelper.CreateClaimLines();
            Console.WriteLine("Before Sorting.... \n");
            foreach (var cl in claimlines)
            {
                Console.WriteLine(cl.ToString());
            }

            Console.WriteLine("\nAfter Sorting BY Rev code-ASC, RVU-DESC, and Total charges-DESC \n");
            var claimlineSortBuilder = new ClaimlineSortBuilder(claimlines);
            claimlineSortBuilder.SetFirstSort(SortingOptions.RevCode );
            claimlineSortBuilder.SetSecondSort(SortingOptions.RVU);
            claimlineSortBuilder.SetThirdSort(SortingOptions.TotalCharges);
            List<ClaimLine> sortedclaimLines =  claimlineSortBuilder.getSortedClaiLiness();
          

            foreach (var cl in sortedclaimLines)
            {
                Console.WriteLine(cl.ToString());
            }


            Console.ReadLine();
        }


    }

}

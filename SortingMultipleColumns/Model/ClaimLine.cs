using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMultipleColumns
{
    public static class ClaimLineHelper{
        public  static List<ClaimLine> CreateClaimLines()
        {
            var claimlines = new List<ClaimLine>();
            claimlines.Add(new ClaimLine(1, 100, 3, "0100", "99000"));
            claimlines.Add(new ClaimLine(3, 150, 2, "0300", "99200"));
            claimlines.Add(new ClaimLine(2, 130, 5, "0400", "99000"));
            claimlines.Add(new ClaimLine(3, 130, 4, "0200", "99100"));
            claimlines.Add(new ClaimLine(3, 150, 5, "0400", "99100"));
            claimlines.Add(new ClaimLine(4, 150, 7, "0100", "99200"));
            claimlines.Add(new ClaimLine(1, 110, 1, "0100", "99000"));
            return claimlines;
        }
    }
    public class ClaimLine
    {
        public ClaimLine(int seq , decimal charges , int rvu , string revcode , string hcpcscode)
        {
            SequenceNumber = seq;
            TotalCharge = charges;
            RVU = rvu;
            RevCode = revcode;
            HCPCSCode = hcpcscode;
        }
        public int SequenceNumber { get; set; }
        public decimal TotalCharge { get; set; }

        public int RVU { get; set; }

        public string RevCode { get; set; }

        public string HCPCSCode { get; set; }


        public override string ToString()
        {
            return 
            "SequenceNumber " + SequenceNumber +
            "\t TotalCharge " + TotalCharge +
            "\t RVU " + RVU +
            "\t RevCode " + RevCode +
            "\t HCPCSCode " + HCPCSCode;
        }
    }
}

using System;
using System.Configuration;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace Txt2Sql2 {
    class Program {
        static void Main(string[] args) {

            var db = new AppDbContext();

            var gpd = new GerberPasDaily {
                PAS_ID = 11,
                SRC_CD = "bb",
                ACCTG_BASIS_CD = "cc",
                REF_ID = "dd",
                CMPNY_CD = "ee",
                EAS_ACCT_NO = "ff",
                CLNDR_ACCTG_MNTH_NO = "gg",
                CLNDR_ACCTG_YR_NO = "hh",
                LOB_CD = "ii",
                DBT_CR_IND = "jj",
                CONVERTED_AMT = "kk",
                BCTR_CD = "ll",
                REINS_CMPNY_CD = "mm",
                STATE_CD = "nn",
                TAX_STAT_TXT = "oo",
                HDR_DESC_TXT = "pp",
                PLAN_CD = "qq",
                SAP_ACCT_NO = "rr",
                PRFT_CTR_TXT = "ss",
                PLCY_NO = "tt",
                TRANS_DT = "uu",
                CLNDR_DT = "vv",
                MEMO_CD = "ww"
            };
            db.GERBER_PAS_DAILY.Add(gpd);
            db.SaveChanges();

            var recs = db.GERBER_PAS_DAILY.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Txt2Sql2 {
    class Program {
        static void Main(string[] args) {

            var db = new AppDbContext();

            var data = LoadFile("Gerber-Pas-Daily.pipedelim");
            data.ForEach(rec => {
                var gpd = new GerberPasDaily {
                    ACCTG_BASIS_CD = rec["ACCTG_BASIS_CD"],
                    BCTR_CD = rec["BCTR_CD"],
                    CLNDR_ACCTG_MNTH_NO = rec["CLNDR_ACCTG_MNTH_NO"],
                    CLNDR_ACCTG_YR_NO = rec["CLNDR_ACCTG_YR_NO"],
                    CLNDR_DT = rec["CLNDR_DT"],
                    CMPNY_CD = rec["CMPNY_CD"],
                    CONVERTED_AMT = rec["CONVERTED_AMT"],
                    DBT_CR_IND = rec["DBT_CR_IND"],
                    EAS_ACCT_NO = rec["EAS_ACCT_NO"],
                    HDR_DESC_TXT = rec["HDR_DESC_TXT"],
                    LOB_CD = rec["LOB_CD"],
                    MEMO_CD = rec["MEMO_CD"],
                    PAS_ID = 0,
                    PLAN_CD = rec["PLAN_CD"],
                    PLCY_NO = rec["PLCY_NO"],
                    PRFT_CTR_TXT = rec["PRFT_CTR_TXT"],
                    REF_ID = rec["REF_ID"],
                    REINS_CMPNY_CD = rec["REINS_CMPNY_CD"],
                    SAP_ACCT_NO = rec["SAP_ACCT_NO"],
                    SRC_CD = rec["SRC_CD"],
                    STATE_CD = rec["STATE_CD"],
                    TAX_STAT_TXT = rec["TAX_STAT_TXT"],
                    TRANS_DT = rec["TRANS_DT"]
                };
                db.GERBER_PAS_DAILY.Add(gpd);
            });
            db.SaveChanges();
        }
        static List<Dictionary<string, string>> LoadFile(string infile) {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Gerber-Pas-Daily.pipedelim");
            var lines = File.ReadAllLines(filepath);
            var columnNames = lines[0].Split('|');
            var dataLines = lines[1..];
            var data = new List<Dictionary<string, string>>();
            foreach(var line in dataLines) {
                var fields = line.Split('|');
                var row = new Dictionary<string, string>(dataLines.Length);
                for(var idx = 0; idx < fields.Length; idx++) {
                    var colName = columnNames[idx];
                    var colValue = fields[idx];
                    row.Add(colName, colValue);
                }
                data.Add(row);
            }
            return data;
        }
    }
}

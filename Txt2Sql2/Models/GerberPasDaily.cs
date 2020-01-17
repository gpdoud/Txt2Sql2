using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Txt2Sql2 {
    
    public class GerberPasDaily {
        public int Id { get; set; }
        public int PAS_ID { get; set; }
        public string SRC_CD { get; set; }
        public string ACCTG_BASIS_CD { get; set; }
        public string REF_ID { get; set; }
        public string CMPNY_CD { get; set; }
        public string EAS_ACCT_NO { get; set; }
        public string CLNDR_ACCTG_MNTH_NO { get; set; }
        public string CLNDR_ACCTG_YR_NO { get; set; }
        public string LOB_CD { get; set; }
        public string DBT_CR_IND { get; set; }
        public string CONVERTED_AMT { get; set; }
        public string BCTR_CD { get; set; }
        public string REINS_CMPNY_CD { get; set; }
        public string STATE_CD { get; set; }
        public string TAX_STAT_TXT { get; set; }
        public string HDR_DESC_TXT { get; set; }
        public string PLAN_CD { get; set; }
        public string SAP_ACCT_NO { get; set; }
        public string PRFT_CTR_TXT { get; set; }
        public string PLCY_NO { get; set; }
        public string TRANS_DT { get; set; }
        public string CLNDR_DT { get; set; }
        public string MEMO_CD { get; set; }

        public GerberPasDaily() {}
    }
}

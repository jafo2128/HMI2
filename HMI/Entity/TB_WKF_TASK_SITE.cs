//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMI.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_WKF_TASK_SITE
    {
        public string SITE_ID { get; set; }
        public string TASK_ID { get; set; }
        public Nullable<System.DateTime> START_TIME { get; set; }
        public Nullable<System.DateTime> FINISH_TIME { get; set; }
        public Nullable<int> SITE_STATUS { get; set; }
        public Nullable<int> SITE_RESULT { get; set; }
        public int SITE_TYPE { get; set; }
        public string SOURCE_SITE_ID { get; set; }
        public string SOURCE_DOC_ID { get; set; }
        public string PREV_SITE_ID { get; set; }
        public string NEXT_SITE_ID { get; set; }
        public string ALERT_USER { get; set; }
        public Nullable<int> TIMEOUT_COUNT { get; set; }
        public Nullable<bool> IS_SIGNABLE_SITE { get; set; }
        public int SIGN_TYPE { get; set; }
        public string PARENT_SITE_ID { get; set; }
        public string SUB_START_SITE_ID { get; set; }
        public string SUB_FINISH_SITE_ID { get; set; }
        public string GRP_SITE_ID { get; set; }
        public Nullable<int> CUST_TYPE { get; set; }
        public string CUST_SITE_ID { get; set; }
        public string RETURN_TO { get; set; }
        public bool IS_VALID { get; set; }
        public string ADDTIONAL_FLOW_ID { get; set; }
        public Nullable<int> SOURCE_SITE_SEQ { get; set; }
        public string SOURCE_ADDITIONAL_SITE_ID { get; set; }
        public string RA_JUMP_RESEND_SITE { get; set; }
        public string EXTERNAL_SITE_ID { get; set; }
        public int EXTERNAL_TYPE { get; set; }
        public bool IS_PREADDITIONAL_SITE { get; set; }
        public string PREADDITIONAL_FLOW { get; set; }
        public bool IS_SKIPPED_SITE { get; set; }
    }
}

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
    
    public partial class TB_WKF_SITE_SIGN
    {
        public string SITE_ID { get; set; }
        public Nullable<int> TIMEOUT_COUNT { get; set; }
        public Nullable<bool> IS_END_FLOW { get; set; }
        public Nullable<bool> IS_ADDITIONAL_SIGN { get; set; }
        public Nullable<bool> IS_JUMP_SIGN { get; set; }
        public Nullable<bool> IS_ASSIGN { get; set; }
        public Nullable<int> SIGN_TYPE { get; set; }
        public string GENERAL_SIGNERS { get; set; }
        public string ALERT_GENERAL_SIGNERS { get; set; }
        public Nullable<bool> IS_APPLYER_SIGN { get; set; }
        public Nullable<bool> IS_FLOW_START_SIGN { get; set; }
        public Nullable<bool> IS_LAST_AGENT_SIGN { get; set; }
        public Nullable<bool> IS_APPLYER_SUPERIOR_SIGN { get; set; }
        public Nullable<bool> IS_LAST_SUPERIOR_SIGN { get; set; }
        public Nullable<bool> IS_APPLYER_ALERT { get; set; }
        public Nullable<bool> IS_FLOW_START_ALERT { get; set; }
        public Nullable<bool> IS_LAST_AGENT_ALERT { get; set; }
        public Nullable<bool> IS_APPLYER_SUPERIOR_ALERT { get; set; }
        public Nullable<bool> IS_LAST_SUPERIOR_ALERT { get; set; }
        public bool IS_MODIFIABLE { get; set; }
        public string SITE_INFO { get; set; }
    }
}

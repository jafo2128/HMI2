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
    
    public partial class TB_EIP_BULLETIN_EXAMINE_LOG
    {
        public string LOG_GUID { get; set; }
        public string CLASS_GUID { get; set; }
        public string BULLETIN_GUID { get; set; }
        public string STATUS { get; set; }
        public string COMMENT { get; set; }
        public string CREATE_USER { get; set; }
        public string CREATE_FROM { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public string MODIFY_USER { get; set; }
        public string MODIFY_FROM { get; set; }
        public Nullable<System.DateTime> MODIFY_DATE { get; set; }
    }
}

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
    
    public partial class TB_WKF_FVR_SITE_CALLBACK_RECORD
    {
        public string RECORD_ID { get; set; }
        public string FORM_VERSION_ID { get; set; }
        public string SITE_ID { get; set; }
        public string PARENT_SITE_ID { get; set; }
        public string TASK_ID { get; set; }
        public Nullable<System.DateTime> LAST_SEND_TIME { get; set; }
        public Nullable<int> SEND_COUNT { get; set; }
        public Nullable<int> SEND_FLAG { get; set; }
        public string REMARK { get; set; }
    }
}

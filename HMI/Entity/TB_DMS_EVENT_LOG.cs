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
    
    public partial class TB_DMS_EVENT_LOG
    {
        public int AutoID { get; set; }
        public string EVENT_TYPE { get; set; }
        public string EVENT_ACTION { get; set; }
        public string EVENT_USER { get; set; }
        public Nullable<System.DateTime> EVENT_TIME { get; set; }
        public string EVENT_OBJECT { get; set; }
        public string EVENT_BEFORE { get; set; }
        public string EVENT_AFTER { get; set; }
        public string EVENT_PARENT_FOLDER { get; set; }
    }
}

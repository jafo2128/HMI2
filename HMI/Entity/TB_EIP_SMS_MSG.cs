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
    
    public partial class TB_EIP_SMS_MSG
    {
        public string MSG_ID { get; set; }
        public string SUBJECT { get; set; }
        public string CONTENT { get; set; }
        public System.DateTime SEND_TIME { get; set; }
        public int TOTAL_MSG_COUNT { get; set; }
        public int SEND_RESULT { get; set; }
        public int SUCCESS_COUNT { get; set; }
        public int FAIL_COUNT { get; set; }
        public string SEND_USER_GUID { get; set; }
        public string RECEIVER_USER_SET { get; set; }
        public bool IS_NOW { get; set; }
        public System.DateTime CREATE_TIME { get; set; }
        public string CREATE_USER_GUID { get; set; }
        public string CREATE_FROM { get; set; }
        public Nullable<System.DateTime> UPDATE_TIME { get; set; }
        public string UPDATE_USER_GUID { get; set; }
        public string UPDATE_FROM { get; set; }
    }
}

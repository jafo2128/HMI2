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
    
    public partial class TB_EIP_FORUM_TOPIC
    {
        public string TOPIC_GUID { get; set; }
        public string ARTICLE_GUID { get; set; }
        public string BOARD_GUID { get; set; }
        public string LAST_REPLY_USER { get; set; }
        public Nullable<System.DateTime> LAST_REPLY_DATE { get; set; }
        public int REPLY_TIMES { get; set; }
        public int READ_TIMES { get; set; }
        public int RECOMMEND_TIMES { get; set; }
        public bool IS_TOP { get; set; }
        public bool IS_LOCK { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
    }
}

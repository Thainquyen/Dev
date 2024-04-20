using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietChat.Model
{
    public class ChatData
    {
        public string list_id { get; set; }
        public int type { get; set; }
        public string show_name { get; set; }
        public DataList list { get; set; }
    }

    public class DataList
    {
        public int type { get; set; }
        public Message msg { get; set; }
    }

    public class Message
    {
        public int type { get; set; }
        public string id {  get; set; } 
        public int time { get; set; }
        public int is_niming { get; set; }

        public Content content { get; set; }

        public UserInfo user_info { get; set; }
    }

    public class UserInfo
    {
        public int uid { get; set; }

        public string username { get; set; }

        public string face { get; set; }
    }

    public class Content
    {
        public string text { get; set; }
    }
}

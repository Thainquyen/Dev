using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietChat.Model
{
    public class ChatDataResponse
    {

        public ChatDataResponse() => data = new List<ChatDetail>();
        public int err { get; set; }
        public string msg { get; set; }

        public List<ChatDetail> data { get; set; }

    }

    public class ChatDetail
    {
        public int last_chat_time { get; set; }
        public string chat_id { get; set; }
        public string last_msg { get; set; }
        public string list_id { get; set; }
        public string photo_path { get; set; }
        public string show_name { get; set; }
        public int time { get; set; }
        public int top { get; set; }
        public int top_time { get; set; }
        public int type { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietChat.Model
{
    public class BaseUserInfo
    {
        public string kefu_list_id {  get; set; }
        public int new_friend_tips_num { get; set; }
        public int new_group_tips_num { get; set; }
        public int no_reader_chat_num { get; set; }
        public int no_reader_circle { get; set; }
        public int no_reader_circle_chat_num { get; set; }
        public int err { get; set; }
        public string msg { get; set; }

        public BaseDataInfo data { get; set; }

    }

    public class BaseDataInfo
    {
        public User user_info { get; set; }
    }

    public class User
    {
        public string circle_img { get; set; }
        public string doodling { get; set; }
        public string money { get; set; }
        public string nickname { get; set; }
        public string photo { get; set; }
        public string trade_password { get; set; }
        public string username { get; set; }
        public int id { get; set; }
        public int sex { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietChat.Model
{
    public class FriendInfo
    {
        public string photo {  get; set; }
        public int user_id { get; set; }
        public string name { get; set; }
    }
    public class Friend
    {
        public Friend()
        {
            data = new FriendInfo();
        }
        public string letter { get; set; }
        public FriendInfo data { get; set; }
        public int index { get; set; }

    }

    public class FriendListData
    {
        public FriendListData()
        {
            data = new List<Friend>();
        }
        public List<Friend> data { get; set; }

    }

}

namespace VietChat.Model
{

    public class FriendApplyInfo
    {
        public int? user_id { get; set; }
        public string? content { get; set; }
        public string? id { get; set; }
        public string? text { get; set; }
        public string? photo { get; set; }
        public string? nickname { get; set; }
    }

    public class FriendApplyResponse
    {
        public FriendApplyResponse()
        {
            data = new List<FriendApplyInfo>();
        }
        public List<FriendApplyInfo> data { get; set; }
        public int err { get; set; }
        public string msg { get; set; }
    }
}

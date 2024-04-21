using Newtonsoft.Json.Linq;

namespace VietChat
{
    internal class Common
    {
        public const string GET_PHOTO_API = "https://bat.vietvozchat.online/static/photo/";

        public static string user = string.Empty;
        public static string pass = string.Empty;
        public static int uId = 0;
        public static string nickname = string.Empty;

        public static Bitmap b_image_user;

        public static int error_flag = 0;
        public static string msg = string.Empty;
        public static string token = string.Empty;

        public static string name_friend = string.Empty;
        public static string user_id_friend = string.Empty;
        public static string photo = string.Empty;

        public static string list_id = string.Empty;
        public static string chat_id = string.Empty;
        public static string last_msg = string.Empty;

        public static JArray list_friend = new JArray();

        public static JObject job_friend = new JObject();

    }
}

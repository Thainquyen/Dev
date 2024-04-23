﻿namespace VietChat.Model
{

    public class data
    {
        public int? id { get; set; }
        public string? nickname { get; set; }
        public int? sex { get; set; }
        public string? photo { get; set; }
    }

    public class DataInfo
    {
        public data? data { get; set; }
        public int? is_type { get; set; }
    }

    public class DataResuft
    {
        public DataInfo? data { get; set; }
        public int err { get; set; }
        public string msg { get; set; }

    }

}

using System;

namespace Web.Twitter.DataStructures
{
    [Serializable]
    public class Tweet
    {
        public string created_at;
        public string id;
        public string lang;
        public string text;
        public string source;
        public string in_reply_to_status_id;
        public string in_reply_to_user_id;
        public string in_reply_to_screen_name;
        public UserProfile user;
        public Tweet retweeted_status;
        public string geo;
        public string coordinates;
        public string place;
        public string contributors;
        public bool is_quote_status;
        public int retweet_count;
        public int favorite_count;
        public bool retweeted;
        public bool favourited;
    }
}
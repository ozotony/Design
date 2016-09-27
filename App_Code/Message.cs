using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helper
{
    public static class Message
    {
        //Put all your message type here. Make sure that you add a CSS Class with same name of this type
        public enum Type
        {
            success, error, info
        };

        //Put all your Messages here. In that way all your team members can use same message for same purpose.
        public static class Text
        {
            public const string START_INFO = "Click on the buttons to show different messages. This message will automatically hide after 10 seconds.";

            public const string SUCCESS_SERVER = "This is a Success message from Server Side.";
            public const string ERROR_SERVER = "This is an Error message from Server Side.";
            public const string INFO_SERVER = "This is a general Info message from Server Side.";

            public const string SUCCESS_CLIENT = "This is a Success message from  Client Side.";
            public const string ERROR_CLIENT = "This is an Error message from Client Side.";
            public const string INFO_CLIENT = "This is an Info message from Client Side. This is used for general purpose.";
        }
    }
}
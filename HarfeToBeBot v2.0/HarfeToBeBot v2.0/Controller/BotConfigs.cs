using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfeToBeBot_v2._0.Controller {
    static class BotConfigs {

        // Bot Detail
        public const string BOT_TOKEN = "";
        public const string BOT_NAME = "HarfeToBeBot?start=";
        public const string BOT_INSTAGRAM_LINK = "https://t.me/" + BOT_NAME;
        public const string BOT_TELEGRAM_LINK = "https://telegram.me/" + BOT_NAME;

        // Available Bot Commands
        public const string CMD_START = "/start";
        public const string CMD_BACK = "/back";
        public const string CMD_INBOX = "/inbox";
        public const string CMD_REPLY = "/reply";
        public const string CMD_LINK = "/mylink";
        public const string CMD_HELP = "/help";

        // Preset Messages
        public const string MSG_WELCOME = "";
        public const string MSG_HELP = "";
        public const string MSG_GET_NAME = "";
        public const string MSG_EXCEPTION = "";
        public const string MSG_RECEIVE_CMD = "چه کاری می تونم برات انجام بدم؟";
    }
}

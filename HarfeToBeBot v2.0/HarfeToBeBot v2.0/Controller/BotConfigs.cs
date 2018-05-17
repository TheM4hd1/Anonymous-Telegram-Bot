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
        public const string CMD_INBOX = "پیام های دریافت شده";
        public const string CMD_REPLY = "/reply";
        public const string CMD_LINK = "می خوام پیام ناشناس دریافت کنم";
        public const string CMD_HELP = "راهنما";

        // Preset Messages
        public const string MSG_WELCOME = " سلام به حرف تو به بات خوش اومدی" + View.Emoji.FACE_WITH_HEART + "\nبا کمک من میتونی برای دوستات بصورت ناشناس پیام بفرستی\n" + "اگر کمک خواستی روی راهنما کلیک کن";
        public const string MSG_HELP = "";
        public const string MSG_GET_NAME = "";
        public const string MSG_EXCEPTION = "";
        public const string MSG_RECEIVE_CMD = "چه کاری می تونم برات انجام بدم؟";
        public const string MSG_SENDING_ANONYMOUS_TO = "شما در حال ارسال پیام ناشناس به X هستید.";
        public const string MSG_USER_NOT_FOUND = "متاسفانه چنین شخصی رو نداریم\n لینک یا آیدی که وارد کردی اشتباهه.";
    }
}

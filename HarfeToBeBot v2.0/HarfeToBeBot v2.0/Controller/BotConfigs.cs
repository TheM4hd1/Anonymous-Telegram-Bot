using HarfeToBeBot_v2._0.View;
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
        public const string CMD_BACK = Emoji.BACK + " بازگشت به منوی اصلی";
        public const string CMD_INBOX = Emoji.INBOX + " پیام های دریافت شده";
        public const string CMD_REPLY = Emoji.REPLY + " می خوام به پیام پاسخ بدم";
        public const string CMD_LINK = Emoji.ENVELOPE + " می خوام پیام ناشناس دریافت کنم";
        public const string CMD_HELP = "راهنما";

        // Preset Messages
        public const string MSG_WELCOME = " سلام به حرف تو به بات خوش اومدی" + View.Emoji.FACE_WITH_HEART + "\nبا کمک من میتونی برای دوستات بصورت ناشناس پیام بفرستی\n" + "اگر کمک خواستی روی راهنما کلیک کن";
        public const string MSG_HELP = "";
        public const string MSG_GET_NAME = "اسمت رو وارد کن تا بفیه موقع ارسال پیام بدونن دارن برای کی پیام میفرستن";
        public const string MSG_EXCEPTION = "";
        public const string MSG_RECEIVE_CMD = "چه کاری می تونم برات انجام بدم؟";
        public const string MSG_SENDING_ANONYMOUS_TO = "شما در حال ارسال پیام ناشناس به X هستید.";
        public const string MSG_USER_NOT_FOUND = "متاسفانه چنین شخصی رو نداریم\n لینک یا آیدی که وارد کردی اشتباهه.";
        public const string MSG_SHOW_INBOX = "شما X پیام دریافت شده دارید\n";
        public const string MSG_SENT = "پیام شما ارسال شد.";
        public const string MSG_NEW_MESSAGE = "شما یک پیام جدید دارید";
        public const string MSG_ENTER_REPLY_NUMBER = "به کدوم پیام می خوای پاسخ بدی؟ فقط عددش رو برام ارسال کن\nاگر بیخیال شدی روی دکمه بازگشت کلیک کن";
        public const string MSG_ENTER_REPLY_MESSAGE = "پاسخت رو برام ارسال کن";
    }
}

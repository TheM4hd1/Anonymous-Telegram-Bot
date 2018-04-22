using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
namespace HarfeToBeBot_v2._0.View {
    class Keyboards {
        public ReplyKeyboardMarkup
            Main,
            Inbox,
            Back;

        public Keyboards() {
            Main = new ReplyKeyboardMarkup();
            KeyboardButton[] row_Mone = {
                new KeyboardButton(text: Emoji.ENVELOPE + " می خوام پیام ناشناس دریافت کنم") // i want to receive anonymous message
            };
            KeyboardButton[] row_Mtwo = {
                new KeyboardButton(text: Emoji.INBOX + " پیام های دریافت شده") // inbox
            };
            KeyboardButton[] row_Mthree = {
                new KeyboardButton(text: Emoji.QUESTION + " راهنما") // help
            };
            Main.Keyboard = new KeyboardButton[][] {
                row_Mone,row_Mtwo,row_Mthree
            };

            Inbox = new ReplyKeyboardMarkup();
            KeyboardButton[] row_Ione = {
                new KeyboardButton(text: Emoji.REPLY + " می خوام به پیام پاسخ بدم") // reply to message
            };
            KeyboardButton[] row_Itwo = {
                new KeyboardButton(text: Emoji.QUESTION + " چجوری از این ویژگی استفاده کنم؟") // how to use this feature
            };
            KeyboardButton[] row_Ithree = {
                new KeyboardButton(text: Emoji.BACK + " بازگشت به منوی اصلی") // back to main menu
            };
            Inbox.Keyboard = new KeyboardButton[][] {
                row_Ione,row_Itwo,row_Ithree
            };

            Back = new ReplyKeyboardMarkup();
            KeyboardButton[] row_Bone = {
                new KeyboardButton(text: Emoji.BACK + " بازگشت به منوی اصلی") // back to main menu
            };
            Back.Keyboard = new KeyboardButton[][] {
                row_Bone
            };
        }
    }
}

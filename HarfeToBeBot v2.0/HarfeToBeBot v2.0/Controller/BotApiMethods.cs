using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using HarfeToBeBot_v2._0.Model;
using HarfeToBeBot_v2._0.View;
using Telegram.Bot.Types.ReplyMarkups;
using System.Net;
using System.IO;

namespace HarfeToBeBot_v2._0.Controller {
    class BotApiMethods {

        TelegramBotClient TelegramBot;
        public View.Keyboards Keyboards;
        public BotApiMethods(TelegramBotClient telegramBot) {
            TelegramBot = telegramBot;
            Keyboards = new Keyboards();
        }

        public async Task<Image> GetProfileImageAsync(int userId) {
            Image profileImage;
            try {
                UserProfilePhotos profilePhotos = await TelegramBot.GetUserProfilePhotosAsync(userId);
                PhotoSize photoSize = profilePhotos.Photos[0][1];
                Telegram.Bot.Types.File profileFile = await TelegramBot.GetFileAsync(photoSize.FileId);
                Stream imageStream = new MemoryStream();
                Telegram.Bot.Types.File getFile = await TelegramBot.GetInfoAndDownloadFileAsync(profileFile.FileId, imageStream);

                profileImage = Image.FromStream(imageStream);
                profileImage.Save(imageStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            } catch (Exception ex) {
                ErrorHandler.SetError(source: "GetProfileImageAsync", error: ex.Message);
                profileImage = Image.FromFile("unkown.png");
            }

            return profileImage;
        }

        public string CreateAnonymousLinks(long id) {
            string contactCode = FindUserContactCode(id: id);
            string message = $"Link For Instagram: {BotConfigs.BOT_INSTAGRAM_LINK}{contactCode}\n" +
                $"Link For Telegram: {BotConfigs.BOT_TELEGRAM_LINK}{contactCode}";

            return message;
        }

        public string FindUserContactCode(long id) {
            try {
                string contactCode = "";
                return contactCode;
            } catch(Exception ex) {
                ErrorHandler.SetError(source: "GetUserContactCode(long id)", error: ex.Message);
                return null;
            }
        }

        public bool EditUserRequest(long id, UserRequests userRequests) {
            try {
                return true;
            } catch(Exception ex) {
                ErrorHandler.SetError(source: "EditUserRequest", error: ex.Message);
                return false;
            }
        }

        public async void SendTextMessageAsync(ChatId chatId, string message, ReplyKeyboardMarkup keyboard = null) {
            if(keyboard == null) {
                keyboard = Keyboards.Main;
            }
            await TelegramBot.SendTextMessageAsync(chatId: chatId, text: message, parseMode: Telegram.Bot.Types.Enums.ParseMode.Default, disableWebPagePreview: true, disableNotification: false, replyToMessageId: 0, replyMarkup: keyboard);
        }
    }
}

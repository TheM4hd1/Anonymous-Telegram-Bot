using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
namespace HarfeToBeBot_v2._0.Controller {
    class BotConnectionHandler {

        TelegramBotClient TelegramBot;
        UpdateHandler UpdateHandler;
        System.Windows.Forms.DataGridView DataGridView;
        string BotToken;

        public BotConnectionHandler(string token, System.Windows.Forms.DataGridView dataGridView) {
            BotToken = token;
            DataGridView = dataGridView;
        }

        public bool IsBotConnected() {
            try {
                TelegramBot = new TelegramBotClient(token: BotToken);
                UpdateHandler = new UpdateHandler(telegramBot: TelegramBot,dataGridView: DataGridView);
                return true;
            } catch (ArgumentException ex) {
                ErrorHandler.SetError(source: "BotConnected", error: ex.Message);
                return false;
            }
        }

        public async Task StartReceivingAsync() {
            int offset = 0;

            while (true) {
                try {
                    Update[] updates = await TelegramBot.GetUpdatesAsync(offset);
                    foreach (Update newUpdate in updates) {
                        offset = newUpdate.Id + 1;
                        if (newUpdate.Message.Equals(obj: null))
                            continue;

                        if (newUpdate.Message.Text != null)
                            await UpdateHandler.ReadTextMessageFromUpdateAsync(newUpdate);
                    }
                } catch (Exception ex) {
                    ErrorHandler.SetError(source: "GetUpdateAsync", error: ex.Message);
                }
            }
        }

    }
}

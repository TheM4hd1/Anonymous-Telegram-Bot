using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using HarfeToBeBot_v2._0.Model;
namespace HarfeToBeBot_v2._0.Controller {
    class UpdateHandler {

        TelegramBotClient TelegramBot;
        BotApiMethods BotApiMethods;
        DatabaseHandler DatabaseHandler;

        public UpdateHandler(TelegramBotClient telegramBot) {
            TelegramBot = telegramBot;
            BotApiMethods = new BotApiMethods(telegramBot);
            DatabaseHandler = new DatabaseHandler();
        }

        public async Task ReadTextMessageFromUpdateAsync(Update update) {
            User senderUser;
            ChatId chatId;
            string updateMessage = string.Empty;
            try {
                updateMessage = update.Message.Text;
                updateMessage = updateMessage.StartsWith("/") ? updateMessage.ToLower() : updateMessage;
                senderUser = update.Message.From;
                chatId = update.Message.Chat.Id;

                if (updateMessage.StartsWith(BotConfigs.CMD_START)) {
                    if(updateMessage.Equals(BotConfigs.CMD_START)) { //----------------------------------------------------------------- '/start'
                        if(DatabaseHandler.UserExists(id: chatId.Identifier)) { 
                            BotApiMethods.SendTextMessageAsync(chatId: chatId, message: BotConfigs.MSG_RECEIVE_CMD);//------------------------------------ Send "what can i do for u?"
                        } else {//---------------------------------------------------------------------------------------------------- Register new user
                            Image profileImage = await BotApiMethods.GetProfileImageAsync(senderUser.Id);
                            Model.NewUser newUser = new Model.NewUser(chatId, senderUser, profileImage);
                            if (DatabaseHandler.RegisterUser(newUser)) {
                                BotApiMethods.SendTextMessageAsync(chatId: chatId, message: BotConfigs.MSG_WELCOME); //------------------- Send "welcome message"
                            } else {
                                BotApiMethods.SendTextMessageAsync(chatId: chatId, message: BotConfigs.MSG_EXCEPTION);
                                // send to admin
                            }
                        }
                    } else { //--------------------------------------------------------------------------------------------------------  '/start contactcode'
                        if (!DatabaseHandler.UserExists(chatId.Identifier)) {// ------------------------------ Register new user
                            Image profileImage = await BotApiMethods.GetProfileImageAsync(senderUser.Id);
                            Model.NewUser newUser = new Model.NewUser(chatId, senderUser, profileImage);
                            if (!DatabaseHandler.RegisterUser(newUser)) {
                                BotApiMethods.SendTextMessageAsync(chatId: chatId, message: BotConfigs.MSG_EXCEPTION);//--------------------------------- sending a message to user that shows we are aware of the problem, we'll fix it soon
                                //------------------------------------------------------------------------------------------------------ send the problem to admin(s)
                                return;
                            }
                        }
                        string contactCode = updateMessage.Split(separator: ' ')[1]; //------ updateMessage = '/start contactCode'.splitBySpace ----> contactCode
                        if(DatabaseHandler.UserExists(contactCode: contactCode)) {
                            string fullName = DatabaseHandler.GetFullNameByContactCode(contactCode: contactCode);
                            BotApiMethods.SendTextMessageAsync(chatId: chatId, message: BotConfigs.MSG_SENDING_ANONYMOUS.Replace("X", fullName)); //---- "your sending anonymous message to 'fullName' please type your message"
                            // <SET REQUEST> 4/30/2018
                        } else {
                            BotApiMethods.SendTextMessageAsync(chatId: chatId, message: BotConfigs.MSG_USER_NOT_FOUND);//--------------- user not found
                        }
                        
                    }
                    

                } else if (updateMessage.StartsWith(BotConfigs.CMD_LINK)) { //------------------------------------------- Request contact links
                    if (DatabaseHandler.IsContactNameSet(id: chatId.Identifier)) {//---------------------------------------------------------------------- If user's name is set to database
                        string links = BotApiMethods.CreateAnonymousLinks(id: chatId.Identifier);//-------------------------------------------- Receive links
                        BotApiMethods.SendTextMessageAsync(chatId: chatId, message: links);
                    } else {//---------------------------------------------------------------------------------------------------------------------------------- before sending links, set user's name to database
                        if(BotApiMethods.EditUserRequest(id: chatId.Identifier, userRequests: Model.UserRequests.contactCode)) { // Add a request to database, user wants to enter his/her own name. database model { column 'Request' ---value---> 0000001 }
                            BotApiMethods.SendTextMessageAsync(chatId: chatId.Identifier, message: BotConfigs.MSG_GET_NAME);
                        } else {
                            BotApiMethods.SendTextMessageAsync(chatId: chatId, message: BotConfigs.MSG_EXCEPTION);
                            // send to admin
                        }
                    }
                } else if (updateMessage.StartsWith(BotConfigs.CMD_INBOX)) {

                } else if (updateMessage.StartsWith(BotConfigs.CMD_HELP)) {

                } else if (updateMessage.StartsWith(BotConfigs.CMD_REPLY)) {

                } else if (updateMessage.StartsWith(BotConfigs.CMD_BACK)) {

                } else { // --------------------------------------------------------------------------------------------------------------- Handling requests
                    string request = BotApiMethods.GetLastUserRequest(id: chatId.Identifier);
                    if (string.IsNullOrEmpty(request))
                        return;
                    if(request.Contains(UserRequests.contactCode.ToString())) {

                    } else if(request.Contains(UserRequests.sendMessage.ToString())) {

                    } else if (request.Contains(UserRequests.replyToMessage.ToString())) {

                    }
                }

            } catch (Exception ex) {
                ErrorHandler.SetError(source: "ReadMessageFromUpdateAsync", error: ex.Message);
                return;
            }
        }
    }
}

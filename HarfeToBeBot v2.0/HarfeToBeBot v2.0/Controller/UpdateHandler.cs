using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using HarfeToBeBot_v2._0.Model;
using System.Windows.Forms;
namespace HarfeToBeBot_v2._0.Controller {
    class UpdateHandler {

        TelegramBotClient TelegramBot;
        BotApiMethods BotApiMethods;
        DatabaseHandler DatabaseHandler;
        DataGridView DataGridView;
        public UpdateHandler(TelegramBotClient telegramBot, DataGridView dataGridView) {
            TelegramBot = telegramBot;
            BotApiMethods = new BotApiMethods(telegramBot);
            DatabaseHandler = new DatabaseHandler();
            DataGridView = dataGridView;
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

                // Update UI
                DataGridView.Invoke((MethodInvoker)delegate {
                    // From,Name,To,ReceiverName,Message
                    DataGridView.Rows.Add(chatId.Identifier, senderUser.FirstName, "BOT", "BOT", updateMessage);
                });

                if (updateMessage.StartsWith(BotConfigs.CMD_START)) {

                    if(updateMessage.Equals(BotConfigs.CMD_START)) { //----------------------------------------------------------------- '/start'
                        if(DatabaseHandler.UserExists(id: chatId.Identifier)) { 
                            BotApiMethods.SendTextMessageAsync(chatId: chatId, message: BotConfigs.MSG_RECEIVE_CMD);//------------------------------------ Send "what can i do for u?"
                        } else {//---------------------------------------------------------------------------------------------------- Register new user
                            Image profileImage = await BotApiMethods.GetProfileImageAsync(senderUser.Id);
                            Model.NewUser newUser = new Model.NewUser(chatId, senderUser, profileImage);
                            if (DatabaseHandler.RegisterUser(newUser: newUser)) {
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
                            if (!DatabaseHandler.RegisterUser(newUser: newUser)) {
                                BotApiMethods.SendTextMessageAsync(chatId: chatId, message: BotConfigs.MSG_EXCEPTION);//--------------------------------- sending a message to user that shows we are aware of the problem, we'll fix it soon
                                //------------------------------------------------------------------------------------------------------ send the problem to admin(s)
                                return;
                            }
                        }
                        string contactCode = updateMessage.Split(separator: ' ')[1]; //------ updateMessage = '/start contactCode'.splitBySpace ----> contactCode
                        if(DatabaseHandler.UserExists(contactCode: contactCode)) {
                            string fullName = DatabaseHandler.GetFullNameByContactCode(contactCode: contactCode);
                            BotApiMethods.SendTextMessageAsync(chatId: chatId, message: BotConfigs.MSG_SENDING_ANONYMOUS_TO.Replace("X", fullName)); //---- "you're going to send an anonymous message for 'fullName' please type your message"
                            DatabaseHandler.EditUserRequest(id: chatId.Identifier, userRequests: UserRequests.sendMessage, contactCode: contactCode);/* ---Update tbl_requests for chatId with request "sendMessage" and "contactCode",
                                                                                                                                                      if user types anymessage and press enter, we will send it to target, (exception: user press BackButton)*/
                            // <REQUEST ADDED TO DATABASE, NOW WE NEED TO ANALYZE THE NEXT USER'S MESSAGE>
                            // NEXT UPDATE STARTS HERE .....
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

                } else { // --------------------------------------------------------------------------------------------------------------- Handling user requests like sendMessage and etc..
                    UserRequests request = DatabaseHandler.GetCurrentRequest(id: chatId.Identifier);
                    if (request == UserRequests.empty)
                        return;
                    if(request == UserRequests.contactCode) {

                    } else if(request == UserRequests.sendMessage) {
                        

                    } else if (request == UserRequests.replyToMessage) {

                    }
                }

            } catch (Exception ex) {
                ErrorHandler.SetError(source: "ReadMessageFromUpdateAsync", error: ex.Message);
                return;
            }
        }
    }
}

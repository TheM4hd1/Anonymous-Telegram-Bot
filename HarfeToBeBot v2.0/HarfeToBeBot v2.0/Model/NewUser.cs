using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
namespace HarfeToBeBot_v2._0.Model {
    struct NewUser {

        public long Id;
        public string FullName;
        public string UserName;
        public string ContactCode;
        public Image ProfilePicture;

        public NewUser(ChatId chatId, User senderUser, Image profilePicture) {
            Id = chatId.Identifier; 
            FullName = $"{senderUser.FirstName} {senderUser.LastName}";
            UserName = senderUser.Username;
            ContactCode = Utilities.Helper.CreateContactCode();
            ProfilePicture = profilePicture;
        }
    }
}
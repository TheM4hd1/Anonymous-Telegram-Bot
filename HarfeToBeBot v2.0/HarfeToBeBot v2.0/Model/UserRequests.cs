using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfeToBeBot_v2._0.Model {
    public enum UserRequests: int { // 6-digits
        contactCode = 1,
        sendMessage = 2,
        replyToMessage = 3,
        empty = 4
    }
}
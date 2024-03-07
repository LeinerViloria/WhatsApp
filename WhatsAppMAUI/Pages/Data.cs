using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppMAUI.Models;

namespace WhatsAppMAUI.Pages
{
    public partial class ChatsPage
    {
        public static IEnumerable<ChatModel> LoadChats()
        {
            return new List<ChatModel>
        {
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0)
        };
        }
    }
}

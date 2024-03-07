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
        public static IEnumerable<ChatModel> LoadData(int Skip, int Take)
        {
            var Data = LoadChats();

            Data = Data.Skip(Skip)
                .Take(Take)
                .ToList();

            if (Data.Count == 0)
                return LoadData(0, Take);

            return Data;
        }

        public static List<ChatModel> LoadChats() => new ()
        {
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0),
            new ChatModel(("avatar.svg"), "Baby", DateTime.Now.AddMinutes(-2), "Honey, when will you", 1),
            new ChatModel(("avatar_group.svg"), "Office", DateTime.Now.AddDays(-1), "Ready to launch", 10),
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0),
        };
    }
}

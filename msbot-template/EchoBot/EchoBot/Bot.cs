using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace EchoBot
{
    public class Bot : IBot
    {
        public async Task OnTurn(ITurnContext turnContext)
        {
            if (turnContext.Activity.Type == ActivityTypes.Message)
            {
                await turnContext.SendActivity($"You said '{turnContext.Activity.Text}'");
            }
        }
    }
}

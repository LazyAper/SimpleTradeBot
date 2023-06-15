using Quartz;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace SimpleTradeBot.Jobs
{
    public class TradeBotStarter: IJob
    {
        private TradeBots tradeBots;

        public TradeBotStarter()
        {
            tradeBots = new TradeBots();
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Run(() => tradeBots.RunAllBotsStep());
        }
    }
}

using Quartz;
using System.Net.Mail;
using System.Net;
using SimpleTradeBot;
using System.Threading.Tasks;

namespace SimpleTradeBotAsp.Jobs
{
    public class TradeBotStarter: IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            TradeBot tb = new TradeBot();
            await Task.Run(() => tb.TradeStep());
        }
    }
}

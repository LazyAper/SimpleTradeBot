using Quartz;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace SimpleTradeBotAsp4.Jobs
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

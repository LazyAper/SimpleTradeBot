using Binance.Net.Clients;
using Binance.Net.Objects.Models.Spot;
using CryptoExchange.Net.CommonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTradeBotBacktester
{
    public class BinanceExchange
    {
        private static BinanceClient GetClient()
        {
            var Client = new BinanceClient();
            Client.SetApiCredentials(new Binance.Net.Objects.BinanceApiCredentials(
                "p39EYe4QxRZS2dXgSL73xCspn88TCQNLQd93ZUKE7rkCuyd2jADi1AD4KntKApv3",
                "tudhsqIz826OAOuaD1dx0ER1cGnrDNzPeKq2pQYIIlVirbbLPipcHrLeZolhTmpN"));

            return Client;
        }


        /// <summary>
        /// возвращает массив торговых пар
        /// </summary>
        public static List<BinanceSymbol> DownloadSpotPairs(string quote)
        {
            var exinf = GetClient().SpotApi.ExchangeData.GetExchangeInfoAsync();
            exinf.Wait();

            var symbols = exinf.Result.Data.Symbols;

            var result = symbols.Where((x) => x.QuoteAsset == quote).ToList();

            return result;

        }

        /// <summary>
        /// возвращает историю цен символа за неделю и день. Текущая цена - последняя.
        /// Время серверное (на 4 часа меньше нашего)
        /// </summary>
        public static void DownloadKlines(string Symbol, out List<Kline> weekKlines, out List<Kline> dayKlines)
        {
            var exinf = GetClient().SpotApi.ExchangeData.GetExchangeInfoAsync();
            exinf.Wait();

            DateTime serverTime = exinf.Result.Data.ServerTime;
            DateTime FromTime = serverTime.AddDays(-1*7);
            DateTime ToTime = serverTime;

            List<Kline> klines = new List<Kline>();

            TimeSpan klInterval = new TimeSpan(0, 1, 0);

            List<Kline> result = new List<Kline>();

            var task = GetClient().SpotApi.CommonSpotClient
                    .GetKlinesAsync(Symbol, klInterval, null, ToTime, 1000);
            task.Wait();
            var kLines = task.Result.Data.ToList();
            result.AddRange(kLines);

            while (FromTime <= kLines[0].OpenTime)
            {
                var timeEnd = result[0].OpenTime;
                task = GetClient().SpotApi.CommonSpotClient
                    .GetKlinesAsync(Symbol, klInterval, null, timeEnd, 1000);
                task.Wait();
                kLines = task.Result.Data.ToList();
                result.InsertRange(0, task.Result.Data.ToList());
            }

            //убираем лишние данные в начале
            result = result.Where((x) =>x.OpenTime >= FromTime).ToList();

            weekKlines = result;

            dayKlines = result.Where((x) => x.OpenTime >= ToTime.AddDays(-1)).ToList();
        }
    }
}

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
            return Client;
        }


        /// <summary>
        /// возвращает массив торговых пар по заданным котировочным валютам
        /// </summary>
        public static List<BinanceSymbol> DownloadSpotPairs(List<string> quotes)
        {
            var exinf = GetClient().SpotApi.ExchangeData.GetExchangeInfoAsync();
            exinf.Wait();

            var symbols = exinf.Result.Data.Symbols;

            
            var result = symbols.Where((x) => quotes.Contains(x.QuoteAsset)).ToList();
            
            //возвращаем пока 3 элемента для простоты разработки
            //result = result.Take(7).ToList();

            return result;

        }

        public static BinanceSymbol DownloadPairInfo(string sym)
        {
            var exinf = GetClient().SpotApi.ExchangeData.GetExchangeInfoAsync();
            exinf.Wait();

            var symbols = exinf.Result.Data.Symbols;


            var result = symbols.First((x) => x.Name == sym);

            return result;
        }

        /// <summary>
        /// возвращает историю цен символа за неделю и день. Текущая цена - последняя.
        /// Время серверное (на 4 часа меньше нашего)
        /// </summary>
        public static void DownloadKlines(string Symbol, out List<Kline> weekKlines, out List<Kline> dayKlines)
        {
            DateTime serverTime = DateTime.UtcNow;
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

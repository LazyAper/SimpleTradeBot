using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace SimpleTradeBot
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Jobs.TradeBotScheduler.Start();
            Console.ReadLine();

            /*
             * ручной запуск ботов с таймером
            TradeBots tradeBots = new TradeBots();
            while (true)
            {
                tradeBots.RunAllBotsStep();
                Thread.Sleep(50000);
            }
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormChart());
            
        }
    }
}


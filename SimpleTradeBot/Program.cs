using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using System.Threading;

namespace SimpleTradeBot
{
    class Program
    {
        [STAThread]
        static void Main()
        {

            TradeBot tb = new TradeBot();

            while (true) {
                tb.TradeStep();
                Thread.Sleep(60000);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormChart());
            
        }
    }
}


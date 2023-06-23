using SimpleTradeBotBacktester.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTradeBotBacktester
{
    public partial class FormSettings : Form
    {
        //текущая пара, ностройки которой надо посмотреть
        public List<Setting> CurrentSettings;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            BindDatagrid();
        }

        public void BindDatagrid()
        {
            settingBindingSource.DataSource = CurrentSettings;
            settingBindingSource.ResetBindings(false);
        }

        private void buttonTrace_Click(object sender, EventArgs e)
        {
            Setting s = (Setting)settingBindingSource.Current;

            FormTrace ft = new FormTrace();
            ft.trace.set = s;
            ft.trace.pair = s.PairCurrent;

            ft.Show();

        }
    }
}

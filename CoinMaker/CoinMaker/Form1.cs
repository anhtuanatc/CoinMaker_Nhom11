using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;


namespace CoinMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ShowGlobalCoin();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

                
        }


        void ShowGlobalCoin()
        {
            var json = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/ticker/?limit=100");
            var jsonGlobal = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/global/");

            List<Model> model = JsonConvert.DeserializeObject<List<Model>>(json);

            Global result = JsonConvert.DeserializeObject<Global>(jsonGlobal);

            var source = new BindingSource(model, null);
            dtg_show.DataSource = source;

            tb_vhtt.Text = result.total_market_cap_usd.ToString();
        }

    }
}

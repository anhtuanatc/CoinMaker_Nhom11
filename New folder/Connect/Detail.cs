using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        String NameCoin="";
        public Detail(String Name)
        {
            InitializeComponent();
            NameCoin = Name;

        }


        private void Detail_Load(object sender, EventArgs e)
        {

            if (NameCoin != null)
            {
                lb_nameCoin.Text = NameCoin;
            }
            

            cbb_nameCoin.DataSource = ShowCoinCBB();
            
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            List<Model> list=Show_Coin(conn, NameCoin);

            lb_slgiatri.Text = list.Count + " Giá Trị";

            List<ModelChartCoin> listChart = new List<ModelChartCoin>();

            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    listChart.Add(new ModelChartCoin(Convert.ToDouble(list[i].price_usd), Convert.ToDouble(list[i].last_updated)));

                    list[i].last_updated = epoch2string(Convert.ToInt32(list[i].last_updated)) + "-" + epoch2Time(Convert.ToInt32(list[i].last_updated));
                    list[i].price_usd = string.Format("{0:#,##0.00}", double.Parse(list[i].price_usd));
                    list[i].market_cap_usd = string.Format("{0:#,##0.00}", double.Parse(list[i].market_cap_usd));
                }

            }


            var listTemp = list.Select(l => new {RANK = l.rank, PRICE_USD = l.price_usd, PRICE_BTC = l.price_btc,MARKET_CAP=l.market_cap_usd,LAST_UPDATE=l.last_updated }).ToList();

            modelChartCoinBindingSource.DataSource = listChart;


            dgv_coin.DataSource = listTemp;
            dgv_coin.Show();



        }


        List<String> ShowCoinCBB()
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string sql = "Select * from Coin";

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;

            List<String> newList = new List<String>();

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                newList.Add(reader.GetString(1).ToString());

            }

            return newList;
        }


        List<Model> Show_Coin(OracleConnection conn, String name)
        {
            string sql = "Select * from Coin where NAME='"+name+"'";

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;

            List<Model> newList = new List<Model>();

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Model model = new Model();
                model.id = reader.GetString(0);
                model.name = reader.GetString(1);
                model.rank = reader.GetString(2);
                model.price_usd = reader.GetString(3);
                model.price_btc = reader.GetString(4);
                model.market_cap_usd = reader.GetString(5);
                model.last_updated = reader.GetString(6);

                newList.Add(model);

            }

            return newList;
        }

        private void btn_showCoin_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            String nameCoin = cbb_nameCoin.Text;
            lb_nameCoin.Text = nameCoin;
            
            List<Model> list = Show_Coin(conn, nameCoin);

            lb_slgiatri.Text = list.Count + " Giá Trị";
            List <ModelChartCoin> listChart = new List<ModelChartCoin>();

            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    listChart.Add(new ModelChartCoin(Convert.ToDouble(list[i].price_usd), Convert.ToDouble(list[i].last_updated)));
                    list[i].last_updated = epoch2string(Convert.ToInt32(list[i].last_updated)) + "-" + epoch2Time(Convert.ToInt32(list[i].last_updated));
                    list[i].price_usd = string.Format("{0:#,##0.00}", double.Parse(list[i].price_usd));
                    list[i].market_cap_usd = string.Format("{0:#,##0.00}", double.Parse(list[i].market_cap_usd));
                    
                }

            }

            var listTemp = list.Select(l => new { RANK = l.rank, PRICE_USD = l.price_usd, PRICE_BTC = l.price_btc, MARKET_CAP = l.market_cap_usd, LAST_UPDATE = l.last_updated }).ToList();

            dgv_coin.DataSource = listTemp;
            dgv_coin.Show();

            modelChartCoinBindingSource.DataSource = listChart;
        }

        private string epoch2string(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToShortDateString();
        }

        private string epoch2Time(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToShortTimeString();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}

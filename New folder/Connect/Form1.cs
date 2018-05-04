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
using Oracle.DataAccess.Client;
using Newtonsoft.Json;
using DevExpress.XtraGrid.Views.Grid;

namespace Connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpDate();

        }


        void UpDate()
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            List<Model> list = new List<Model>();

            Query(conn, list);

            var listTemp = list.Select(l => new { NAME = l.name, RANK = l.rank, PRICE_USD = l.price_usd, PRICE_BTC = l.price_btc }).ToList();


            data_grid.DataSource = listTemp.ToList();
            data_grid.Show();
            Global global = new Global();
            Query_Global(conn, global);

            lb_ngay.Text = epoch2string(Convert.ToInt32(list[0].last_updated))+" - "+ epoch2Time(Convert.ToInt32(list[0].last_updated));

            lb_vhtt.Text = string.Format("{0:#,##0.00}", double.Parse(global.total_market_cap_usd)) + " $";

            lb_lb24h1.Text = string.Format("{0:#,##0.00}", double.Parse(global.total_24h_volume_usd)) + " $";

            lb_bcut.Text = global.bitcoin_percentage_of_market_cap + " %";




            conn.Close();
            conn.Dispose();
            conn = null;
        }

        private string epoch2string(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToShortDateString();
        }

        private string epoch2Time(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToShortTimeString();
        }



        void Query_ShowData(OracleConnection conn, List<Model> list)
        {
            string sql = "Select * from COIN_UPDATE";

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
                list.Add(model);

            }

        }


        private static void Query(OracleConnection conn,List<Model> list)
        {
            string sql = "Select * from Coin where LAST_UPDATE = (Select Max(LAST_UPDATE) from Coin)";

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

                list.Add(model);

            }

        }

        void Query_Global(OracleConnection conn, Global global)
        {
            string sql = "Select * from GLOBAL where LAST_UPDATE = (Select Max(LAST_UPDATE) from GLOBAL)";

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;

            

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                global.total_market_cap_usd = reader.GetString(1);
                global.total_24h_volume_usd = reader.GetString(2);
                global.bitcoin_percentage_of_market_cap = reader.GetString(3);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var json = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/ticker/?limit=1000");
            

            List<Model> model = JsonConvert.DeserializeObject<List<Model>>(json);

            int res = 0;
            for(int i = 0; i <model.Count; i++)
            {

                res+= DownDataUpDate(model[i].name, model[i].rank, model[i].price_usd, model[i].price_btc, model[i].market_cap_usd);
            }

            Update_Global();

            MessageBox.Show("Có " + res + " giá trị được thêm");
        }

        void Update_Global()
        {
            var jsonGlobal = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/global/");

            Global global = JsonConvert.DeserializeObject<Global>(jsonGlobal);

            var epoch = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            int ress = Convert.ToInt32(epoch);

            global.last_updated = ress.ToString();

            OracleConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            try
            {
                string sql = "Insert into GLOBAL(TOTAL_MARKET,TOTAL_24H,BITCOIN_PERCENTAGE,LAST_UPDATE) values (:total_market, :total_24h,:bitcoin_percentage,:last_update)";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = sql;

                cmd.Parameters.Add(":total_market", OracleDbType.Varchar2).Value = global.total_market_cap_usd;
                cmd.Parameters.Add(":total_24h", OracleDbType.Varchar2).Value = global.total_24h_volume_usd;
                cmd.Parameters.Add(":bitcoin_percentage", OracleDbType.Varchar2).Value = global.bitcoin_percentage_of_market_cap;
                cmd.Parameters.Add(":last_update", OracleDbType.Varchar2).Value = global.last_updated.ToString();

                int row = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }

        }


        int DownDataUpDate(String Name, String Rank, String Price_usd, String Price_btc, String Market_cap)
        {
            OracleConnection connection = DBUtils.GetDBConnection();
            connection.Open();


            try
            {
                string sql = "Insert into COIN_UPDATE (NAME,RANK,PRICE_USD,PRICE_BTC,MARKET_CAP) values (:name, :rank,:price_usd,:price_btc,:market_cap)";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = sql;

                cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = Name;
                cmd.Parameters.Add(":rank", OracleDbType.Varchar2).Value = Rank;
                cmd.Parameters.Add(":price_usd", OracleDbType.Varchar2).Value = Price_usd;
                cmd.Parameters.Add(":price_btc", OracleDbType.Varchar2).Value = Price_btc;
                cmd.Parameters.Add(":market_cap", OracleDbType.Varchar2).Value = Market_cap;

                int row = cmd.ExecuteNonQuery();

                return row;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }

            return 0;
        }


        int DownData(String Name, String Rank, String Price_usd, String Price_btc, String Market_cap, String Last_update)
        {
            OracleConnection connection = DBUtils.GetDBConnection();
            connection.Open();


            try
            {
                string sql = "Insert into COIN (NAME,RANK,PRICE_USD,PRICE_BTC,MARKET_CAP,LAST_UPDATE) values (:name, :rank,:price_usd,:price_btc,:market_cap,:last_update)";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = sql;

                cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value =Name;
                cmd.Parameters.Add(":rank", OracleDbType.Varchar2).Value = Rank;
                cmd.Parameters.Add(":price_usd", OracleDbType.Varchar2).Value =Price_usd;
                cmd.Parameters.Add(":price_btc", OracleDbType.Varchar2).Value =Price_btc;
                cmd.Parameters.Add(":market_cap", OracleDbType.Varchar2).Value = Market_cap;
                cmd.Parameters.Add(":last_update", OracleDbType.Varchar2).Value =Last_update;

                int row = cmd.ExecuteNonQuery();

                return row;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }

            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Global();
        }


        private void data_grid_MouseClick(object sender, MouseEventArgs e)
        {
            var k =((GridView)data_grid.MainView).GetFocusedRowCellValue("NAME");

            Detail detail = new Detail(k.ToString());
            detail.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Activate();
            detail.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LsGloBal gloBal = new LsGloBal();
            gloBal.Show();
        }

        int GetTimeMax()
        {
            OracleConnection connection = DBUtils.GetDBConnection();
            connection.Open();

            string sql = "Select Max(LAST_UPDATE) from Coin";


            OracleCommand cmd = new OracleCommand();

            cmd.Connection = connection;
            cmd.CommandText = sql;



            OracleDataReader reader = cmd.ExecuteReader();

            string temp ="0";
            while (reader.Read())
            {
                temp = reader.GetString(0);
            }
           
            return Convert.ToInt32(temp);
        }

        private void btn_udcoin_Click(object sender, EventArgs e)
        {
            var epoch = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            int ress = Convert.ToInt32(epoch);

            if (GetTimeMax() + 300 > ress)
            {
                MessageBox.Show("Không Thể UpDate! Xin Thử Lại Trong Giây Lát!");
                return;
            }

            var json = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/ticker/?limit=1000");

            List<Model> listModel = JsonConvert.DeserializeObject<List<Model>>(json);

            for (int i = 0; i < listModel.Count; i++)
            {
                 listModel[i].last_updated = ress.ToString();
            }

            int res = 0;
            for (int i = 0; i < listModel.Count; i++)
            {
                res += DownData(listModel[i].name, listModel[i].rank, listModel[i].price_usd, listModel[i].price_btc, listModel[i].market_cap_usd,listModel[i].last_updated);
            }
            MessageBox.Show("Có " + res + " giá trị được thêm");

            if (res != 0)
            {
                UpDate();
                Update_Global();
            }

            
           
        }

        private void btn_lichsu_Click(object sender, EventArgs e)
        {

        }
    }
}

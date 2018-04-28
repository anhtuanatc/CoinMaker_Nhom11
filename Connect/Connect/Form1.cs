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

            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            List<Model> list = new List<Model>();

            Query(conn,list);

            data_grid.DataSource = list;
            data_grid.Show();

            conn.Close();
            conn.Dispose();
            conn = null;
        }


        private static void Query(OracleConnection conn,List<Model> list)
        {
            string sql = "Select * from Coin";

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

        private void button1_Click(object sender, EventArgs e)
        {

            var json = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/ticker/?limit=1000");
            var jsonGlobal = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/global/");

            List<Model> model = JsonConvert.DeserializeObject<List<Model>>(json);

            int res = 0;
            for(int i = 0; i <model.Count; i++)
            {

                res+=DownData(model[i].name, model[i].rank, model[i].price_usd, model[i].price_btc, model[i].market_cap_usd, model[i].last_updated);
            }

            MessageBox.Show("Có " + res + " giá trị được thêm");
        }


        int DownData(String Name, String Rank, String Price_usd, String Price_btc, String Market_cap, String Last_update)
        {
            OracleConnection connection = DBUtils.GetDBConnection();
            connection.Open();


            try
            {
                string sql = "Insert into Coin (NAME,RANK,PRICE_USD,PRICE_BTC,MARKET_CAP,LAST_UPDATE) values (:name, :rank,:price_usd,:price_btc,:market_cap,:last_update)";

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

    }
}

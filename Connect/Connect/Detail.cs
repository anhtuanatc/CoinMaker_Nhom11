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


            cbb_nameCoin.DataSource = ShowCoinCBB();
            
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            List<Model> list=Show_Coin(conn, NameCoin);
            dgv_coin.DataSource = list;
            dgv_coin.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            String nameCoin = cbb_nameCoin.Text;
            List<Model> list = Show_Coin(conn,nameCoin);

            dgv_coin.DataSource = list;
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
    }
}

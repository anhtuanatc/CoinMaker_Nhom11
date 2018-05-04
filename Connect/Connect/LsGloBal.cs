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
    public partial class LsGloBal : Form
    {
        public LsGloBal()
        {
            InitializeComponent();
        }

        private void LsGloBal_Load(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            List<Global> list =Show_GloBal(conn);

            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].last_updated = epoch2string(Convert.ToInt32(list[i].last_updated)) + "-" + epoch2Time(Convert.ToInt32(list[i].last_updated));
                    list[i].total_market_cap_usd = string.Format("{0:#,##0.00}", double.Parse(list[i].total_market_cap_usd));
                    list[i].total_24h_volume_usd = string.Format("{0:#,##0.00}", double.Parse(list[i].total_24h_volume_usd));
                }

            }

            var listTemp = list.Select(l => new { TOTAL_MARKET = l.total_market_cap_usd, TOTAL_24H = l.total_24h_volume_usd,LAST_UPDATE = l.last_updated }).ToList();

            dtg_global.DataSource = listTemp;
            dtg_global.Show();

            lb_vhttln.Text+=" : "+ string.Format("{0:#,##0.00}", double.Parse(GetMax("TOTAL_MARKET", conn)))+" $";
            lb_bccutln.Text+= " : " + string.Format("{0:#,##0.00}", double.Parse(GetMax("BITCOIN_PERCENTAGE", conn))) + " %";
            lb_kl24hln.Text+= " : " + string.Format("{0:#,##0.00}", double.Parse(GetMax("TOTAL_24H", conn))) + " $";

        }


        String GetMax(String Data, OracleConnection connection)
        {

            string sql = "Select Max("+Data+") from GLOBAL";

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = connection;
            cmd.CommandText = sql;

            OracleDataReader reader = cmd.ExecuteReader();

            string temp = "0";
            while (reader.Read())
            {
                temp = reader.GetString(0);
            }

            return temp;
        }


        private string epoch2string(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToShortDateString();
        }

        private string epoch2Time(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToShortTimeString();
        }

        List<Global> Show_GloBal(OracleConnection conn)
        {
            string sql = "Select * from GLOBAL" ;

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;

            List<Global> newList = new List<Global>();

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Global global = new Global();
                global.total_market_cap_usd = reader.GetString(1);
                global.total_24h_volume_usd = reader.GetString(2);
                global.bitcoin_percentage_of_market_cap = reader.GetString(3);
                global.last_updated = reader.GetString(4);

                newList.Add(global);

            }

            return newList;
        }
    }
}

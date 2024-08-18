using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lksmart
{
    internal class GenerateID
    {
        public static SqlConnection conn = connection.Connect();
        public static SqlCommand cmd;
        public static SqlDataReader rd;


        public static string idBarang()
        {
            string hasil;
            cmd = new SqlCommand("SELECT * FROM [tbl_barang] ORDER BY id_barang DESC", conn);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                var urut = int.Parse(rd["id_barang"].ToString().Substring(4)) + 1;
                hasil = "BRG00" + urut.ToString();

            }
            else
            {
                hasil = "BRG001";
            }

            return hasil;
        }
        public static string noTransaksi()
        {
            string hasil;
            cmd = new SqlCommand("SELECT * FROM [tbl_transaksi] ORDER BY no_transaksi DESC", conn);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                var urut = int.Parse(rd["no_transaksi"].ToString().Substring(4)) + 1;
                hasil = "TRS00" + urut.ToString();

            }
            else
            {
                hasil = "TRS001";
            }

            return hasil;
        }
        public static string idtransaksi()
        {
            string hasil;
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [tbl_barang] ORDER BY id_transaksi DESC", conn);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                hasil = (int.Parse(rd["id_transaksi"].ToString()) + 1).ToString();

            }
            else
            {
                hasil = "1";
            }
            conn.Close();
            return hasil;

        }

    }
}

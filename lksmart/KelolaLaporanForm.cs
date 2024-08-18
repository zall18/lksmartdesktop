using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lksmart
{
    public partial class KelolaLaporanForm : Form
    {
        SqlConnection conn = connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter dr;
        DataTable dt;
        public KelolaLaporanForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [tbl_transaksi] WHERE tgl_transaksi BETWEEN @awal AND @akhir", conn);
            cmd.Parameters.AddWithValue("@awal", awal.Value);
            cmd.Parameters.AddWithValue("@akhir", akhir.Value);
            dr = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT SUM(total_bayar) AS bayar, tgl_transaksi as date FROM [tbl_transaksi] WHERE tgl_transaksi BETWEEN @awal AND @akhir GROUP BY tgl_transaksi", conn);
            cmd.Parameters.AddWithValue("@awal", awal.Value);
            cmd.Parameters.AddWithValue("@akhir", akhir.Value);
            rd = cmd.ExecuteReader();
            chart1.Series.Clear();
            chart1.Series.Add("omset");
            int i = 0;
            while (rd.Read())
            {

                string date = rd["date"].ToString();
                double bayar = Convert.ToDouble(rd["bayar"]);

                chart1.Series[i].Points.AddXY(date, bayar);

            }
            rd.Close();
            conn.Close();
        }
    }
}

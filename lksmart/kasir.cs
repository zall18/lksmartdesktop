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
    public partial class kasir : Form
    {
        SqlConnection conn = connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter dr;

        int number = 1;

        public void table_load()
        {
            dgv.Columns.Clear();
            dgv.ColumnCount = 7;
            dgv.Columns[0].Name = "No Transaksi";
            dgv.Columns[1].Name = "Kode Barang";
            dgv.Columns[2].Name = "Nama Barang";
            dgv.Columns[3].Name = "Harga Barang";
            dgv.Columns[4].Name = "QTY";
            dgv.Columns[5].Name = "total";
            dgv.Columns[6].Name = "id";

            dgv.Columns[6].Visible = false;


        }

        public void menu_load()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [tbl_barang]", conn);
            rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                menu.Items.Add(rd["kode_barang"].ToString() + " - " + rd["nama_barang"].ToString());
            }
            rd.Close();
            conn.Close();

        }
        public kasir()
        {
            InitializeComponent();
            table_load();
            menu_load();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tambah_Click(object sender, EventArgs e)
        {
            string no = "TRS00" + number.ToString();
            string kode = menu.Text.ToString().Split('-')[0];
            string nama = menu.Text.ToString().Split('-')[1];
            dgv.Rows.Add(1);
            dgv.Rows[dgv.Rows.Count - 2].Cells[0].Value = no;
            dgv.Rows[dgv.Rows.Count - 2].Cells[1].Value = kode;
            dgv.Rows[dgv.Rows.Count - 2].Cells[2].Value = nama;
            dgv.Rows[dgv.Rows.Count - 2].Cells[3].Value = harga.Text;
            dgv.Rows[dgv.Rows.Count - 2].Cells[4].Value = quatitas.Text;
            dgv.Rows[dgv.Rows.Count - 2].Cells[5].Value = th.Text;
            dgv.Rows[dgv.Rows.Count - 2].Cells[6].Value = id.Text;

            harga.Text = null;
            quatitas.Text = null;
            th.Text = null;

            pelanggan.Enabled = false;
            telepon.Enabled = false;
 
            int total = 0;

            foreach (DataGridViewRow dr in dgv.Rows)
            {
                int tt = Convert.ToInt32(dr.Cells[5].Value);
                total += tt;
            }

            tb.Text = total.ToString();
        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kode = menu.Text.ToString().Split('-')[0];

            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [tbl_barang] WHERE kode_barang = '" + kode + "'", conn);
            rd = cmd.ExecuteReader();
            if(rd.HasRows)
            {
                rd.Read();
                harga.Text = rd["harga_satuan"].ToString();
                id.Text = rd["id_barang"].ToString();

            }
            rd.Close();
            conn.Close();
        }

        private void quatitas_TextChanged(object sender, EventArgs e)
        {
            double q;
            double hg;
            if (double.TryParse(quatitas.Text, out q) && double.TryParse(harga.Text, out hg))
            {

                double total = hg * q;

                th.Text = total.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ub;
            double total;
            if(double.TryParse(bayar.Text, out ub) && double.TryParse(tb.Text, out total))
            {
                if(ub < total)
                {
                    MessageBox.Show("Uang yang diinput kurang!");
                }
                else
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        conn.Open();
                        cmd = new SqlCommand("UPDATE [tbl_barang] SET jumlah_barang = jumlah_barang - " + Convert.ToDecimal(row.Cells[4].Value) + " WHERE id_barang = '" + row.Cells[6].Value + "'", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                    double kembali = ub - total;
                    uk.Text = kembali.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("INSERT INTO [tbl_transaksi] VALUES('" + GenerateID.noTransaksi() + "', @waktu, '" + session.user_name + "', '" + tb.Text + "', '" + session.user_id+ "')", conn);
            cmd.Parameters.AddWithValue("@waktu", DateTime.Now);
            cmd.ExecuteNonQuery();
            conn.Close();
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {

                conn.Open();
                cmd = new SqlCommand("INSERT INTO [tbl_detail] VALUES('" + dgv.Rows[i].Cells[2].Value + "', '" + dgv.Rows[i].Cells[3].Value + "', '" + dgv.Rows[i].Cells[4].Value + "', '" + dgv.Rows[i].Cells[6].Value + "', '"+ids.Text+"')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }

            MessageBox.Show("Data berhasil disimpan!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Invoice", 320, 500);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Invoce", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(20, 10));
            e.Graphics.DrawString("nama kasir: " + session.user_name, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 30));
            e.Graphics.DrawString("Tanggal: " + DateTime.Now.ToShortDateString(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(160, 30));
            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 50));
            e.Graphics.DrawString("barang |", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(30, 70));
            e.Graphics.DrawString("harga |", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(100, 70));
            e.Graphics.DrawString("qty |", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(160, 70));
            e.Graphics.DrawString("total", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(230, 70));

            int x = 30;
            int y = 90;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                string barang = Convert.ToString(row.Cells[2].Value);
                string harga = Convert.ToString(row.Cells[3].Value);
                string qty = Convert.ToString(row.Cells[4].Value);
                string total = Convert.ToString(row.Cells[5].Value);

                e.Graphics.DrawString(barang, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(x, y));
                e.Graphics.DrawString(harga, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(x + 70, y));
                e.Graphics.DrawString(qty, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(x + 140, y));
                e.Graphics.DrawString(total, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(x + 190, y));

                y += 20;

            }
            e.Graphics.DrawString("------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString("Total Bayar", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(x, y + 20));
            e.Graphics.DrawString("Rp. " + tb.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(x + 160, y + 20));

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void telepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void quatitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand log = new SqlCommand("INSERT INTO [tbl_log] VALUES (@waktu, 'LOGOUT', '" + session.user_id + "')", conn);
            log.Parameters.AddWithValue("@waktu", DateTime.Now);
            log.ExecuteNonQuery();
            conn.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

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
    public partial class LogForm : Form
    {
        SqlConnection conn = connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter dr;
        DataTable dt;

        KelolaUserForm userForm = new KelolaUserForm();
        KelolaLaporanForm laporanForm = new KelolaLaporanForm();

        public void table_load()
        {
            conn.Open();
            cmd  = new SqlCommand("SELECT * FROM [tbl_log] ORDER BY id_log DESC", conn);
            dr = new SqlDataAdapter(cmd);
            dt = new DataTable();   
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        public LogForm()
        {
            InitializeComponent();
            table_load();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [tbl_log] WHERE waktu BETWEEN @awal AND @akhir ORDER BY id_log DESC", conn);
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
            userForm.TopLevel = false;
            panel2.Controls.Add(userForm);
            userForm.BringToFront();
            userForm.Show();
            laporanForm.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            laporanForm.TopLevel = false;
            panel2.Controls.Add(laporanForm);
            laporanForm.BringToFront();
            laporanForm.Show();
            userForm.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand log = new SqlCommand("INSERT INTO [tbl_log] VALUES (@waktu, 'LOGOUT', '" +session.user_id + "')", conn);
            log.Parameters.AddWithValue("@waktu", DateTime.Now);
            log.ExecuteNonQuery();
            conn.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [tbl_log] WHERE waktu BETWEEN @awal AND @akhir ORDER BY id_log DESC", conn);
            cmd.Parameters.AddWithValue("@awal", awal.Value);
            cmd.Parameters.AddWithValue("@akhir", akhir.Value);
            dr = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}

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
    public partial class KelolaUserForm : Form
    {
        SqlConnection conn = connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter dr;
        DataTable dt;

        public void table_load()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [tbl_user]", conn);
            dr = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void clear()
        {
            tipe.Text = null;
            nama.Text = null;
            alamat.Text = null;
            telpon.Text = null;
            username.Text = null ;
            password.Text = null ;

            edit.Enabled = false;
            hapus.Enabled = false;
            tambah.Enabled = true;
        }
        public KelolaUserForm()
        {
            InitializeComponent();
            table_load();
            clear();
        }

        private void KelolaUserForm_Load(object sender, EventArgs e)
        {

        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if(tipe.Text.Length == 0)
            {
                MessageBox.Show("Tipe User wajib diisi!");
            }else if(nama.Text.Length == 0)
            {
                MessageBox.Show("Nama wajib diisi!");
            }else if(telpon.Text.Length == 0)
            {
                MessageBox.Show("Telpon wajib diisi!");
            }else if (alamat.Text.Length == 0)
            {
                MessageBox.Show("Alamaat wajib diisi!");
            }else if (username.Text.Length == 0)
            {
                MessageBox.Show("Username wajib diisi!");
            }else if (password.Text.Length == 0)
            {
                MessageBox.Show("Password wajib diisi!");
            }else
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM [tbl_user] WHERE username = '" + username.Text + "'", conn);
                rd = cmd.ExecuteReader();
                if(rd.HasRows)
                {
                    rd.Close();
                    conn.Close();
                    MessageBox.Show("Username ini sudah digunakan");
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO [tbl_user] VALUES ('" + tipe.Text + "', '" + nama.Text + "', '" + alamat.Text + "', '" + username.Text + "', '" + telpon.Text + "', '" + HashPassword.Hash(password.Text) + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    table_load();
                    clear();
                    MessageBox.Show("Berhasil menambahkan data");
                }
            }

        }

        private void edit_Click(object sender, EventArgs e)
        {
            conn.Open();
            if(password.Text.Length != 0)
            {

                cmd = new SqlCommand("UPDATE [tbl_user] SET tipe_user = '"+tipe.Text+"', nama = '"+nama.Text+"', alamat = '"+alamat.Text+"', username = '"+username.Text+"', telepon = '"+telpon.Text+"', password = '"+HashPassword.Hash(password.Text)+"' WHERE id_user = '"+id.Text+"'", conn);
            }
            else
            {
                cmd = new SqlCommand("UPDATE [tbl_user] SET tipe_user = '" + tipe.Text + "', nama = '" + nama.Text + "', alamat = '" + alamat.Text + "', username = '" + username.Text + "', telepon = '" + telpon.Text + "' WHERE id_user = '" + id.Text + "'", conn);
            }
            cmd.ExecuteNonQuery();
            conn.Close();

            table_load();
            clear();
            MessageBox.Show("Berhasil menngubah data");
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus data?", "User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM [tbl_user] WHERE id_user = '" + id.Text + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                table_load();
                clear();
                MessageBox.Show("Berhasil menghapus data");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow data = this.dataGridView1.Rows[e.RowIndex];

                id.Text = data.Cells["id_user"].Value.ToString();
                tipe.Text = data.Cells["tipe_user"].Value.ToString();
                nama.Text = data.Cells["nama"].Value.ToString();
                alamat.Text = data.Cells["alamat"].Value.ToString();
                username.Text = data.Cells["username"].Value.ToString();
                telpon.Text = data.Cells["telepon"].Value.ToString();
                password.Text = data.Cells["password"].Value.ToString();

                edit.Enabled = true; 
                hapus.Enabled = true;
                tambah.Enabled = false;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [tbl_user] WHERE nama LIKE '%"+this.search.Text+"%'", conn);
            dr = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void telpon_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void telpon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}

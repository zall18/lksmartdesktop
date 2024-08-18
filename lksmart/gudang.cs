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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace lksmart
{
    public partial class gudang : Form
    {
        SqlConnection conn = connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter dr;
        DataTable dt;

        string imageName = "";
        bool upload = false;

        public void table_load()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [tbl_barang]", conn);
            dr = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void clear()
        {
            kode.Text = null;
            nama.Text = null;
            jumlah.Text = null;
            satuan.Text = null;
            harga.Text = null;

            upload = false;
            img.Image = null;
            edit.Enabled = false;
            hapus.Enabled = false;
            tambah.Enabled = true;
        }

        public gudang()
        {
            InitializeComponent();
            table_load();
            clear();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if(kode.Text.Length == 0 )
            {
                MessageBox.Show("Kode barang wajib diisi");
            }else if(jumlah.Text.Length == 0)
            {
                MessageBox.Show("Jumlah barang wajib diisi");
            }else if(nama.Text.Length == 0)
            {
                MessageBox.Show("Nama barang wajib diisi");
            }else if(harga.Text.Length == 0)
            {
                MessageBox.Show("Harga barang wajib diisi");
            }else if (satuan.Text.Length == 0)
            {
                MessageBox.Show("Satuan barang wajib diisi");
            }
            else
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM [tbl_barang] WHERE kode_barang = '" + kode.Text + "'", conn);
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Close();
                    conn.Close();
                    MessageBox.Show("Kode Barang ini sudah digunakan");
                }
                else
                {
                    conn.Close();
                    imageName = kode.Text + ".jpg";
                    string folder = @"C:\Users\smkyp\source\repos\lksmart\lksmart\gambar";
                    string path = System.IO.Path.Combine(folder, imageName);
                    img.Image.Save(path);


                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO [tbl_barang] VALUES ('" + GenerateID.idBarang() + "', '" + kode.Text + "', '" + nama.Text + "', @waktu, '" + jumlah.Text + "', '" + satuan.Text + "', '" + harga.Text + "', '" + imageName + "')", conn);
                    cmd.Parameters.AddWithValue("@waktu", date.Value);
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
            if (upload)
            {
                imageName = kode.Text + ".jpg";
                string folder = @"C:\Users\smkyp\source\repos\lksmart\lksmart\gambar";
                string path = System.IO.Path.Combine(folder, imageName);
                img.Image.Save(path);
            }
            conn.Open();
            cmd = new SqlCommand("UPDATE [tbl_barang] SET kode_barang = '"+kode.Text+"', nama_barang = '"+nama.Text+"', jumlah_barang = '"+jumlah.Text+"', expired_date = @waktu, satuan = '"+satuan.Text+"', harga_satuan = '"+harga.Text+"' WHERE id_barang = '"+id.Text+"'", conn);
            cmd.Parameters.AddWithValue("@waktu", date.Value);
            cmd.ExecuteNonQuery();
            conn.Close();

            

            table_load();
            clear();
            MessageBox.Show("Berhasil menngubah data");
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus data?", "Barang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM [tbl_barang] WHERE id_barang = '" + id.Text + "'", conn);
                imageName = kode.Text + ".jpg";
                string folder = @"C:\Users\smkyp\source\repos\lksmart\lksmart\gambar";
                string path = System.IO.Path.Combine(folder, imageName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                cmd.ExecuteNonQuery();
                conn.Close();

                table_load();
                clear();
                MessageBox.Show("Berhasil menghapus data");
            }
                
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM [tbl_barang] WHERE nama_barang LIKE '%"+this.search.Text+"%'", conn);
            dr = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow data = this.dataGridView1.Rows[e.RowIndex];

                id.Text = data.Cells["id_barang"].Value.ToString();
                kode.Text = data.Cells["kode_barang"].Value.ToString();
                nama.Text = data.Cells["nama_barang"].Value.ToString();
                date.Value = (DateTime)data.Cells["expired_date"].Value;
                jumlah.Text = data.Cells["jumlah_barang"].Value.ToString();
                satuan.Text = data.Cells["satuan"].Value.ToString();
                harga.Text = data.Cells["harga_satuan"].Value.ToString();

                imageName = kode.Text + ".jpg";
                string folder = @"C:\Users\smkyp\source\repos\lksmart\lksmart\gambar";
                string path = System.IO.Path.Combine(folder, imageName);
                if (System.IO.File.Exists(path))
                {
                    using (System.IO.FileStream fileStream = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        img.Image = System.Drawing.Image.FromStream(fileStream);
                    }
                }
                else
                {
                    img.Image = null;

                }

                tambah.Enabled = false;
                edit.Enabled = true;
                hapus.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                upload = true;
            }
        }

        private void jumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void satuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void harga_KeyPress(object sender, KeyPressEventArgs e)
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

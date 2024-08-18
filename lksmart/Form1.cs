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
    public partial class Form1 : Form
    {
        SqlConnection conn = connection.Connect();
        SqlCommand cmd;
        SqlDataReader rd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if(email.Text.Length == 0)
            {
                MessageBox.Show("Email field is required");
            }else if(password.Text.Length == 0)

            {
                MessageBox.Show("Password field is required");
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM [tbl_user] WHERE username = '" + email.Text + "' AND password = '" + HashPassword.Hash(password.Text) + "'", conn);
                rd = cmd.ExecuteReader();
                if(rd.HasRows)
                {
                    rd.Read();
                    int id = (int)rd["id_user"];
                    string name = rd["username"].ToString();
                    string tipe = rd["tipe_user"].ToString();
                    session.start(id, name);
                    rd.Close();
                    conn.Close();

                    conn.Open();
                    SqlCommand log = new SqlCommand("INSERT INTO [tbl_log] VALUES (@waktu, 'LOGIN', '" + id + "')", conn);
                    log.Parameters.AddWithValue("@waktu", DateTime.Now);
                    log.ExecuteNonQuery();
                    conn.Close() ;

                    if (tipe == "admin")
                    {
                        LogForm logForm = new LogForm();
                        logForm.Show();
                        this.Hide();
                    }else if(tipe == "kasir")
                    {
                        kasir kasir = new kasir();
                        kasir.Show();
                        this.Hide();
                    }else if(tipe == "gudang")
                    {
                        gudang  gudang = new gudang();
                        gudang.Show();
                        this.Hide();
                    }


                    MessageBox.Show("Login Success");

                }
                else
                {
                    conn.Close( );
                    MessageBox.Show("email and password doesn't match");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            email.Text = null;
            password.Text = null;
        }
    }
}

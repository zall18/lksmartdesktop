namespace lksmart
{
    partial class KelolaUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.telpon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.RichTextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tambah = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "KELOLA USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipe User";
            // 
            // tipe
            // 
            this.tipe.FormattingEnabled = true;
            this.tipe.Items.AddRange(new object[] {
            "gudang",
            "kasir"});
            this.tipe.Location = new System.Drawing.Point(40, 81);
            this.tipe.Name = "tipe";
            this.tipe.Size = new System.Drawing.Size(224, 21);
            this.tipe.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nama";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(40, 121);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(224, 20);
            this.nama.TabIndex = 18;
            // 
            // telpon
            // 
            this.telpon.Location = new System.Drawing.Point(40, 166);
            this.telpon.Name = "telpon";
            this.telpon.Size = new System.Drawing.Size(224, 20);
            this.telpon.TabIndex = 20;
            this.telpon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telpon_KeyPress);
            this.telpon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.telpon_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Alamat";
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(40, 207);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(277, 65);
            this.alamat.TabIndex = 22;
            this.alamat.Text = "";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(307, 79);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(224, 20);
            this.username.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Username";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(307, 121);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(224, 20);
            this.password.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Password";
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tambah.Location = new System.Drawing.Point(307, 157);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 37);
            this.tambah.TabIndex = 27;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.Color.Red;
            this.hapus.Location = new System.Drawing.Point(469, 157);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(75, 37);
            this.hapus.TabIndex = 28;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = false;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.edit.Location = new System.Drawing.Point(388, 157);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 37);
            this.edit.TabIndex = 29;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 135);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(461, 277);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 31;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(553, 9);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(28, 20);
            this.id.TabIndex = 32;
            this.id.Visible = false;
            // 
            // KelolaUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.id);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telpon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KelolaUserForm";
            this.Text = "KelolaUserForm";
            this.Load += new System.EventHandler(this.KelolaUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox telpon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox alamat;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox id;
    }
}
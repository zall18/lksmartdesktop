namespace lksmart
{
    partial class gudang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gudang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kode = new System.Windows.Forms.TextBox();
            this.jumlah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.satuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.tambah = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(52, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "KELOLA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(56, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "BARANG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(206, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "KELOLA GARANG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kode Barang";
            // 
            // kode
            // 
            this.kode.Location = new System.Drawing.Point(371, 52);
            this.kode.Name = "kode";
            this.kode.Size = new System.Drawing.Size(225, 20);
            this.kode.TabIndex = 17;
            // 
            // jumlah
            // 
            this.jumlah.Location = new System.Drawing.Point(371, 78);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(225, 20);
            this.jumlah.TabIndex = 19;
            this.jumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jumlah_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Jumlah Barang";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(371, 104);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(225, 20);
            this.nama.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nama Barang";
            // 
            // satuan
            // 
            this.satuan.Location = new System.Drawing.Point(371, 130);
            this.satuan.Name = "satuan";
            this.satuan.Size = new System.Drawing.Size(225, 20);
            this.satuan.TabIndex = 23;
            this.satuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.satuan_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Satuan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Expired data";
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(371, 182);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(225, 20);
            this.harga.TabIndex = 27;
            this.harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harga_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Harga Satuan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Gambar Barang";
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(371, 208);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(100, 94);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 29;
            this.img.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Pilih Gambar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.edit.Location = new System.Drawing.Point(655, 147);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 37);
            this.edit.TabIndex = 33;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.Color.Red;
            this.hapus.Location = new System.Drawing.Point(655, 190);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(75, 37);
            this.hapus.TabIndex = 32;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = false;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tambah.Location = new System.Drawing.Point(655, 104);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 37);
            this.tambah.TabIndex = 31;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(669, 304);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 35;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 113);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(371, 156);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(225, 20);
            this.date.TabIndex = 36;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(767, 9);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(37, 20);
            this.id.TabIndex = 37;
            this.id.Visible = false;
            // 
            // gudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.id);
            this.Controls.Add(this.date);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.img);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.satuan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "gudang";
            this.Text = "gudang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kode;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox satuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox id;
    }
}
namespace lksmart
{
    partial class kasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasir));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quatitas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telepon = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pelanggan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.th = new System.Windows.Forms.TextBox();
            this.tambah = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bayar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uk = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.diskon = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.ids = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "TRANSAKSI";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(52, 406);
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
            this.pictureBox1.Location = new System.Drawing.Point(52, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(217, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "FORM TRANSAKSI";
            // 
            // quatitas
            // 
            this.quatitas.Location = new System.Drawing.Point(428, 114);
            this.quatitas.Name = "quatitas";
            this.quatitas.Size = new System.Drawing.Size(176, 20);
            this.quatitas.TabIndex = 33;
            this.quatitas.TextChanged += new System.EventHandler(this.quatitas_TextChanged);
            this.quatitas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quatitas_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Quantitas";
            // 
            // harga
            // 
            this.harga.Enabled = false;
            this.harga.Location = new System.Drawing.Point(428, 72);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(176, 20);
            this.harga.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Harga satuan";
            // 
            // telepon
            // 
            this.telepon.Location = new System.Drawing.Point(222, 114);
            this.telepon.Name = "telepon";
            this.telepon.Size = new System.Drawing.Size(180, 20);
            this.telepon.TabIndex = 29;
            this.telepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telepon_KeyPress);
            // 
            // menu
            // 
            this.menu.FormattingEnabled = true;
            this.menu.Location = new System.Drawing.Point(222, 71);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(180, 21);
            this.menu.TabIndex = 28;
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pilih Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Telepon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Nama Pelanggan";
            // 
            // pelanggan
            // 
            this.pelanggan.Location = new System.Drawing.Point(222, 159);
            this.pelanggan.Name = "pelanggan";
            this.pelanggan.Size = new System.Drawing.Size(180, 20);
            this.pelanggan.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(425, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Total Harga";
            // 
            // th
            // 
            this.th.Enabled = false;
            this.th.Location = new System.Drawing.Point(428, 159);
            this.th.Name = "th";
            this.th.Size = new System.Drawing.Size(180, 20);
            this.th.TabIndex = 37;
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tambah.Location = new System.Drawing.Point(672, 86);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 37);
            this.tambah.TabIndex = 39;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.Color.Red;
            this.hapus.Location = new System.Drawing.Point(672, 131);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(75, 37);
            this.hapus.TabIndex = 40;
            this.hapus.Text = "Reset";
            this.hapus.UseVisualStyleBackColor = false;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(222, 203);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(544, 113);
            this.dgv.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bayar
            // 
            this.bayar.Location = new System.Drawing.Point(265, 354);
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(137, 20);
            this.bayar.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Cash";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Bayar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Jumlah Kembalian";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Rp.";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // uk
            // 
            this.uk.AutoSize = true;
            this.uk.Location = new System.Drawing.Point(352, 406);
            this.uk.Name = "uk";
            this.uk.Size = new System.Drawing.Size(10, 13);
            this.uk.TabIndex = 49;
            this.uk.Text = "-";
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Location = new System.Drawing.Point(708, 319);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(10, 13);
            this.tb.TabIndex = 52;
            this.tb.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(678, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "Rp.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(580, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Total Harga";
            // 
            // diskon
            // 
            this.diskon.AutoSize = true;
            this.diskon.Location = new System.Drawing.Point(708, 337);
            this.diskon.Name = "diskon";
            this.diskon.Size = new System.Drawing.Size(10, 13);
            this.diskon.TabIndex = 55;
            this.diskon.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(678, 337);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 54;
            this.label18.Text = "Rp.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(580, 337);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 53;
            this.label19.Text = "Disc";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(766, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(36, 20);
            this.id.TabIndex = 56;
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(766, 19);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(36, 20);
            this.ids.TabIndex = 57;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "Tambah Pelanggan";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ids);
            this.Controls.Add(this.id);
            this.Controls.Add(this.diskon);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.uk);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bayar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.th);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pelanggan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quatitas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telepon);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "kasir";
            this.Text = "kasir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quatitas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telepon;
        private System.Windows.Forms.ComboBox menu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pelanggan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox th;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox bayar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label uk;
        private System.Windows.Forms.Label tb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label diskon;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox ids;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button5;
    }
}
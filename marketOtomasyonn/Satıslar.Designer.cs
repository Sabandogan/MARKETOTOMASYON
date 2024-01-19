namespace marketOtomasyonn
{
    partial class Satıslar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFısler = new System.Windows.Forms.DataGridView();
            this.dgvSatisDetaylar = new System.Windows.Forms.DataGridView();
            this.FISNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URUNBARKOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URUNADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URUNFIYAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOPLAMTUTAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKasa = new System.Windows.Forms.Label();
            this.btnCiro = new System.Windows.Forms.Button();
            this.btnFisSil = new System.Windows.Forms.Button();
            this.mtxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtKasiyerSorgu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFısler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisDetaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFısler
            // 
            this.dgvFısler.AllowUserToAddRows = false;
            this.dgvFısler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFısler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFısler.Location = new System.Drawing.Point(9, 10);
            this.dgvFısler.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFısler.Name = "dgvFısler";
            this.dgvFısler.ReadOnly = true;
            this.dgvFısler.RowHeadersWidth = 51;
            this.dgvFısler.RowTemplate.Height = 24;
            this.dgvFısler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFısler.Size = new System.Drawing.Size(1204, 388);
            this.dgvFısler.TabIndex = 0;
            this.dgvFısler.SelectionChanged += new System.EventHandler(this.dgvFısler_SelectionChanged);
            // 
            // dgvSatisDetaylar
            // 
            this.dgvSatisDetaylar.AllowUserToAddRows = false;
            this.dgvSatisDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSatisDetaylar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSatisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatisDetaylar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FISNO,
            this.URUNBARKOD,
            this.URUNADI,
            this.URUNFIYAT,
            this.ADET,
            this.TOPLAMTUTAR});
            this.dgvSatisDetaylar.Location = new System.Drawing.Point(9, 428);
            this.dgvSatisDetaylar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSatisDetaylar.Name = "dgvSatisDetaylar";
            this.dgvSatisDetaylar.RowHeadersVisible = false;
            this.dgvSatisDetaylar.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.dgvSatisDetaylar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSatisDetaylar.RowTemplate.Height = 24;
            this.dgvSatisDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatisDetaylar.Size = new System.Drawing.Size(1204, 344);
            this.dgvSatisDetaylar.TabIndex = 1;
            // 
            // FISNO
            // 
            this.FISNO.HeaderText = "FİŞNO";
            this.FISNO.Name = "FISNO";
            // 
            // URUNBARKOD
            // 
            this.URUNBARKOD.HeaderText = "ÜRÜN BARKODU";
            this.URUNBARKOD.Name = "URUNBARKOD";
            // 
            // URUNADI
            // 
            this.URUNADI.HeaderText = "ÜRÜNADI";
            this.URUNADI.Name = "URUNADI";
            // 
            // URUNFIYAT
            // 
            this.URUNFIYAT.HeaderText = "ÜRÜNFİYAT";
            this.URUNFIYAT.Name = "URUNFIYAT";
            // 
            // ADET
            // 
            this.ADET.HeaderText = "ADET";
            this.ADET.Name = "ADET";
            // 
            // TOPLAMTUTAR
            // 
            this.TOPLAMTUTAR.HeaderText = "TOPLAMTUTAR";
            this.TOPLAMTUTAR.Name = "TOPLAMTUTAR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1218, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "FİŞİ GETİR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasa.Location = new System.Drawing.Point(1511, 7);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(95, 33);
            this.lblKasa.TabIndex = 3;
            this.lblKasa.Text = "KASA";
            // 
            // btnCiro
            // 
            this.btnCiro.BackColor = System.Drawing.Color.Lime;
            this.btnCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiro.Location = new System.Drawing.Point(1454, 49);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(219, 105);
            this.btnCiro.TabIndex = 4;
            this.btnCiro.Text = "0";
            this.btnCiro.UseVisualStyleBackColor = false;
            // 
            // btnFisSil
            // 
            this.btnFisSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFisSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFisSil.Location = new System.Drawing.Point(1218, 271);
            this.btnFisSil.Name = "btnFisSil";
            this.btnFisSil.Size = new System.Drawing.Size(219, 105);
            this.btnFisSil.TabIndex = 5;
            this.btnFisSil.Text = "FİŞİ İPTAL ET";
            this.btnFisSil.UseVisualStyleBackColor = false;
            this.btnFisSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // mtxtTarih
            // 
            this.mtxtTarih.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTarih.Location = new System.Drawing.Point(1218, 10);
            this.mtxtTarih.Mask = "00/00/0000";
            this.mtxtTarih.Name = "mtxtTarih";
            this.mtxtTarih.Size = new System.Drawing.Size(214, 33);
            this.mtxtTarih.TabIndex = 6;
            this.mtxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1218, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 105);
            this.button2.TabIndex = 7;
            this.button2.Text = "TARİHE GÖRE SATIŞLARI\r\nGETİR\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(1218, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 105);
            this.button3.TabIndex = 8;
            this.button3.Text = "BÜTÜN FİŞLERİ GETİR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(1454, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 105);
            this.button4.TabIndex = 9;
            this.button4.Text = "KASİYERE GÖRE SATIŞLAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtKasiyerSorgu
            // 
            this.txtKasiyerSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKasiyerSorgu.Location = new System.Drawing.Point(1454, 271);
            this.txtKasiyerSorgu.Name = "txtKasiyerSorgu";
            this.txtKasiyerSorgu.Size = new System.Drawing.Size(219, 38);
            this.txtKasiyerSorgu.TabIndex = 10;
            this.txtKasiyerSorgu.Visible = false;
            this.txtKasiyerSorgu.TextChanged += new System.EventHandler(this.txtKasiyerSorgu_TextChanged);
            // 
            // Satıslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1736, 808);
            this.Controls.Add(this.txtKasiyerSorgu);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mtxtTarih);
            this.Controls.Add(this.btnFisSil);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.lblKasa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSatisDetaylar);
            this.Controls.Add(this.dgvFısler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Satıslar";
            this.Text = "Satıslar";
            this.Load += new System.EventHandler(this.Satıslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFısler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisDetaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFısler;
        private System.Windows.Forms.DataGridView dgvSatisDetaylar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Button btnCiro;
        private System.Windows.Forms.Button btnFisSil;
        private System.Windows.Forms.MaskedTextBox mtxtTarih;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FISNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUNBARKOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUNADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUNFIYAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADET;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOPLAMTUTAR;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtKasiyerSorgu;
    }
}
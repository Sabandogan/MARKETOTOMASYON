namespace marketOtomasyonn
{
    partial class SatısEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatısEkrani));
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnFisİptal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnanaToplam = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvSatis = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnikiyuzUstu = new System.Windows.Forms.Button();
            this.btnyuzUstu = new System.Windows.Forms.Button();
            this.btnelliUstu = new System.Windows.Forms.Button();
            this.btnyirmiUstu = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblKasiyer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(2, 20);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(234, 37);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // btnFisİptal
            // 
            this.btnFisİptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFisİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFisİptal.Location = new System.Drawing.Point(986, 380);
            this.btnFisİptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnFisİptal.Name = "btnFisİptal";
            this.btnFisİptal.Size = new System.Drawing.Size(117, 85);
            this.btnFisİptal.TabIndex = 3;
            this.btnFisİptal.Text = "FİŞ İPTAL";
            this.btnFisİptal.UseVisualStyleBackColor = false;
            this.btnFisİptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(866, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "NAKİT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnanaToplam
            // 
            this.btnanaToplam.BackColor = System.Drawing.Color.Red;
            this.btnanaToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanaToplam.ForeColor = System.Drawing.Color.White;
            this.btnanaToplam.Location = new System.Drawing.Point(866, 470);
            this.btnanaToplam.Margin = new System.Windows.Forms.Padding(2);
            this.btnanaToplam.Name = "btnanaToplam";
            this.btnanaToplam.Size = new System.Drawing.Size(237, 87);
            this.btnanaToplam.TabIndex = 4;
            this.btnanaToplam.Text = "0 TL";
            this.btnanaToplam.UseVisualStyleBackColor = false;
            this.btnanaToplam.TextChanged += new System.EventHandler(this.btnanaToplam_TextChanged);
            
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(866, 303);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(237, 72);
            this.button5.TabIndex = 6;
            this.button5.Text = "STOK DÜZENLE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvSatis
            // 
            this.dgvSatis.AllowUserToAddRows = false;
            this.dgvSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSatis.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSatis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSatis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSatis.EnableHeadersVisualStyles = false;
            this.dgvSatis.Location = new System.Drawing.Point(2, 62);
            this.dgvSatis.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSatis.MultiSelect = false;
            this.dgvSatis.Name = "dgvSatis";
            this.dgvSatis.RowHeadersVisible = false;
            this.dgvSatis.RowHeadersWidth = 51;
            this.dgvSatis.RowTemplate.Height = 40;
            this.dgvSatis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatis.Size = new System.Drawing.Size(860, 495);
            this.dgvSatis.TabIndex = 7;
            this.dgvSatis.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSatis_CellValueChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 561);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(105, 561);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(208, 561);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(312, 561);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(99, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // btnikiyuzUstu
            // 
            this.btnikiyuzUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnikiyuzUstu.Location = new System.Drawing.Point(2, 618);
            this.btnikiyuzUstu.Margin = new System.Windows.Forms.Padding(2);
            this.btnikiyuzUstu.Name = "btnikiyuzUstu";
            this.btnikiyuzUstu.Size = new System.Drawing.Size(99, 34);
            this.btnikiyuzUstu.TabIndex = 13;
            this.btnikiyuzUstu.Text = "0";
            this.btnikiyuzUstu.UseVisualStyleBackColor = true;
            // 
            // btnyuzUstu
            // 
            this.btnyuzUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyuzUstu.Location = new System.Drawing.Point(105, 618);
            this.btnyuzUstu.Margin = new System.Windows.Forms.Padding(2);
            this.btnyuzUstu.Name = "btnyuzUstu";
            this.btnyuzUstu.Size = new System.Drawing.Size(99, 34);
            this.btnyuzUstu.TabIndex = 14;
            this.btnyuzUstu.Text = "0";
            this.btnyuzUstu.UseVisualStyleBackColor = true;
            // 
            // btnelliUstu
            // 
            this.btnelliUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnelliUstu.Location = new System.Drawing.Point(208, 618);
            this.btnelliUstu.Margin = new System.Windows.Forms.Padding(2);
            this.btnelliUstu.Name = "btnelliUstu";
            this.btnelliUstu.Size = new System.Drawing.Size(99, 34);
            this.btnelliUstu.TabIndex = 15;
            this.btnelliUstu.Text = "0";
            this.btnelliUstu.UseVisualStyleBackColor = true;
            // 
            // btnyirmiUstu
            // 
            this.btnyirmiUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyirmiUstu.Location = new System.Drawing.Point(312, 618);
            this.btnyirmiUstu.Margin = new System.Windows.Forms.Padding(2);
            this.btnyirmiUstu.Name = "btnyirmiUstu";
            this.btnyirmiUstu.Size = new System.Drawing.Size(99, 34);
            this.btnyirmiUstu.TabIndex = 16;
            this.btnyirmiUstu.Text = "0";
            this.btnyirmiUstu.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(866, 226);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 72);
            this.button4.TabIndex = 18;
            this.button4.Text = "SATIŞLARI GÖSTER";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // lblKasiyer
            // 
            this.lblKasiyer.AutoSize = true;
            this.lblKasiyer.BackColor = System.Drawing.Color.White;
            this.lblKasiyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyer.Location = new System.Drawing.Point(432, 587);
            this.lblKasiyer.Name = "lblKasiyer";
            this.lblKasiyer.Size = new System.Drawing.Size(195, 25);
            this.lblKasiyer.TabIndex = 19;
            this.lblKasiyer.Text = "AKTİF KASİYER :";
        
            // 
            // SatısEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1723, 767);
            this.Controls.Add(this.lblKasiyer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnyirmiUstu);
            this.Controls.Add(this.btnelliUstu);
            this.Controls.Add(this.btnyuzUstu);
            this.Controls.Add(this.btnikiyuzUstu);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSatis);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnanaToplam);
            this.Controls.Add(this.btnFisİptal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBarkod);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SatısEkrani";
            this.Text = "SatısEkrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SatısEkrani_FormClosed);
            this.Load += new System.EventHandler(this.SatısEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnFisİptal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnanaToplam;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvSatis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnikiyuzUstu;
        private System.Windows.Forms.Button btnyuzUstu;
        private System.Windows.Forms.Button btnelliUstu;
        private System.Windows.Forms.Button btnyirmiUstu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblKasiyer;
    }
}
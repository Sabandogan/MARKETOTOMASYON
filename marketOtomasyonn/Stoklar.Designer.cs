namespace marketOtomasyonn
{
    partial class Stoklar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stoklar));
            this.dgvStoklar = new System.Windows.Forms.DataGridView();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnurunKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txturunAdi = new System.Windows.Forms.TextBox();
            this.txturunFiyat = new System.Windows.Forms.TextBox();
            this.txturunBirimi = new System.Windows.Forms.TextBox();
            this.txturunStok = new System.Windows.Forms.TextBox();
            this.txturunMarka = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmarkaGuncelle = new System.Windows.Forms.TextBox();
            this.txturunbarkodGuncelle = new System.Windows.Forms.TextBox();
            this.txtstokGuncelle = new System.Windows.Forms.TextBox();
            this.txtbirimGuncelle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfiyatGuncelle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txturunadiGuncelle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbltoplamKayıt = new System.Windows.Forms.Label();
            this.btnKritikStoklar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoklar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStoklar
            // 
            this.dgvStoklar.AllowUserToAddRows = false;
            this.dgvStoklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStoklar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStoklar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStoklar.Location = new System.Drawing.Point(14, 88);
            this.dgvStoklar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStoklar.Name = "dgvStoklar";
            this.dgvStoklar.ReadOnly = true;
            this.dgvStoklar.RowHeadersWidth = 51;
            this.dgvStoklar.RowTemplate.Height = 24;
            this.dgvStoklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoklar.Size = new System.Drawing.Size(1302, 305);
            this.dgvStoklar.TabIndex = 0;
            this.dgvStoklar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoklar_CellClick);
            
        
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(226, 41);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(333, 26);
            this.txtBarkod.TabIndex = 1;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÜRÜN BARKODU";
        
            // 
            // btnurunKaydet
            // 
            this.btnurunKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnurunKaydet.Location = new System.Drawing.Point(226, 247);
            this.btnurunKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnurunKaydet.Name = "btnurunKaydet";
            this.btnurunKaydet.Size = new System.Drawing.Size(162, 52);
            this.btnurunKaydet.TabIndex = 3;
            this.btnurunKaydet.Text = "KAYDET";
            this.btnurunKaydet.UseVisualStyleBackColor = false;
            this.btnurunKaydet.Click += new System.EventHandler(this.btnurunKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ÜRÜN FİYATI";
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ÜRÜN BİRİMİ";
         
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ÜRÜN STOK ADETİ";
     
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "ÜRÜN MARKASI";
          
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "ÜRÜN ADI";
    
            // 
            // txturunAdi
            // 
            this.txturunAdi.Location = new System.Drawing.Point(226, 75);
            this.txturunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txturunAdi.Name = "txturunAdi";
            this.txturunAdi.Size = new System.Drawing.Size(333, 26);
            this.txturunAdi.TabIndex = 9;
           
            // 
            // txturunFiyat
            // 
            this.txturunFiyat.Location = new System.Drawing.Point(226, 109);
            this.txturunFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.txturunFiyat.Name = "txturunFiyat";
            this.txturunFiyat.Size = new System.Drawing.Size(333, 26);
            this.txturunFiyat.TabIndex = 10;
        
            // 
            // txturunBirimi
            // 
            this.txturunBirimi.Location = new System.Drawing.Point(226, 144);
            this.txturunBirimi.Margin = new System.Windows.Forms.Padding(2);
            this.txturunBirimi.Name = "txturunBirimi";
            this.txturunBirimi.Size = new System.Drawing.Size(333, 26);
            this.txturunBirimi.TabIndex = 11;
        
            // 
            // txturunStok
            // 
            this.txturunStok.Location = new System.Drawing.Point(226, 180);
            this.txturunStok.Margin = new System.Windows.Forms.Padding(2);
            this.txturunStok.Name = "txturunStok";
            this.txturunStok.Size = new System.Drawing.Size(333, 26);
            this.txturunStok.TabIndex = 12;
          
            // 
            // txturunMarka
            // 
            this.txturunMarka.Location = new System.Drawing.Point(226, 218);
            this.txturunMarka.Margin = new System.Windows.Forms.Padding(2);
            this.txturunMarka.Name = "txturunMarka";
            this.txturunMarka.Size = new System.Drawing.Size(333, 26);
            this.txturunMarka.TabIndex = 13;
        
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txturunMarka);
            this.groupBox1.Controls.Add(this.txtBarkod);
            this.groupBox1.Controls.Add(this.txturunStok);
            this.groupBox1.Controls.Add(this.btnurunKaydet);
            this.groupBox1.Controls.Add(this.txturunBirimi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txturunFiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txturunAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 407);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(818, 318);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN KAYDETME ";
   
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(393, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "KAYIT SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnGuncelle.Location = new System.Drawing.Point(200, 252);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(169, 50);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtarama
            // 
            this.txtarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarama.Location = new System.Drawing.Point(139, 52);
            this.txtarama.Margin = new System.Windows.Forms.Padding(2);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(167, 28);
            this.txtarama.TabIndex = 15;
            this.txtarama.TextChanged += new System.EventHandler(this.txtarama_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "ÜRÜN ARA :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.ImageKey = "(none)";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(1323, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 57);
            this.button2.TabIndex = 17;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-shutdown-48.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtmarkaGuncelle);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.txturunbarkodGuncelle);
            this.groupBox2.Controls.Add(this.txtstokGuncelle);
            this.groupBox2.Controls.Add(this.txtbirimGuncelle);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtfiyatGuncelle);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txturunadiGuncelle);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(836, 407);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(580, 318);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜRÜN GÜNCELLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "ÜRÜN BARKODU";
            // 
            // txtmarkaGuncelle
            // 
            this.txtmarkaGuncelle.Location = new System.Drawing.Point(200, 223);
            this.txtmarkaGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.txtmarkaGuncelle.Name = "txtmarkaGuncelle";
            this.txtmarkaGuncelle.Size = new System.Drawing.Size(333, 26);
            this.txtmarkaGuncelle.TabIndex = 25;
            // 
            // txturunbarkodGuncelle
            // 
            this.txturunbarkodGuncelle.Location = new System.Drawing.Point(200, 46);
            this.txturunbarkodGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.txturunbarkodGuncelle.Name = "txturunbarkodGuncelle";
            this.txturunbarkodGuncelle.Size = new System.Drawing.Size(333, 26);
            this.txturunbarkodGuncelle.TabIndex = 14;
            // 
            // txtstokGuncelle
            // 
            this.txtstokGuncelle.Location = new System.Drawing.Point(200, 180);
            this.txtstokGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.txtstokGuncelle.Name = "txtstokGuncelle";
            this.txtstokGuncelle.Size = new System.Drawing.Size(333, 26);
            this.txtstokGuncelle.TabIndex = 24;
            // 
            // txtbirimGuncelle
            // 
            this.txtbirimGuncelle.Location = new System.Drawing.Point(200, 149);
            this.txtbirimGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.txtbirimGuncelle.Name = "txtbirimGuncelle";
            this.txtbirimGuncelle.Size = new System.Drawing.Size(333, 26);
            this.txtbirimGuncelle.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "ÜRÜN FİYATI";
            // 
            // txtfiyatGuncelle
            // 
            this.txtfiyatGuncelle.Location = new System.Drawing.Point(200, 114);
            this.txtfiyatGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.txtfiyatGuncelle.Name = "txtfiyatGuncelle";
            this.txtfiyatGuncelle.Size = new System.Drawing.Size(333, 26);
            this.txtfiyatGuncelle.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "ÜRÜN BİRİMİ";
            // 
            // txturunadiGuncelle
            // 
            this.txturunadiGuncelle.Location = new System.Drawing.Point(200, 80);
            this.txturunadiGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.txturunadiGuncelle.Name = "txturunadiGuncelle";
            this.txturunadiGuncelle.Size = new System.Drawing.Size(333, 26);
            this.txturunadiGuncelle.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 184);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "ÜRÜN STOK ADETİ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "ÜRÜN ADI";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 228);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "ÜRÜN MARKASI";
            // 
            // lbltoplamKayıt
            // 
            this.lbltoplamKayıt.AutoSize = true;
            this.lbltoplamKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamKayıt.Location = new System.Drawing.Point(318, 54);
            this.lbltoplamKayıt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltoplamKayıt.Name = "lbltoplamKayıt";
            this.lbltoplamKayıt.Size = new System.Drawing.Size(145, 20);
            this.lbltoplamKayıt.TabIndex = 18;
            this.lbltoplamKayıt.Text = "TOPLAM KAYIT :";
            // 
            // btnKritikStoklar
            // 
            this.btnKritikStoklar.BackColor = System.Drawing.Color.Red;
            this.btnKritikStoklar.Location = new System.Drawing.Point(1320, 88);
            this.btnKritikStoklar.Margin = new System.Windows.Forms.Padding(2);
            this.btnKritikStoklar.Name = "btnKritikStoklar";
            this.btnKritikStoklar.Size = new System.Drawing.Size(191, 59);
            this.btnKritikStoklar.TabIndex = 26;
            this.btnKritikStoklar.Text = "KRİTİK STOKLARI GÖSTER";
            this.btnKritikStoklar.UseVisualStyleBackColor = false;
            this.btnKritikStoklar.Click += new System.EventHandler(this.btnKritikStoklar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1637, 825);
            this.ControlBox = false;
            this.Controls.Add(this.btnKritikStoklar);
            this.Controls.Add(this.lbltoplamKayıt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtarama);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStoklar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "STOKLAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoklar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStoklar;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnurunKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txturunAdi;
        private System.Windows.Forms.TextBox txturunFiyat;
        private System.Windows.Forms.TextBox txturunBirimi;
        private System.Windows.Forms.TextBox txturunStok;
        private System.Windows.Forms.TextBox txturunMarka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmarkaGuncelle;
        private System.Windows.Forms.TextBox txturunbarkodGuncelle;
        private System.Windows.Forms.TextBox txtstokGuncelle;
        private System.Windows.Forms.TextBox txtbirimGuncelle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfiyatGuncelle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txturunadiGuncelle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbltoplamKayıt;
        private System.Windows.Forms.Button btnKritikStoklar;
    }
}


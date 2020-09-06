namespace Twok
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.buttonPortlar = new System.Windows.Forms.Button();
            this.buttonAktifTestler = new System.Windows.Forms.Button();
            this.panelPortlar = new System.Windows.Forms.Panel();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonYenile = new System.Windows.Forms.Button();
            this.buttonPortEkle = new System.Windows.Forms.Button();
            this.dataGridViewPorts = new System.Windows.Forms.DataGridView();
            this.portName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boudRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parityBit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopBits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxBoudRate = new System.Windows.Forms.ComboBox();
            this.labelBaglıPortlar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPanelPortlarGeri = new System.Windows.Forms.Button();
            this.panelTestler = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPanelTestGeri = new System.Windows.Forms.Button();
            this.panelMainMenu.SuspendLayout();
            this.panelPortlar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPorts)).BeginInit();
            this.panelTestler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.buttonPortlar);
            this.panelMainMenu.Controls.Add(this.buttonAktifTestler);
            this.panelMainMenu.Location = new System.Drawing.Point(163, 78);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(150, 89);
            this.panelMainMenu.TabIndex = 0;
            this.panelMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainMenu_Paint);
            // 
            // buttonPortlar
            // 
            this.buttonPortlar.Location = new System.Drawing.Point(426, 313);
            this.buttonPortlar.Name = "buttonPortlar";
            this.buttonPortlar.Size = new System.Drawing.Size(75, 23);
            this.buttonPortlar.TabIndex = 1;
            this.buttonPortlar.Text = "Portlar";
            this.buttonPortlar.UseVisualStyleBackColor = true;
            this.buttonPortlar.Click += new System.EventHandler(this.buttonPortlar_Click);
            // 
            // buttonAktifTestler
            // 
            this.buttonAktifTestler.Location = new System.Drawing.Point(426, 247);
            this.buttonAktifTestler.Name = "buttonAktifTestler";
            this.buttonAktifTestler.Size = new System.Drawing.Size(75, 23);
            this.buttonAktifTestler.TabIndex = 0;
            this.buttonAktifTestler.Text = "Aktif Testler";
            this.buttonAktifTestler.UseVisualStyleBackColor = true;
            this.buttonAktifTestler.Click += new System.EventHandler(this.buttonAktifTestler_Click);
            // 
            // panelPortlar
            // 
            this.panelPortlar.Controls.Add(this.buttonPanelPortlarGeri);
            this.panelPortlar.Controls.Add(this.labelBaglıPortlar);
            this.panelPortlar.Controls.Add(this.dataGridViewPorts);
            this.panelPortlar.Controls.Add(this.panel1);
            this.panelPortlar.Location = new System.Drawing.Point(146, 252);
            this.panelPortlar.Name = "panelPortlar";
            this.panelPortlar.Size = new System.Drawing.Size(655, 324);
            this.panelPortlar.TabIndex = 1;
            this.panelPortlar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPortlar_Paint);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(15, 12);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 0;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxBoudRate);
            this.panel1.Controls.Add(this.buttonPortEkle);
            this.panel1.Controls.Add(this.buttonYenile);
            this.panel1.Controls.Add(this.comboBoxPorts);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(65, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 130);
            this.panel1.TabIndex = 1;
            // 
            // buttonYenile
            // 
            this.buttonYenile.Location = new System.Drawing.Point(26, 83);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(75, 23);
            this.buttonYenile.TabIndex = 1;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseVisualStyleBackColor = true;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // buttonPortEkle
            // 
            this.buttonPortEkle.Location = new System.Drawing.Point(175, 83);
            this.buttonPortEkle.Name = "buttonPortEkle";
            this.buttonPortEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonPortEkle.TabIndex = 2;
            this.buttonPortEkle.Text = "Port Ekle";
            this.buttonPortEkle.UseVisualStyleBackColor = true;
            this.buttonPortEkle.Click += new System.EventHandler(this.buttonPortEkle_Click);
            // 
            // dataGridViewPorts
            // 
            this.dataGridViewPorts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPorts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.portName,
            this.boudRate,
            this.parityBit,
            this.dataBits,
            this.stopBits});
            this.dataGridViewPorts.Location = new System.Drawing.Point(402, 40);
            this.dataGridViewPorts.Name = "dataGridViewPorts";
            this.dataGridViewPorts.Size = new System.Drawing.Size(544, 531);
            this.dataGridViewPorts.TabIndex = 2;
            this.dataGridViewPorts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // portName
            // 
            this.portName.HeaderText = "Port Adı";
            this.portName.Name = "portName";
            // 
            // boudRate
            // 
            this.boudRate.HeaderText = "Bant Genişliği";
            this.boudRate.Name = "boudRate";
            // 
            // parityBit
            // 
            this.parityBit.HeaderText = "Eşlik Biti";
            this.parityBit.Name = "parityBit";
            // 
            // dataBits
            // 
            this.dataBits.HeaderText = "Bit Sayısı";
            this.dataBits.Name = "dataBits";
            // 
            // stopBits
            // 
            this.stopBits.HeaderText = "Durma Biti";
            this.stopBits.Name = "stopBits";
            // 
            // comboBoxBoudRate
            // 
            this.comboBoxBoudRate.FormattingEnabled = true;
            this.comboBoxBoudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.comboBoxBoudRate.Location = new System.Drawing.Point(15, 39);
            this.comboBoxBoudRate.Name = "comboBoxBoudRate";
            this.comboBoxBoudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBoudRate.TabIndex = 3;
            // 
            // labelBaglıPortlar
            // 
            this.labelBaglıPortlar.AutoSize = true;
            this.labelBaglıPortlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBaglıPortlar.Location = new System.Drawing.Point(618, 9);
            this.labelBaglıPortlar.Name = "labelBaglıPortlar";
            this.labelBaglıPortlar.Size = new System.Drawing.Size(129, 25);
            this.labelBaglıPortlar.TabIndex = 3;
            this.labelBaglıPortlar.Text = "Bağlı Portlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Portlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bant Genişliği";
            // 
            // buttonPanelPortlarGeri
            // 
            this.buttonPanelPortlarGeri.Location = new System.Drawing.Point(65, 524);
            this.buttonPanelPortlarGeri.Name = "buttonPanelPortlarGeri";
            this.buttonPanelPortlarGeri.Size = new System.Drawing.Size(75, 47);
            this.buttonPanelPortlarGeri.TabIndex = 4;
            this.buttonPanelPortlarGeri.Text = "Geri";
            this.buttonPanelPortlarGeri.UseVisualStyleBackColor = true;
            this.buttonPanelPortlarGeri.Click += new System.EventHandler(this.buttonPanelPortlarGeri_Click);
            // 
            // panelTestler
            // 
            this.panelTestler.Controls.Add(this.buttonPanelTestGeri);
            this.panelTestler.Controls.Add(this.dataGridView1);
            this.panelTestler.Location = new System.Drawing.Point(471, 95);
            this.panelTestler.Name = "panelTestler";
            this.panelTestler.Size = new System.Drawing.Size(448, 89);
            this.panelTestler.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.tourCount,
            this.tourTime,
            this.pdz,
            this.phs});
            this.dataGridView1.Location = new System.Drawing.Point(167, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 513);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // no
            // 
            this.no.HeaderText = "Masa numarası";
            this.no.Name = "no";
            // 
            // tourCount
            // 
            this.tourCount.HeaderText = "Tur sayısı";
            this.tourCount.Name = "tourCount";
            // 
            // tourTime
            // 
            this.tourTime.HeaderText = "Tur Tamamlama Zamanı";
            this.tourTime.Name = "tourTime";
            // 
            // pdz
            // 
            this.pdz.HeaderText = "Piston Düşme Zamanı";
            this.pdz.Name = "pdz";
            // 
            // phs
            // 
            this.phs.HeaderText = "Piston Hareket Sayısı";
            this.phs.Name = "phs";
            // 
            // buttonPanelTestGeri
            // 
            this.buttonPanelTestGeri.Location = new System.Drawing.Point(37, 563);
            this.buttonPanelTestGeri.Name = "buttonPanelTestGeri";
            this.buttonPanelTestGeri.Size = new System.Drawing.Size(73, 45);
            this.buttonPanelTestGeri.TabIndex = 1;
            this.buttonPanelTestGeri.Text = "Geri";
            this.buttonPanelTestGeri.UseVisualStyleBackColor = true;
            this.buttonPanelTestGeri.Click += new System.EventHandler(this.buttonPanelTestGeri_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 643);
            this.Controls.Add(this.panelTestler);
            this.Controls.Add(this.panelPortlar);
            this.Controls.Add(this.panelMainMenu);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelPortlar.ResumeLayout(false);
            this.panelPortlar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPorts)).EndInit();
            this.panelTestler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button buttonPortlar;
        private System.Windows.Forms.Button buttonAktifTestler;
        private System.Windows.Forms.Panel panelPortlar;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.DataGridView dataGridViewPorts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPortEkle;
        private System.Windows.Forms.Button buttonYenile;
        private System.Windows.Forms.DataGridViewTextBoxColumn portName;
        private System.Windows.Forms.DataGridViewTextBoxColumn boudRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn parityBit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBits;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopBits;
        private System.Windows.Forms.ComboBox comboBoxBoudRate;
        private System.Windows.Forms.Label labelBaglıPortlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPanelPortlarGeri;
        private System.Windows.Forms.Panel panelTestler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdz;
        private System.Windows.Forms.DataGridViewTextBoxColumn phs;
        private System.Windows.Forms.Button buttonPanelTestGeri;
    }
}


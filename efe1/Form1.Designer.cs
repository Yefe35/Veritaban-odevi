namespace efe1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriEmail = new System.Windows.Forms.TextBox();
            this.txtMusteriTel = new System.Windows.Forms.TextBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.txtCalisanAd = new System.Windows.Forms.TextBox();
            this.txtCalisanSoyad = new System.Windows.Forms.TextBox();
            this.txtCalisanPozisyon = new System.Windows.Forms.TextBox();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSatisCalisan = new System.Windows.Forms.ComboBox();
            this.cmbSatisMusteri = new System.Windows.Forms.ComboBox();
            this.btnUrunSat = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.nudSatisAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSatisSil = new System.Windows.Forms.Button();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatisAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKategoriAdi.Location = new System.Drawing.Point(493, 24);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKategoriAdi.TabIndex = 0;
            this.txtKategoriAdi.Text = "KategoriAdi";
            this.txtKategoriAdi.TextChanged += new System.EventHandler(this.txtKategoriAdi_TextChanged);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(493, 50);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(100, 23);
            this.btnKategoriEkle.TabIndex = 1;
            this.btnKategoriEkle.Text = "KategoriEkle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKategoriler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKategoriler.EnableHeadersVisualStyles = false;
            this.dgvKategoriler.Location = new System.Drawing.Point(392, 132);
            this.dgvKategoriler.Name = "dgvKategoriler";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKategoriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKategoriler.Size = new System.Drawing.Size(325, 414);
            this.dgvKategoriler.TabIndex = 2;
            this.dgvKategoriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvKategoriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoriler_CellDoubleClick);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUrunAdi.Location = new System.Drawing.Point(6, 22);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 3;
            this.txtUrunAdi.Text = "UrunAdi";
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            this.txtUrunAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrunAdi_KeyDown);
            // 
            // nudFiyat
            // 
            this.nudFiyat.BackColor = System.Drawing.SystemColors.Menu;
            this.nudFiyat.Location = new System.Drawing.Point(70, 118);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 4;
            this.nudFiyat.ValueChanged += new System.EventHandler(this.nudFiyat_ValueChanged);
            this.nudFiyat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudFiyat_KeyDown);
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(483, 92);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 5;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            this.cmbKategori.Click += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            this.cmbKategori.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbKategori_KeyDown);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(6, 71);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 6;
            this.btnUrunEkle.Text = "UrunEkle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // dgvUrunler
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            this.dgvUrunler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUrunler.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUrunler.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUrunler.EnableHeadersVisualStyles = false;
            this.dgvUrunler.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvUrunler.Location = new System.Drawing.Point(13, 174);
            this.dgvUrunler.Name = "dgvUrunler";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUrunler.Size = new System.Drawing.Size(759, 326);
            this.dgvUrunler.TabIndex = 7;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrunEkle_Click);
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMusteriAd.Location = new System.Drawing.Point(72, 19);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAd.TabIndex = 8;
            this.txtMusteriAd.Text = "MusteriAd";
            this.txtMusteriAd.TextChanged += new System.EventHandler(this.txtMusteriAd_TextChanged);
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMusteriSoyad.Location = new System.Drawing.Point(72, 58);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriSoyad.TabIndex = 9;
            this.txtMusteriSoyad.Text = "MusteriSoyad";
            this.txtMusteriSoyad.TextChanged += new System.EventHandler(this.txtMusteriSoyad_TextChanged);
            // 
            // txtMusteriEmail
            // 
            this.txtMusteriEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMusteriEmail.Location = new System.Drawing.Point(199, 19);
            this.txtMusteriEmail.Name = "txtMusteriEmail";
            this.txtMusteriEmail.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriEmail.TabIndex = 10;
            this.txtMusteriEmail.Text = "MusteriEmail";
            this.txtMusteriEmail.TextChanged += new System.EventHandler(this.txtMusteriEmail_TextChanged);
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMusteriTel.Location = new System.Drawing.Point(199, 58);
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriTel.TabIndex = 11;
            this.txtMusteriTel.Text = "MusteriTel";
            this.txtMusteriTel.TextChanged += new System.EventHandler(this.txtMusteriTel_TextChanged);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(72, 103);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(100, 39);
            this.btnMusteriEkle.TabIndex = 12;
            this.btnMusteriEkle.Text = "MusteriEkle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMusteriler.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMusteriler.EnableHeadersVisualStyles = false;
            this.dgvMusteriler.Location = new System.Drawing.Point(26, 172);
            this.dgvMusteriler.Name = "dgvMusteriler";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMusteriler.Size = new System.Drawing.Size(698, 295);
            this.dgvMusteriler.TabIndex = 13;
            // 
            // txtCalisanAd
            // 
            this.txtCalisanAd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCalisanAd.Location = new System.Drawing.Point(91, 33);
            this.txtCalisanAd.Name = "txtCalisanAd";
            this.txtCalisanAd.Size = new System.Drawing.Size(100, 20);
            this.txtCalisanAd.TabIndex = 14;
            this.txtCalisanAd.Text = "CalisanAd";
            // 
            // txtCalisanSoyad
            // 
            this.txtCalisanSoyad.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCalisanSoyad.Location = new System.Drawing.Point(213, 33);
            this.txtCalisanSoyad.Name = "txtCalisanSoyad";
            this.txtCalisanSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtCalisanSoyad.TabIndex = 15;
            this.txtCalisanSoyad.Text = "CalisanSoyad";
            // 
            // txtCalisanPozisyon
            // 
            this.txtCalisanPozisyon.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCalisanPozisyon.Location = new System.Drawing.Point(91, 79);
            this.txtCalisanPozisyon.Name = "txtCalisanPozisyon";
            this.txtCalisanPozisyon.Size = new System.Drawing.Size(100, 20);
            this.txtCalisanPozisyon.TabIndex = 16;
            this.txtCalisanPozisyon.Text = "CalisanPozisyon";
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(213, 96);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(84, 46);
            this.btnCalisanEkle.TabIndex = 17;
            this.btnCalisanEkle.Text = "CalisanEkle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalisanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalisanlar.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCalisanlar.EnableHeadersVisualStyles = false;
            this.dgvCalisanlar.Location = new System.Drawing.Point(24, 166);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalisanlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCalisanlar.Size = new System.Drawing.Size(919, 371);
            this.dgvCalisanlar.TabIndex = 18;
            this.dgvCalisanlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1146, 615);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtKategoriAdi);
            this.tabPage1.Controls.Add(this.btnKategoriEkle);
            this.tabPage1.Controls.Add(this.cmbKategori);
            this.tabPage1.Controls.Add(this.dgvKategoriler);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1138, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kategoriler";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kategori Seç";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbSatisCalisan);
            this.tabPage2.Controls.Add(this.cmbSatisMusteri);
            this.tabPage2.Controls.Add(this.btnUrunSat);
            this.tabPage2.Controls.Add(this.btnUrunGuncelle);
            this.tabPage2.Controls.Add(this.btnUrunSil);
            this.tabPage2.Controls.Add(this.txtUrunAdi);
            this.tabPage2.Controls.Add(this.btnUrunEkle);
            this.tabPage2.Controls.Add(this.nudFiyat);
            this.tabPage2.Controls.Add(this.dgvUrunler);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1138, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Urun Fiyat";
            // 
            // cmbSatisCalisan
            // 
            this.cmbSatisCalisan.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbSatisCalisan.ForeColor = System.Drawing.Color.Black;
            this.cmbSatisCalisan.FormattingEnabled = true;
            this.cmbSatisCalisan.Location = new System.Drawing.Point(801, 174);
            this.cmbSatisCalisan.Name = "cmbSatisCalisan";
            this.cmbSatisCalisan.Size = new System.Drawing.Size(121, 21);
            this.cmbSatisCalisan.TabIndex = 12;
            this.cmbSatisCalisan.Text = "SatisCalisan";
            // 
            // cmbSatisMusteri
            // 
            this.cmbSatisMusteri.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbSatisMusteri.ForeColor = System.Drawing.Color.Black;
            this.cmbSatisMusteri.FormattingEnabled = true;
            this.cmbSatisMusteri.Location = new System.Drawing.Point(964, 174);
            this.cmbSatisMusteri.Name = "cmbSatisMusteri";
            this.cmbSatisMusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbSatisMusteri.TabIndex = 11;
            this.cmbSatisMusteri.Text = "SatisMusteri";
            // 
            // btnUrunSat
            // 
            this.btnUrunSat.Location = new System.Drawing.Point(266, 111);
            this.btnUrunSat.Name = "btnUrunSat";
            this.btnUrunSat.Size = new System.Drawing.Size(103, 30);
            this.btnUrunSat.TabIndex = 10;
            this.btnUrunSat.Text = "UrunSat";
            this.btnUrunSat.UseVisualStyleBackColor = true;
            this.btnUrunSat.Click += new System.EventHandler(this.btnUrunSat_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(258, 71);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(111, 23);
            this.btnUrunGuncelle.TabIndex = 9;
            this.btnUrunGuncelle.Text = "Urun Guncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(115, 71);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(75, 23);
            this.btnUrunSil.TabIndex = 8;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage3.Controls.Add(this.txtMusteriAd);
            this.tabPage3.Controls.Add(this.txtMusteriEmail);
            this.tabPage3.Controls.Add(this.txtMusteriSoyad);
            this.tabPage3.Controls.Add(this.txtMusteriTel);
            this.tabPage3.Controls.Add(this.btnMusteriEkle);
            this.tabPage3.Controls.Add(this.dgvMusteriler);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1138, 589);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Müşteriler";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage4.Controls.Add(this.txtCalisanAd);
            this.tabPage4.Controls.Add(this.dgvCalisanlar);
            this.tabPage4.Controls.Add(this.txtCalisanSoyad);
            this.tabPage4.Controls.Add(this.btnCalisanEkle);
            this.tabPage4.Controls.Add(this.txtCalisanPozisyon);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1138, 589);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Çalışan";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage5.Controls.Add(this.nudSatisAdet);
            this.tabPage5.Controls.Add(this.btnSatisSil);
            this.tabPage5.Controls.Add(this.dgvSatislar);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1138, 589);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Satıslar";
            // 
            // nudSatisAdet
            // 
            this.nudSatisAdet.BackColor = System.Drawing.SystemColors.Menu;
            this.nudSatisAdet.Location = new System.Drawing.Point(213, 45);
            this.nudSatisAdet.Name = "nudSatisAdet";
            this.nudSatisAdet.Size = new System.Drawing.Size(120, 20);
            this.nudSatisAdet.TabIndex = 2;
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.Location = new System.Drawing.Point(37, 29);
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(150, 49);
            this.btnSatisSil.TabIndex = 1;
            this.btnSatisSil.Text = "SatisSil";
            this.btnSatisSil.UseVisualStyleBackColor = true;
            this.btnSatisSil.Click += new System.EventHandler(this.btnSatisSil_Click);
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSatislar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSatislar.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSatislar.EnableHeadersVisualStyles = false;
            this.dgvSatislar.Location = new System.Drawing.Point(13, 111);
            this.dgvSatislar.Name = "dgvSatislar";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSatislar.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSatislar.Size = new System.Drawing.Size(1115, 445);
            this.dgvSatislar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1139, 610);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSatisAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.DataGridView dgvKategoriler;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriEmail;
        private System.Windows.Forms.TextBox txtMusteriTel;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.TextBox txtCalisanAd;
        private System.Windows.Forms.TextBox txtCalisanSoyad;
        private System.Windows.Forms.TextBox txtCalisanPozisyon;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnSatisSil;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.Button btnUrunSat;
        private System.Windows.Forms.ComboBox cmbSatisCalisan;
        private System.Windows.Forms.ComboBox cmbSatisMusteri;
        private System.Windows.Forms.NumericUpDown nudSatisAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


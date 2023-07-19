namespace PersonelTakipUygulamasi.Forms
{
	partial class FrmAnaMenu
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlAraclar = new System.Windows.Forms.Panel();
			this.lblDurum = new System.Windows.Forms.Label();
			this.cbxDurum = new System.Windows.Forms.ComboBox();
			this.lblUnvan = new System.Windows.Forms.Label();
			this.cbxUnvan = new System.Windows.Forms.ComboBox();
			this.lblDepertman = new System.Windows.Forms.Label();
			this.cbxDepertman = new System.Windows.Forms.ComboBox();
			this.lblDogumTarihi = new System.Windows.Forms.Label();
			this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
			this.tbxPersonelNo = new System.Windows.Forms.TextBox();
			this.lblPersonelNo = new System.Windows.Forms.Label();
			this.tbxTCKimlikNo = new System.Windows.Forms.TextBox();
			this.lblTCKimlikNo = new System.Windows.Forms.Label();
			this.tbxSoyAdi = new System.Windows.Forms.TextBox();
			this.lblSoyAdi = new System.Windows.Forms.Label();
			this.tbxAdi = new System.Windows.Forms.TextBox();
			this.lblAdi = new System.Windows.Forms.Label();
			this.pnlButonlar = new System.Windows.Forms.Panel();
			this.btnTemizle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnBul = new System.Windows.Forms.Button();
			this.btnGetir = new System.Windows.Forms.Button();
			this.btnHepsiniSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.dgwCalisanlar = new System.Windows.Forms.DataGridView();
			this.lblBaslik = new System.Windows.Forms.Label();
			this.pnlAraclar.SuspendLayout();
			this.pnlButonlar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwCalisanlar)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlAraclar
			// 
			this.pnlAraclar.Controls.Add(this.lblDurum);
			this.pnlAraclar.Controls.Add(this.cbxDurum);
			this.pnlAraclar.Controls.Add(this.lblUnvan);
			this.pnlAraclar.Controls.Add(this.cbxUnvan);
			this.pnlAraclar.Controls.Add(this.lblDepertman);
			this.pnlAraclar.Controls.Add(this.cbxDepertman);
			this.pnlAraclar.Controls.Add(this.lblDogumTarihi);
			this.pnlAraclar.Controls.Add(this.dateDogumTarihi);
			this.pnlAraclar.Controls.Add(this.tbxPersonelNo);
			this.pnlAraclar.Controls.Add(this.lblPersonelNo);
			this.pnlAraclar.Controls.Add(this.tbxTCKimlikNo);
			this.pnlAraclar.Controls.Add(this.lblTCKimlikNo);
			this.pnlAraclar.Controls.Add(this.tbxSoyAdi);
			this.pnlAraclar.Controls.Add(this.lblSoyAdi);
			this.pnlAraclar.Controls.Add(this.tbxAdi);
			this.pnlAraclar.Controls.Add(this.lblAdi);
			this.pnlAraclar.ForeColor = System.Drawing.SystemColors.Control;
			this.pnlAraclar.Location = new System.Drawing.Point(16, 123);
			this.pnlAraclar.Name = "pnlAraclar";
			this.pnlAraclar.Size = new System.Drawing.Size(578, 315);
			this.pnlAraclar.TabIndex = 0;
			// 
			// lblDurum
			// 
			this.lblDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblDurum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDurum.ForeColor = System.Drawing.SystemColors.Control;
			this.lblDurum.Location = new System.Drawing.Point(-1, 274);
			this.lblDurum.Name = "lblDurum";
			this.lblDurum.Size = new System.Drawing.Size(213, 31);
			this.lblDurum.TabIndex = 15;
			this.lblDurum.Text = "DURUM";
			this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbxDurum
			// 
			this.cbxDurum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxDurum.FormattingEnabled = true;
			this.cbxDurum.Items.AddRange(new object[] {
            "Aktif Çalışan",
            "Sözleşmesi Askıda",
            "Ücretsiz İzinli",
            "İşten Çıkarılma",
            "İstafa "});
			this.cbxDurum.Location = new System.Drawing.Point(215, 274);
			this.cbxDurum.Name = "cbxDurum";
			this.cbxDurum.Size = new System.Drawing.Size(363, 31);
			this.cbxDurum.TabIndex = 14;
			this.cbxDurum.Tag = "Durumu";
			// 
			// lblUnvan
			// 
			this.lblUnvan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblUnvan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUnvan.ForeColor = System.Drawing.SystemColors.Control;
			this.lblUnvan.Location = new System.Drawing.Point(-1, 237);
			this.lblUnvan.Name = "lblUnvan";
			this.lblUnvan.Size = new System.Drawing.Size(213, 31);
			this.lblUnvan.TabIndex = 13;
			this.lblUnvan.Text = "ÜNVAN";
			this.lblUnvan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbxUnvan
			// 
			this.cbxUnvan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxUnvan.FormattingEnabled = true;
			this.cbxUnvan.Items.AddRange(new object[] {
            "Kurul Başkanı",
            "Kurul Üyesi",
            "Departman Müdürü",
            "Departman Şefi",
            "Departman Çalışanı",
            "Yardımcı Hizmetler"});
			this.cbxUnvan.Location = new System.Drawing.Point(215, 237);
			this.cbxUnvan.Name = "cbxUnvan";
			this.cbxUnvan.Size = new System.Drawing.Size(363, 31);
			this.cbxUnvan.TabIndex = 12;
			this.cbxUnvan.Tag = "Unvan";
			// 
			// lblDepertman
			// 
			this.lblDepertman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblDepertman.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDepertman.ForeColor = System.Drawing.SystemColors.Control;
			this.lblDepertman.Location = new System.Drawing.Point(-1, 200);
			this.lblDepertman.Name = "lblDepertman";
			this.lblDepertman.Size = new System.Drawing.Size(213, 31);
			this.lblDepertman.TabIndex = 11;
			this.lblDepertman.Text = "DEPARTMAN";
			this.lblDepertman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbxDepertman
			// 
			this.cbxDepertman.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxDepertman.FormattingEnabled = true;
			this.cbxDepertman.Items.AddRange(new object[] {
            "Yönetim",
            "İdari İşler",
            "Muhasabe",
            "Satın Alma",
            "Pazarlama",
            "Yazılım",
            "Tasarım",
            "Destek Hizmetleri"});
			this.cbxDepertman.Location = new System.Drawing.Point(215, 200);
			this.cbxDepertman.Name = "cbxDepertman";
			this.cbxDepertman.Size = new System.Drawing.Size(363, 31);
			this.cbxDepertman.TabIndex = 10;
			this.cbxDepertman.Tag = "Departman";
			// 
			// lblDogumTarihi
			// 
			this.lblDogumTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblDogumTarihi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDogumTarihi.ForeColor = System.Drawing.SystemColors.Control;
			this.lblDogumTarihi.Location = new System.Drawing.Point(-1, 163);
			this.lblDogumTarihi.Name = "lblDogumTarihi";
			this.lblDogumTarihi.Size = new System.Drawing.Size(213, 31);
			this.lblDogumTarihi.TabIndex = 9;
			this.lblDogumTarihi.Text = "DOGUM TARİHİ";
			this.lblDogumTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateDogumTarihi
			// 
			this.dateDogumTarihi.Cursor = System.Windows.Forms.Cursors.Default;
			this.dateDogumTarihi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dateDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateDogumTarihi.Location = new System.Drawing.Point(215, 163);
			this.dateDogumTarihi.Name = "dateDogumTarihi";
			this.dateDogumTarihi.Size = new System.Drawing.Size(363, 31);
			this.dateDogumTarihi.TabIndex = 8;
			this.dateDogumTarihi.Tag = "DogumTarihi";
			this.dateDogumTarihi.ValueChanged += new System.EventHandler(this.dateDogumTarihi_ValueChanged);
			// 
			// tbxPersonelNo
			// 
			this.tbxPersonelNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tbxPersonelNo.Location = new System.Drawing.Point(215, 126);
			this.tbxPersonelNo.Name = "tbxPersonelNo";
			this.tbxPersonelNo.Size = new System.Drawing.Size(363, 31);
			this.tbxPersonelNo.TabIndex = 7;
			this.tbxPersonelNo.Tag = "PersonelNo";
			// 
			// lblPersonelNo
			// 
			this.lblPersonelNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblPersonelNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblPersonelNo.ForeColor = System.Drawing.SystemColors.Control;
			this.lblPersonelNo.Location = new System.Drawing.Point(-1, 126);
			this.lblPersonelNo.Name = "lblPersonelNo";
			this.lblPersonelNo.Size = new System.Drawing.Size(213, 31);
			this.lblPersonelNo.TabIndex = 6;
			this.lblPersonelNo.Text = "PERSONEL NO";
			this.lblPersonelNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbxTCKimlikNo
			// 
			this.tbxTCKimlikNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tbxTCKimlikNo.Location = new System.Drawing.Point(215, 86);
			this.tbxTCKimlikNo.Name = "tbxTCKimlikNo";
			this.tbxTCKimlikNo.Size = new System.Drawing.Size(363, 31);
			this.tbxTCKimlikNo.TabIndex = 5;
			this.tbxTCKimlikNo.Tag = "TCKimlikNo";
			// 
			// lblTCKimlikNo
			// 
			this.lblTCKimlikNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblTCKimlikNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTCKimlikNo.ForeColor = System.Drawing.SystemColors.Control;
			this.lblTCKimlikNo.Location = new System.Drawing.Point(-1, 86);
			this.lblTCKimlikNo.Name = "lblTCKimlikNo";
			this.lblTCKimlikNo.Size = new System.Drawing.Size(213, 31);
			this.lblTCKimlikNo.TabIndex = 4;
			this.lblTCKimlikNo.Text = " TC KİMLİK NO";
			this.lblTCKimlikNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbxSoyAdi
			// 
			this.tbxSoyAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tbxSoyAdi.Location = new System.Drawing.Point(215, 43);
			this.tbxSoyAdi.Name = "tbxSoyAdi";
			this.tbxSoyAdi.Size = new System.Drawing.Size(363, 31);
			this.tbxSoyAdi.TabIndex = 3;
			this.tbxSoyAdi.Tag = "SoyAdi";
			// 
			// lblSoyAdi
			// 
			this.lblSoyAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblSoyAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSoyAdi.ForeColor = System.Drawing.SystemColors.Control;
			this.lblSoyAdi.Location = new System.Drawing.Point(-1, 43);
			this.lblSoyAdi.Name = "lblSoyAdi";
			this.lblSoyAdi.Size = new System.Drawing.Size(213, 31);
			this.lblSoyAdi.TabIndex = 2;
			this.lblSoyAdi.Text = "SOYADI";
			this.lblSoyAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbxAdi
			// 
			this.tbxAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tbxAdi.Location = new System.Drawing.Point(215, 3);
			this.tbxAdi.Name = "tbxAdi";
			this.tbxAdi.Size = new System.Drawing.Size(363, 31);
			this.tbxAdi.TabIndex = 1;
			this.tbxAdi.Tag = "Adi";
			// 
			// lblAdi
			// 
			this.lblAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAdi.ForeColor = System.Drawing.SystemColors.Control;
			this.lblAdi.Location = new System.Drawing.Point(-1, 3);
			this.lblAdi.Name = "lblAdi";
			this.lblAdi.Size = new System.Drawing.Size(213, 31);
			this.lblAdi.TabIndex = 0;
			this.lblAdi.Text = "ADI";
			this.lblAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlButonlar
			// 
			this.pnlButonlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlButonlar.Controls.Add(this.btnTemizle);
			this.pnlButonlar.Controls.Add(this.btnSil);
			this.pnlButonlar.Controls.Add(this.btnBul);
			this.pnlButonlar.Controls.Add(this.btnGetir);
			this.pnlButonlar.Controls.Add(this.btnHepsiniSil);
			this.pnlButonlar.Controls.Add(this.btnGuncelle);
			this.pnlButonlar.Controls.Add(this.btnKaydet);
			this.pnlButonlar.Location = new System.Drawing.Point(12, 444);
			this.pnlButonlar.Name = "pnlButonlar";
			this.pnlButonlar.Size = new System.Drawing.Size(583, 264);
			this.pnlButonlar.TabIndex = 1;
			// 
			// btnTemizle
			// 
			this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnTemizle.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnTemizle.ForeColor = System.Drawing.SystemColors.Control;
			this.btnTemizle.Location = new System.Drawing.Point(196, 90);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(192, 81);
			this.btnTemizle.TabIndex = 7;
			this.btnTemizle.Text = "TEMİZLE";
			this.btnTemizle.UseVisualStyleBackColor = false;
			this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnSil.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.ForeColor = System.Drawing.SystemColors.Control;
			this.btnSil.Location = new System.Drawing.Point(0, 90);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(192, 81);
			this.btnSil.TabIndex = 6;
			this.btnSil.Text = "SECİLİ KAYDI SİL";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnBul
			// 
			this.btnBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnBul.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBul.ForeColor = System.Drawing.SystemColors.Control;
			this.btnBul.Location = new System.Drawing.Point(295, 177);
			this.btnBul.Name = "btnBul";
			this.btnBul.Size = new System.Drawing.Size(288, 81);
			this.btnBul.TabIndex = 5;
			this.btnBul.Text = "BUL";
			this.btnBul.UseVisualStyleBackColor = false;
			this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
			// 
			// btnGetir
			// 
			this.btnGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnGetir.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGetir.ForeColor = System.Drawing.SystemColors.Control;
			this.btnGetir.Location = new System.Drawing.Point(-1, 177);
			this.btnGetir.Name = "btnGetir";
			this.btnGetir.Size = new System.Drawing.Size(288, 81);
			this.btnGetir.TabIndex = 4;
			this.btnGetir.Text = "GETİR";
			this.btnGetir.UseVisualStyleBackColor = false;
			this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
			// 
			// btnHepsiniSil
			// 
			this.btnHepsiniSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnHepsiniSil.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnHepsiniSil.ForeColor = System.Drawing.SystemColors.Control;
			this.btnHepsiniSil.Location = new System.Drawing.Point(391, 90);
			this.btnHepsiniSil.Name = "btnHepsiniSil";
			this.btnHepsiniSil.Size = new System.Drawing.Size(192, 81);
			this.btnHepsiniSil.TabIndex = 3;
			this.btnHepsiniSil.Text = "HEPSİNİ SİL";
			this.btnHepsiniSil.UseVisualStyleBackColor = false;
			this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnGuncelle.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.ForeColor = System.Drawing.SystemColors.Control;
			this.btnGuncelle.Location = new System.Drawing.Point(295, 3);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(288, 81);
			this.btnGuncelle.TabIndex = 1;
			this.btnGuncelle.Text = "GUNCELLE";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnKaydet.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
			this.btnKaydet.Location = new System.Drawing.Point(0, 3);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(288, 81);
			this.btnKaydet.TabIndex = 0;
			this.btnKaydet.Text = "KAYDET";
			this.btnKaydet.UseVisualStyleBackColor = false;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// dgwCalisanlar
			// 
			this.dgwCalisanlar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.dgwCalisanlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgwCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwCalisanlar.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dgwCalisanlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwCalisanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgwCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgwCalisanlar.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgwCalisanlar.EnableHeadersVisualStyles = false;
			this.dgwCalisanlar.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dgwCalisanlar.Location = new System.Drawing.Point(610, 123);
			this.dgwCalisanlar.Name = "dgwCalisanlar";
			this.dgwCalisanlar.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgwCalisanlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgwCalisanlar.RowHeadersWidth = 51;
			this.dgwCalisanlar.RowTemplate.Height = 24;
			this.dgwCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwCalisanlar.Size = new System.Drawing.Size(915, 579);
			this.dgwCalisanlar.TabIndex = 2;
			this.dgwCalisanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCalisanlar_CellClick);
			// 
			// lblBaslik
			// 
			this.lblBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBaslik.BackColor = System.Drawing.Color.DimGray;
			this.lblBaslik.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBaslik.ForeColor = System.Drawing.Color.Black;
			this.lblBaslik.Location = new System.Drawing.Point(12, 9);
			this.lblBaslik.Name = "lblBaslik";
			this.lblBaslik.Size = new System.Drawing.Size(1513, 91);
			this.lblBaslik.TabIndex = 3;
			this.lblBaslik.Text = "PERSONEL TAKİP UYGULAMASI";
			this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmAnaMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1560, 720);
			this.Controls.Add(this.lblBaslik);
			this.Controls.Add(this.dgwCalisanlar);
			this.Controls.Add(this.pnlButonlar);
			this.Controls.Add(this.pnlAraclar);
			this.Name = "FrmAnaMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Personel Takip Uygulaması";
			this.Load += new System.EventHandler(this.FrmAnaMenu_Load);
			this.pnlAraclar.ResumeLayout(false);
			this.pnlAraclar.PerformLayout();
			this.pnlButonlar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgwCalisanlar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlAraclar;
		private System.Windows.Forms.Label lblAdi;
		private System.Windows.Forms.DateTimePicker dateDogumTarihi;
		private System.Windows.Forms.TextBox tbxPersonelNo;
		private System.Windows.Forms.Label lblPersonelNo;
		private System.Windows.Forms.TextBox tbxTCKimlikNo;
		private System.Windows.Forms.Label lblTCKimlikNo;
		private System.Windows.Forms.TextBox tbxSoyAdi;
		private System.Windows.Forms.Label lblSoyAdi;
		private System.Windows.Forms.TextBox tbxAdi;
		private System.Windows.Forms.Label lblDurum;
		private System.Windows.Forms.ComboBox cbxDurum;
		private System.Windows.Forms.Label lblUnvan;
		private System.Windows.Forms.ComboBox cbxUnvan;
		private System.Windows.Forms.Label lblDepertman;
		private System.Windows.Forms.ComboBox cbxDepertman;
		private System.Windows.Forms.Label lblDogumTarihi;
		private System.Windows.Forms.Panel pnlButonlar;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnTemizle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnBul;
		private System.Windows.Forms.Button btnGetir;
		private System.Windows.Forms.Button btnHepsiniSil;
		private System.Windows.Forms.DataGridView dgwCalisanlar;
		private System.Windows.Forms.Label lblBaslik;
	}
}
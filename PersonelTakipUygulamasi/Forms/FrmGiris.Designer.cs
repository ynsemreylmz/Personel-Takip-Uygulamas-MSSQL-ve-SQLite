namespace PersonelTakipUygulamasi.Forms
{
	partial class FrmGiris
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblGiris = new System.Windows.Forms.Label();
			this.rdbtnSqlite = new System.Windows.Forms.RadioButton();
			this.rdbtnSqlServer = new System.Windows.Forms.RadioButton();
			this.btnGiris = new System.Windows.Forms.Button();
			this.btnCikis = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.Controls.Add(this.btnCikis);
			this.panel1.Controls.Add(this.btnGiris);
			this.panel1.Controls.Add(this.rdbtnSqlServer);
			this.panel1.Controls.Add(this.rdbtnSqlite);
			this.panel1.Controls.Add(this.lblGiris);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(508, 371);
			this.panel1.TabIndex = 0;
			// 
			// lblGiris
			// 
			this.lblGiris.BackColor = System.Drawing.SystemColors.ControlText;
			this.lblGiris.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGiris.ForeColor = System.Drawing.SystemColors.Control;
			this.lblGiris.Location = new System.Drawing.Point(43, 10);
			this.lblGiris.Name = "lblGiris";
			this.lblGiris.Size = new System.Drawing.Size(409, 116);
			this.lblGiris.TabIndex = 0;
			this.lblGiris.Text = "PERSONEL TAKİP UYGULAMASI";
			this.lblGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rdbtnSqlite
			// 
			this.rdbtnSqlite.AutoSize = true;
			this.rdbtnSqlite.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdbtnSqlite.Location = new System.Drawing.Point(49, 141);
			this.rdbtnSqlite.Name = "rdbtnSqlite";
			this.rdbtnSqlite.Size = new System.Drawing.Size(125, 40);
			this.rdbtnSqlite.TabIndex = 1;
			this.rdbtnSqlite.TabStop = true;
			this.rdbtnSqlite.Text = "SQLite";
			this.rdbtnSqlite.UseVisualStyleBackColor = true;
			this.rdbtnSqlite.CheckedChanged += new System.EventHandler(this.rdbtnSqlite_CheckedChanged);
			// 
			// rdbtnSqlServer
			// 
			this.rdbtnSqlServer.AutoSize = true;
			this.rdbtnSqlServer.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdbtnSqlServer.Location = new System.Drawing.Point(284, 141);
			this.rdbtnSqlServer.Name = "rdbtnSqlServer";
			this.rdbtnSqlServer.Size = new System.Drawing.Size(168, 40);
			this.rdbtnSqlServer.TabIndex = 2;
			this.rdbtnSqlServer.TabStop = true;
			this.rdbtnSqlServer.Text = "SqlServer";
			this.rdbtnSqlServer.UseVisualStyleBackColor = true;
			this.rdbtnSqlServer.CheckedChanged += new System.EventHandler(this.rdbtnSqlServer_CheckedChanged);
			// 
			// btnGiris
			// 
			this.btnGiris.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGiris.Location = new System.Drawing.Point(49, 209);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(403, 67);
			this.btnGiris.TabIndex = 3;
			this.btnGiris.Text = "GİRİŞ YAP";
			this.btnGiris.UseVisualStyleBackColor = true;
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// btnCikis
			// 
			this.btnCikis.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCikis.Location = new System.Drawing.Point(49, 282);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(403, 69);
			this.btnCikis.TabIndex = 4;
			this.btnCikis.Text = "ÇIKIŞ YAP";
			this.btnCikis.UseVisualStyleBackColor = true;
			this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
			// 
			// FrmGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(532, 395);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmGiris";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblGiris;
		private System.Windows.Forms.Button btnCikis;
		private System.Windows.Forms.Button btnGiris;
		private System.Windows.Forms.RadioButton rdbtnSqlServer;
		private System.Windows.Forms.RadioButton rdbtnSqlite;
	}
}
namespace EczaneOtomasyonu
{
	partial class FrmHastaKaydı
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNo = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbGuvence = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(51, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "HastaNo(T.C)";
			// 
			// txtNo
			// 
			this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtNo.Location = new System.Drawing.Point(312, 36);
			this.txtNo.Mask = "00000000000";
			this.txtNo.Name = "txtNo";
			this.txtNo.Size = new System.Drawing.Size(217, 35);
			this.txtNo.TabIndex = 1;
			this.txtNo.ValidatingType = typeof(int);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(51, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ad-Soyad";
			// 
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAd.Location = new System.Drawing.Point(311, 85);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(217, 35);
			this.txtAd.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(51, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Adres";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(51, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 29);
			this.label4.TabIndex = 5;
			this.label4.Text = "Telefon";
			// 
			// txtAdres
			// 
			this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdres.Location = new System.Drawing.Point(311, 129);
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(217, 35);
			this.txtAdres.TabIndex = 6;
			// 
			// txtTel
			// 
			this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTel.Location = new System.Drawing.Point(311, 177);
			this.txtTel.Mask = "(999) 000-0000";
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(217, 35);
			this.txtTel.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(51, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 29);
			this.label5.TabIndex = 8;
			this.label5.Text = "Güvence";
			// 
			// cbGuvence
			// 
			this.cbGuvence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbGuvence.FormattingEnabled = true;
			this.cbGuvence.Location = new System.Drawing.Point(312, 220);
			this.cbGuvence.Name = "cbGuvence";
			this.cbGuvence.Size = new System.Drawing.Size(217, 37);
			this.cbGuvence.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(312, 276);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(216, 53);
			this.button1.TabIndex = 10;
			this.button1.Text = "Kaydet";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmHastaKaydı
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1113, 550);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cbGuvence);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNo);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmHastaKaydı";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HASTA KAYIT İŞLEMİ";
			this.Load += new System.EventHandler(this.FrmHastaKaydı_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox txtNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.MaskedTextBox txtTel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbGuvence;
		private System.Windows.Forms.Button button1;
	}
}
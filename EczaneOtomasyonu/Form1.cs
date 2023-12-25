using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace EczaneOtomasyonu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		OleDbConnection con = new OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=EczaneDb.accdb");
		void listele()
		{
			OleDbCommand komut = new OleDbCommand("Select * from satislar", con);
			OleDbDataAdapter da = new OleDbDataAdapter(komut);
			DataTable tablo = new DataTable();
			da.Fill(tablo);
			dataGridView1.DataSource = tablo;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtTcNo.Text == "" || txtBarkodNo.Text == "")
			{
				MessageBox.Show("Lütfe tüm alanları eksiksiz giriniz", "Eksik Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else
			{
				bool sonuc1 = false;
				bool sonuc2 = false;
				int toplamFiyat = 0, fiyat = 0;

				OleDbCommand komut1 = new OleDbCommand("select*from Hastalar where TcNo=@p1", con);
				con.Open();
				komut1.Parameters.AddWithValue("@p1", txtTcNo.Text);
				OleDbDataReader dr = komut1.ExecuteReader();
				if (dr.Read())
				{
					sonuc1 = true;
				}
				con.Close();

				OleDbCommand komut2 = new OleDbCommand("select*from Ilaclar where barkodNo=@p1", con);
				con.Open();
				komut2.Parameters.AddWithValue("@p1", txtBarkodNo.Text);

				OleDbDataReader dr2 = komut2.ExecuteReader();
				if (dr2.Read())
				{
					fiyat = int.Parse(dr2["fiyat"].ToString());
					sonuc2 = true;
				}
				con.Close();

				if (!sonuc1)
					MessageBox.Show("Lütfen önce hasta kaydını yapınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else if (!sonuc2)
					MessageBox.Show("Lütfen önce ilaç kaydını yapınız", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					OleDbCommand komut = new OleDbCommand("insert into satislar(hastaNo,ilacNo, adet,toplamFiyat,tarih,durum) values (@p1,@p2,@p3,@p4,@p5,@p6)", con);

					con.Open();
					toplamFiyat = fiyat *int.Parse(numAdet.Value.ToString());
					komut.Parameters.AddWithValue("@p1", txtTcNo.Text);
					komut.Parameters.AddWithValue("@p2", txtBarkodNo.Text);
					komut.Parameters.AddWithValue("@p3", numAdet.Value);
					komut.Parameters.AddWithValue("@p4", toplamFiyat);
					komut.Parameters.AddWithValue("@p5", DateTime.Today);
					komut.Parameters.AddWithValue("@p6", true);

					int sonuc = komut.ExecuteNonQuery();

					if (sonuc > 0)
					{
						MessageBox.Show("Toplam Fiyat: " + toplamFiyat);
						MessageBox.Show("Satış Yapıldı", "Satış");
					}
					else
					{
						MessageBox.Show("Satış işleminde hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}

					con.Close();
				}
				listele();

			}
		}

		private void hastaKaydıToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmHastaKaydı fr = new FrmHastaKaydı();
			fr.Show();

		}
	}
}
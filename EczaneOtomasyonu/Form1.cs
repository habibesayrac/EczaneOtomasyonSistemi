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
		void listele()
		{
			OleDbConnection connection = new OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=EczaneDb.accdb");
			OleDbCommand komut = new OleDbCommand("Select * from satislar",connection);
			OleDbDataAdapter da = new OleDbDataAdapter(komut);
			DataTable tablo = new DataTable();
			da.Fill(tablo);
			dataGridView1.DataSource= tablo;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listele();
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonu
{
    public partial class FrmIlacSil : Form
    {
        public FrmIlacSil()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=EczaneDb.accdb");
        public void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Ilaclar where durum = true", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void FrmIlacSil_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtNumara.Text == "")
            {
                MessageBox.Show("Aradığınız ilacın barkod numarasını giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("select * from Ilaclar where durum = true and barkodNo=@p1", con);
                komut.Parameters.AddWithValue("@p1", int.Parse(txtNumara.Text));
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                con.Open();
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                con.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtNumara.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz ilacın barkod numarasını giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("update Ilaclar set durum=false where durum = true and barkodNo=@p1", con);
                komut.Parameters.AddWithValue("@p1", int.Parse(txtNumara.Text));
                con.Open();
                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show(txtNumara.Text + " numaralı kayıt başarıyla silindi");
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace efe1
{
    public partial class Form1 : Form
    {
        string connStr = "server=localhost;user=root;database=efebilgisayar;port=3306;password=Fghfgh55";
        int seciliUrunID = -1;
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        // --- Kategori ---
        void KategorileriListele()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Kategoriler";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKategoriler.DataSource = dt;
            }
        }

        void KategorileriComboBoxaDoldur()
        {
            cmbKategori.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Kategoriler";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbKategori.Items.Add(new ComboBoxItem
                        {
                            Text = dr["kategori_adi"].ToString(),
                            Value = dr["kategori_id"]
                        });
                    }
                }
            }
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text.Trim() == "")
            {
                MessageBox.Show("Kategori adı gir!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO Kategoriler (kategori_adi) VALUES (@ad)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", txtKategoriAdi.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kategori eklendi!");
                KategorileriListele();
                KategorileriComboBoxaDoldur();
                txtKategoriAdi.Clear();
            }
        }

        private void dgvKategoriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int kategoriID = Convert.ToInt32(dgvKategoriler.Rows[e.RowIndex].Cells["kategori_id"].Value);
                DialogResult dr = MessageBox.Show("Bu kategoriyi silmek istediğine emin misin?", "Sil", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "DELETE FROM Kategoriler WHERE kategori_id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", kategoriID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kategori silindi!");
                        KategorileriListele();
                        KategorileriComboBoxaDoldur();
                    }
                }
            }
        }

        // --- Ürün ---
        void UrunleriListele()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = @"SELECT u.urun_id, u.urun_adi, u.fiyat, k.kategori_adi 
                               FROM Urunler u
                               LEFT JOIN Kategoriler k ON u.kategori_id = k.kategori_id";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUrunler.DataSource = dt;
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text.Trim() == "" || cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm alanları doldur!");
                return;
            }
            var seciliKategori = (ComboBoxItem)cmbKategori.SelectedItem;
            int kategoriID = Convert.ToInt32(seciliKategori.Value);

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO Urunler (urun_adi, fiyat, kategori_id) VALUES (@adi, @fiyat, @kat)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@adi", txtUrunAdi.Text);
                cmd.Parameters.AddWithValue("@fiyat", nudFiyat.Value);
                cmd.Parameters.AddWithValue("@kat", kategoriID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ürün eklendi!");
                UrunleriListele();
                txtUrunAdi.Clear();
                nudFiyat.Value = 0;
            }

        }

        private void dgvUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int urunID = Convert.ToInt32(dgvUrunler.Rows[e.RowIndex].Cells["urun_id"].Value);

                DialogResult dr = MessageBox.Show("Bu ürünü silmek istediğine emin misin?", "Sil", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "DELETE FROM Urunler WHERE urun_id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", urunID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ürün silindi!");
                        UrunleriListele();
                    }
                }
            }
            if (e.RowIndex >= 0)
            {
                seciliUrunID = Convert.ToInt32(dgvUrunler.Rows[e.RowIndex].Cells["urun_id"].Value);
                txtUrunAdi.Text = dgvUrunler.Rows[e.RowIndex].Cells["urun_adi"].Value.ToString();
                nudFiyat.Value = Convert.ToDecimal(dgvUrunler.Rows[e.RowIndex].Cells["fiyat"].Value);

                string kategoriAdi = dgvUrunler.Rows[e.RowIndex].Cells["kategori_adi"].Value.ToString();
                foreach (ComboBoxItem item in cmbKategori.Items)
                {
                    if (item.Text == kategoriAdi)
                    {
                        cmbKategori.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        // --- Müşteri ---
        void MusterileriListele()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Musteriler";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMusteriler.DataSource = dt;
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (txtMusteriAd.Text.Trim() == "" || txtMusteriSoyad.Text.Trim() == "" ||
                txtMusteriEmail.Text.Trim() == "" || txtMusteriTel.Text.Trim() == "")
            {
                MessageBox.Show("Tüm müşteri alanlarını doldurun!");
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "CALL musteri_ekle(@ad, @soyad, @email, @tel)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ad", txtMusteriAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtMusteriSoyad.Text);
                    cmd.Parameters.AddWithValue("@email", txtMusteriEmail.Text);
                    cmd.Parameters.AddWithValue("@tel", txtMusteriTel.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri eklendi!");
                    MusterileriListele();
                    txtMusteriAd.Clear();
                    txtMusteriSoyad.Clear();
                    txtMusteriEmail.Clear();
                    txtMusteriTel.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            // Seçili satır yoksa uyar!
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin!");
                return;
            }

            // Seçili satırdan urun_id çek
            int urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["urun_id"].Value);

            // Onay iste
            DialogResult dr = MessageBox.Show("Bu ürünü silmek istediğine emin misin?", "Sil", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM Urunler WHERE urun_id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", urunID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün silindi!");
                    UrunleriListele(); // Listeyi güncelle
                }
            }
        }



        // --- Çalışan ---
        void CalisanlariListele()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Calisanlar";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCalisanlar.DataSource = dt;
            }
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            if (txtCalisanAd.Text.Trim() == "" || txtCalisanSoyad.Text.Trim() == "" || txtCalisanPozisyon.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                // BURADA ARTIK PROSEDÜRÜ ÇAĞIRIYORUZ!
                string sql = "CALL calisan_ekle(@ad, @soyad, @pozisyon)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", txtCalisanAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtCalisanSoyad.Text);
                cmd.Parameters.AddWithValue("@pozisyon", txtCalisanPozisyon.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Çalışan eklendi!");
                CalisanlariListele();
                txtCalisanAd.Clear();
                txtCalisanSoyad.Clear();
                txtCalisanPozisyon.Clear();
            }
        }


        private void dgvCalisanlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int calisanID = Convert.ToInt32(dgvCalisanlar.Rows[e.RowIndex].Cells["calisan_id"].Value);

                DialogResult dr = MessageBox.Show("Bu çalışanı silmek istediğine emin misin?", "Sil", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "DELETE FROM Calisanlar WHERE calisan_id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", calisanID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Çalışan silindi!");
                        CalisanlariListele();
                    }
                }
            }
        }
        void SatislariListele()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = @"
            SELECT 
                s.satis_id, 
                u.urun_adi, 
                u.fiyat, 
                k.kategori_adi,
                m.ad AS musteri_ad, 
                m.soyad AS musteri_soyad,
                c.ad AS calisan_ad, 
                c.soyad AS calisan_soyad,
                s.adet, 
                s.tarih
            FROM Satislar s
            LEFT JOIN Urunler u ON s.urun_id = u.urun_id
            LEFT JOIN Kategoriler k ON u.kategori_id = k.kategori_id
            LEFT JOIN Musteriler m ON s.musteri_id = m.musteri_id
            LEFT JOIN Calisanlar c ON s.calisan_id = c.calisan_id
        ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSatislar.DataSource = dt;
            }
        }


        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            if (dgvSatislar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir satış seçin!");
                return;
            }

            int satisID = Convert.ToInt32(dgvSatislar.SelectedRows[0].Cells["satis_id"].Value);
            DialogResult dr = MessageBox.Show("Satışı silmek istediğine emin misin?", "Sil", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM Satislar WHERE satis_id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", satisID);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Satış silindi!");
                SatislariListele();
            }
        }
        void MusterileriComboBoxaDoldur()
        {
            cmbSatisMusteri.Items.Clear();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT musteri_id, ad, soyad FROM Musteriler", conn);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbSatisMusteri.Items.Add(new ComboBoxItem
                        {
                            Text = dr["ad"] + " " + dr["soyad"],
                            Value = dr["musteri_id"]
                        });
                    }
                }
            }
        }

        void CalisanlariComboBoxaDoldur()
        {
            cmbSatisCalisan.Items.Clear();
            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT calisan_id, ad, soyad FROM Calisanlar", conn);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmbSatisCalisan.Items.Add(new ComboBoxItem
                        {
                            Text = dr["ad"] + " " + dr["soyad"],
                            Value = dr["calisan_id"]
                        });
                    }
                }
            }
        }
        private void btnUrunSat_Click(object sender, EventArgs e)
        {
            // Ürün seçili mi kontrol
            if (dgvUrunler.SelectedRows.Count == 0 || cmbSatisMusteri.SelectedIndex == -1 || cmbSatisCalisan.SelectedIndex == -1)
            {
                MessageBox.Show("Ürün, müşteri ve çalışan seçin!");
                return;
            }

            int urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["urun_id"].Value);
            int musteriID = Convert.ToInt32(((ComboBoxItem)cmbSatisMusteri.SelectedItem).Value);
            int calisanID = Convert.ToInt32(((ComboBoxItem)cmbSatisCalisan.SelectedItem).Value);
            int adet = (int)nudSatisAdet.Value;
            DateTime tarih = DateTime.Now;

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "INSERT INTO Satislar (musteri_id, urun_id, calisan_id, adet, tarih) VALUES (@musteri, @urun, @calisan, @adet, @tarih)", conn);
                cmd.Parameters.AddWithValue("@musteri", musteriID);
                cmd.Parameters.AddWithValue("@urun", urunID);
                cmd.Parameters.AddWithValue("@calisan", calisanID);
                cmd.Parameters.AddWithValue("@adet", adet);
                cmd.Parameters.AddWithValue("@tarih", tarih);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Satış kaydedildi!");
            SatislariListele(); // Satışlar tablosunu yenile
        }





        // --- Form Load ---
        private void Form1_Load(object sender, EventArgs e)
        {
            CalisanlariListele();
            MusterileriListele();
            KategorileriListele();
            KategorileriComboBoxaDoldur();
            UrunleriListele();
            SatislariListele();
            MusterileriComboBoxaDoldur();   // Satış müşteri combobox doldur
            CalisanlariComboBoxaDoldur();   // Satış çalışan combobox doldur

        }

        // Diğer otomatik olaylar için boş methodlar (tasarım tarafında gerekirse):
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e) { }
        private void nudFiyat_ValueChanged(object sender, EventArgs e) { }
        private void txtKategoriAdi_TextChanged(object sender, EventArgs e) { }
        private void txtMusteriAd_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Şimdilik boş
        }

        private void UrunEkle_Click(object sender, EventArgs e)
        {
            // Şimdilik boş
        }

        private void dgvCalisanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusteriSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            // Boş bırakabilirsin, işin yoksa.
        }

        private void txtUrunAdi_KeyDown(object sender, KeyEventArgs e)
        {
            // Boş bırakabilirsin veya ileride kullanırsın.
        }


        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliUrunID == -1)
            {
                MessageBox.Show("Güncellemek için önce tablodan bir ürün seçmelisin!");
                return;
            }

            string yeniAd = txtUrunAdi.Text.Trim();
            decimal yeniFiyat = nudFiyat.Value;
            var seciliKategori = (ComboBoxItem)cmbKategori.SelectedItem;
            int yeniKategoriID = Convert.ToInt32(seciliKategori.Value);

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "UPDATE Urunler SET urun_adi=@ad, fiyat=@fiyat, kategori_id=@kat WHERE urun_id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", yeniAd);
                cmd.Parameters.AddWithValue("@fiyat", yeniFiyat);
                cmd.Parameters.AddWithValue("@kat", yeniKategoriID);
                cmd.Parameters.AddWithValue("@id", seciliUrunID);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Ürün güncellendi!");
            UrunleriListele();
            KategorileriComboBoxaDoldur();
        }



        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                seciliUrunID = Convert.ToInt32(dgvUrunler.Rows[e.RowIndex].Cells["urun_id"].Value);
                txtUrunAdi.Text = dgvUrunler.Rows[e.RowIndex].Cells["urun_adi"].Value.ToString();
                nudFiyat.Value = Convert.ToDecimal(dgvUrunler.Rows[e.RowIndex].Cells["fiyat"].Value);

                string kategoriAdi = dgvUrunler.Rows[e.RowIndex].Cells["kategori_adi"].Value.ToString();
                foreach (var item in cmbKategori.Items)
                {
                    if (((ComboBoxItem)item).Text == kategoriAdi)
                    {
                        cmbKategori.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Enabled = true;
            nudFiyat.Enabled = true;
            cmbKategori.Enabled = true;
            btnUrunGuncelle.Enabled = true; // Güncelle butonunu da aktif et
        }

        private void nudFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUrunGuncelle.PerformClick();
            }
        }

        private void cmbKategori_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FaylMeneceri
{
    public partial class Form1 : Form
    {
        private string cariQovluq = "";

        public Form1()
        {
            InitializeComponent();
            lblMelumat.Text = "Fayl seçilməyib";
            lblStatus.Text = "Hazırdır";
        }

        private void btnQovluq_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    cariQovluq = dlg.SelectedPath;
                    txtYol.Text = cariQovluq;
                    FayllariYenile();
                }
            }
        }

        private void FayllariYenile()
        {
            lstFayllar.Items.Clear();
            txtMetn.Clear();
            lblMelumat.Text = "Fayl seçilməyib";

            if (Directory.Exists(cariQovluq))
            {
                string[] fayllar = Directory.GetFiles(cariQovluq, "*.txt");
                foreach (string fayl in fayllar)
                {
                    lstFayllar.Items.Add(Path.GetFileName(fayl));
                }
            }

            lblStatus.Text = "Fayl sayı: " + lstFayllar.Items.Count;
        }

        private void lstFayllar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem == null) return;

            string faylAdi = lstFayllar.SelectedItem.ToString();
            string tamYol = Path.Combine(cariQovluq, faylAdi);

            if (File.Exists(tamYol))
            {
                FileInfo info = new FileInfo(tamYol);
                lblMelumat.Text = "Ad: " + info.Name + " | Ölçü: " + (info.Length / 1024) + " KB";
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem == null)
            {
                MessageBox.Show("Fayl seçin!");
                return;
            }

            string tamYol = Path.Combine(cariQovluq, lstFayllar.SelectedItem.ToString());
            if (File.Exists(tamYol))
            {
                txtMetn.Text = File.ReadAllText(tamYol);
                lblStatus.Text = "Fayl açıldı";
            }
        }

        private void btnSaxla_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem == null)
            {
                MessageBox.Show("Fayl seçin!");
                return;
            }

            string tamYol = Path.Combine(cariQovluq, lstFayllar.SelectedItem.ToString());
            File.WriteAllText(tamYol, txtMetn.Text);
            lblStatus.Text = "Yadda saxlanıldı";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstFayllar.SelectedItem == null)
            {
                MessageBox.Show("Fayl seçin!");
                return;
            }

            string tamYol = Path.Combine(cariQovluq, lstFayllar.SelectedItem.ToString());
            if (File.Exists(tamYol))
            {
                File.Delete(tamYol);
                FayllariYenile();
                lblStatus.Text = "Fayl silindi";
            }
        }
    }
}
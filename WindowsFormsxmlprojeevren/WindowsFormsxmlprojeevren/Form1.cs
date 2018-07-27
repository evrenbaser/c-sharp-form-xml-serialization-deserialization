using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsxmlprojeevren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string Path = Application.StartupPath + @"\data.xml";
        private MyXmlSerializer Serializer = new MyXmlSerializer();
        private List<TodoItem> Gorevlerim = new List<TodoItem>();

        private void ListeleriDoldur()
        {

            this.lstTamamlananlarListesi.Items.Clear();
            this.clbYapilacaklarListesi.Items.Clear();

            foreach ( TodoItem gorev in Gorevlerim)
            {
                

                if (gorev.Tamamlandi==false)
                {
                    this.clbYapilacaklarListesi.Items.Add(gorev);
                }
                else
                {
                    this.lstTamamlananlarListesi.Items.Add(gorev);
                }

            }
        }
          private void YapilacaklarListesiKaydet()
        {
            Serializer.Serialize<List<TodoItem>>(Path, this.Gorevlerim);
        }
        private void YapilacaklarListesiOku()
        {
            this.Gorevlerim = Serializer.Deserialize<List<TodoItem>>(Path);
        }

        private void yeniToolStripButton_Click(object sender, EventArgs e)
        {
            TodoItem yenigorev = new TodoItem()
            {
                Id = Guid.NewGuid(),
                GorevMetni = textBox1.Text,
                Tamamlandi = false
            };
            this.Gorevlerim.Add(yenigorev);
            this.ListeleriDoldur();
            this.YapilacaklarListesiKaydet();
            // this.clbYapilacaklarListesi.Items.Add(yenigorev);
            this.notifyIcon1.BalloonTipText = "yeni görev oluşturuldu.";
            this.notifyIcon1.ShowBalloonTip(2000);
        }
        private void duzeltToolStripButton_Click(object sender, EventArgs e)
        {

            if (clbYapilacaklarListesi.SelectedIndex==-1)
            {
                MessageBox.Show("düzeltme işlemi için bir görev seç");
              return;
            }

            TodoItem gorev = (TodoItem)clbYapilacaklarListesi.SelectedItem;
            gorev.GorevMetni = textBox1.Text;
            this.ListeleriDoldur();
            this.YapilacaklarListesiKaydet();
        }

        private void silToolStripButton_Click(object sender, EventArgs e)// sil
        {
            if (clbYapilacaklarListesi.SelectedIndex==-1)
            {
                MessageBox.Show("lütfen silme işlemi için bir görev seçiniz");
              return;
            }

          //  clbYapilacaklarListesi.Items.Remove(clbYapilacaklarListesi.SelectedItem);
            this.Gorevlerim.Remove((TodoItem)clbYapilacaklarListesi.SelectedItem);
            this.ListeleriDoldur();
            this.YapilacaklarListesiKaydet();
        }

        private void clbYapilacaklarListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (clbYapilacaklarListesi.SelectedIndex==-1)
              return;
            

            TodoItem gorev = (TodoItem)clbYapilacaklarListesi.SelectedItem;
            textBox1.Text = gorev.GorevMetni;

        }

        private void kesToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void kopyalaToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void yapistirToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void clbYapilacaklarListesi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue== CheckState.Checked)
            {
                TodoItem gorev = (TodoItem)clbYapilacaklarListesi.SelectedItem;
                gorev.Tamamlandi = true;
                gorev.TamamlanmaTarihi = DateTime.Now;

                this.YapilacaklarListesiKaydet();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            if (System.IO.File.Exists(Path))
            {
                this.YapilacaklarListesiOku();
            }
            this.ListeleriDoldur();
        }

        private void clbYapilacaklarListesi_MouseUp(object sender, MouseEventArgs e)
        {
            if(clbYapilacaklarListesi.CheckedItems.Count>0)
            {
                this.ListeleriDoldur();
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uygulamaHakkımdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hakkımda sayfasına geçsin ... 
            About about = new About();
            about.ShowDialog();
        }
    }
}

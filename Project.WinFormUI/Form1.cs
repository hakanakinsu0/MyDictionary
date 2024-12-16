using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinFormUI
{
    public partial class Form1 : Form
    {
        CategoryRepository _cr;
        TermRepository _tr;
        Category _secilenCategory;
        Term _secilenTerm;

        public Form1()
        {
            InitializeComponent();
            _cr = new CategoryRepository();
            _tr = new TermRepository();
        }

        private void BtnKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriEkle();
            KategorileriGetirVeKontrolleriTemizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategorileriGetirVeKontrolleriTemizle();
        }

        private void LstKategoriler_Click(object sender, EventArgs e)
        {
            if (LstKategoriler.SelectedItem != null)
            {
                _secilenCategory = LstKategoriler.SelectedItem as Category;
                TxtKategori.Text = _secilenCategory.Name;
                LstKavramlar.DataSource = _tr.Where(x => x.CategoryId == _secilenCategory.Id);//&& x.Status != DataStatus.Deleted
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            KategoriGuncelle();
        }
        private void BtnKategoriSil_Click(object sender, EventArgs e)
        {
            KategoriyiSil();

        }

        private void BtnKategoriYokEt_Click(object sender, EventArgs e)
        {
            KategoriYokEt();
        }


        #region Category-TasarimsalMetotlar

        private void KategoriYokEt()
        {
            if (LstKategoriler.SelectedItem != null || _secilenCategory.Status == DataStatus.Deleted)
            {
                _secilenCategory.Name = TxtKategori.Text;
                _cr.Destroy(_secilenCategory);
                KategorileriGetirVeKontrolleriTemizle();
                MessageBox.Show("Kategori yok edildi.");
            }
            else KategoriSecilmemeUyarisiVer();
        }
        private void KategoriyiSil()
        {
            if (LstKategoriler.SelectedItem != null)
            {
                _cr.Delete(_secilenCategory);
                KategorileriGetirVeKontrolleriTemizle();
                MessageBox.Show("Kategori Silinmistir");
            }
            else KategoriSecilmemeUyarisiVer();
        }

        private void KategorileriGetirVeKontrolleriTemizle()
        {
            LstKategoriler.DataSource = _cr.GetAll();
            LstKategoriler.SelectedIndex = -1;
            TxtKategori.Text = "";

        }

        private void KategoriGuncelle()
        {
            if (LstKategoriler.SelectedItem != null)
            {
                _secilenCategory.Name = TxtKategori.Text;
                _cr.Update(_secilenCategory);
                KategorileriGetirVeKontrolleriTemizle();
                MessageBox.Show("Kategori Guncellendi");
            }
            else KategoriSecilmemeUyarisiVer();
        }

        private static void KategoriSecilmemeUyarisiVer()
        {
            MessageBox.Show("Once Kategori Seciniz.");
        }

        private void KategoriEkle()
        {
            if (TxtKategori.Text == null) MessageBox.Show("Kategori girmediniz.");
            _cr.Add(new Category
            {
                Name = TxtKategori.Text
            });
            MessageBox.Show("Kategori eklendi.");
        }
        #endregion



        private void BtnKavramEkle_Click(object sender, EventArgs e)
        {
            KavramEkle();

        }

        private void LstKavramlar_Click(object sender, EventArgs e)
        {
            if (LstKavramlar.SelectedItem != null)
            {
                _secilenTerm = LstKavramlar.SelectedItem as Term;
                TxtKavram.Text = _secilenTerm.Name;
                TxtKavramAciklama.Text = _secilenTerm.Description;

            }
        }
        private void BtnKavramGuncelle_Click(object sender, EventArgs e)
        {
            KavramGuncelle();
        }

        private void BtnKavramSil_Click(object sender, EventArgs e)
        {
            KavramiSil();
        }

        private void BtnKavramYokEt_Click(object sender, EventArgs e)
        {
            KavramYokEt();
        }


        #region Term-KavramsalMetotlar

        private void KavramlariGetirVeKontrolleriTemizle()
        {
            if (_secilenCategory != null)
            {
                LstKavramlar.DataSource = _tr.Where(x => x.CategoryId == _secilenCategory.Id); //&& x.Status != DataStatus.Deleted

            }
            else
            {
                LstKavramlar.DataSource = null;
            }

            LstKavramlar.SelectedIndex = -1;
            TxtKavramAciklama.Text = "";
            TxtKavram.Text = "";
        }


        private void KavramEkle()
        {
            if (LstKategoriler.SelectedItem == null)
            {
                KategoriSecilmemeUyarisiVer();
                return;
            }

            if (TxtKavram.Text == null || TxtKavramAciklama.Text == null)
            {
                MessageBox.Show("Kavram adi ve aciklamasi bos olamaz");
                return;
            }


            _tr.Add(new Term
            {
                Name = TxtKavram.Text,
                Description = TxtKavramAciklama.Text,
                CategoryId = _secilenCategory.Id
            });

            MessageBox.Show($"{_secilenCategory.Name} kategorisine {TxtKavram.Text} kavrami eklendi.");
            KavramlariGetirVeKontrolleriTemizle();
        }

        private void KavramGuncelle()
        {
            if (LstKavramlar.SelectedItem != null)
            {
                _secilenTerm.Name = TxtKavram.Text;
                _secilenTerm.Description = TxtKavramAciklama.Text;
                _tr.Update(_secilenTerm);
                KavramlariGetirVeKontrolleriTemizle();
                MessageBox.Show($"{_secilenTerm.Name} kavrami guncellenmistir.");

            }
            else MessageBox.Show("Once Kavram Seciniz.");
        }

        private void KavramiSil()
        {
            if (LstKavramlar.SelectedItem != null)
            {
                _tr.Delete(_secilenTerm);
                KavramlariGetirVeKontrolleriTemizle();
                MessageBox.Show("Kavram silinmistir.");

            }
            else MessageBox.Show("Once kavram seciniz.");
        }

        private void KavramYokEt()
        {
            if (LstKavramlar.SelectedItem != null || _secilenTerm.Status == DataStatus.Deleted)
            {
                _secilenTerm.Name = TxtKavram.Text;
                _secilenTerm.Description = TxtKavramAciklama.Text;
                _tr.Destroy(_secilenTerm);
                KavramlariGetirVeKontrolleriTemizle();
                MessageBox.Show("Kavram yok edildi.");
            }
            else MessageBox.Show("Once kavram seciniz");
        }

        #endregion

        private void BtnTumunuGetir_Click(object sender, EventArgs e)
        {
            if (LstKategoriler.SelectedItem != null)
            {
                // Seçili kategoriyi al
                _secilenCategory = LstKategoriler.SelectedItem as Category;

                // Form2'yi aç ve kategori ID'sini gönder
                Form2 form2 = new Form2(_secilenCategory.Id);
                form2.ShowDialog();
            }
            else MessageBox.Show("Once kategori seciniz.");
        }

        private void BtnButunKavramlar_Click(object sender, EventArgs e)
        {
            // Form2'yi kategori bağımsız olarak aç
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}

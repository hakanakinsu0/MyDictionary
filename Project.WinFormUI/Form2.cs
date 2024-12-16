using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
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
    public partial class Form2 : Form
    {
        TermRepository _tr;
        int? _categoryId;

        public Form2()
        {
            InitializeComponent();
            _tr = new TermRepository();
            _categoryId = null; // Tüm kavramları yüklemek için

        }
        public Form2(int categoryId)
        {
            InitializeComponent();
            _tr = new TermRepository();
            _categoryId = categoryId;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (_categoryId.HasValue)
            {
                LoadTermsByCategory(_categoryId.Value);
            }
            else
            {
                LoadAllTerms();
            }
        }

        private void LoadTermsByCategory(int categoryId)
        {
            // Seçili kategoriye ait kavramları getir. DataGridView'e bağla
            DgvKavramlar.DataSource = _tr.Where(x => x.CategoryId == categoryId).Select(x => new
            {
                Kategori = x.Category.Name,
                Kavram = x.Name,
                Açıklama = x.Description,
                Durum = x.Status.ToString()
            }).ToList();
        }

        private void LoadAllTerms()
        {
            // Tüm kavramları getir ve DataGridView'e bağla
            List<Term> allTerms = _tr.Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted).ToList();

            DgvKavramlar.DataSource = allTerms.Select(x => new
            {
                Kategori = x.Category.Name,
                Kavram = x.Name,
                Açıklama = x.Description,
                Durum = x.Status.ToString()
            }).ToList();
        }
    }
}

using DLWMS.Data;
using DLWMS.Data.IB200165;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200165
{
    public partial class frmPretragaIB200165 : Form
    {
        private Student student;
        DLWMSDbContext db = KonekcijaNaBazuIB200165.db;
        List <dtoStudentIB200165> studenti = new List<dtoStudentIB200165> ();   
        public frmPretragaIB200165()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            UcitajSpolove();
        }

        private void UcitajSpolove()
        {
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
            cmbSpol.DataSource = db.Spolovi.ToList();
            cmbSpol.SelectedIndex = -1;
        }
        private void UcitajPodatke()
        {
           var spol =cmbSpol.SelectedItem as Spol;
            var dtmOd = dtpOd.Value;
            var dtmDo = dtpDo.Value;
            var lista = db.Studenti.Include(x => x.Spol).Where(x => x.Spol.Id == spol.Id &&
            (x.DatumRodjenja >= dtmOd && x.DatumRodjenja <= dtmDo)).ToList();
            dgvStudenti.DataSource = null;
            if(lista.Count == 0)
            {
                MessageBox.Show($"U bazi nema studenata koji su sljedeceg spola: "+
                    $"{spol.Naziv} i da su rodjeni u periodu od {dtmOd.ToShortDateString()} do {dtmDo.ToShortDateString()}");
            }
            else
            {
                studenti.Clear();
                foreach (var std in lista)
                    studenti.Add(new dtoStudentIB200165() { Student = std });
                dgvStudenti.DataSource = studenti;
                
            }
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ValidniPodaci())
                UcitajPodatke();
        }

        private bool ValidniPodaci()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbSpol, err, Kljucevi.ObaveznaVrijednost);
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            if(ValidniPodaci())
                UcitajPodatke();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            if(ValidniPodaci())
                UcitajPodatke();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {
                var std = dgvStudenti.SelectedRows[0].DataBoundItem as dtoStudentIB200165;
                var frm = new frmUvjerenjaIB200165(std.Student);
                frm.ShowDialog();
            }
            else
            {
                var std = dgvStudenti.SelectedRows[0].DataBoundItem as dtoStudentIB200165;
                var frm = new frmSlikaIB200165(std);
                frm.ShowDialog();

            }



        }
    }
}

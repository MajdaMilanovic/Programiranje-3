using DLWMS.Data;
using DLWMS.Data.IB200165;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNovoUvjerenjeIB200165 : Form
    {
        private Student student;
        DLWMSDbContext db = KonekcijaNaBazuIB200165.db;

        public frmNovoUvjerenjeIB200165(Student student)
        {
            InitializeComponent();
            Text = "Dodaj novo uvjerenje";
            this.student = student;
            UcitajVrste();
        }

        private void UcitajVrste()
        {
            List<string> vrste = new List<string>();
            vrste.Add("Uvjerenje o statusu studenta");
            vrste.Add("Uvjerenje o polozenim ispitima");
            vrste.Add("Uvjerenje o prosjeku ocjena");
            cmbVrsta.DataSource = vrste;
        }

        private void pbUplatnica_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var rd = new OpenFileDialog();
            if(rd.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(rd.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(podaciValidni())
            {
                var vrsta = cmbVrsta.SelectedItem.ToString();
                var svrha = txtSvrha.Text;
                var slika = ImageHelper.FromImageToByte(pbUplatnica.Image);

                var novo = new StudentiUvjerenjaIB200165()
                {
                    Student=student,
                    Svrha=svrha,
                    Vrsta=vrsta,
                    Uplatnica=slika,
                    Printano=false,
                    Datum=DateTime.Now
                };
                db.StudentiUvjerenja.Add(novo);
                db.SaveChanges();
                MessageBox.Show("Uspjesno dodano uvjerenje");
            }
        }

        private bool podaciValidni()
        {
            return Validator.ValidirajKontrolu(cmbVrsta, errorProvider1, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtSvrha, errorProvider1, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(pbUplatnica, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }
    }
}

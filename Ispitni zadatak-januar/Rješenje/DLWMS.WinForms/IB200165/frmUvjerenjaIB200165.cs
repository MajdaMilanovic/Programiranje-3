using DLWMS.Data;
using DLWMS.Data.IB200165;
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
    public partial class frmUvjerenjaIB200165 : Form
    {
     
        private Student student;
        DLWMSDbContext db = KonekcijaNaBazuIB200165.db;
        List<StudentiUvjerenjaIB200165> uvjerenja = new List<StudentiUvjerenjaIB200165>();


        public frmUvjerenjaIB200165(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvUvjerenja.AutoGenerateColumns = false;
            UcitajVrste();
            UcitajUvjerenja();
        }

        private void UcitajUvjerenja()
        {
            uvjerenja.Clear();
            uvjerenja = db.StudentiUvjerenja.Include(x => x.Student).Where(x => x.Student.Id == student.Id).ToList();
            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource = uvjerenja;
            Text = $"Broj uvjerenja -> {uvjerenja.Count}";

            //btnDodaj2.Enabled = uvjerenja.Count() == 0 ? false : true;
        }

        private void UcitajVrste()
        {
            List<string> vrste = new List<string>();
            vrste.Add("Uvjerenje o statusu studenta");
            vrste.Add("Uvjerenje o polozenim ispitima");
            vrste.Add("Uvjerenje o prosjeku ocjena");
            cmbVrsta.DataSource = vrste;
        }

        private void frmUvjerenjaIB200165_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var frm = new frmNovoUvjerenjeIB200165(student);
            frm.ShowDialog();
            UcitajUvjerenja();
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==5)
            {
                var uvj = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB200165;

                var rd = MessageBox.Show("Zelite li obrisati odabrano uvjerenje?", "Info", MessageBoxButtons.YesNo);
                if(rd==DialogResult.Yes)
                {
                    db.StudentiUvjerenja.Remove(uvj);
                    db.SaveChanges();
                    UcitajUvjerenja();
                }
            }
            else if(e.ColumnIndex==6)
            {
                var uvj = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB200165;
                var frm = new frmIzvjestajIB200165(uvj);
                frm.ShowDialog();

                uvj.Printano = true;

                db.SaveChanges();
                UcitajUvjerenja();
            }
        }

        private void btnDodaj2_Click(object sender, EventArgs e)
        {
            int brojUvjerenja;
            try
            {
                brojUvjerenja = int.Parse(txtBroj.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Nije unesen broj zahtjeva!!!");
                return;
            }
            txtInfo.ScrollBars = ScrollBars.Vertical;
            var vrsta = cmbVrsta.SelectedItem.ToString();
            var svrha = txtSvrha.Text;
            var slika = db.StudentiUvjerenja.First().Uplatnica;

            var thread = new Thread(() => DodajUvjerenja(brojUvjerenja, vrsta, svrha, slika));
            thread.Start();
        }

        private void DodajUvjerenja(int brojUvjerenja, string vrsta, string svrha, byte[] slika)
        {
            for (int i = 0; i < brojUvjerenja; i++)
            {
                var novo = new StudentiUvjerenjaIB200165()
                {
                    Student = student,
                    Svrha = svrha,
                    Vrsta = vrsta,
                    Uplatnica = slika,
                    Printano = false,
                    Datum = DateTime.Now
                };
            db.StudentiUvjerenja.Add(novo);
            db.SaveChanges();
                Action ac = () =>
                {
                    txtInfo.Text += $"{novo.Datum.ToLongTimeString()} -> {novo.Vrsta} ({novo.Student.BrojIndeksa})" +
                    $" - {novo.Student.Ime} {novo.Student.Prezime} u svrhu {novo.Svrha}" + Environment.NewLine;
                    SetCursor();
                };
                BeginInvoke(ac);
                Thread.Sleep(300);
            }
            MessageBox.Show($"Studentu {student.Ime} {student.Prezime} ({student.BrojIndeksa})" +
                $"uspjesno dodato {brojUvjerenja} uvjerenja");
            BeginInvoke(UcitajUvjerenja);
        }

        private void SetCursor()
        {
            txtInfo.SelectionStart = txtInfo.Text.Length;
            txtInfo.ScrollToCaret();
        }
    }
}

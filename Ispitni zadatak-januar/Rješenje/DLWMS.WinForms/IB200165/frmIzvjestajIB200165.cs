using DLWMS.Data.IB200165;
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
    public partial class frmIzvjestajIB200165 : Form
    {
        private StudentiUvjerenjaIB200165 uvj;

 

        public frmIzvjestajIB200165(StudentiUvjerenjaIB200165 uvj)
        {
            InitializeComponent();
            this.uvj = uvj;
        }
    }
}

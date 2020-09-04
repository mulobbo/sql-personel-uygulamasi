using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personelkayıt
{
    public partial class frmraporlar : Form
    {
        public frmraporlar()
        {
            InitializeComponent();
        }

        private void frmraporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PersonelveritabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.Tbl_PersonelTableAdapter.Fill(this.PersonelveritabaniDataSet.Tbl_Personel);

            this.reportViewer1.RefreshReport();
        }
    }
}

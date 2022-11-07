using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateFlooringCosts
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void stripCarpeting_Click(object sender, EventArgs e)
        {
            Form newFormCarpet = new frmCarpeting();
            newFormCarpet.MdiParent = this;
            newFormCarpet.Show();
        }

        private void stripHardwood_Click(object sender, EventArgs e)
        {
            Form newFormHardwood = new frmHardwood();
            newFormHardwood.MdiParent = this;
            newFormHardwood.Show();
        }

        private void stripClose_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            if (activeForm != null)
                activeForm.Close();
        }

        private void stripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stripCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void stripVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void stripHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void stripButtonCarpeting_Click(object sender, EventArgs e)
        {
            Form newForm = new frmCarpeting();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void stripButtonHardwood_Click(object sender, EventArgs e)
        {
            Form newForm = new frmHardwood();
            newForm.MdiParent = this;
            newForm.Show();
        }
    }
}

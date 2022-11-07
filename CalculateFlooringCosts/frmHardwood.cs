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
    public partial class frmHardwood : Form
    {
        public frmHardwood()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal area = Convert.ToDecimal(txtArea.Text);
            decimal hardwoodUnitCost = Convert.ToDecimal(txtCost.Text);
            decimal hardwoodCost = area * hardwoodUnitCost;
            decimal installationCost = 0m;
            if (rdoStandard.Checked)
                installationCost = area * 2.99m;
            else
                installationCost = area * 1.99m;
            decimal totalCost = hardwoodCost + installationCost;

            txtHardwood.Text = hardwoodCost.ToString("c2");
            txtInstallation.Text = installationCost.ToString("c2");
            txtTotal.Text = totalCost.ToString("c2");

            txtArea.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

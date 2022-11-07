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
    public partial class frmCarpeting : Form
    {
        public frmCarpeting()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal area = Convert.ToDecimal(txtArea.Text);
            decimal carpetingUnitCost = Convert.ToDecimal(txtCost.Text);
            decimal carpetingCost = area * carpetingUnitCost;
            decimal paddingCost = 0m;
            if (chkPadding.Checked)
                paddingCost = area * .39m;
            decimal installationCost = area * .99m;
            decimal totalCost = carpetingCost + paddingCost + installationCost;

            txtCarpeting.Text = carpetingCost.ToString("c2");
            txtPadding.Text = paddingCost.ToString("c2");
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

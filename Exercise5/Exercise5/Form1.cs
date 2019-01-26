using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class ApproximatePiForm : Form
    {
        public ApproximatePiForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int intTerms;

            if (int.TryParse(txtTerms.Text, out intTerms))
            {
                int index = 0;
                double x = 4;
                double y = 1;
                double approx;
                double newpi = 0.0;

                while (++index < intTerms - 1)
                {
                    approx = x / y;
                    newpi = newpi + approx;
                    y = y + 2;
                    x = (x > 0) ? -4.0 : 4.0;
                }

                txtPI.Text = Convert.ToString(newpi);
                this.label2.Text = "Approximate value of pi after " + txtTerms.Text + " terms";
            }

            else
            {
                MessageBox.Show("Please Enter Valid Integer", "Input Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                txtTerms.Text = "";
                this.ActiveControl = txtTerms;
            }
        }

        private void ApproximatePiForm_Load(object sender, EventArgs e)
        {

        }
    }
}

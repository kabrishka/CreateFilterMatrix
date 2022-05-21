using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KC_20_Gimalova_lab8.Forms
{
    public partial class Matrix : Form
    {
        public Matrix()
        {
            InitializeComponent();
        }

        private void trackRows_Scroll(object sender, EventArgs e)
        {
            try
            {
                lblN.Text = trackRows.Value.ToString();
                DataBank.valueRows = Convert.ToInt32(trackRows.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackColumns_Scroll(object sender, EventArgs e)
        {
            try
            {
                lblM.Text = trackColumns.Value.ToString();
                DataBank.valueCols = Convert.ToInt32(trackColumns.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void numericK_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataBank.k = Convert.ToDouble(numericK.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

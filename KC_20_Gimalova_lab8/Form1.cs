using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KC_20_Gimalova_lab8
{
    public partial class Form1 : Form
    {
        //поля
        private Button currentButton;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Matrix(), sender);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Filters(), sender);
        }

        //Создаем метод, открывающий форму в container panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        
    }
}

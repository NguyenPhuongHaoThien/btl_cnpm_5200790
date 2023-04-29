using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonCNPM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Form1 fLogin = new Form1();
            if (fLogin.ShowDialog(this) == DialogResult.OK)
            {
                // User logged in successfully
                // Show the main form
                this.Show();
            }
        }

        private Form activeChildForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeChildForm != null) { 
                activeChildForm.Close();
            }
            activeChildForm = childForm;
            if(activeChildForm != null)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildFormAdd.Controls.Add(childForm);
                panelChildFormAdd.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void tạoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddOrder fOrder = new FormAddOrder();
            openChildForm(fOrder);
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(null);
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddItem fItem = new FormAddItem();
            openChildForm(fItem);
        }

        private void thêmAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddAgent fAgent = new FormAddAgent();
            openChildForm(fAgent);
        }
    }
}

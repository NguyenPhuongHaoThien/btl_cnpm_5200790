using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonCNPM
{
    public partial class FormAddAgent : Form
    {
        public FormAddAgent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAgentName.Text) || string.IsNullOrEmpty(txtAgentAddress.Text))
            {
                MessageBox.Show("Please fullfill all information ");

            }
            else
            {
                SqlConnection conn = new SqlConnection(Program.GetCon());
                conn.Open();
                SqlCommand cmd = new SqlCommand("[CreateAgent]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@AgentName", txtAgentName.Text));
                cmd.Parameters.Add(new SqlParameter("@Address", txtAgentAddress.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshInput_Click(object sender, EventArgs e)
        {
            txtAgentName.Text = string.Empty;
            txtAgentAddress.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAgentAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAgentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

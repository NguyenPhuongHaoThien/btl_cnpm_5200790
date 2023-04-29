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
    public partial class FormAddItem : Form
    {
        public FormAddItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(txtItemSize.Text)) {
                MessageBox.Show("Please fullfill all information ");

            }
            else
            {
                SqlConnection conn = new SqlConnection(Program.GetCon());
                conn.Open();
                SqlCommand cmd = new SqlCommand("[CreateItem]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ItemName", txtItemName.Text));
                cmd.Parameters.Add(new SqlParameter("@Size", txtItemSize.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btnRefreshInput_Click(object sender, EventArgs e)
        {
            txtItemName.Text = string.Empty;
            txtItemSize.Text = string.Empty;
        }
    }
}

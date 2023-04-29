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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please full fill username or password");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Program.GetCon());
                //conn.ConnectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=LabDB;Integrated Security=True";
                conn.Open();
                String sSQL = "SELECT username, password FROM [user] WHERE " +
                "username='" + txtUserID.Text + "' and password='" +
                txtPassword.Text + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful!");
                    this.Close();
/*                    MainForm main = new MainForm();
                    main.ShowDialog();*/
                }
                else
                {
                    MessageBox.Show("Invalid Login. Please check userID or Password!");
                }
            }
        }
    }
}

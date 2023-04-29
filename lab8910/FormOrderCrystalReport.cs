using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTapLonCNPM
{
    public partial class FormOrderCrystalReport : Form
    {
        public int orderID = 0;
        public FormOrderCrystalReport(int OrderID)
        {
            InitializeComponent();
            orderID = OrderID;
        }

        private void FormOrderCrystalReport_Load(object sender, EventArgs e)
        {
            MessageBox.Show(orderID.ToString());
            try
            {
                SqlConnection conn = new SqlConnection(Program.GetCon());
                conn.Open();
                SqlCommand cmd = new SqlCommand("[PrintOrderTable]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataReport = new DataSet();
                da.Fill(dataReport, "OrderReport");
                if (dataReport == null)
                {
                    MessageBox.Show("EMpty");
                }
                else
                {
                    MessageBox.Show("Not Empty");
                }
                //Add data to cryreport
                OrderCrystalReport Order_Detail_Report = new OrderCrystalReport();
                Order_Detail_Report.SetDataSource(dataReport);

                //Add crypreport to viewer
                crystalReportOrderViewer.ReportSource = Order_Detail_Report;
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

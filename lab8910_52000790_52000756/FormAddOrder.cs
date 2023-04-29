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
    public partial class FormAddOrder : Form
    {
        int currentAgentID = 0;
        int currentPrice = 0;
        int currentQuantity = 0;
        int currentItemID = 0;
        int currentOrderID = 0;
        int createdOrder = 0;
        DateTime currentOrderDate = DateTime.Now;
        DataTable orderDetailTable = new DataTable();
        public FormAddOrder()
        {
            InitializeComponent();

            //Init columns for currentOrderTable
            orderDetailTable.Columns.Add("OrderID", typeof(int));
            orderDetailTable.Columns.Add("ItemID", typeof(int));
            orderDetailTable.Columns.Add("UnitAmount", typeof(int));
            orderDetailTable.Columns.Add("Quantity", typeof(int));


        }
        private void FormAddOrder_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(Program.GetCon());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetAllItems]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();

            if(dt.Rows.Count > 0)
            {
                comboBoxItems.DisplayMember = "ItemName";
                comboBoxItems.ValueMember = "ItemID";
                comboBoxItems.DataSource= dt;
                comboBoxItems.SelectedIndex = -1;
            }
        }

        private void btnGetIdAgent_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.GetCon());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetAgentID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AgentName", txtAgentName.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            da.Dispose();

            if (dt.Rows.Count > 0)
            {
                DataRow firstRow = dt.Rows[0];
                object firstColumnValue = firstRow.ItemArray[0];
                int ID = (int)firstRow["AgentID"];
                labelAgentID.Text = ID.ToString();
                currentAgentID = ID;
            }
            else
            {
                labelAgentID.Text = "Not Found Agent";
            }
        }

        private void dateOrder_ValueChanged(object sender, EventArgs e)
        {
            currentOrderDate= dateOrder.Value;
        }

        private void textPriceItem_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textPriceItem.Text))
                currentPrice = int.Parse(textPriceItem.Text);
        }

        private void txtQuantityItem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantityItem.Text))
                currentQuantity = int.Parse(txtQuantityItem.Text);
        }
        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItems.SelectedIndex != -1)
            {
                currentItemID = int.Parse(comboBoxItems.SelectedValue.ToString());
            }
            else
            {
                currentItemID = 0;
            }
        }

        private void btnAddOrderDetails_Click(object sender, EventArgs e)
        {
            if(currentOrderID == 0)
            {
                currentOrderID = getCurrentOrderID();
            }
            if (currentAgentID == 0 || currentQuantity == 0 || currentPrice == 0 || currentItemID == 0)
            {
                MessageBox.Show("Please FullFill all Information!");
            }
            else
            {   // Add new row for dataTableOrderDetail            
                DataRow newRow = orderDetailTable.NewRow();
                
                newRow["OrderID"] = currentOrderID;
                newRow["ItemID"] = currentItemID;
                newRow["UnitAmount"] = currentPrice;
                newRow["Quantity"] = currentQuantity;
                orderDetailTable.Rows.Add(newRow);
                //Update datagridview
                updateDataGridView(orderDetailTable);
                RefreshInputOrderDetail();
            }
        }

        private int getCurrentOrderID()
        {
            SqlConnection conn = new SqlConnection(Program.GetCon());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[GetCurrentOrderID]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter returnParam = cmd.Parameters.Add("@curOrderID", SqlDbType.Int);
            returnParam.Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();

            int orderId = (int)returnParam.Value;
            if (orderId == null) {
                orderId = 1;
            }
            else
            {
                orderId += 1;
            }
            return orderId ;
        }
        private void updateDataGridView(DataTable dt)
        {
            dataGridViewOrderDetail.DataSource = dt;
            dataGridViewOrderDetail.Refresh();
            dataGridViewOrderDetail.Update();
        }
        private void RefreshInputOrderDetail()
        {
            comboBoxItems.SelectedIndex = -1;
            textPriceItem.Text = string.Empty;
            currentPrice = 0;
            txtQuantityItem.Text = string.Empty;
            currentQuantity= 0;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            createdOrder = currentOrderID;
            createOrder();
            createOderDetail();
            RefreshOrder();
            

        }

        private void createOrder()
        {
            SqlConnection conn = new SqlConnection(Program.GetCon());
            conn.Open();
            SqlCommand cmd = new SqlCommand("[CreateOrder]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OrderDate", currentOrderDate));
            cmd.Parameters.Add(new SqlParameter("@AgentID", currentAgentID));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void createOderDetail()
        {

            SqlConnection conn = new SqlConnection(Program.GetCon());
            conn.Open();

            foreach (DataRow row in orderDetailTable.Rows)
            {
                SqlCommand cmd = new SqlCommand("[CreateOrderDetail]", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@OrderID", row["OrderID"]));
                cmd.Parameters.Add(new SqlParameter("@ItemID", row["ItemID"]));
                cmd.Parameters.Add(new SqlParameter("@Quantity", row["Quantity"]));
                cmd.Parameters.Add(new SqlParameter("@UnitAmount", row["UnitAmount"]));
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void RefreshOrder()
        {
            currentAgentID = 0;
            labelAgentID.Text = string.Empty;
            txtAgentName.Text = string.Empty;
            
            currentOrderDate = DateTime.Now;
            orderDetailTable.Clear();
            updateDataGridView(orderDetailTable);

            RefreshInputOrderDetail();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormOrderCrystalReport formOrderCrystalReport = new FormOrderCrystalReport(createdOrder);
            formOrderCrystalReport.ShowDialog();
        }
    }
}

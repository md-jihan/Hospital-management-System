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

namespace InventoryManagementSystem
{
    public partial class OrderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=hms;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCustomer WHERE CONCAT(cid,cname) LIKE '%" + txtCSearch.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid, pname,pqty, pprice, pdescription, pcategory) LIKE '%" + txtPSearch.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void txtCSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void txtPSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
        int qty = 0;
        private void UDQty_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if(Convert.ToInt32(UDQty.Value) > qty) {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UDQty.Value = UDQty.Value - 1;
                return;
            }
            if(Convert.ToInt32(UDQty.Value) > 0){
                int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(UDQty.Value);
                txtTotal.Text = total.ToString();
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPId.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCId.Text == "")
                {
                    MessageBox.Show("Please Select Customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPId.Text == "")
                {
                    MessageBox.Show("Please Select Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure want to Insert this order?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbOrder(odate, pid, cid, qty, price, total)VALUES(@odate, @pid, @cid, @qty, @price, @total)", con);
                    
                    cm.Parameters.AddWithValue("@odate", DOrder.Value);
                    cm.Parameters.AddWithValue("@pid", Convert.ToInt32(txtPId.Text));
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt32(txtCId.Text));
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt32(UDQty.Value));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToInt32(txtTotal.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order has been successfully insert.");

                    cm = new SqlCommand("UPDATE tbProduct SET pqty=(pqty-@pqty) WHERE pid LIKE '" + txtPId.Text + "'", con);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt32(UDQty.Value));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txtCId.Clear();
            txtCName.Clear();

            txtPId.Clear();
            txtPName.Clear();
            txtPrice.Clear();
            UDQty.Value = 0;
            txtTotal.Clear();
            DOrder.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void GetQty()
        {
            cm = new SqlCommand("SELECT pid,pqty FROM tbProduct WHERE pid='"+ txtPId.Text +"'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());    
            }
            dr.Close();
            con.Close();
        }
    }
}

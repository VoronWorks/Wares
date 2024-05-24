using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestShop
{
    public partial class FormOrders : Form
    {
        private NpgsqlConnection con;
        private string conString =
             "Host = 127.0.0.1; Username = postgres; Password = password; Database = Wares";
        public FormOrders()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();

            string sql = "SELECT lastname, firstname, patronym FROM Customers";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            cbCustomer.Items.Clear();
            while (reader.Read())
            {
                cbCustomer.Items.Add(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2));
            }
            reader.Close();

            string sql1 = "SELECT name_prod FROM products";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            NpgsqlDataReader reader1 = cmd1.ExecuteReader();
            cbProd.Items.Clear();
            while (reader1.Read())
            {
                cbProd.Items.Add(reader1.GetString(0));
            }
            reader1.Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id, lastname, firstname, patronym FROM Customers";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int customer_id = 0;
            while (reader.Read())
            {
                if (cbCustomer.SelectedItem.ToString() == reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3))
                {
                    customer_id = Convert.ToInt32(reader.GetValue(0));
                }
            }
            reader.Close();

            string sql1 = "SELECT id, name_prod FROM products";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            NpgsqlDataReader reader1 = cmd1.ExecuteReader();
            int product_id = 0;
            while (reader1.Read())
            {
                if (cbProd.SelectedItem.ToString() == reader1.GetString(1))
                {
                    product_id = Convert.ToInt32(reader1.GetValue(0));
                }
            }
            reader1.Close();

            string sql2 = "INSERT INTO Orders(order_date,  arrived, quantity, " +
                "customer_id, product_id) VALUES(@order_date,  @arrived, @quantity, @customer_id, @product_id)";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, con);

            DateTime orderDate = this.dtpInv.Value;
            cmd2.Parameters.AddWithValue("order_date", orderDate);


            cmd2.Parameters.AddWithValue("quantity", int.Parse(this.nudQuan.Value.ToString()));
            cmd2.Parameters.AddWithValue("arrived", this.checkBox1.Checked); ;
            cmd2.Parameters.AddWithValue("customer_id", customer_id);
            cmd2.Parameters.AddWithValue("product_id", product_id);
            cmd2.Prepare();
            cmd2.ExecuteNonQuery();
            this.Close();
        }



       


      



        private void FormInvoices_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

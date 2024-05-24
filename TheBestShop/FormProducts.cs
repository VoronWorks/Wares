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
using System.Windows.Forms.DataVisualization.Charting;

namespace TheBestShop
{
    public partial class FormProducts : Form
    {
        private NpgsqlConnection con;
        private string conString =
             "Host = 127.0.0.1; Username = postgres; Password = password; Database = Wares";
        public FormProducts()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql1 = "INSERT INTO Products(name_prod, cost_prod) VALUES(@name, @cost)";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);

            cmd1.Parameters.AddWithValue("name", this.tbnameProd.Text);

            string costString = this.tbCost.Text;
            float costValue;
            if (float.TryParse(costString, out costValue))
            {
                cmd1.Parameters.AddWithValue("cost", costValue);
            }
            else
            {
                MessageBox.Show("Неверный формат ввода стоимости. Пожалуйста, введите число.");
                
            }
           

            cmd1.Prepare();
            cmd1.ExecuteNonQuery();

            this.Close();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }
    }
}

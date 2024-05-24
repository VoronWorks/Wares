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
    public partial class FormCustomers : Form
    {
        private NpgsqlConnection con;
        private string conString =
             "Host = 127.0.0.1; Username = postgres; Password = password; Database = Wares";
        public FormCustomers()
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
            string sql1 = "INSERT INTO Customers(lastname, firstname, patronym, phone, address)" +
                " VALUES(@lastname, @name, @surname, @phone, @address)";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            cmd1.Parameters.AddWithValue("lastname", this.tbLastname.Text);
            cmd1.Parameters.AddWithValue("name", this.tbName.Text);
            cmd1.Parameters.AddWithValue("surname", this.tbSurname.Text);
            cmd1.Parameters.AddWithValue("phone", this.tbPhone.Text);
            cmd1.Parameters.AddWithValue("address", this.tbAddress.Text);
            cmd1.Prepare();
            cmd1.ExecuteNonQuery();

            this.Close();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}

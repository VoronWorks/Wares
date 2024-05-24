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
    public partial class FormCustomersChange : Form
    {
        private NpgsqlConnection con;
        private string conString =
             "Host = 127.0.0.1; Username = postgres; Password = password; Database = Wares";
        public FormCustomersChange()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadClients();

        }
        public DataGridViewRow SelectedRow { get; set; }

        private void FormCustomersChange_Load(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                // Заполнить поля данными из выбранной строки
                labelid.Text = SelectedRow.Cells["id"].Value.ToString();
                tbLastname.Text = SelectedRow.Cells["firstname"].Value.ToString();
                tbName.Text = SelectedRow.Cells["lastname"].Value.ToString();
                tbSurname.Text = SelectedRow.Cells["patronym"].Value.ToString();
                tbAddress.Text = SelectedRow.Cells["address"].Value.ToString();
                tbPhone.Text = SelectedRow.Cells["phone"].Value.ToString();
            }
        }

        private void loadClients()
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Customers", con);
            adap.Fill(dt);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Customers SET lastname=@lastname, firstname=@name, " +
                "patronym=@surname, phone = @phone, address = @address WHERE id = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("lastname", this.tbLastname.Text);
            cmd.Parameters.AddWithValue("name", this.tbName.Text);
            cmd.Parameters.AddWithValue("surname", this.tbSurname.Text);
            cmd.Parameters.AddWithValue("phone", this.tbPhone.Text);
            cmd.Parameters.AddWithValue("address", this.tbAddress.Text);
            int id = int.Parse(this.labelid.Text);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            this.Close();

        }
    }
}

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

namespace SRP
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=StudentRequestDB;Integrated Security=True");
        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            int stId = int.Parse(idBox.Text);
            String fullN = fullnameBox.Text;
            String email = emailBox.Text;
            String pswd = passwordBox.Text;
            String dpt = departmentBox.Text;
            String querry = "INSERT INTO Student VALUES("+ stId + ",'"+fullN+"','"+email+"','"+pswd+"','"+dpt+"')";
            SqlDataAdapter sda = new SqlDataAdapter(querry, con);
            con.Open();
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Student saved with Success");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Department dpt = new SRP.Department();
            this.Hide();
            dpt.Show();
        }
    }
}

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

namespace PoliceDepartmentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            string s = "select dbo.SignIn(@id, @pass)";
            string a = "select dbo.SignInAdmin(@id, @pass)";
            SqlCommand cmd = new SqlCommand(s, con);
            SqlCommand cmd2 = new SqlCommand(a, con);
            cmd.Parameters.AddWithValue("@id", loginIdTxt.Text);
            cmd.Parameters.AddWithValue("@pass", loginPassTxt.Text);
            cmd.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@id", loginIdTxt.Text);
            cmd2.Parameters.AddWithValue("@pass", loginPassTxt.Text);
            cmd2.CommandType = CommandType.Text;
            con.Open();
            String resultUser = cmd.ExecuteScalar().ToString();
            string resultAdmin = cmd2.ExecuteScalar().ToString();

            if (resultUser == "True")
            {
                string id = loginIdTxt.Text;
                this.Hide();
                Main main = new Main(id);
                main.ShowDialog();
                this.Close();
            }
            else if(resultAdmin == "True")
            {
                string id = loginIdTxt.Text;
                this.Hide();
                AdminForms.Statistics statistics = new AdminForms.Statistics(id);
                statistics.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter your ID & password correctly");
            }
        }

        private bool isEmpty()
        {
            if (loginIdTxt.Text == "" || loginPassTxt.Text == "")
            {
                MessageBox.Show("Please Fill Out All The Fields");
                return true;
            }
            else
            { 
                return false;
            }
        }

        private void loginIdTxt_TextChanged(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void loginIdTxt_Click(object sender, EventArgs e)
        {
            loginIdTxt.Clear();
            panel1.BackColor = Color.FromArgb(52, 241, 244);
            pictureBox2.BackgroundImage = Properties.Resources.user2;
            loginIdTxt.ForeColor = Color.FromArgb(52, 241, 244);

            panel2.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources.pswrd;
            loginPassTxt.ForeColor = Color.White;
            if (loginPassTxt.Text == "") loginPassTxt.Text = "Password";
        }

        private void loginPassTxt_Click(object sender, EventArgs e)
        {
            loginPassTxt.Clear();
            panel2.BackColor = Color.FromArgb(52, 241, 244);
            pictureBox3.BackgroundImage = Properties.Resources.pswrd2;
            loginPassTxt.ForeColor = Color.FromArgb(52, 241, 244);

            panel1.BackColor = Color.White;
            pictureBox2.BackgroundImage = Properties.Resources.user;
            loginIdTxt.ForeColor = Color.White;
            if (loginIdTxt.Text == "") loginIdTxt.Text = "User ID";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           label1.Hide();
        }
    }
}

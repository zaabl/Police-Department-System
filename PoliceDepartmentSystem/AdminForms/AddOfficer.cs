using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PoliceDepartmentSystem.AdminForms
{
    public partial class AddOfficer : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
        SqlCommand cmd;
        string imgLoc = "";

        public AddOfficer()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddOfficer_Load(object sender, EventArgs e)
        {

        }

        private void addOfficerBrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Officer Picture";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    addOfficerPicture.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addOfficerSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "INSERT INTO Officer(Officer_ID,Rank,Name,Crime_Count, Password, Photo)VALUES('" + addOfficerIDTxt.Text + "','" + addOfficerRankTxt.Text + "','" + addOfficerNameTxt.Text + "', 0, '" + addOfficerPasswordTxt.Text + "',@img)";
                //string sql = "INSERT INTO Officer(Officer_ID, Rank, Name, Photo, Password, Crime_Count)VALUES('" + addOfficerIDTxt.Text + "', '"+addOfficerRankTxt.Text+"', '"+addOfficerNameTxt.Text+"' ,@img ,'"+addOfficerPasswordTxt.Text+"' ,'"+ textBox1.Text+"')";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(x.ToString() + " record(s) saved.");
                }
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

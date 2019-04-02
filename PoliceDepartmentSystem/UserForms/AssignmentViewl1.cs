using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PoliceDepartmentSystem.UserForms
{
    public partial class AssignmentViewl1 : UserControl
    {
        public string CrimeID { get; set; }
        string imgLoc = "";
        int count = 0;
        int numOfPhoto;


        public AssignmentViewl1()
        {
            InitializeComponent();
            
        }

        private void AssignmentViewl1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            //crimeID = "5612";

            //===========================================================RetriveData===============================================================
            //=====================================================================================================================================

            SqlCommand cmd = new SqlCommand("dbo.rCrimeDate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", CrimeID);
            SqlDataReader rdr = null;
            rdr = cmd.ExecuteReader();
            rdr.Read();
            dateLbl.Text = rdr["Date"].ToString();
            rdr.Close();

            SqlCommand cmd2 = new SqlCommand("dbo.rCrimeType", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@id", CrimeID);
            SqlDataReader rdr2 = null;
            rdr2 = cmd2.ExecuteReader();
            rdr2.Read();
            typeLbl.Text = rdr2["Type"].ToString();
            rdr2.Close();

            SqlCommand cmd3 = new SqlCommand("dbo.rCrimeStatus", con);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@id", CrimeID);
            SqlDataReader rdr3 = null;
            rdr3 = cmd3.ExecuteReader();
            rdr3.Read();
            string status = rdr3["Status"].ToString();
            if(status == "True")
            {
                statusLbl.Text = "Resolved";
            }
            else
            {
                statusLbl.Text = "On Going";
            }
            rdr3.Close();

            SqlCommand cmd4 = new SqlCommand("dbo.rCrimeCriminalID", con);
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd4.Parameters.AddWithValue("@id", CrimeID);
            SqlDataReader rdr4 = null;
            rdr4 = cmd4.ExecuteReader();
            rdr4.Read();
            string Criminal_ID = rdr4["Criminal_ID"].ToString();
            rdr4.Close();

            SqlCommand cmd6 = new SqlCommand("dbo.rCriminalName", con);
            cmd6.CommandType = CommandType.StoredProcedure;
            cmd6.Parameters.AddWithValue("@id", Criminal_ID);
            SqlDataReader rdr6 = null;
            rdr6 = cmd6.ExecuteReader();
            rdr6.Read();
            criminalNameLbl.Text = rdr6["Name"].ToString();
            rdr6.Close();

            SqlCommand cmd7 = new SqlCommand("dbo.rCrimeOfficerName", con);
            cmd7.CommandType = CommandType.StoredProcedure;
            cmd7.Parameters.AddWithValue("@id", CrimeID);
            SqlDataReader rdr7 = null;
            rdr7 = cmd7.ExecuteReader();
            rdr7.Read();
            officerNameLbl.Text = rdr7["Name"].ToString();
            rdr7.Close();

            SqlCommand cmd8 = new SqlCommand("dbo.rCriminalDetails", con);
            cmd8.CommandType = CommandType.StoredProcedure;
            cmd8.Parameters.AddWithValue("@id", CrimeID);
            SqlDataReader rdr8 = null;
            rdr8 = cmd8.ExecuteReader();
            rdr8.Read();
            detailsLbl.Text = rdr8["Details"].ToString();
            rdr8.Close();

            //===========================================================RetrivePhoto==============================================================
            //=====================================================================================================================================


            string retrivePhoto = "select Photo from Criminal where Criminal_ID = " + Criminal_ID + " ";
            SqlCommand cmd5 = new SqlCommand(retrivePhoto, con);
            SqlDataAdapter ada = new SqlDataAdapter(cmd5);
            DataSet ds = new DataSet();
            ada.Fill(ds, "Criminal");
            int c = ds.Tables["Criminal"].Rows.Count;
            if (c > 0)
            {
                byte[] img = new byte[0];
                img = (byte[])(ds.Tables["Criminal"].Rows[c - 1]["Photo"]);
                MemoryStream ms = new MemoryStream(img);
                criminalPhotoLbl.Image = Image.FromStream(ms);
            }



            crimeIDLbl.Text = CrimeID;

            //===========================================================Tools found on scene======================================================
            //=====================================================================================================================================
            numOfPhoto = num_of_photo();
            show_photo(count);

        }

        int num_of_photo()
        {
            int num_photo = 0;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            string idd = CrimeID.ToString();

            SqlCommand com = new SqlCommand("select count (*) from Photo where (Crime_ID =@Id ) ", con);
            com.Parameters.Add("@Id", SqlDbType.Int, idd.Length).Value = Convert.ToInt32(idd);
            num_photo = Convert.ToInt32(com.ExecuteScalar());
            con.Close();
            return num_photo;

        }

        void show_photo(int count) {
           
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("select * from Photo where (Crime_ID = @Id ) ", con);
            string idd = CrimeID.ToString();
            com.Parameters.Add("@Id", SqlDbType.Int, idd.Length).Value = Convert.ToInt32(idd);
            SqlDataAdapter ad = new SqlDataAdapter(com);
            DataTable dataT = new DataTable();
            ad.Fill(dataT);
            int number_photo = num_of_photo();
            if (number_photo == 0)
                return;
            byte[] aa = new byte[0];
            aa = (byte[])(dataT.Rows[count]["Photo"]);
            MemoryStream ms = new MemoryStream(aa);
            Bitmap bt = new Bitmap(ms);
            crimePhotos.Image = Image.FromStream(ms);
            //Image<Gray, byte> c = new Image<Gray, byte>(bt);

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd8 = new SqlCommand("dbo.UpdateStatus", con);
            cmd8.CommandType = CommandType.StoredProcedure;
            cmd8.Parameters.AddWithValue("@id", CrimeID);
            cmd8.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd8 = new SqlCommand("dbo.UpdateDetails", con);
            cmd8.CommandType = CommandType.StoredProcedure;
            cmd8.Parameters.AddWithValue("@id", CrimeID);
            cmd8.Parameters.AddWithValue("@detail", detailsLbl.Text);
            cmd8.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Officer Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    crimePhotos.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            SqlCommand cmd;


            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "INSERT INTO Photo(Crime_ID, Photo)VALUES('" + CrimeID + "',@img)";
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
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (count == numOfPhoto - 1)
                count = 0;
            else
                count++;
            show_photo(count);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (count == 0)
                count = numOfPhoto - 1;
            else
                count--;
            show_photo(count);
        }
    }
}

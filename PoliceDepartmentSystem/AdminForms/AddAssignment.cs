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
    public partial class AddAssignment : UserControl
    {
            string officerID;
        private object sqlDbType;
        string criminalID2;

        public AddAssignment()
        {
            InitializeComponent();
            officersGrid.Hide();
            officersCross.Hide();
            criminalGrid.Hide();
            criminalCross.Hide();
        }

        private void selectedOfficerLbl_Click(object sender, EventArgs e)
        {
            officersGrid.Show();
            officersCross.Show();
        }

        private void officersCross_Click(object sender, EventArgs e)
        {
            officersGrid.Hide();
            officersCross.Hide();
        }

        private void officersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ID = officersGrid.SelectedRows[0].Cells["Name"].Value.ToString();
                selectedOfficerLbl.Text = ID;
                officersGrid.Hide();
                officersCross.Hide();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please select the desired row");
            }
        }

        private void AddAssignment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            SqlDataAdapter ada3 = new SqlDataAdapter("select * from dbo.returnAllOfficers()", con);
            DataTable tb2 = new DataTable();
            ada3.Fill(tb2);
            officersGrid.DataSource = tb2;

            SqlDataAdapter ada4 = new SqlDataAdapter("select * from dbo.returnAllCriminals()", con);
            DataTable tb3 = new DataTable();
            ada4.Fill(tb3);
            criminalGrid.DataSource = tb3;

            /////////////// getting officer id from his name //////////////////////////
            //SqlCommand cmd = new SqlCommand("select Officer_ID from Officer where Name = '"+selectedOfficerLbl.Text+"' ", con);
            //SqlParameter name = new SqlParameter("@name", SqlDbType.Int);
            //name.Value = selectedOfficerLbl;
            //int officerID = (int)cmd.ExecuteScalar();
            //SqlParameter name = new SqlParameter("@name", SqlDbType.Int);
            //name.Value = selectedOfficerLbl;
            //label8.Text = officerID.ToString();
            //label8.Text = officerID.ToString();
            //cmd.Parameters.Add("@name", sqlDbType.nvchar(10), name.Length).value = Convert.ToString(name);


            /////////////////////////getting criminal id////////////////////////////
            ///

            //SqlCommand cmd9 = new SqlCommand("select Criminal_ID from Criminal where Name = '" + selectCriminalLbl.Text + "' ", con);
            
            //int criminalID2 = (int)cmd9.ExecuteScalar();

            //label8.Text = criminalID2.ToString();
            //photoofcriminal




            ////////////////////////////////////////////////////////////////
            //SqlCommand cmd2 = new SqlCommand("dbo.ReturnCriminalID", con);
            //cmd2.CommandType = CommandType.StoredProcedure;
            //cmd2.Parameters.AddWithValue("@name", selectCriminalLbl.Text);
            //SqlDataReader rdr2 = null;
            //rdr2 = cmd2.ExecuteReader();
            //rdr2.Read();
            //string criminalID = "";
            //while (rdr2.Read())
            //{
            //     criminalID= rdr2["Criminal_ID"].ToString();
            //}
            //rdr2.Close();

            // Photooooooooooooooooooo

            //string retrivePhoto = "select Photo from Criminal where Criminal_ID = '" + criminalID2 + "' ";
            //SqlCommand cmd3 = new SqlCommand(retrivePhoto, con);
            //SqlDataAdapter ada = new SqlDataAdapter(cmd3);
            //DataSet ds = new DataSet();
            //ada.Fill(ds, "Criminal");
            //int c = ds.Tables["Criminal"].Rows.Count;
            //if (c > 0)
            //{
            //    byte[] img = new byte[0];
            //    img = (byte[])(ds.Tables["Criminal"].Rows[c - 1]["Photo"]);
            //    MemoryStream ms = new MemoryStream(img);
            //    criminalPhotoLbl.Image = Image.FromStream(ms);
            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void selectCriminalLbl_Click(object sender, EventArgs e)
        {
            criminalGrid.Show();
            criminalCross.Show();
        }

        private void criminalCross_Click(object sender, EventArgs e)
        {
            criminalGrid.Hide();
            criminalCross.Hide();
        }

        private void criminalGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ID = criminalGrid.SelectedRows[0].Cells["Name"].Value.ToString();
                selectCriminalLbl.Text = ID;
                criminalGrid.Hide();
                criminalCross.Hide();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please select the desired row");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(selectedOfficerLbl.Text=="Click to choose")
            {
                MessageBox.Show("Please select your Officer");
            }
            if (selectCriminalLbl.Text == "Click to choose")
            {
                MessageBox.Show("Please select the Criminal");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
                con.Open();
                SqlCommand cmd9 = new SqlCommand("select Criminal_ID from Criminal where Name = '" + selectCriminalLbl.Text + "' ", con);

                criminalID2 = cmd9.ExecuteScalar().ToString();
                string retrivePhoto = "select Photo from Criminal where Criminal_ID = '" + criminalID2 + "' ";
                SqlCommand cmd3 = new SqlCommand(retrivePhoto, con);
                SqlDataAdapter ada = new SqlDataAdapter(cmd3);
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
                SqlCommand cmd = new SqlCommand("select Officer_ID from Officer where Name = '" + selectedOfficerLbl.Text + "' ", con);
                officerID = cmd.ExecuteScalar().ToString();
      

                SqlCommand countAssignments = new SqlCommand("select Count(*) from Crime where Officer_ID = '" + officerID + "' ", con);
                int count = (int)countAssignments.ExecuteScalar();
                if (count >= 10)
                {
                    MessageBox.Show("This Officer is already assigned to 10 crimes ");
                    selectedOfficerLbl.Text = "Click to choose";
                }
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            MessageBox.Show(criminalID2);

            string sql = "INSERT INTO Crime (Crime_ID,Date,Type,Status,Details,Officer_ID) VALUES('" + crimeIdTxt.Text + "','" + DateTxt.Text + "','" + typeTxt.Text + "', 0 ,'" + detailsTxt.Text + "', '" + officerID + "')";
            string sql2 = "INSERT INTO Criminal_Crime(Crime_ID,Criminal_ID)VALUES('" + crimeIdTxt.Text + "' , " + criminalID2 + " )";
            SqlCommand AddAssignmentcmd1 = new SqlCommand(sql, con);
            SqlCommand AddAssignmentcmd2 = new SqlCommand(sql2, con);

            AddAssignmentcmd1.ExecuteNonQuery();
            AddAssignmentcmd2.ExecuteNonQuery();
            SqlCommand Incrementcmd = new SqlCommand("Update Officer set Crime_Count += 1 where Officer_ID = '"+ officerID +"' " ,con  );
            Incrementcmd.ExecuteNonQuery();


        }
    }
}

using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
using System.IO;

namespace PoliceDepartmentSystem
{

    public partial class Main : Form
    {
        string ID;

        public Main(string id)
        {
            InitializeComponent();
            ID = id;
    //======================================================Initializing Name/Rank==========================================================
    //======================================================================================================================================
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.DisplayRank", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader rdr = null;
            rdr = cmd.ExecuteReader();
            rdr.Read();
            announcementRankLabel.Text = rdr["Rank"].ToString();
            rdr.Close();

            SqlCommand cmd2 = new SqlCommand("dbo.DisplayName", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@id", id);
            rdr = cmd2.ExecuteReader();
            rdr.Read();
            announcementRankLabel.Text += rdr["Name"].ToString();
            rdr.Close();

            criminalPannel.Hide();
            mainIDLbl.Text = "ID " + id;

    //==========================================================ProfilePicture=============================================================
    //=====================================================================================================================================
            string retrivePhoto = "select Photo from Officer where Officer_ID = "+id+" ";
            SqlCommand cmd3 = new SqlCommand(retrivePhoto, con);
            SqlDataAdapter ada = new SqlDataAdapter(cmd3);
            DataSet ds = new DataSet();
            ada.Fill(ds, "Officer");
            int c = ds.Tables["Officer"].Rows.Count;
            if(c > 0)
            {
                byte[] img = new byte[0];
                img = (byte[])(ds.Tables["Officer"].Rows[c - 1]["Photo"]);
                MemoryStream ms = new MemoryStream(img);
                mainProfilePicture.Image = Image.FromStream(ms);
            }
    //===========================================================AssignmentGridView========================================================
    //=====================================================================================================================================

            

    //===========================================================AssignmentGridView========================================================
    //=====================================================================================================================================

            //SqlDataAdapter ada3 = new SqlDataAdapter("select * from dbo.archiveOfficer('46572')", con);
            //DataTable tb2 = new DataTable();
            //ada3.Fill(tb2);
            //archiveGrid.DataSource = tb2;
            archive1.id = id;
            archive1.load = true;
            criminalPannel.Hide();
            archive1.Hide();
            assignments1.Hide();
            assignments1.id = id;
        }

        private void assignmentsNavBtn_Click(object sender, EventArgs e)
        {
            panelNav.Top = assignmentsNavBtn.Top;
            criminalPannel.Hide();
            announcementsPanel.Hide();
            archive1.Hide();
            assignments1.Show();
            titleTxt.Text = "Assignments";
        }


        private void criminalNavBtn_Click(object sender, EventArgs e)
        {
            panelNav.Top = criminalNavBtn.Top;
            criminalPannel.Show();
            announcementsPanel.Hide();
            archive1.Hide();
            assignments1.Hide();
            titleTxt.Text = "Criminals";
        }

        private void archiveNavBtn_Click(object sender, EventArgs e)
        {
            panelNav.Top = archiveNavBtn.Top;
            archive1.Show();
            criminalPannel.Hide();
            announcementsPanel.Hide();
            assignments1.Hide();
            titleTxt.Text = "Archive";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'police_Depart_SystemDataSet6.rAnnouncements' table. You can move, or remove it, as needed.
            this.rAnnouncementsTableAdapter.Fill(this.police_Depart_SystemDataSet6.rAnnouncements);
            // TODO: This line of code loads data into the 'testDataSet2.Announcements' table. You can move, or remove it, as needed.
            //this.announcementsTableAdapter.Fill(this.testDataSet2.Announcements);
            // TODO: This line of code loads data into the 'police_Depart_SystemDataSet.Criminal' table. You can move, or remove it, as needed.
            this.criminalTableAdapter.Fill(this.police_Depart_SystemDataSet.Criminal);


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void mainNavBtn_Click(object sender, EventArgs e)
        {
            panelNav.Top = mainNavBtn.Top;
            announcementsPanel.Show();
            criminalPannel.Hide();
            assignments1.Hide();
            titleTxt.Text = "Announcements";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(ID);
            main.ShowDialog();
            this.Close();

        }
    }
}

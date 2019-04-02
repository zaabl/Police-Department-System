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

namespace PoliceDepartmentSystem.AdminForms
{
    public partial class Statistics : Form
    {
        public string ID;

        public Statistics(string id)
        {
            InitializeComponent();

    //======================================================Initializing Name/Rank==========================================================
    //======================================================================================================================================

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            adminIdLbl.Text = "ID " + id;
            ID = id;

            SqlCommand DisplayRankcmd = new SqlCommand("dbo.DisplayAdminRank", con);
            DisplayRankcmd.CommandType = CommandType.StoredProcedure;
            DisplayRankcmd.Parameters.AddWithValue("@id", id);
            SqlDataReader rdr = null;
            rdr = DisplayRankcmd.ExecuteReader();
            rdr.Read();
            adminRankLbl.Text = rdr["Rank"].ToString();
            rdr.Close();

            SqlCommand DisplayNamecmd = new SqlCommand("dbo.DisplayAdminName", con);
            DisplayNamecmd.CommandType = CommandType.StoredProcedure;
            DisplayNamecmd.Parameters.AddWithValue("@id", id);
            rdr = DisplayNamecmd.ExecuteReader();
            rdr.Read();
            AdminNameLbl.Text = rdr["Name"].ToString();
            rdr.Close();

            string retrivePhoto = "select Photo from Admin where Admin_ID = " + id + " ";
            SqlCommand cmd3 = new SqlCommand(retrivePhoto, con);
            SqlDataAdapter ada = new SqlDataAdapter(cmd3);
            DataSet ds = new DataSet();
            ada.Fill(ds, "Admin");
            int c = ds.Tables["Admin"].Rows.Count;
            if (c > 0)
            {
                byte[] img = new byte[0];
                img = (byte[])(ds.Tables["Admin"].Rows[c - 1]["Photo"]);
                MemoryStream ms = new MemoryStream(img);
                adminProfilePhoto.Image = Image.FromStream(ms);
            }

    //======================================================Solved/Unsolved Graph===========================================================
    //======================================================================================================================================
            SqlCommand cmd = new SqlCommand("select count(*) from Crime where Status =0", con);
            int CountFalse = (int)cmd.ExecuteScalar();
            SqlCommand cmd2 = new SqlCommand("select count(*) from Crime where Status =1", con);
            int CountTrue = (int)cmd2.ExecuteScalar();
            //con.Close();
            chart1.Series["Solved"].Points.AddXY("Solved", CountTrue);
            chart1.Series["Solved"].Points.AddXY("UnSolved", CountFalse);
    //=================================================Crimes Solved over the years=========================================================
    //======================================================================================================================================
            SqlCommand cmdd = new SqlCommand("select count(*) from Crime where right(Date,6) = 2010 and Status = 1", con);
            int Count1 = (int)cmdd.ExecuteScalar();
            SqlCommand cmdd2 = new SqlCommand("select count(*) from Crime where right(Date,6) = 2011 and Status = 1", con);
            int Count2 = (int)cmdd2.ExecuteScalar();
            SqlCommand cmdd3 = new SqlCommand("select count(*) from Crime where right(Date,6) = 2012 and Status = 1", con);
            int Count3 = (int)cmdd3.ExecuteScalar();
            SqlCommand cmdd4 = new SqlCommand("select count(*) from Crime where right(Date,6) = 2013 and Status = 1", con);
            int Count4 = (int)cmdd4.ExecuteScalar();
            SqlCommand cmdd5 = new SqlCommand("select count(*) from Crime where right(Date,6) = 2014 and Status = 1", con);
            int Count5 = (int)cmdd5.ExecuteScalar();
            SqlCommand cmdd6 = new SqlCommand("select count(*) from Crime where right(Date,6) = 2015 and Status = 1", con);
            int Count6 = (int)cmdd6.ExecuteScalar();
            SqlCommand cmdd7 = new SqlCommand("select count(*) from Crime where right(Date,6) = 2016 and Status = 1", con);
            int Count7 = (int)cmdd7.ExecuteScalar();
            SqlCommand cmdd8 = new SqlCommand("select count(*) from Crime where right(Date,6) = 2017 and Status = 1", con);
            int Count8 = (int)cmdd8.ExecuteScalar();
            SqlCommand cmdd9 = new SqlCommand("select count(*) from Crime where right(Date,6) = 2018 and Status = 1", con);
            int Count9 = (int)cmdd9.ExecuteScalar();
            //con.Close();
            chart3.Series["Solved"].Points.AddXY("2010", Count1);
            chart3.Series["Solved"].Points.AddXY("2011", Count2);
            chart3.Series["Solved"].Points.AddXY("2012", Count3);
            chart3.Series["Solved"].Points.AddXY("2013", Count4);
            chart3.Series["Solved"].Points.AddXY("2014", Count5);
            chart3.Series["Solved"].Points.AddXY("2015", Count6);
            chart3.Series["Solved"].Points.AddXY("2016", Count7);
            chart3.Series["Solved"].Points.AddXY("2017", Count8);
            chart3.Series["Solved"].Points.AddXY("2018", Count9);

            //=================================================Types Of Crimes======================================================================
            //======================================================================================================================================

            SqlCommand cmddd = new SqlCommand("select count(*) from Crime where Type = 'Murder'", con);
            int Countt1 = (int)cmddd.ExecuteScalar();
            SqlCommand cmddd2 = new SqlCommand("select count(*) from Crime where Type ='Sexual Harrasment'", con);
            int Countt2 = (int)cmddd2.ExecuteScalar();
            SqlCommand cmddd3 = new SqlCommand("select count(*) from Crime where Type ='Theft'", con);
            int Countt3 = (int)cmddd3.ExecuteScalar();
            SqlCommand cmddd4 = new SqlCommand("select count(*) from Crime where Type ='Robery'", con);
            int Countt4 = (int)cmddd4.ExecuteScalar();
            SqlCommand cmddd5 = new SqlCommand("select count(*) from Crime where Type ='Traficcing'", con);
            int Countt5 = (int)cmddd5.ExecuteScalar();
            SqlCommand cmddd6 = new SqlCommand("select count(*) from Crime where Type ='Kidnapping'", con);
            int Countt6 = (int)cmddd6.ExecuteScalar();
            SqlCommand cmddd7 = new SqlCommand("select count(*) from Crime where Type ='Other'", con);
            int Countt7 = (int)cmddd7.ExecuteScalar();

            chart2.Series["Types Of Crime"].Points.AddXY("Murder", Countt1);
            chart2.Series["Types Of Crime"].Points.AddXY("Sexual Harrasment", Countt2);
            chart2.Series["Types Of Crime"].Points.AddXY("Theft", Countt3);
            chart2.Series["Types Of Crime"].Points.AddXY("Robery", Countt4);
            chart2.Series["Types Of Crime"].Points.AddXY("Trafficing", Countt5);
            chart2.Series["Types Of Crime"].Points.AddXY("Kidnapping", Countt6);
            chart2.Series["Types Of Crime"].Points.AddXY("Other", Countt6);

            statisticsPanel.BringToFront();
            announcementsPanel.Hide();
            officersPanel.Hide();
            assignmentsAdmin1.Hide();
            assignmentsAdmin1.id = ID;
            archive1.userType = "Admin";
            archive1.Hide();
            
        }

        private void mainNavBtn_Click(object sender, EventArgs e)
        {
            panelNav.Top = announcementsNavBtn.Top;
            statisticsPanel.Hide();
            officersPanel.Hide();
            assignmentsAdmin1.Hide();
            announcementsPanel.Show();
            criminalPannel.Hide();
            archive1.Hide();
            titleTxt.Text = "Announcements";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void assignmentsNavBtn_Click(object sender, EventArgs e)
        {
            panelNav.Top = assignmentsNavBtn.Top;
            statisticsPanel.Hide();
            officersPanel.Hide();
            announcementsPanel.Hide();
            assignmentsAdmin1.Show();
            criminalPannel.Hide();
            archive1.Hide();
            titleTxt.Text = "Assignments";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelNav.Top = officersNavBtn.Top;
            statisticsPanel.Hide();
            announcementsPanel.Hide();
            officersPanel.Show();
            assignmentsAdmin1.Hide();
            criminalPannel.Hide();
            archive1.Hide();
            titleTxt.Text = "Officers";
        }

        private void criminalNavBtn_Click(object sender, EventArgs e)
        {
            panelNav.Top = criminalNavBtn.Top;
            statisticsPanel.Hide();
            announcementsPanel.Hide();
            officersPanel.Hide();
            assignmentsAdmin1.Hide();
            archive1.Hide();
            criminalPannel.Show();
            titleTxt.Text = "Criminals";
        }

        private void archiveNavBtn_Click(object sender, EventArgs e)
        {
            panelNav.Top = archiveNavBtn.Top;
            archive1.Show();
            statisticsPanel.Hide();
            announcementsPanel.Hide();
            officersPanel.Hide();
            assignmentsAdmin1.Hide();
            criminalPannel.Hide();
            titleTxt.Text = "Archive";
        }

        private void statisticsNavBtn_Click(object sender, EventArgs e)
        {
            panelNav.Top = statisticsNavBtn.Top;
            statisticsPanel.Show();
            titleTxt.Text = "Statistics";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("HI");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addOfficer1.Show();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'police_Depart_SystemDataSet10.Criminal' table. You can move, or remove it, as needed.
            this.criminalTableAdapter.Fill(this.police_Depart_SystemDataSet10.Criminal);
            // TODO: This line of code loads data into the 'police_Depart_SystemDataSet9.rAnnouncements' table. You can move, or remove it, as needed.
            this.rAnnouncementsTableAdapter.Fill(this.police_Depart_SystemDataSet9.rAnnouncements);
            // TODO: This line of code loads data into the 'police_Depart_SystemDataSet8.Officer' table. You can move, or remove it, as needed.
            this.officerTableAdapter.Fill(this.police_Depart_SystemDataSet8.Officer);

        }

        private void announcementsAdmin1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            SqlCommand AddAnnouncementcmd = new SqlCommand("dbo.addAnnouncement", con);
            AddAnnouncementcmd.CommandType = CommandType.StoredProcedure;
            AddAnnouncementcmd.Parameters.AddWithValue("@id", ID);
            AddAnnouncementcmd.Parameters.AddWithValue("@message", announcementTxt.Text);
            AddAnnouncementcmd.ExecuteNonQuery();
            announcementTxt.Text = " ";
            MessageBox.Show("Posted Successfully");
            this.Hide();
            Statistics statistics = new Statistics(ID);
            statistics.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addCriminal1.Show();
        }

        private void addCriminal1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics statistics = new Statistics(ID);
            statistics.ShowDialog();
            this.Close();

        }
    }
}

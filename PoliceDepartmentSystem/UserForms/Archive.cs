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

namespace PoliceDepartmentSystem.UserForms
{
    public partial class Archive : UserControl
    {
        public string id { get; set; }
        public Boolean load { get; set; }
        public string userType { get; set; }

        public Archive()
        {
            InitializeComponent();
            id = "46572";
            load = false;
            //assignmentViewl11.Hide();
        }

        private void Archive_Load_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            SqlDataAdapter ada3 = new SqlDataAdapter("select * from dbo.archiveOfficer('46572')", con);
            DataTable tb2 = new DataTable();
            ada3.Fill(tb2);
            archiveGrid.DataSource = tb2;

            if (userType == "Admin")
            {
                DataTable tb6 = new DataTable();
                SqlDataAdapter ada6 = new SqlDataAdapter("select * from dbo.archeiveAdmin2()", con);
                ada6.Fill(tb6);
                archiveGrid.DataSource = tb6;
                archiveGrid.Columns[3].Width = 400;
            }
            else
            {
                SqlDataAdapter ada4 = new SqlDataAdapter("select * from dbo.archiveOfficer('" + id + "')", con);
                tb2.Clear();
                ada4.Fill(tb2);
                archiveGrid.DataSource = tb2;
                archiveGrid.Columns[3].Width = 400;
            }

        }

        private void archiveGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ID = archiveGrid.SelectedRows[0].Cells["Crime_ID"].Value.ToString();
                //assignmentViewl11.crimeID = ID;
                //assignmentViewl11.Show();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please select the desired row");
            }
        }

        private void archiveGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void archiveGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        string ID = archiveGrid.SelectedRows[0].Cells["Crime_ID"].Value.ToString();
        //        assignmentViewl11.crimeID = ID;
        //        assignmentViewl11.Show();
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Please select the desired row");
        //    }
        //}
    }
}

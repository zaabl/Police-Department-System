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
    public partial class Assignments : UserControl
    {
        public string id { get; set; }
        public Boolean load { get; set; }

        public Assignments()
        {
            InitializeComponent();
            //id = "46572";
            assignmentViewl11.Hide();
        }

        private void Assignments_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            SqlDataAdapter ada3 = new SqlDataAdapter("select * from dbo.ViewOfficerAssignments('"+id+"')", con);
            DataTable tb2 = new DataTable();
            ada3.Fill(tb2);
            assignmentGrid.DataSource = tb2;
            assignmentGrid.Columns[0].Width = 160;
            assignmentGrid.Columns[1].Width = 160;
            assignmentGrid.Columns[2].Width = 160;
            assignmentGrid.Columns[3].Width = 160;
        }

        private void assignmentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ID = assignmentGrid.SelectedRows[0].Cells["Crime_ID"].Value.ToString();
                assignmentViewl11.CrimeID = ID;
                assignmentViewl11.Show();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please select the desired row");
            }
        }
    }
}

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

namespace PoliceDepartmentSystem.AdminForms
{
    public partial class AssignmentsAdmin : UserControl
    {
        public string id { get; set; }

        public AssignmentsAdmin()
        {
            InitializeComponent();
            addAssignment1.Hide();
            assignmentViewl11.Hide();
        }

        private void AssignmentsAdmin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            SqlDataAdapter ada3 = new SqlDataAdapter("select * from dbo.ViewAllassignments()",con);
            DataTable tb2 = new DataTable();
            ada3.Fill(tb2);
            assignmentsAGrid.DataSource = tb2;
            assignmentsAGrid.Columns[0].Width = 160;
            assignmentsAGrid.Columns[1].Width = 160;
            assignmentsAGrid.Columns[2].Width = 160;
            assignmentsAGrid.Columns[3].Width = 160;
        }

        private void addAssignment_Click(object sender, EventArgs e)
        {
            addAssignment1.Show();
            assignmentViewl11.Hide();
        }

        private void assignmentsAGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ID = assignmentsAGrid.SelectedRows[0].Cells["Crime_ID"].Value.ToString();
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

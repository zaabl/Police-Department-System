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
    public partial class AssignmentsAdmincs : UserControl
    {
        public string id { get; set; }

        public AssignmentsAdmincs()
        {
            InitializeComponent();
        }

        private void AssignmentsAdmincs_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I0ICH35;Initial Catalog=Police_Depart_System;Integrated Security=True");
            con.Open();
            SqlDataAdapter ada3 = new SqlDataAdapter("select * from dbo.ViewOfficerAssignments(" + id + ")", con);
            DataTable tb2 = new DataTable();
            ada3.Fill(tb2);
            assignmentsAdminGrid.DataSource = tb2;
            assignmentsAdminGrid.Columns[0].Width = 160;
            assignmentsAdminGrid.Columns[1].Width = 160;
            assignmentsAdminGrid.Columns[2].Width = 160;
            assignmentsAdminGrid.Columns[3].Width = 160;
        }
    }
}

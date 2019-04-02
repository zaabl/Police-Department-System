using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceDepartmentSystem.AdminForms
{
    public partial class Officers : UserControl
    {
        public Officers()
        {
            InitializeComponent();
            addOfficer1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addOfficer1.Show();
        }

        private void addOfficer1_Load(object sender, EventArgs e)
        {
            addOfficer1.Hide();
        }
    }
}

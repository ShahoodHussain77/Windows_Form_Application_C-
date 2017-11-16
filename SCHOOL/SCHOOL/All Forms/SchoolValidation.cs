using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SCHOOL
{
    public partial class SchoolValidation : Form
    {
        public SchoolValidation()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string department = "ADMISSION";
            MainMdiForm mdiForm = new MainMdiForm();
            mdiForm.Show();
            this.Hide();            
            mdiForm.checkDepart(department);
        }

        private void SchoolValidation_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string department = "HR";
            MainMdiForm mdiForm = new MainMdiForm();
            mdiForm.Show();
            this.Hide();
            mdiForm.checkDepart(department);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string department = "FACULTY";
            MainMdiForm mdiForm = new MainMdiForm();
            mdiForm.Show();
            this.Hide();
            mdiForm.checkDepart(department);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}

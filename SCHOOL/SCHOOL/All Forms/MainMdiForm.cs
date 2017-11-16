using System;
using System.Windows.Forms;

namespace SCHOOL
{
    public partial class MainMdiForm : Form
    {
        public string department;
        static bool active = false;

        public MainMdiForm()
        {
            InitializeComponent();
        }

        public void checkDepart(string depart)
        {
            if (depart == "ADMISSION")
            {
                department = "ADMISSION";
            }
            else if (depart == "HR")
            {
                department = "HR";
            }
            else if (depart == "FACULTY")
            {
                department = "FACULTY";
            }
            Login load = new Login(department);
            load.MdiParent = this;
            load.Show();
        }

        public void checkBoolean(bool act)
        {
            active = act;
        }

        private void MainMdiForm_Load(object sender, EventArgs e)
        {}

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (active == true)
            {
                RegisterationForm reg = new RegisterationForm();
                reg.MdiParent = this;
                reg.Show();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (active == true)
            {
                ViewAdmission ViewAdd = new ViewAdmission();
                ViewAdd.MdiParent = this;
                ViewAdd.Show();
            }
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            SchoolValidation val = new SchoolValidation();
            val.Show();
        }

        
    }
}

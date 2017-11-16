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
    public partial class ViewAdmission : Form
    {
        public ViewAdmission()
        {
            InitializeComponent();
        }

        private void ViewAdmission_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SandyBrown;
            dataGridView1.EnableHeadersVisualStyles = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SandyBrown;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegisterationForm fome = new RegisterationForm();
            this.Hide();
            fome.Show();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}

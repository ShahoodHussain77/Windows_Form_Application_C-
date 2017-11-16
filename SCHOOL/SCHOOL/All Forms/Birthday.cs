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
    public partial class Birthday : Form
    {
        public Birthday()
        {
            InitializeComponent();
        }

        private void Birthday_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SandyBrown;
            dataGridView1.EnableHeadersVisualStyles = false;
        }
    }
}

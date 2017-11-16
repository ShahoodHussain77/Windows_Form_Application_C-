using System;
using System.Windows.Forms;
using SCHOOL.Sql_Classes;
using System.Data.Odbc;
using System.Data;

namespace SCHOOL
{
    public partial class Login : Form
    {
        public string department;
        connectionClass conClass = new connectionClass();        
        
        public Login(string depart)
        {
            InitializeComponent();
            department = depart;
            string depQuery = "SELECT LOG_REG_Name,LOG_REG_Type FROM LOGIN_REGISTRATION WHERE LOG_REG_Depart = '"+department+"'";
            OdbcDataAdapter da = conClass.ExecQueryAdapter(depQuery);
            try
            {
                DataSet ds = new DataSet();
                da.Fill(ds,"LOGIN_REGISTRATION");
                comboBox1.DisplayMember = "LOG_REG_Name";
                comboBox1.ValueMember = "LOG_REG_Name";
                comboBox1.DataSource = ds.Tables[0];
                comboBox2.DisplayMember = "LOG_REG_Type";
                comboBox2.ValueMember = "LOG_REG_Type";
                comboBox2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LOGIN_REGISTRATION WHERE LOG_REG_Name='" + this.comboBox1.Text + "' AND LOG_REG_Password='" + this.textBox1.Text + "'";
            try
            {
                if (comboBox1.Text == "" || textBox1.Text=="")
                {
                    MessageBox.Show("Select User and Password");
                }
                else
                {
                    bool any = conClass.User_Login(query);
                    if (any)
                    {
                        MessageBox.Show("Login Success!!! Select Operation from menu");
                        this.Hide();
                        MainMdiForm mdiForm = new MainMdiForm();
                        mdiForm.checkBoolean(any);
                    }
                    else
                    {
                        MessageBox.Show("Name or Password is incorrect");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

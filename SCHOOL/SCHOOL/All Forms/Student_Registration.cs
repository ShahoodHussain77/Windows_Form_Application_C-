using System;
using System.Windows.Forms;
using SCHOOL.Sql_Classes;
using System.Collections.Generic;
using System.Drawing;
using System.Data.Odbc;
using System.IO;

namespace SCHOOL
{
    public partial class RegisterationForm : Form
    {
        connectionClass conClass = new connectionClass();

        // STUDENT INFORMATION
        string STU_Acad_year = "";
        string STU_Admission_No = "";
        string STU_Admission_Class = "";
        string STU_First_Name = "";
        string STU_Last_Name = "";
        string STU_DOB = "";
        string STU_Type = "";
        string STU_Caste = "";
        string STU_Admission_Date = "";
        string STU_Present_Class = "";
        string STU_Gender = "";
        string STU_Medium = "";
        string STU_Religion = "";
        string STU_Address = "";
        string STU_State = "";
        string STU_City = "";
        string STU_Country = "";
        string STU_Phone_No = "";
        string STU_Mobile_No = "";
        string STU_Email = "";
        byte[] photoArray;

        // FATHER DETAILS
        string FAT_Name = "";
        string FAT_Phone_No = "";
        string FAT_Mobile_No = "";
        string FAT_Email = "";
        string FAT_Qualification = "";
        string FAT_Occupation = "";
        string FAT_Annual_Income = "";
         
        // MOTHER DETAILS
        string MOT_Name = "";
        string MOT_Phone_No = "";
        string MOT_Mobile_No = "";
        string MOT_Email = "";
        string MOT_Qualification = "";
        string MOT_Annual_Income = "";
        string MOT_Occupation = "";

        // GUARDIANS DETAILS
        string GUR_Name = "";
        string GUR_Phone_No = "";
        string GUR_Mobile_No = "";
        string GUR_Qualification = "";
        string GUR_Annual_Income = "";
        string GUR_Occupation = "";


        public RegisterationForm()
        {
            InitializeComponent();
        }
        
        private void tabPage1_Click(object sender, EventArgs e)
        {}

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (STU_Acad_year == "" || STU_Admission_Class == "" || STU_First_Name=="" || STU_Last_Name=="" || STU_DOB=="" || STU_Type==""
                || STU_Caste==""  ||STU_Admission_Date == "" || STU_Present_Class=="" || STU_Gender=="" || STU_Medium==""
                || STU_Religion=="" || STU_Address=="" || STU_State=="" || STU_City=="" || STU_Country==""
                || STU_Phone_No == "" || STU_Mobile_No == "" || STU_Email == "" )
            {
                MessageBox.Show("Please insert all fields");
            }
            else if (FAT_Name == "" || FAT_Phone_No == "" || FAT_Mobile_No == "" || FAT_Email == "" || FAT_Qualification == "" 
                || FAT_Occupation == "" || FAT_Annual_Income == "" || MOT_Name == "" || MOT_Phone_No == "" || MOT_Mobile_No == ""
                || MOT_Email == "" || MOT_Qualification == "" || MOT_Annual_Income == "" || MOT_Occupation == "" )
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                //string query = "INSERT INTO STUDENT_ADMISSION (STU_ADM_Firstname,STU_ADM_Lastname,STU_ADM_Academic_Year,STU_ADM_Admission_Class,STU_ADM_DOB,STU_ADM_Stu_Type,STU_ADM_Caste,STU_ADM_Gender,STU_ADM_Adm_Date,STU_ADM_Present_Class,STU_ADM_Stu_Status,STU_ADM_Medium,STU_ADM_Caste_Category,STU_ADM_Religion,STU_ADM_Address,STU_ADM_State,STU_ADM_City,STU_ADM_Country,STU_ADM_Phone_No,STU_ADM_Mobile_No,STU_ADM_Email,STU_ADM_Previous_School,STU_ADM_Student_Image) VALUES ('" + STU_First_Name + "','" + STU_Last_Name + "','" + STU_Acad_year + "','" + STU_Admission_Class + "','" + STU_DOB + "','" + STU_Type + "','" + STU_Caste + "','" + STU_Gender + "','" + STU_Admission_Date + "','" + STU_Present_Class + "','" + STU_Medium + "','" + STU_Religion + "','" + STU_Address + "','" + STU_State + "','" + STU_City + "','" + STU_Country + "','" + STU_Phone_No + "','" + STU_Mobile_No + "','" + STU_Email + "','" + photoArray + "');";
                //OdbcDataReader reader = conClass.ExecQueryReader(query);           
                MessageBox.Show("else condition");
            }
        }

       
        // STUDENT DETAILS

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Acad_year = comboBox5.Text;
        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Admission_Class = comboBox6.Text;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            STU_First_Name = textBox2.Text;
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            STU_Last_Name = textBox17.Text;
        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_DOB = dateTimePicker2.Text;
        }

        private void comboBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Type = comboBox9.Text;
        }

        private void comboBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Caste = comboBox10.Text;
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Admission_Date = dateTimePicker1.Text;
        }

        private void comboBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Present_Class = comboBox7.Text;
        }

        private void radioButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                STU_Gender = radioButton1.Text;
            else
                STU_Gender = radioButton2.Text;
        }

        private void radioButton2_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isChecked = radioButton2.Checked;
            if (isChecked)
                STU_Gender = radioButton2.Text;
            else
                STU_Gender = radioButton2.Text;
        }

        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Medium = comboBox8.Text;
        }

        

        private void comboBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Religion = comboBox11.Text;
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Address = richTextBox2.Text;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            STU_Mobile_No = textBox6.Text;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_State = comboBox3.Text;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_City = comboBox4.Text;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Country = comboBox2.Text;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            STU_Phone_No = textBox5.Text;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            STU_Email = textBox13.Text;
        }

        // FATHER DETAILS
        
        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            FAT_Name = textBox18.Text;
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            FAT_Phone_No = textBox20.Text;
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            FAT_Mobile_No = textBox21.Text;
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            FAT_Email = textBox22.Text;
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            FAT_Annual_Income = textBox23.Text;
        }

        private void comboBox13_KeyDown(object sender, KeyEventArgs e)
        {
            FAT_Qualification = comboBox13.Text;
        }

        private void comboBox14_KeyDown(object sender, KeyEventArgs e)
        {
            FAT_Occupation = comboBox14.Text;
        }

        // MOTHER DETAILS

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            MOT_Name = textBox28.Text;
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            MOT_Phone_No = textBox27.Text;
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            MOT_Mobile_No = textBox26.Text;
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            MOT_Email = textBox25.Text;
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            MOT_Annual_Income = textBox24.Text;
        }

        private void comboBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            MOT_Qualification = comboBox16.Text;
        }

        private void comboBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            MOT_Occupation = textBox15.Text;
        }

        // GUARDIANS DETAILS
        
        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            GUR_Name = textBox29.Text;
        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            GUR_Phone_No = textBox33.Text;
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            GUR_Mobile_No = textBox32.Text;
        }

        private void comboBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            GUR_Qualification = comboBox18.Text;
        }

        private void comboBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            GUR_Occupation = comboBox17.Text;
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            GUR_Annual_Income = textBox30.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fileDialog.FileName);
                MemoryStream ms = new MemoryStream();
                photoArray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photoArray, 0, photoArray.Length);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Previous_School school = new Previous_School();
            school.Show();
        }
    }
}

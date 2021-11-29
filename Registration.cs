using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sarah
{


    public partial class Registration : Form
    {
        private Sarah.Student student = new Student();

        private List<String> genders = new List<String>();
        
       
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginButtonClick(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            student.firstName = firstNameInput.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void emailTextChanged(object sender, EventArgs e)
        {
            student.email = emailInput.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextChanged(object sender, EventArgs e)
        {
            student.lastName = lastNameInput.Text; 
        }

        private void otherNamesTextChanged(object sender, EventArgs e)
        {
            student.otherName = otherNamesInput.Text;
        }

        private void phoneTextChanged(object sender, EventArgs e)
        {
            student.phone = phoneInput.Text;
        }

        private void onGenderChanged(object sender, EventArgs e)
        {

            int gender = genderComboBox.SelectedIndex;

            if(gender < 0)
                gender = 0;
           
            student.setGender(gender);
        }

        private void regis(object sender, EventArgs e)
        {

        }

        private void registrationBtnClick(object sender, EventArgs e)
        {
            var frm = new StudentProfileForm(student,this);

            frm.Show();
            this.Hide();
        }
    }
}

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
    public partial class StudentProfileForm : Form
    {

        private Student student;

        private Registration registrationForm;

        private List<Course> courses = new List<Course>();

        private List<Course> registeredCourses = new List<Course>();

        public StudentProfileForm(Student student, Registration registrationForm) {
            this.student = student;
            this.registrationForm = registrationForm;
            InitializeComponent();
            initializeDataSet();
            updateUI();
        }


        public StudentProfileForm()
        {
            InitializeComponent();
            initializeDataSet();
            updateUI();
        }

        public void initializeDataSet() {
            coursesListView.View = View.Tile;
        }

        public void updateUI() {
            updatePersonalDetails();
            updateCoursesListView();
        }

        public void updateCoursesListView() {
            coursesListView.Groups.Clear();
            coursesListView.Items.Clear();

            List<ListViewGroup> departments = new List<ListViewGroup>();

            Dictionary<String,List< Course >> departmentDictionary = new Dictionary<String, List<Course>>();

            registeredCourses.ForEach(course =>
            {

                if (!departmentDictionary.ContainsKey(course.department)) 
                    departmentDictionary[course.department] = new List<Course>();
                List<Course>  department = departmentDictionary[course.department];

                department.Add(course);


            });

            foreach (KeyValuePair<String,List<Course>> entry in departmentDictionary)
            {
                string key = entry.Key;
                List<Course> courses = entry.Value;

                ListViewGroup group = new ListViewGroup(key, HorizontalAlignment.Left);



                courses.ForEach(course =>
                {
                    coursesListView.Items.Add(new ListViewItem(course.getName(),group));
                });


                coursesListView.Groups.Add(group);


            }
         



        }

        public void updatePersonalDetails() {
            firstNameLabel.Text = student.firstName;
            lastNameLabel.Text = student.lastName;
            otherNamesLabel.Text = student.otherName;
            emailLabel.Text = student.email;
            phoneLabel.Text = student.phone;
        }

        private void userProfileImageClick(object sender, EventArgs e)
        {

        }

        private void firstNameLabelClick(object sender, EventArgs e)
        {

        }

        private void onAddCourses(object sender, EventArgs e)
        {
            CourseRegistration form = new CourseRegistration(registeredCourses, this);
            form.Show();
        }

        private void reOpenMainForm(object sender, FormClosedEventArgs e)
        {
            if(student.firstName == "" || student.firstName == null)
                registrationForm.Show();
            else 
                registrationForm.Close();
        }

        public void setRegisteredCourses(List<Course> courses) { 
            this.registeredCourses = courses;
            updateCoursesListView();
        }
    }
}

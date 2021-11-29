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
    public partial class CourseRegistration : Form
    {

        private Dictionary<String, List<Course>> departments;
        private List<Course> registeredCourses;

        List<String> departmentOptions = new List<String>();

        StudentProfileForm studentProfileForm;

        private string department = "Science";

        public CourseRegistration(List<Course> registeredCourses, StudentProfileForm form)
        {

            InitializeComponent();
            this.studentProfileForm = form;
            this.registeredCourses = registeredCourses;

            initializeDataSet();
            updateUI();

        }

        // Adds Items to my departments dictionary.
        public void initializeDataSet() {
            departments = new Dictionary<String,List<Course>>();

            departments["Science"] = new List<Course>();

            departments["Science"].Add(new Course("Information Technology","Science")); 
            departments["Science"].Add(new Course("Computer Science","Science")); 
            departments["Science"].Add(new Course("Agriculture","Science")); 
            departments["Science"].Add(new Course("Mathematics For Computer Science","Science")); 
            departments["Science"].Add(new Course("Calculas 1","Science"));


            departments["Education"] = new List<Course>();
            departments["Education"].Add(new Course("Physical Education","Education")); 
            departments["Education"].Add(new Course("Languages","Education")); 
            departments["Education"].Add(new Course("Linguistics","Education")); 
            departments["Education"].Add(new Course("Some More Educational Stuff","Education")); 


            departments["Another"] = new List<Course>();
            departments["Another"].Add(new Course("Course About Another", "Another")); 
            departments["Another"].Add(new Course("Just Dummy Courses", "Another")); 
            departments["Another"].Add(new Course("Another One", "Another")); 
            departments["Another"].Add(new Course("This One is funny", "Another")); 

            

        }

        public void prepareComboBox() {
            foreach (var department in departments){
                departmentOptions.Add(department.Key);
                departmentsComboBox.Items.Add(department.Key);
            }
            updateComboBox();
        }

        public void updateComboBox() {
            departmentsComboBox.SelectedIndex = departmentOptions.IndexOf(department);
        }

        public void updateUI() {
            prepareComboBox();
            updateCheckBoxListView();
            
        }

        public void updateCheckBoxListView() {
            coursesCheckBoxList.Items.Clear();
            departments[department].ForEach(course =>
            {
               coursesCheckBoxList.Items.Add(course.getName());
            });
        }

        private void onDepartmentChange(object sender, EventArgs e)
        {
            department = departmentOptions[departmentsComboBox.SelectedIndex];
            updateCheckBoxListView();
        }

        private void onSaveClick(object sender, EventArgs e)
        {

            Close();
            studentProfileForm.setRegisteredCourses(registeredCourses);
        }

        private void onCourseSelectionChange(object sender, EventArgs e)
        {
            List<Course> selectableCourses = departments[department];

            List<Course> selectedCourses = new List<Course>();


            foreach (var item in coursesCheckBoxList.SelectedItems) {
                var courseName = item.ToString();
                var course  = selectableCourses.Find(x => x.getName().Equals(courseName));
                selectedCourses.Add(course);
            }

            selectedCourses.ForEach(selectedCourse =>
            {
                var foundCourse = registeredCourses.Find(course => course.getName()== selectedCourse.getName() && course.department == selectedCourse.department);


                if (foundCourse == null)
                    registeredCourses.Add(selectedCourse);

            }); 
        }
    }
}

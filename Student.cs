using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarah
{
    public class Student
    {
        public int id;
        public string firstName;
        public string lastName;
        public string otherName = "";
        public string phone;
        public string gender;
        public string email;

        public List<String> genders = new List<String>();
        public Student(string firstName = "", string lastName = "", string otherName = "", string phone = "", string gender = "", string email = "")
        {
            genders.Add("Female");
            genders.Add("Male");
            genders.Add("Other");
            this.firstName = firstName;
            this.lastName = lastName;
            this.otherName = otherName;
            this.phone = phone;
            this.gender = gender;
            this.email = email;
        }

        public void setGender(int gender) { 
            this.gender = genders[gender];
        }

        public string getGender(int gender)
        {
            return this.genders[gender];
        }

    }

    public class Course
    {
        private string name;
        public string department;


        private Course()
        {

        }

        public Course(string name, string department)
        {
            this.name = name;
            this.department = department;
        }

        public string getName() { return this.name; }

    }


}

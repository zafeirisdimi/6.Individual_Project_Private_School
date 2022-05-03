using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises
{
    class Teacher : Person
    {
        private String _subject;

        public  String Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public List<Course> courses = new List<Course>();
        //default constructor 

        //custom constructor
        public Teacher(String lastName, String firstName, String subject):base(lastName,firstName)
        {
            Subject = subject;
        }


        //methods
        public override string ToString()  
        {
            return ($"{{\t|Lastname: {LastName}\t|Firstname: {FirstName}\t|Subject: {Subject}||\t}}");
        }

    }
}

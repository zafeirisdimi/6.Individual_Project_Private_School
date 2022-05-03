using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises
{
    class Course

    {
        //properties of object Course
        private String _titleCourse;

        public String TitleCourse
        {
            get { return _titleCourse; }
            set { _titleCourse = value; }
        }

        public StreamType streamType { get; set; }
        public TypeOfCourse TypeCourse { get; set; }

        private DateTime _startTimeCourse;

        public DateTime StartTimeCourse
        {
            get { return _startTimeCourse; }
            set { _startTimeCourse = value; }
        }

        private DateTime _endTimeCourse;

        public DateTime EndTimeCourse
        {
            get { return _endTimeCourse; }
            set { _endTimeCourse = value; }
        }

        public List<Student> Students = new List<Student>();
        public List<Teacher> Teachers = new List<Teacher>();
        public List<Assignment> Assignments  = new List<Assignment>(); 


        // No default constructor to avoid creating an object with no first or last name.

        //custom constructor
        public Course(String titleCourse,TypeOfCourse type, DateTime startTimeCourse, DateTime endtimeCourse,StreamType stream) 
        {
            TitleCourse = titleCourse;
            TypeCourse = type;
            StartTimeCourse = startTimeCourse;
            EndTimeCourse = endtimeCourse;
            streamType = stream;
        }

       
        //methods
        public override string ToString()
        {
            return $"{{ |Title: {TitleCourse} |Type: {TypeCourse} |Start-time: {StartTimeCourse} |End-time:{EndTimeCourse}|Stream:{streamType}}}";
        }

    }
}

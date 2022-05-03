using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises
{
    class Student : Person
    {
        private DateTime _birthDay;

        public DateTime BirthDay
        {
            get { return _birthDay; }
            set { _birthDay = value; }
        }

        private int _tuitFees;

        public int TuitFees
        {
            get { return _tuitFees; }
            set { _tuitFees = value; }
        }

        public List<Course> courses = new List<Course>();


        //default constructor

        //custom constructor
        public Student( String LastName, String FirstName, DateTime birthTime, int tuitionFees):base(LastName,FirstName)
        {
            BirthDay = birthTime;
            TuitFees = tuitionFees;
        }

        //methods
        public override string ToString()
        {
            return $"{{  Lastname: {LastName}| Firstname: {FirstName} | BirthDay: {BirthDay} | TuitionFees: {TuitFees}  }}";
        }
    }
}

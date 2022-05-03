using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises
{
    class Assignment
    {
        //properties of object Assignment
        private String _titleAssign;

        public String TitleAssign
        {
            get { return _titleAssign; }
            set { _titleAssign = value; }
        }

        private String _decriptionAssign;

        public String DescripAssing
        {
            get { return _decriptionAssign; }
            set { _decriptionAssign = value; }
        }

        private DateTime _subDateTime;

        public DateTime SubDateTime
        {
            get { return _subDateTime; }
            set { _subDateTime = value; }
        }

        private int _oralMark;

        public int OralMark
        {
            get { return _oralMark; }
            set { _oralMark = value; }
        }

        private int _totalMark;

        public int TotalMark
        {
            get { return _totalMark; }
            set { _totalMark = value; }
        }

        public List<Course> courses { get; set; } = new List<Course>();

        //  No default constructor to avoid creating an object with no first or last name.
        //  Custom constructor
        public Assignment(String title, String description, DateTime subDateTime, int oralMark, int totalMark)
        {
            TitleAssign = title;
            DescripAssing = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public override string ToString()
        {
            return $"{{ Title: {TitleAssign}| Description: {DescripAssing} | SubDateTime: {SubDateTime} | OralMark: {OralMark} | TotalMark: {TotalMark}  }}";
        }
    }
}

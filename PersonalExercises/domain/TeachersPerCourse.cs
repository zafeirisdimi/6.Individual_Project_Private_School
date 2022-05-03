using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises.domain
{
    class TeachersPerCourse
    {
        public Course Course { get; set; }
        public List<Teacher> Teachers = new List<Teacher>();

        public TeachersPerCourse(Course c,List<Teacher> teachers)
        {
            Course = c;
            Teachers = teachers;
        }

    }
}

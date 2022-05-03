using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises.domain
{
    class StudentsPerCourse
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public Course Course { get; set; }

        public StudentsPerCourse(List<Student> students, Course course)
        {
            Students = students;
            Course = course;
        }

    }
}

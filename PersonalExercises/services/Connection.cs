using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises
{
    class ConnectionList
    {
        public void StudentCourse(Student student, Course course) 
        {
            course.Students.Add(student);
            student.courses.Add(course);
        }

        public void TeacherCourse(Teacher teacher, Course course)
        {
            course.Teachers.Add(teacher);
            teacher.courses.Add(course);
        }

        public void AssignmentCourse(Assignment assignment, Course course)
        {
            course.Assignments.Add(assignment);
            assignment.courses.Add(course);
        }
    }
}

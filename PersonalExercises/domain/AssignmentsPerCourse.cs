using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises.domain
{
    class AssignmentsPerCourse
    {
        public Course Course { get; set; }
        public List<Assignment> Assignments = new List<Assignment>();

        public AssignmentsPerCourse(Course c, List<Assignment> assignments)
        {
            Course = c;
            Assignments = assignments;
        }

        public override string ToString()
        {
            return ($"The Course {Course} has {Assignments.Capacity} {Assignments}");
        }
    }
}

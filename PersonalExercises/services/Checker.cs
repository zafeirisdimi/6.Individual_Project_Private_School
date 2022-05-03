using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises.services
{
    class Checker
    {
        //method to check if the EndTime has valid value for Course
        public void  EndTimeValid(DateTime startCourse,DateTime endCourse)
        {
            int result = DateTime.Compare(startCourse, endCourse);
            while (result < 0)
            {
                Console.WriteLine($"Date {endCourse} is not valid.  :-(");
                Console.WriteLine($"Insert new EndTime for the specific Course\n");
                endCourse = DateTime.Parse(Console.ReadLine());
                result = DateTime.Compare(startCourse, endCourse);
            };
        }
    }
}

using PersonalExercises.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersonalExercises.services
{
    static class FakeDatabase
    {
        //int noOfCourses = 5;
        //int no0fAssingments = 6;

        
        public static List<Student> GenerateFakeStudents()
        {
            int noOfStudents = 20;
            List<Student> studentsFake = new List<Student>();
            for (int i = 0; i < noOfStudents; i++)
            {
                Student student = new Student(DataGenerator.GenerateLname(), DataGenerator.GenerateFname(), DataGenerator.GenerateDateTime(), DataGenerator.GenerateTfees());
                studentsFake.Add(student);
            }
            return studentsFake;
        }

        public static List<Student> GenerateFakeStudentsForCourse()
        {
            int noOfStudents = 5;
            List<Student> studentsFake = new List<Student>();
            for (int i = 0; i < noOfStudents; i++)
            {
                Student student = new Student(DataGenerator.GenerateLname(), DataGenerator.GenerateFname(), DataGenerator.GenerateDateTime(), DataGenerator.GenerateTfees());
                studentsFake.Add(student);
            }
            return studentsFake;
        }
        public static List<Teacher> GenerateFakeTeachers()
        {
            int no0fTeachers = 5;
            List<Teacher> teachersFake = new List<Teacher>();
            for (int i = 0; i < no0fTeachers; i++)
            {
                Teacher teacher = new Teacher(DataGenerator.GenerateLname(), DataGenerator.GenerateFname(), DataGenerator.GenerateRandomSubject());
                teachersFake.Add(teacher);
            }
            return teachersFake;
        }
        public static List<Teacher> GenerateFakeTeachersForCourse()
        {
            int no0fTeachers = 4;
            List<Teacher> teachersFake1 = new List<Teacher>();
            for (int i = 0; i < no0fTeachers; i++)
            {
                Teacher teacher1 = new Teacher(DataGenerator.GenerateLname(), DataGenerator.GenerateFname(), DataGenerator.GenerateRandomSubject());
                teachersFake1.Add(teacher1);
            }
            return teachersFake1;
        }

        public static List<Assignment> GenerateFakeAssignments()
        {
            int no0fAssignments = 5;
            List<Assignment> assignmentsFake = new List<Assignment>();
            for (int i = 0; i < no0fAssignments; i++)
            {
                Assignment assignmentFake = new Assignment(DataGenerator.CreateFakeTitleAssign(), DataGenerator.CreateFakeTitleAssign(), DataGenerator.GenerateDateTime(),DataGenerator.CreateOralMarkFake(),DataGenerator.CreateTotalMarkFake());
                assignmentsFake.Add(assignmentFake);
            }
            return assignmentsFake;
        }

        public static List<Assignment> GenerateFakeAssignmentsForCourse()
        {
            int no0fAssignments = 4;
            List<Assignment> assignmentsFake1 = new List<Assignment>();
            for (int i = 0; i < no0fAssignments; i++)
            {
                Assignment assignmentFake1 = new Assignment(DataGenerator.CreateFakeTitleAssign(), DataGenerator.GenerateDescription(), DataGenerator.GenerateDateTime(), DataGenerator.CreateOralMarkFake(), DataGenerator.CreateTotalMarkFake());
                assignmentsFake1.Add(assignmentFake1);
            }
            return assignmentsFake1;
        }

        public static List<Course> GenerateFakeCourses()
        {
            int no0fCourses = 6;
            List<Course> coursesFake = new List<Course>();
            for (int i = 0; i < no0fCourses; i++)
            {
                Course courseFake = new Course(DataGenerator.CreateFakeTitleCourse(), DataGenerator.GenerateRandomTypeOfCourse(), DataGenerator.GenerateDateTime(), DataGenerator.EndTimeCourse(),DataGenerator.GenerateRandomStream());
                for (int j = 0; j < no0fCourses; j++)
                {
                    courseFake.Students = FakeDatabase.GenerateFakeStudentsForCourse();
                }
                coursesFake.Add(courseFake);
            }
            return coursesFake;
        }

        public static StudentsPerCourse  FakeStudentsPerCourse()
        {
            Course courseFake = new Course(DataGenerator.CreateFakeTitleCourse(), TypeOfCourse.FULLTIME, DataGenerator.GenerateDateTime(), DataGenerator.EndTimeCourse(), DataGenerator.GenerateRandomStream());
            List<Student> studentsList = FakeDatabase.GenerateFakeStudents();
            var studentsPerCourse = new StudentsPerCourse(studentsList, courseFake);
            //studentsPerCourse.PrintStudentsPerCourse(studentsPerCourse);
            return studentsPerCourse;
            
        }

    }
}


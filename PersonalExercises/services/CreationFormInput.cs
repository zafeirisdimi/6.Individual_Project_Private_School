using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises
{
    static class CreationFormInput
    {
        public static List<Student> CreateStudents()
        {

            List<Student> StudentList = new List<Student>();
            Student student = null; // Single pointer for all new objects

            String answer = null;
            do
            {
                Console.WriteLine("------------------------------------------\n");
                Console.WriteLine($"\tCREATE NEW STUDENT\n");
                Console.WriteLine("------------------------------------------\n");
                Console.WriteLine("First Name:\n");
                string firstName = Console.ReadLine();

                Console.WriteLine("Last Name:\n");
                string lastName = Console.ReadLine();

                Console.WriteLine("Birthday of student:(like 18/8/1990)\n");
                DateTime birthDay = DateTime.Parse(Console.ReadLine());
                var validBirth = birthDay.ToShortDateString();


                Console.WriteLine("Tuition fees of student:\n");
                int tuitFees = int.Parse(Console.ReadLine());

                student = new Student(firstName, lastName, birthDay, tuitFees);
                Console.WriteLine($"\tSuccessfully created a new student!:-)\n");
                StudentList.Add(student);

                Console.WriteLine("\t Do you add one more student?\t Answer Y/N\n");
                answer = Console.ReadLine();
            } while ((answer == "Y"));

            return StudentList;
        }

        public static List<Teacher> CreateTeachers()
        {
            List<Teacher> TeacherList = new List<Teacher>();
            Teacher teacher = null;

            String answer = null;
            do
            {
                Console.WriteLine("------------------------------------------\n");
                Console.WriteLine($"\t CREATE A NEW TEACHER\n");
                Console.WriteLine("------------------------------------------\n");
                Console.WriteLine("First Name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Last Name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Subject of course: (WEB/JAVA/CS/SQL)");
                String subject = Console.ReadLine();
                teacher = new Teacher(firstName, lastName, subject);
                Console.WriteLine($"\tSuccessfully created a new  teacher :-)");

                TeacherList.Add(teacher);
                Console.WriteLine("Do you add one more teacher?\t Answer Y/N");
                answer = Console.ReadLine();
            } while (answer == "Y");
            return TeacherList;
        }


        public static List<Assignment> CreateAssignments()
        {
            List<Assignment> AssignmentList = new List<Assignment>();
            Assignment assignment = null;

            String answer = null;
            do
            {
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine($"\t CREATE NEW ASSIGNMENT\n");
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine("Title:");
                string title = Console.ReadLine();

                Console.WriteLine("Description:");
                string description = Console.ReadLine();

                Console.WriteLine("Submit Datetime:");
                DateTime submitDate = DateTime.Parse(Console.ReadLine());
                

                Console.WriteLine("Oral makr:");
                int oralMark = int.Parse(Console.ReadLine());

                Console.WriteLine("Total mark:");
                int totalMark = int.Parse(Console.ReadLine());
                var validTotalMark = totalMark - oralMark;

                assignment = new Assignment(title, description, submitDate, oralMark, totalMark);
                Console.WriteLine($"\tSuccessfully created a new assignment :-)");

                AssignmentList.Add(assignment);
                Console.WriteLine("\t Do you add one more assignment?\t Answer Y/N\n");
                answer = Console.ReadLine();
            } while ((answer == "Y"));

            return AssignmentList;
        }

        public static List<Course> CreateCourses()
        {

            List<Course> CourseList = new List<Course>();
            Course course = null;
            String answer = null;
            do
            {
                Console.WriteLine("=====================================\n");
                Console.WriteLine($"\t CREATE NEW COURSE\n");
                Console.WriteLine("=====================================\n");
                Console.WriteLine("Title:");
                string title = Console.ReadLine();

                Console.WriteLine("Type:(FULLTIME/PARTTIME/REMOTE/HYDRID/PRIVATE)");
                TypeOfCourse type = (TypeOfCourse)Enum.Parse(typeof(TypeOfCourse), Console.ReadLine());


                Console.WriteLine("Start Date:");
                DateTime startDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("End Date:");
                DateTime endDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Stream:(TEAMS,VIDEO,INCLASS)");
                StreamType stream = (StreamType)Enum.Parse(typeof(StreamType), Console.ReadLine());

                course = new Course(title, type, startDate, endDate, stream);
                Console.WriteLine($"\tSuccessfully created a new course :-)");
                CourseList.Add(course);

                Console.WriteLine("\t Do you add one more course?\t Answer Y/N\n");
                answer = Console.ReadLine();

            } while ((answer == "Y"));

            return CourseList;
        }



    }


}





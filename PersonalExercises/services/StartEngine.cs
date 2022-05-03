using PersonalExercises.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalExercises.domain;
using System.Threading;

namespace PersonalExercises
{
    static class StartEngine
    {
        public static void HomeScreen()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("\t\t Welcome to the Individual Project");
            Console.WriteLine("************************************************************");
            Console.WriteLine("\t\t The list of operations:");
            Console.WriteLine("Select:  (1) Insert all the data from keyboard step by step");
            Console.WriteLine("         (2) Automatic inserting dummy data.");
            Console.WriteLine("         (3) Special operation: Control the custom date if it is a day of week(Included the operation 2)");
            Console.WriteLine("============================================================");
            Console.WriteLine("<-------  Press 0 to exit  ------>\n");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 2)
            {
                Console.WriteLine("\t You picked the operation 2 :-) ");
                Console.WriteLine("============================================================\n");
                Console.WriteLine("\t\tThe list of OUTPUT operations\n");
                Console.WriteLine("============================================================\n");
                Console.WriteLine(" Select\t(1). Show all the students");
                Console.WriteLine("       \t(2). Show all the trainers");
                Console.WriteLine("       \t(3). Show all the assignments");
                Console.WriteLine("       \t(4). Show all the courses");
                Console.WriteLine("       \t(5). Show all the students per course");
                Console.WriteLine("       \t(6). Show all the assignments per course");
                Console.WriteLine("       \t(7). Show all the teachers per course");
                Console.WriteLine("       \t(8). Show all the students per assignment per course");
                Console.WriteLine("============================================================\n");
                Console.WriteLine("<-------  Press 0 to exit  ------>\n");
                int choiceOutput = int.Parse(Console.ReadLine());
                //while (choiceOutput > 0)
                //{

                List<Course> coursesFakeList = FakeDatabase.GenerateFakeCourses();
                switch (choiceOutput)
                    {
                        case 1:
                            List<Student> studentsFake = FakeDatabase.GenerateFakeStudents();
                            foreach (var student in studentsFake)
                            {
                                Console.WriteLine($"\tStudent {student}");
                            }
                            
                            break;
                        case 2:
                            List<Teacher> teachersFake = FakeDatabase.GenerateFakeTeachers();
                            foreach (var teacher in teachersFake)
                            {
                                Console.WriteLine($"\tTeacher {teacher}}}");
                            }
                            break;
                        case 3:
                            List<Assignment> assignmentsFake = FakeDatabase.GenerateFakeAssignments();
                            foreach (var assignment in assignmentsFake)
                            {
                                Console.WriteLine($"\tAssignment {assignment}");
                            }
                            break;
                        case 4:
                            List<Course> coursesFake = FakeDatabase.GenerateFakeCourses();
                            foreach (var course in coursesFake)
                            {
                                Console.WriteLine($"\tCourse {course}");
                            }
                            break;
                        case 5:
                            List<Student> studentsFake2 = FakeDatabase.GenerateFakeStudentsForCourse();
                            foreach (var course in coursesFakeList)
                            {
                                Console.WriteLine($"--->\t{course.TitleCourse}\t|Stream:{course.streamType}");
                            course.Students = studentsFake2;
                                foreach (var student in course.Students)
                                {
                                    Console.WriteLine($"\t\tWatched by {student}");
                                }

                            }
                            break;
                    case 6:
                        List<Assignment> assignmentsFake1 = FakeDatabase.GenerateFakeAssignmentsForCourse();
                        foreach (var course in coursesFakeList)
                        {
                            Console.WriteLine($"--->\t{course.TitleCourse}\t|Stream:{course.streamType}");
                            course.Assignments = assignmentsFake1;
                            foreach (var assignment in course.Assignments)
                            {
                                Console.WriteLine($"Assignment:\t\t{assignment}");
                                
                            }

                        }
                        break;
                    case 7:
                        List<Teacher> teacherssFake1 = FakeDatabase.GenerateFakeTeachersForCourse();
                        foreach (var course in coursesFakeList)
                        {
                            Console.WriteLine($"--->\t{course.TitleCourse}\t|Stream:{course.streamType}");
                            course.Teachers = teacherssFake1;
                            foreach (var teacher in course.Teachers)
                            {
                                Console.WriteLine($"Teacher:\t\t{teacher}");
                                
                            }

                        }
                        break;

                    //foreach (var course in coursesFakeList2)
                    //{
                    //    Console.WriteLine($"--->\t{course.TitleCourse}\t|Stream:{course.streamType}");

                    //    foreach (var teacher in course.Teachers)
                    //    {
                    //        Console.WriteLine($"\t\t{teacher}");
                    //    }

                    //}
                    //break;
                    default:
                            Console.WriteLine("<-------  Press 0 to exit  ------>\n");
                            choiceOutput = int.Parse(Console.ReadLine());
                            break;
                    }
                //}
                
                
            }
            else if (choice == 1)
            {
                Console.WriteLine("You picked operation 1\n");
                var StudentList = CreationFormInput.CreateStudents();
                foreach (var student in StudentList)
                {
                    Console.WriteLine("\t____________________________________________________________");
                    Console.WriteLine($"Student:{student}");
                    Console.WriteLine("\t____________________________________________________________");
                }

                var TeacherList = CreationFormInput.CreateTeachers();
                foreach (var teacher in TeacherList)
                {
                    Console.WriteLine("____________________________________________________________");
                    Console.WriteLine($"Teacher:{teacher}");
                    Console.WriteLine("\t____________________________________________________________");
                }

                var AssignmentList = CreationFormInput.CreateAssignments();
                foreach (var assignment in AssignmentList)
                {
                    Console.WriteLine("____________________________________________________________");
                    Console.WriteLine($"Assignment:{assignment}");
                    Console.WriteLine("____________________________________________________________");
                }

                var CourseList = CreationFormInput.CreateCourses();
                foreach (var course in CourseList)
                {
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine($"Course:{course}");
                    Console.WriteLine("_____________________________________________");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("============================================================\n");
                Console.WriteLine("\t\tSpecial operation\n");
                Console.WriteLine("============================================================\n");

            }
            else
            {
                Console.WriteLine("Exit from application.");
            }



        }
    }
}
                


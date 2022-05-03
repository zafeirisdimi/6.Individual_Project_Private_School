using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersonalExercises.services
{
    public static class DataGenerator
    {
        //properties
        private static string[] fnames = { "Athanasios", "Alexis", "Evangelos", "Dimitrios", "Menelaos", "Anna", "Viki", "Katerina", "Glykeria", "Errika", "Alexandra" };
        private static string[] lnames = { "Papadopoulou", "Alexiou", "Evangelou", "Dimitriou", "Anagnostou", "Papazoglou", "Oikonomou", "Pappa" };
        private static string[] titleAssign = { "HTML-CSS", "CRUD in JS", "CRUD in C#", "DO-LIST", "USER LOGIN", "Databases Queries" };
        private static string[] titleCourse = { "SOFTWARE MANAGEMENT", "GITHUB", "C#", "WEB(HTML,CSS,JS)", "DATABASES", "JS FRAMEWORKS" };
        private static string[] decriptAssing = { "What is that?", "How we use it", "What affect in our programming life", "That is important", "Very useful tool", "if you are programmer,learn it","Decription ***", "Description *******","something for description" };


        //methods

        //method to generate random First name form array string fnames for object Student and Teacher
        public static string GenerateFname()
        {

            Random rand1 = new Random();
            Thread.Sleep(1);
            var idx = rand1.Next(fnames.Length);
            string randomFirstName = fnames[idx];
            return randomFirstName;
        }
        //method to generate random Last name form array string lnames for object Student and Teacher
        public static string GenerateLname()
        {
            Random rand2 = new Random();
            Thread.Sleep(1);
            var idx = rand2.Next(lnames.Length);
            string randomLastName = lnames[idx];
            return randomLastName;
        }

        //method to generate random number for object Student.Tuition Fees
        public static int GenerateTfees()
        {
            var rand3 = new Random();
            Thread.Sleep(1);
            int num = rand3.Next(1000, 2501);
            return num;
        }

        //method to generate random Subject for object Course
        public static string GenerateRandomSubject()
        {
            var r = new Random();
            Thread.Sleep(1);
            Type type = typeof(Subject);
            Array values = type.GetEnumValues();
            int index = r.Next(values.Length);
            Subject value = (Subject)values.GetValue(index);
            String s = value.ToString();
            return s;

        }
        //method to select random type for object Course.TypeOfCourse
        public static TypeOfCourse GenerateRandomTypeOfCourse()
        {
            var r = new Random();
            Thread.Sleep(1);
            Type type = typeof(TypeOfCourse);
            Array values = type.GetEnumValues();
            int index = r.Next(values.Length);
            TypeOfCourse value = (TypeOfCourse)values.GetValue(index);
            return value;

        }

        //method to select random stream for object Course.StreamType
        public static StreamType GenerateRandomStream()
        {
            var r = new Random();
            Thread.Sleep(1);
            Type type = typeof(StreamType);
            Array values = type.GetEnumValues();
            int index = r.Next(values.Length);
            StreamType value = (StreamType)values.GetValue(index);
            return value;

        }

        //method to select random description for object Assignment.Description
        public static string GenerateDescription()
        {
            Random rand1 = new Random();
            Thread.Sleep(2);
            int p = rand1.Next(decriptAssing.Length);
            string str = decriptAssing[p];
            return str;
        }
        
        //method to generate random DateTime format (year,month,day)
        public static DateTime GenerateDateTime()
        {
            var random = new Random();
            Thread.Sleep(1);
            int month = random.Next(1, 13);
            int day = random.Next(1, 31);
            int year = random.Next(2022, 2055);
            bool day_loop = false;

            while (day_loop != true)
            {
                if (month == 2)
                {
                    if (day > 28)
                    {
                        day = random.Next(31);
                        day_loop = false;
                    }
                    else
                    {
                        day_loop = true;
                    }
                } else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day > 30)
                    {
                        day = random.Next(31);
                        day_loop = false;
                    }
                    else
                    {
                        day_loop = true;
                    }
                }
                else
                {
                    day_loop = true;
                }
            }
            var dateTime = new DateTime(year, month, day);
            return dateTime;
        }

        //method to generate a valid EndTime for object Course with 2 hours difference from StartTime
        public static DateTime EndTimeCourse()
        {
            var date1 = DataGenerator.GenerateDateTime();
            var dateEndCourse = date1.AddHours(2);
            return dateEndCourse;
        }

        //method to generate a title for object Assignment.TitleAssign
        public static String CreateFakeTitleAssign()
        {
            var r = new Random();
            Thread.Sleep(1);
            var index = r.Next(titleAssign.Length);
            String titleFakeAssign = titleAssign[index];
            return titleFakeAssign;
        }
        //method to select random title from string array for object Course.Title
        public static String CreateFakeTitleCourse()
        {
            var r = new Random();
            Thread.Sleep(1);
            var index = r.Next(titleCourse.Length);
            String titleFakeCourse = titleCourse[index];
            return titleFakeCourse;
        }

        //method to generate random number for object Assignment:OralMark
        public static int CreateOralMarkFake()
        {
            var r = new Random();
            var number = r.Next(0,21);
            return number;
        }

        public static int CreateTotalMarkFake()
        {
            var oralMarkFake = DataGenerator.CreateOralMarkFake();
            
            int totalMark = 100;
            var validTotalMarkFake = totalMark - oralMarkFake;
            return validTotalMarkFake;
        }
    }
}

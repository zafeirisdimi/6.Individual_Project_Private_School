using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExercises
{
     public abstract class Person
    {
       
        private String _lastName;
        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private String _firstName;

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

   
        public Person( String lastName, String firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }


        //methods of object Person
        public virtual void PrintInfo()
        {
            Console.WriteLine($"First Last Name: {LastName} First Name: { FirstName}");
        }







    }
}

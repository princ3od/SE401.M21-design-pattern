using System;

namespace Builder
{
    public class Student
    {
        private String Id;
        private String FirstName;
        private String LastName;
        private String CurrentClass;
        private String Phone;

        public Student(String id, String firstName, String lastName, String currentClass, String phone)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CurrentClass = currentClass;
            this.Phone = phone;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}

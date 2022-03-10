using System;

namespace Builder
{
    public class StudentConcreteBuilder : StudentBuilder
    {
        private String id;
        private String firstName;
        private String lastName;
        private String currentClass;
        private String phone;

        public StudentBuilder SetId(String id)
        {
            this.id = id;
            return this;
        }

        public StudentBuilder SetFirstName(String firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public StudentBuilder SetLastName(String lastName)
        {
            this.lastName = lastName;
            return this;
        }


        public StudentBuilder SetCurrentClass(String currentClass)
        {
            this.currentClass = currentClass;
            return this;
        }

        public StudentBuilder SetPhone(String phone)
        {
            this.phone = phone;
            return this;
        }

        public Student Build()
        {
            return new Student(id, firstName, lastName, currentClass, phone);
        }
    }
}

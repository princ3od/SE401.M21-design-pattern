using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface StudentBuilder
    {
        StudentBuilder SetId(String id);
        StudentBuilder SetFirstName(String firstName);
        StudentBuilder SetLastName(String lastName);
        StudentBuilder SetCurrentClass(String currentClass);
        StudentBuilder SetPhone(String phone);
        Student Build();
    }
}

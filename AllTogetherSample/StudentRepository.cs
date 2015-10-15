using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    public class StudentRepository
    {
        private static Lazy<StudentRepository> _instance;
        public static StudentRepository Instance => _instance.Value;
        public Student_CSharp5 UpdateStudent(Student_CSharp5 student)
        {
            return student;
        }
        public Student_CSharp6 UpdateStudent(Student_CSharp6 student)
        {
            return student;
        }
    }
}

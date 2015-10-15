using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    public class Student_CSharp5
    {
        public Student_CSharp5(string firstName, string lastName, double gpa, double hours, List<Course> courses = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Gpa = gpa;
            Hours = hours;
            Courses = courses;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public double Hours { get; private set; }
        public double Gpa { get; private set; }
        public bool IsHonorStudent
        {
            get
            {
                return Gpa > 3.8;
            }
        }
        public List<Course> Courses { get; private set; }
        public String HardestCourse {
            get
            {
                return Courses == null ? "" : Courses.Where(x => x != null).OrderBy(x => x.HistoricalGpa).Select(x => x.Name).FirstOrDefault() ?? "";
            }
        }
        public override string ToString()
        {
            return String.Format("Name: {0}, Gpa: {1}", FullName, Gpa);
        }
        public Student_CSharp5 FinishCourse(Course course, double grade)
        {
            if (course == null)
            {
                return this;
            }
            var newHours = Hours + course.Hours;
            Gpa = ((Gpa * Hours) + grade) / newHours;
            Hours = newHours;
            Courses.Add(course);
            return StudentRepository.Instance.UpdateStudent(this);
        }
    }
}

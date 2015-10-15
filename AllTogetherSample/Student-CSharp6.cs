using System;
using System.Collections.Generic;
using System.Linq;

namespace Immutable
{
    public class Student_CSharp6
    {
        public Student_CSharp6(string firstName, string lastName, double gpa, double hours, List<Course> courses = null)
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
        public String HardestCourse
        {
            get
            {
                return Courses == null ? "" : Courses.Where(x => x != null).OrderBy(x => x.HistoricalGpa).Select(x => x.Name).FirstOrDefault() ?? "";
            }
        }
        public override string ToString()
        {
            return String.Format("Name: {0}, Gpa: {1}", FullName, Gpa);
        }
        public Student_CSharp6 FinishCourse(Course course, double grade)
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

    #region Working CSharp6 Version
    //public class Student_CSharp6
    //{
    //    public Student_CSharp6(string firstName, string lastName, double gpa, double hours, List<Course> courses = null)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //        Gpa = gpa;
    //        Hours = hours;
    //        Courses = courses;
    //    }
    //    public string FirstName { get; }
    //    public string LastName { get; }
    //    public string FullName => FirstName + " " + LastName;
    //    public double Hours { get; }
    //    public double Gpa { get; }
    //    public bool IsHonorStudent => Gpa > 3.8;
    //    public List<Course> Courses { get; }
    //    public String HardestCourse => Courses?.Where(x => x != null).OrderBy(x => x.HistoricalGpa).Select(x => x.Name).FirstOrDefault() ?? "";
    //    public override string ToString() => $"Name: {FullName}, Gpa: {Gpa}";
    //    public Student_CSharp6 FinishCourse(Course course, double grade)
    //    {
    //        if (course == null)
    //        {
    //            return this;
    //        }
    //        var newHours = Hours + course.Hours;
    //        var newGpa = ((Gpa * Hours) + grade) / newHours;
    //        var newCourses = new List<Course>(Courses);
    //        newCourses.Add(course);
    //        var updatedStudent = new Student_CSharp6(FirstName, LastName, newGpa, newHours, newCourses);
    //        return StudentRepository.Instance.UpdateStudent(updatedStudent);
    //    }
    //}
    #endregion
}

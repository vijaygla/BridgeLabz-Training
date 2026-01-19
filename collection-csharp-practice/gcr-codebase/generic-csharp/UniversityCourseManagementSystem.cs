using System;
using System.Collections.Generic;

// Base course type
abstract class CourseType
{
    public string Title { get; set; }
}

class ExamCourse : CourseType { }
class AssignmentCourse : CourseType { }

// Generic course manager
class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    public void ShowCourses()
    {
        foreach (var c in courses)
            Console.WriteLine(c.Title);
    }
}

class Program
{
    static void Main()
    {
        Course<ExamCourse> exams = new Course<ExamCourse>();
        exams.AddCourse(new ExamCourse { Title = "Maths" });
        exams.ShowCourses();
    }
}

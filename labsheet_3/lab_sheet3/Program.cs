using System;
namespace que_1;

public class Course
{
    private string courseName;
    private string instructorName;
    private double grade;

    //public properties
    public string CourseName
    {
        get { return courseName; }
    }

    public double Grade
    {
        get { return grade; }
    }

    //constructor
    public Course(string courseName, string instructorName,double grade)
    {
        this.courseName = courseName;
        SetInstructorName(instructorName);
        SetGrade(grade);
    }

    //public method to set instructor's name with validation
    public void SetInstructorName(string instructorName)
    {
        if (string.IsNullOrWhiteSpace(instructorName))
        {
            throw new ArgumentException("Instructor cannot be empty or null");
        }
        this.instructorName = instructorName;
    }

    //private method to calculate letter grade
    private string CalculateLetterGrade()
    {
        if (grade > 90)
            return "A";
        else if (grade >= 80)
            return "B";
        else if (grade >= 70)
            return "C";
        else if (grade >= 60)
            return "D";
        else
            return "F";
    }

    //public method to print course information
    public void PrintCourseInfo()
    {
        string letterGrade = CalculateLetterGrade();
        Console.WriteLine($"Course Name:{courseName}");
        Console.WriteLine($"Instructor Name:{instructorName}");
        Console.WriteLine($"Letter Grade:{letterGrade}");
        Console.ReadLine();
    }

    //private method to set grade validation
    private void SetGrade(double grade)
    {
        if (grade< 0 || grade>100)
        {
            throw new ArgumentException("Grade must be between 0 and 100");
        }
        this.grade = grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //create a new course object
            Course course = new Course("Computer Science", "Dr.Smith", 85);

            //print course infortmation
            course.PrintCourseInfo();

            //try setting invalid instructor name
            //this should throw an exception
            //course.SetInstructorName("");//uncomment this line to see the exception
            //try setting invalid grade
            //this should throw an exception
            //course.SetGrade(105);//uncomment this line to see the exception
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error:{ex.Message}");
            Console.ReadLine();
        }
    }
}
namespace ConsoleApp2;

public class Lessons
{
    string title;
    int startdate;
    int lessons;
    public List<Student> students = new List<Student>();
    public List<Teacher> teacher = new List<Teacher>();
    public Lessons(string title, int startdate, int lessons)
    {
        this.title = title;
        this.startdate = startdate;
        this.lessons = lessons;
    }
    public  string GetTitle()
    {
        return title;
    }

    public int GetStartDate()
    {
        return startdate;
    }

    public int GetLessons()
    {
        return lessons;
    }

    public void setTitle(string title)
    {
        this.title = title;
    }

    public void setStartDate(int startdate)
    {
        this.startdate = startdate;
    }

    public void setLessons(int lessons)
    {
        this.lessons = lessons;
    }

    public void printParticipants()
    {
        Console.WriteLine(" Deze mensen zijn ingeschreven :");
        foreach (Student student in students)
        {
            Console.WriteLine(student.getName());
        }
    }

    public void printTeachers()
    {
        Console.WriteLine(" Deze docenten zijn ingeschreven :");
        foreach (Teacher teacher in teacher)
        {
            Console.WriteLine(teacher.getName());
        }
    }
    
}

namespace ConsoleApp2;

public class Lessons
{
    string title;
    int startdate;
    int lessons;
    
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
}
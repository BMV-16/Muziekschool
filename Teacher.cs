namespace ConsoleApp2;

public class Teacher
{
    private string name;
    private string email;
    private int TeachesSubjects; 
    public List<Lessons> _lessonsList = new List<Lessons>();

    public Teacher(string name, string email, int teachesSubjects)
    {
        this.name = name;
        this.email = email;
        TeachesSubjects = teachesSubjects;
    }

    public string getName()
    {
        return name;
    }

    public string getemail()
    {
        return email;
    }

    public int getTeachesSubjects()
    {
        return TeachesSubjects;
    }

    public void setTeachesSubjects(int teachesSubjects)
    {
        this.TeachesSubjects = teachesSubjects;
    }

    public void setEmail(string email)
    {
        this.email = email;
    }

    public void setName(string name)
    {
        this.name = name;
    }

}
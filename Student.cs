namespace ConsoleApp2;

public class Student
{
    private string name;
    private string email;
    private int FollowsSubjects;
    
    public Student(string name, string email, int followsSubjects)
    {
        this.name = name;
        this.email = email;
        FollowsSubjects = followsSubjects;
    }

    public string getName()
    {
        return name;
    }

    public string getEmail()
    {
        return email;
    }

    public int getFollowsSubjects()
    {
        return FollowsSubjects;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setEmail(string email)
    {
        this.email = email;
    }

    public void setFollowsSubjects(int followsSubjects)
    {
        this.FollowsSubjects = followsSubjects;
    }
}
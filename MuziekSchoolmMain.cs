namespace ConsoleApp2;

public class MuziekSchoolmMain
{
    public static void Main(string[] args)
    {
        MuziekSchool muziekSchool = new MuziekSchool();
        
        Student student1 = new Student("piet bokker", "piet.bok@EmailAddressAttribute.ab", 2);
        Student student2 = new Student("Raven", "raven@kwn.gvd", 6);
        Student student3 = new Student("Chloe", "chloedehond#honden.be", 14);

        muziekSchool._studenten.Add(student1);
        _studenten.Add(student2);
        _studenten.Add(student3);
        
        
        Teacher teacher1 = new Teacher("Bad Bunny", "bad.b@gmlai.ce", 4);
        Teacher teacher2 = new Teacher("Prue", "Hebgeenemail@gfn.com", 3);
        Teacher teacher3 = new Teacher("Kobinaribo", "obarino@ysu.com", 5);
        
        _teacher.Add(teacher1);
        _teacher.Add(teacher2);
        _teacher.Add(teacher3);
        
        List<Lessons> lessonsList = new List<Lessons>();
        Lessons lesson1 = new Lessons("Math", 01092025, 3);
        Lessons lesson2 = new Lessons("Singing", 01092025, 8);
        Lessons lesson3 = new Lessons("Nederlands", 01092025, 6);
        Lessons lesson4 = new Lessons("Sports", 01092025, 4);
        Lessons lesson5 = new Lessons("Clarinets", 01092025, 2);

        lessonsList.Add(lesson1);
        lessonsList.Add(lesson2);
        lessonsList.Add(lesson3);
        lessonsList.Add(lesson4);
        lessonsList.Add(lesson5);
    }
}
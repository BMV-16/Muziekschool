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
        muziekSchool._studenten.Add(student2);
        muziekSchool._studenten.Add(student3);
        
        
        Teacher teacher1 = new Teacher("Bad Bunny", "bad.b@gmlai.ce", 4);
        Teacher teacher2 = new Teacher("Prue", "Hebgeenemail@gfn.com", 3);
        Teacher teacher3 = new Teacher("Kobinaribo", "obarino@ysu.com", 5);
        
        muziekSchool._teacher.Add(teacher1);
        muziekSchool._teacher.Add(teacher2);
        muziekSchool._teacher.Add(teacher3);
        
      
        Lessons lesson1 = new Lessons("Math", 01092025, 3);
        Lessons lesson2 = new Lessons("Singing", 01092025, 8);
        Lessons lesson3 = new Lessons("Nederlands", 01092025, 6);
        Lessons lesson4 = new Lessons("Sports", 01092025, 4);
        Lessons lesson5 = new Lessons("Clarinets", 01092025, 2);

        muziekSchool.lessonsList.Add(lesson1);
        muziekSchool.lessonsList.Add(lesson2);
        muziekSchool.lessonsList.Add(lesson3);
        muziekSchool.lessonsList.Add(lesson4);
        muziekSchool.lessonsList.Add(lesson5);

        muziekSchool.lessonsList[0].students.Add(student1);
        muziekSchool.lessonsList[1].students.Add(student2);
        muziekSchool.lessonsList[2].students.Add(student3);
        muziekSchool.lessonsList[3].teacher.Add(teacher1);
        muziekSchool.lessonsList[4].teacher.Add(teacher2);
        muziekSchool.lessonsList[4].teacher.Add(teacher3);
        
        muziekSchool.lessonsList[0].printParticipants();
        muziekSchool.lessonsList[1].printParticipants();
        muziekSchool.lessonsList[2].printParticipants();
        muziekSchool.lessonsList[3].printParticipants();
        muziekSchool.lessonsList[4].printParticipants();
        
        
        muziekSchool.lessonsList[0].printTeachers();
        muziekSchool.lessonsList[1].printTeachers();
        muziekSchool.lessonsList[2].printTeachers();
        muziekSchool.lessonsList[3].printTeachers();
        muziekSchool.lessonsList[4].printTeachers();
        
    }
}

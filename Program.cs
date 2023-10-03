using GroupsOfStudents;
using Studentns;

// 1) IComparable
Student st1 = new Student("1","1","1");
Student st2 = new Student("2","2","2");
st1.Info();
st2.Info();
Console.WriteLine(st1.CompareTo(st2));

// 3) IComparer
Console.WriteLine("=============================================================");
Group gr1 = new Group();
gr1.AddStudent(st1);
gr1.AddStudent(st2);
//gr1.Students().Sort(new Student.LastNameComparer());
//gr1.GroupInfo();
gr1.Students().Sort(new Student.ExamsComparer());
gr1.GroupInfo();

// 6) IEnumerator
Console.WriteLine("=============================================================");
foreach (Student student in gr1)
{
    student.PhoneNumber = "00000000";
}
foreach (Student student in gr1)
{
    student.Info();
}
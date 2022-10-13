using System;
class StudentList
{
    private List<Student>studentlist;
    public StudentList()
    {
        this.studentlist=new List<Student>();
    }
    public void NewCol(Student student){
        this.studentlist.Add(student);
    }
      public void FetchStudentList()
    {
        Console.WriteLine("List Student");
        Console.WriteLine("*********************************");
        foreach(Student student in this.studentlist){
          Console.WriteLine("Prefix{0}\n Name{1} \n Lastname{2} \n",student.GetPrefix,student.Getname,student.Getlastname);
        
        }
    }
    
}
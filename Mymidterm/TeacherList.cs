using System;
class TeacherList
{
    private List<Teacher>teacherslist;
    public TeacherList()
    {
        this.teacherslist=new List<Teacher>();
    }
    public void NewCol(Teacher teacher){
        this.teacherslist.Add(teacher);
    }
      public void FetchTeacherCollegeList()
    {
        Console.WriteLine("List  Teaher");
        Console.WriteLine("*********************************");
        foreach(Teacher teacher in this.teacherslist){
            Console.WriteLine("Prefix{0}\n Name{1} \n Lastname{2} \n  ",teacher.GetPrefix,teacher.Getname,teacher.Getlastname);
        }

        }
        }
    

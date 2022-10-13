using System;
class CollegeList
{
    private List<CollegeStudent>collegeslist;
    public CollegeList()
    {
        this.collegeslist=new List<CollegeStudent>();
    }
    public void NewCol(CollegeStudent collegeStudent){
        this.collegeslist.Add(collegeStudent);
    }
    public void FetchCollegeList()
    {
        Console.WriteLine("List Colege Student");
        Console.WriteLine("*********************************");
        foreach(CollegeStudent collegeStudent in this.collegeslist){
            Console.WriteLine("Prefix{0}\n Name{1} \n Lastname{2} \n  ",collegeStudent.GetPrefix,collegeStudent.Getname,collegeStudent.Getlastname);
        
        }
    }
}
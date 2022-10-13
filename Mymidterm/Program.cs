using System;
enum Menu
{
    RegisterNewStudent = 1,
    RegisterNewTeacher = 2,
    GetListPersons = 3
}

class Program {
    public static int M4Counter = 0;
     public static int M5Counter = 0;
      public static int M6Counter = 0;
    public static int CollegeCounter = 0;
    public static int studnenCounter = 0;
    public static int TeacherCounter = 0;
    static CollegeList collegeList;
    static StudentList studnentList;
    static TeacherList teacherList;
    static void Main(){
    PrepareCollegeListWhenProgramIsLoad();
     PreparestudentListWhenProgramIsLoad();
      PrepareteacherListWhenProgramIsLoad();
    firstMenu();
    InputforFirstMenu();
     
    }
   
    public static void firstMenu(){
        Console.Clear();
        Console.WriteLine("Welcome to Idia camp");
        Console.WriteLine("1.Registor");
        Console.WriteLine("2.Participate Number");
        Console.WriteLine("3.Log in");
          }
           public static void LogedintMenu(){
            int X;
        Console.Clear();
        Console.WriteLine("1:Registor");
        Console.WriteLine("2:College Student infotmation");
        Console.WriteLine("3:Student information");
        Console.WriteLine("4:Teacher information");
        Console.WriteLine("5:Log out");
        Console.WriteLine("Select Number ::");
        X = int.Parse(Console.ReadLine());
        if (X == 1){
            
            Console.WriteLine("Registor Menu");
             RegistorMenu();
        }
        if(X == 2){
           
            Console.WriteLine("College Student infotmation");
            Console.WriteLine("Number of College Student{0}",CollegeCounter);
            Console.WriteLine("Show Person");
            Console.WriteLine("***********************************");
            collegeList.FetchCollegeList();
        }
        if(X == 3){
            
           Console.WriteLine("Student infotmation");
            Console.WriteLine("Number of Student{0}",studnenCounter);
             Console.WriteLine("Show Person");
            Console.WriteLine("***********************************");
            studnentList.FetchStudentList();
        }
        if(X == 4){ 
           Console.WriteLine("teacher infotmation");
            Console.WriteLine("Number of Student{0}",teacherList);
             Console.WriteLine("Show Person");
             }
          }
         

    public static void InputforFirstMenu(){
        Console.Write("Press number :");
        double Menuanswer;
        for (int A = 0;A < 99;A++){
        Menuanswer = double.Parse(Console.ReadLine());
        if (Menuanswer == 1){
            Console.Clear();
            Console.WriteLine("Registor Menu");
            RegistorMenu();

            A = A  + 100;
        }
        if(Menuanswer == 2){
            Console.Clear();
            Console.WriteLine("Particicate Static");
            ParticicateStatic();

           A = A  + 100;
        }
        if(Menuanswer == 3){
            Console.Clear();
            Console.WriteLine("Log in");
            Email.LogInMenu();
           LogedintMenu();
            
            Back();

            A = A  + 100;
        }
        if(Menuanswer >= 4){
            Console.WriteLine("incorrect Please try again");
        }
        } 
        
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------
       public static void RegistorMenu(){
        int classes;

        Console.WriteLine("Please Input your class");
        Console.WriteLine("1: College Student");
        Console.WriteLine("2: Student");
        Console.WriteLine("3: Teacher");
        Console.Write("Press the number: ");
        classes= int.Parse(Console.ReadLine());
        if (classes == 1){
            
            Console.Clear();
            Console.WriteLine("Register college Student");
            CollegeCounter++;
            CollegeStudent collegeStudent = new CollegeStudent(GetPrefix(),Getname(),GetLastname(),GetstudentID(),GetfoodAller(),GetReligouse(),GetAdmin(),GetEmail(),GetPassword());
           Program.collegeList.NewCol(collegeStudent);
            Back();
        }
          if (classes == 2){
            Console.Clear();
            Console.WriteLine("Register New Student");
            studnenCounter++;
            Student student = new Student(GetPrefix(),Getname(),GetLastname(),Getage(),GetfoodAller(),GetGrade(),GetReligouse(),GetSchool());
           Program.studnentList.NewCol(student);
            Back();
        }
         
          if (classes == 3){
            Console.Clear();
            Console.WriteLine("Register New Teacher");
            TeacherCounter++;
            Teacher teacher = new Teacher(GetPrefix(),Getname(),GetLastname(),Getage(),GetRank(),GetReligouse(),GetfoodAller(),GetCar(),GetcarID(),GetAdmin(),GetEmail(),GetPassword());
           Program.teacherList.NewCol(teacher);
            Back();
            }
       } 
     //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
      static string GetGrade(){
        Console.WriteLine("Grade: ");
        int X;
        string R = "";
        Console.WriteLine("1 : M.4");
        Console.WriteLine("2 : M.5");
        Console.WriteLine("3 : M.6" );
        
        X = int.Parse(Console.ReadLine());
        if(X == 1){
            M4Counter++;
            R = "M.4";
        }
         else if(X == 2){
             M5Counter++;
            R = " M.5";
        }
        else if(X == 3){
            M6Counter++;
            R = "M.6";
        }
        return R;
      }
       static string GetRank(){
       Console.WriteLine("Rank: ");
        int X;
        string R = "";
        Console.WriteLine("1 : the head of a college");
        Console.WriteLine("2 : head of faculty department");
        Console.WriteLine("3 : Teacher" );
        
        X = int.Parse(Console.ReadLine());
        if(X == 1){
            R = " the head of a college";
        }
         else if(X == 2){
            R = "head of faculty department";
        }
        else if(X == 3){
            R = "Teacher";
        }
        return R;
       }
       static string GetCar(){
         string carmai = "";
        Console.WriteLine("Bring Car?: ");
        Console.WriteLine("Yes : 1");
        Console.WriteLine("No : 2 : " );
        int x = int.Parse(Console.ReadLine());
        if(x == 1)
        carmai ="Yes";
        else if (x==2)
        carmai ="No";
    

        return carmai;

       }
       static string GetcarID(){
        Console.Write("CarID :");
        Console.Write("(Incase of Bringing)");
        Console.Write("::");
        return Console.ReadLine();
        
       }

       static string GetPrefix(){
        int X ;
        string Y = "";
            Console.WriteLine("Prefix");
            Console.WriteLine("1: Mr.");
            Console.WriteLine("2: Mrs.");
            Console.WriteLine("3: Miss.");
            Console.Write("Please Input number");
            X = int.Parse(Console.ReadLine());
            if(X ==  1 ){
            Y = "Mr";
            }
            else if(X ==  2 ){
            Y = "Mrs";
            }
            else if(X ==  3 ){
            Y = "Miss";
            } 
            return Y;

       }
       static string Getage(){
        Console.Write("Age");
        return Console.ReadLine();
       }
       static string GetSchool(){
        Console.Write("School :");
        return Console.ReadLine();
       }
       static string Getname()
        {
        Console.Write("Name: ");
        return Console.ReadLine();
    }
    static string GetLastname()
        {
        Console.Write("LastName: ");
        return Console.ReadLine();
    }
    static string GetstudentID()
        {
        Console.Write("StudentID: ");
        return Console.ReadLine();
    }
    static string GetfoodAller()
        {
        Console.Write("foodAller: ");
        return Console.ReadLine();
    }
    static string GetReligouse()
        {
        Console.WriteLine("Religouse: ");
        int X;
        string R = "";
        Console.WriteLine("1 : Budhist");
        Console.WriteLine("2 : Christ");
        Console.WriteLine("3 : Isalam" );
        Console.WriteLine("4 : Else");
        X = int.Parse(Console.ReadLine());
        if(X == 1){
            R = "Budhist";
        }
         else if(X == 2){
            R = "Christ";
        }
        else if(X == 3){
            R = "Isalam";
        }
        else 
        R = "Else";
        return R;
    }
     static string GetAdmin()
        {
        string Adminmai = "";
        Console.WriteLine("Admin: ");
        Console.WriteLine("Yes : 1");
        Console.WriteLine("No : 2 : " );
        int x = int.Parse(Console.ReadLine());
        if(x == 1)
        Adminmai ="Yes";
        else if (x==2)
        Adminmai ="No";
    

        return Adminmai;
    }
    static string GetEmail()
        {
        Console.Write("Email: ");
        Console.WriteLine("(Incase of Admin)");
        return Console.ReadLine();
    }
     static string GetPassword()
        {
        Console.Write("Password: ");
           Console.WriteLine("(Incase of Admin)");
        return Console.ReadLine();
    }
 
    //*************************************************************************************************//
    public static void Back(){
        firstMenu();
        InputforFirstMenu();
    }

    public static void BacktoLoginMenu(){
        LogedintMenu();
    }
     static void PrepareCollegeListWhenProgramIsLoad()
    {
       Program.collegeList = new CollegeList();
    }
     static void PreparestudentListWhenProgramIsLoad()
    {
       Program.studnentList = new StudentList();
    }
     static void PrepareteacherListWhenProgramIsLoad()
    {
       Program.teacherList = new TeacherList();
    }
    static void ParticicateStatic(){
        string B ;
        Console.Clear();
    Console.WriteLine("Teacher Number:{0}",TeacherCounter);
    Console.WriteLine("Student Number:{0}",studnenCounter);
    Console.WriteLine("College Number:{0}",CollegeCounter);
    Console.WriteLine("Grade M.4 Number:{0}",M4Counter);
    Console.WriteLine("Grade M.5 Number:{0}",M5Counter);
    Console.WriteLine("Grade M.6 Number:{0}",M6Counter);
    Console.Write("Press Any for Back: ");
    B = (Console.ReadLine());
    if(B ==""){
        Back();
    }
    else{
        Back();
    }
}
    }
    //------------------------------------------------------------------------------------------------



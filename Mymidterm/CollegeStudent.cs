using System;
public  class CollegeStudent{
    public string Prefix;
    public string name;
    public string lastname;
    public string StudentID;
    public string foodAllergy;
    public string Religous;
    public string Admin;
    public string Password;
    public CollegeStudent(string Prefix,string name,string lastname,string StudentID,string foodAllergy,string Religous,string Admin,string Email,string password){
        this.Prefix = Prefix;
        this.name = name;
        this.lastname=lastname;
        this.StudentID=StudentID;
        this.foodAllergy=foodAllergy;
        this.Religous=Religous;
        this.Admin=Admin;
        this.Password=password;
    }
        
         public string GetPrefix()
    {
        return this.Prefix;
    }
         public string Getname()
    {
        return this.Prefix;
    }
       public string Getlastname()
    {
        return this.lastname;
    }
      public string GetstudentID()
    {
        return this.StudentID;
    }
     public string GetfoodAller()
    {
        return this.foodAllergy;
    }
    public string GetReligouse(){
        return this.Religous;
    }
    public string GetAdim(){
        return this.Admin;
    }
    public string GetPassword(){
        return this.Password;
    }

    }

  




using System;

public class Student{
     public string Prefix;
    public string name;
    public string lastname;
    public string Age;
    public string foodAllergy;
    public string Grade;
    public string foodAller;
    public string Religion;
    public string school;
    public Student(string Prefix,string name,string lastname,string Age,string foodAllergy,string Grade,string Religous,string school){
        this.Prefix = Prefix;
        this.name = name;
        this.lastname=lastname;
        this.Age= Age;
        this.foodAllergy=foodAllergy;
        this.Grade=Grade;
        this.Religion=Religous;
        this.school=school;
        

    }
        
         public string GetPrefix()
    {
        return this.Prefix;
    }
         public string Getname()
    {
        return this.name;
    }
       public string Getlastname()
    {
        return this.lastname;
    }
      public string GetAge()
    {
        return this.Age;
    }
     public string GetfoodAller()
    {
        return this.foodAllergy;
    }
    public string GetGrade()
    {
        return this.Grade;
    }
    public string GetReligouse(){
        return this.Religion;
    }
    public string Getschool(){
        return this.school;
    }
   
    }

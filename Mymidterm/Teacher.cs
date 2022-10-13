using System;


    public  class Teacher {
    public   string Prefix;
    public  string name;
    public  string lastname;
    public  string Age;
    public  string Rank;
    public  string Religous;
    public  string foodAller;
    public  string BringCar;
    public  string carID;
    public  string Admin;
    public  string Email;
    public  string Password;
    public Teacher(string Prefix,string name,string lastname,string Age,string Rank,string Religous,string foodAller,string BringCar,string carID,string Admin,string Email,string Password){
        this.Prefix = Prefix;
        this.name = name;
        this.lastname=lastname;
        this.Age=Age;
        this.Rank=Rank;
        this.Religous=Religous;
        this.foodAller=foodAller;
        this.BringCar=BringCar;
        this.carID=carID;
        this.Admin=Admin;
        this.Email=Email;
        this.Password=Password;
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
     public string GetRank()
    {
        return this.Rank;
    }
    public string GetReligouse(){
        return this.Religous;
    }
    public string GetAdim(){
        return this.Admin;
    }
    public string GetEmail(){
        return this.Email;
    }
    public string GetPassword(){
        return this.Password;
    }
    public string GetBringcar(){
        return this.BringCar;
    }
     public string GetcarID(){
        return this.carID;
    }

    }

  
    

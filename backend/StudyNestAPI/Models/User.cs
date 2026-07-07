namespace StudyNestAPI.Models;

public class User {
    public int ID {get; set;}
    public string FullName {get; set;} = "";
    public string Email {get; set;} = "";
    public string Password {get; set;} = "";
    public bool Premium {get; set;} 
}
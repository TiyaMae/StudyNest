namespace StudyNestAPI.Models;

public class Review {
    public int ID {get; set;}
    public int StudySpaceID {get; set;}
    public int UserID {get; set;} 
    public int Rating {get; set;}
    public string Comment {get; set;} = "";
}
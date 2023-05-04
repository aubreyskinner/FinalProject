namespace Final.Models
{
public class User{
    public int UserId {get;set;} // Primary Key
    public string? FirstName {get;set;}
    public string? LastName {get;set;}
    public string? Address {get;set;}
    public string? Email {get;set;}
    public List<Workout> Workouts {get;set;} = new List<Workout>();

    
    
}
}
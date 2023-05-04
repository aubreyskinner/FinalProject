namespace Final.Models{
    public class Workout{
        public int WorkoutId {get;set;}
        public DateTime DateCompleted {get;set;}
        public int Calories {get;set;}
        public int WorkoutLength {get;set;}
        public string? WorkoutType {get;set;}
        public int UserId {get;set;}
        public User? User {get;set;}


    }
}
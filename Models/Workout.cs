using System;
using System.ComponentModel.DataAnnotations;
namespace Final.Models{
    public class Workout{
        public int WorkoutId {get;set;}

        [Display(Name = "Date Completed")]
        [DataType(DataType.Date)]
        public DateTime DateCompleted {get;set;}


        [Range(1,1000)]
        [Display(Name = "Calories Burned")]
        public int Calories {get; set;}

        [Display(Name = "Length of Workout (in minutes)")]
        public int WorkoutLength {get;set;}

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Type of Workout")]
        public string? WorkoutType {get;set;}
        public int UserId {get;set;}
        public User? User {get;set;}


    }
}
using System.ComponentModel.DataAnnotations;
using System;
namespace Final.Models
{
public class User{
    public int UserId {get;set;} // Primary Key

    [StringLength(60, MinimumLength = 3)]
    [Required]
    [Display(Name = "First Name")]
    public string? FirstName {get;set;}

    [StringLength(60, MinimumLength = 3)]
    [Required]
    [Display(Name = "Last Name")]
    public string? LastName {get;set;}

    [Required]
    [StringLength(100)]
    public string? Address {get;set;}
    
    [Required]
    [Display(Name = "E-mail Address")]
    [EmailAddress]
    public string? Email {get;set;}

    public List<Workout> Workouts {get;set;} = new List<Workout>();

    
    
}
}
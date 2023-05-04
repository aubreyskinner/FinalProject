using Microsoft.EntityFrameworkCore;
namespace Final.Models
{
public static class SeedData{
public static void Initialize(IServiceProvider serviceProvider){

using (var context = new WorkoutContext(
serviceProvider.GetRequiredService<DbContextOptions<WorkoutContext>>())){
    


if (context.Users.Any()){
return; 
}

context.Users.AddRange(

new User
{FirstName = "Johnathan", LastName ="Ramirez", Address= "312 Sunny Drive", Email= "jramirez@yahoo.com", Workouts = new List<Workout>{new Workout {DateCompleted= DateTime.Parse("2023-02-12"), Calories = 172, WorkoutLength= 34, WorkoutType= "Treadmill"}}},

new User
{FirstName = "Stacy", LastName = "Williams", Address= "415 Walnut Way", Email= "Stacysmom@icloud.com"},

new User 
{FirstName = "Malachi", LastName = "Jones", Address= "672 Highway 83", Email= "malichijoness@yahoo.com", Workouts = new List<Workout>{new Workout {DateCompleted= DateTime.Parse("2023-04-16"), Calories = 103, WorkoutLength= 20, WorkoutType= "Swimming"}}},

new User 
{FirstName = "Jordan", LastName = "Hardy", Address= "613 Eastern Road", Email= "howdyjordy@gmail.com"},

new User 
{FirstName = "John", LastName = "Dutton", Address= "782 Yellow Drive", Email= "ilovecows@yahoo.com",Workouts = new List<Workout>{new Workout {DateCompleted= DateTime.Parse("2023-01-03"), Calories = 332, WorkoutLength= 68, WorkoutType= "Weight Lifting"}}},

new User 
{FirstName = "Casey", LastName = "Jones", Address= "542 Rocky Road", Email= "baseballrocks@gmail.com"},

new User 
{FirstName = "Ryan", LastName = "Reynolds", Address= "989 Beverly Hills", Email= "ryanrey@icloud.com"},

new User 
{FirstName = "Haley", LastName = "Thompson", Address= "124 Lometa Drive", Email= "haleythompson34@yahoo.com"},

new User 
{FirstName = "Aubrey", LastName = "Skinner", Address= "139 Periwinkle Drive", Email= "aubreyskinner@yahoo.com"},

new User 
{FirstName = "Barbara", LastName = "Johnson", Address= "142 Aston Road", Email= "yoitsbarbs@hotmail.com"},

new User 
{FirstName = "Leia", LastName = "Organa", Address= "235 Alderaan Way", Email= "spacerockss@gmail.com"},

new User 
{FirstName = "Sherry", LastName = "Hall", Address= "143 Paintbrush Drive", Email= "sherryhall@icloud.com"},

new User 
{FirstName = "Perfecto", LastName = "Mancha", Address= "917 Mansion Way", Email= "iamperfecto@icloud.com"},

new User 
{FirstName = "Taylor", LastName = "Keys", Address= "909 Holiday Drive", Email= "taylorrkeys@hotmail.com"},

new User 
{FirstName = "Abby", LastName = "Smith", Address= "154 Mulberry Drive", Email= "abbysmithh@icloud.com"},

new User 
{FirstName = "Tommy", LastName = "Lockwood", Address= "443 North Avenue", Email= "tommlockwood43@icloud.com"},

new User 
{FirstName = "Ellen", LastName = "Parker", Address= "557 Elmonte Street", Email= "eparker33@icloud.com"},

new User 
{FirstName = "Sebastian", LastName = "Goodwin", Address= "092 Tanglewood Road", Email= "sebgoodwin81@aol.com"},

new User 
{FirstName = "Lara", LastName = "Croft", Address= "501 Tomb Road", Email= "ilovetreasure@aol.com", Workouts = new List<Workout>{new Workout {DateCompleted= DateTime.Parse("2022-08-09"), Calories = 490, WorkoutLength= 82, WorkoutType= "Running"}}},

new User 
{FirstName = "Mason", LastName = "Harris", Address= "111 Wilson Street", Email= "mharris11@hotmail.com"},

new User 
{FirstName = "Jim", LastName = "Morrison", Address= "102 Lizard Way", Email= "doorsrcool@yahoo.com"},

new User 
{FirstName = "Allison", LastName = "Arnolds", Address= "787 Haven Drive", Email= "aarnolds19@icloud.com"},

new User 
{FirstName = "Jerome", LastName = "Sampson", Address= "323 Ashton Lane", Email= "jeromesamp@icloud.com"},

new User 
{FirstName = "Wilbur", LastName = "Wilbings", Address= "002 Terrace Lane", Email= "wilbings45@yahoo.com"},

new User 
{FirstName = "Gilbert", LastName = "Riley", Address= "298 Woodway Street", Email= "griley29@icloud.com"}
);
 
context.SaveChanges();
}
}
}
}
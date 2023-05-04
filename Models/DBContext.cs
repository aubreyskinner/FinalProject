using Microsoft.EntityFrameworkCore;
namespace Final.Models
{
	public class WorkoutContext : DbContext
	{
		public WorkoutContext (DbContextOptions<WorkoutContext> options)
			: base(options)
		{
		}
		public DbSet<User> Users {get; set;} = default!;
		public DbSet<Workout> Workouts {get;set;} = default!;

        internal void SaveChanges(User user)
        {
            throw new NotImplementedException();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Training_Quiz.Models.Domain;

namespace Training_Quiz.Models
{
	public class TrainingQuizDbContext : DbContext
	{
		public TrainingQuizDbContext(DbContextOptions<TrainingQuizDbContext> options) : base(options)
		{
		}
		public DbSet<QuizType> QuizTypes { get; set; }
	}
}
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingQuiz.Core
{
	public abstract partial class BaseEntity
	{
		/// <summary>
		/// Gets or sets the entity identifier
		/// </summary>
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		//[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
		public decimal ID { get; set; }
	}
}
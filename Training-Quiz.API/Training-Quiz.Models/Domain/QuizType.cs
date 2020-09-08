using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Training_Quiz.Models.Domain
{
	public class QuizType
	{
		[Key]
		[Identit]
		public int ID { get; set; }\
		[Column(TypeName = "nvarchar(100)")]
		public string QuizTypeName { get; set; }
		public int? Order { get; set; }
	}
}
